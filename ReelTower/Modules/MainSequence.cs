﻿#region Imports
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TechFloor.Components;
using TechFloor.Forms;
using TechFloor.Gui;
using TechFloor.Object;
using TechFloor.Service.MYCRONIC.WebService;
using TechFloor.Util;
using AMM;
using System.Security.RightsManagement;
using System.Collections.Concurrent;
#endregion

#region Program
#pragma warning disable CS0618, CS0219
namespace TechFloor
{
    #region Enumerations
    public enum ErrorCode
    {
        None,
        AbortInitialize,
        FailedInitialize,
        ReelTowerResponseTimeout,
        RobotCommunicationFailure,
        RobotMoveToHomeTimeout,
        RobotMoveTimeout,
        FailedToStopProgram,
        FailedToPauseProgram,
        FailedToLoadProgram,
        FailedToPlayProgram,
        CartPresentSensorFailure,
        ReturnReelPresentSensorFailure,
        ReturnReelTypeIsNotValid,
        RobotVisionFailure,
        RobotVisionAlignPositionFailure,
        RobotVisionDecodeBarcodeFailure,
        RobotVisionDecodedBarcodeIsNotValid,
        FailedToPickupReelFromCart,
        FailedToPickupReelFromReturn,
        FailedToCheckReelTypeOfCart,
        FailedToCheckReelTypeOfReturn,
        FailedToSetReelSizeOfCartToRobot,
        FailedToSetReelSizeOfReturnToRobot,
        FailedToSetWorkSlotOfCart,
        WorkSlotOfCartIsNotValid,
        UnloadReelTowerIdIsNotValid,
        DetectedAReelOnGripper,
        FailedToSetCartReelSize,
        FailedToSetReturnReelSize,
        RobotPositionIsNotMatched,
        RobotStateIsNotMatched,
        FailedToPickUnloadReel,
        ReelTowerIsAlarmState,
        ReelTowerIsFull,
        ReelTowerIsBusy,
        RobotEmergencyStop,
        RobotProtectiveStop,
        RobotReelDetectionSensorFailure,
        ReelBarcodeIsNotUnique,
        MobileRobotCommunicationFailure,
        AMMConnectFailure,
    }

    public enum SeverityLevels
    {
        Cleared,
        Warning,
        Minor,
        Major,
        Critical,
        Indeterminate
    }

    public enum ReelTowerGroupSteps
    {
        None,
        Ready,
        CheckProvideJobState,
        Done,
    }

    public enum BarcodeConfirmStates
    {
        Prepared,
        Confirmed,
        Reject
    }

    public enum ReelHandlerSteps
    {
        None,
        Ready,
        CheckProgramState,
        ConfirmRobotProgramState,

        // Load cart reel sequence
        CheckCartReelType,
        SetReelTypeOfCartToRobot,
        PrepareToLoadReelFromCart,
        SetWorkSlotToRobot,
        GoToHomeBeforeReelHeightCheck, // 200
        MoveToReelHeightCheckPositionOfWorkSlot,
        MeasureReelHeightOnCart,
        CheckReelAlignmentOnCart,
        RequestToReelLoadConfirm,
        PrepareToReadBarcodeOnReel,
        ReadBarcodeOnReel,
        RequestToConfirmLoadReelBarcodeOfCart,
        AdjustPositionAndPickupReelOfCart,
        GoToHomeAfterPickUpReel, // 204
        MoveToFrontOfTower,
        PutReelIntoTower,
        RequestToConfirmLoadedReelAssign,
        CompletedToLoadReel,
        PrepareToChangeWorkSlotOfCart,
        ChangeWorkSlotOfCart,
        // Load failure case
        MoveBackToHomeByVisionAlignmentFailureToLoad,
        MoveBackToHomeByReelTowerResponseTimeoutToLoad,
        MoveBackToHomeByReelTowerRefuseToLoad,
        MoveBackToHomeByCancelBarcodeInputToLoad,
        MoveBackToHomeByReelPickupFailureToLoad,
        MoveBackToHomeByCartReelTypeCheckFailure,
        WaitForBarcodeInput,
        CheckReelAlignmentAfterBarcodeInput,

        // Load return reel sequence
        PrepareToLoadReturnReel,
        SetReelTypeOfReturnToRobot,
        MoveToFrontOfReturnStage,
        ApproachToReelHeightCheckPointAtReturnStage,
        MeasureReelHeightOnReturnStage,
        CheckReelAlignmentOnReturnStage,
        RequestToReturnReelLoadConfirm,
        // PrepareToReadBarcodeOnReel,
        // ReadBarcodeOnReel,
        RequestToConfirmLoadReelBarcodeOfReturnStage,
        AdjustPositionAndPickupReelOfReturnStage,
        // Load return failure case 
        MoveBackToFrontOfReturnStage,
        MoveBackToFrontOfReturnStageByVisionAlignmentFailureToLoadReturn,
        MoveBackToFrontOfReturnStageByResponseTimeoutToLoadReturn,
        MoveBackToFrontOfReturnStageByReelTowerRefuseToLoadReturn,
        MoveBackToFrontOfReturnStageByCancelBarcodeInputToLoadReturn,
        MoveBackToFrontOfReturnStageByReelPickupFailureToLoadReturn,

        // Unload Sequence
        PrepareToUnloadTowerReel,
        MoveToFrontOfUnloadTower,
        TakeReelFromUnloadTower,
        RequestToUnloadReelAssignment,
        MoveToFrontOfOutputStage,
        ApproachOutputStage,
        PutReelIntoOutputStage,
        RequestToConfirmUnloadedReelAssign,
        CompletedToUnloadReelFromTower,

        // Failure sequences
        MoveBackToFrontOfTowerByReelPickupFailureToUnload,

        // Unload to buffer sequence
        PrepareToReturnReelToBuffer,

        Done,
    }

    public enum SubSequenceSteps
    {
        Prepare,
        Proceed,
        Post
    }

    public enum BarcodeInputStates
    {
        Wait,
        Typed,
        Canceled,
    }

    public enum Notifications
    {
        ReelTowerNotification,
        ReelHadlerNotification,
        ProvidedReelTakeOutNotificationOfTower1,
        ProvidedReelTakeOutNotificationOfTower2,
        ProvidedReelTakeOutNotificationOfTower3,
        ProvidedReelTakeOutNotificationOfTower4,
    }
    #endregion

    public class ReelTowerGroupSequence : AbstractClassDisposable, IMainSequence
    {
        #region Enumerations
        public enum InitializeSteps : int
        {
            None,
            Ready,
            CheckTowerInformation,
            CheckNotificationListener,
            CheckReelHandler,
            CheckAMM,
            PrepareInitialize,
            Initializing,
            PostInitialize,
            Done,
            Unknown,
            Failed
        }
        #endregion

        #region Constants
        protected const int CONST_THREAD_POLLING_INTERVAL                           = 100;

        protected const int CONST_SIMULATION_DELAY                                  = 300;
        
        public const int CONST_MAX_TOWER_COUNT                                      = 4;
        
        public const int CONST_MAX_MOBILE_STAGE_COUNT                               = 4;

#if DEBUG
        public const string CONST_WORK_PATH                                         = @"C:\Temp\K4\ApplicationData\";
#else
        
        public const string CONST_WORK_PATH                                         = @"D:\ApplicationData\";
#endif
        public const string CONST_CONFIG_PATH                                       = @"Config\";
        
        public const string CONST_MODEL_PATH                                        = @"Model\";
        
        public const string CONST_DATA_PATH                                         = @"Data\";

        public readonly char[] CONST_NEWLINE_DELIMITERS                             = { '\r', '\n' };

        public readonly char[] CONST_NOTIFICATION_DELIMITERS                        = { ';' };

        protected readonly string CONST_PROVIDE_JOB_PREFIX = $"JOB_{DateTime.Now.ToString("yyyyMMdd")}_";
        #endregion

        #region Fields
        protected ErrorCode reelTowerGroupSequenceErrorCode                         = ErrorCode.None;

        protected bool takeOutByManual                                              = false;
        
        protected bool cycleStop                                                    = false;
        
        protected bool autoRunning                                                  = false;
        
        protected bool initialized                                                  = false;
        
        protected bool stopInitialize                                               = false;
        
        protected bool finishedLoadReelFromCart                                     = false;

        protected int currentWorkSlotOfCart                                         = 1;
        
        protected int threadScheduleInterval                                        = 10;
        
        protected int intervalReelTowerStatePolling                                 = 200;
        
        protected int timeoutRobotCommunication                                     = 10000;
        
        protected int timeoutOfRobotMoving                                          = 30000;
        
        protected int timeoutOfRobotHoming                                          = 36000;
        
        protected int timeoutMobileRobotCommunication                               = 3000;
        
        protected int timeOfMobileRobotClampValidation                              = 20000;
        
        protected int timeOfReturnReelPresentValidation                             = 10000;
        
        protected int timeoutOfNotification                                         = 30000;
        
        protected int delayOfImageProcessing                                        = 3000;
        
        protected int delayOfImageProcessingRetry                                   = 1000;
        
        protected int delayOfGrapRetry                                              = 100;
        
        protected int delayOfRobotCommunicationRetry                                = 1000;
        
        protected int delayOfUnloadReelStateUpdate                                  = 1000;
        
        protected int delayOfMaterialPackageUpdate                                  = 3000;
        
        protected int reelTowerQueryRetryCount                                      = 0;
        
        protected int robotActionRetryCount                                         = 0;
        
        protected int robotVisionRetryCount                                         = 0;
        
        protected int robotVisionRetryAttemptsCount                                 = 0;
        
        protected int robotVisionRetryCycleCount                                    = 0;
        
        protected int retryLimitOfReelTowerQuery                                    = 3;
        
        protected int retryLimitOfRobotActionCheck                                  = 10;
        
        protected int retryLimitOfRobotVisionCheck                                  = 10;
        
        protected int retryLimitOfRobotVisionCheckAttempts                          = 3;
        
        protected int retryLimitOfRobotPickup                                       = 10;
        
        protected int imageProcessTimeoutTick                                       = 0;
        
        protected int materialUnloadMoveTick                                        = 0;
        
        protected int materialLoadMoveTick                                          = 0;
        
        protected int materialBarcodeTick                                           = 0;
        
        protected int materialInfoUpdateTick                                        = 0;
        
        protected int robotProgramStateTick                                         = 0;
        
        protected int reelTowerTick                                                 = 0;
        
        protected int mobileRobotTick                                               = 0;
        
        protected int robotTick                                                     = 0;
        
        protected int visionTick                                                    = 0;
        
        protected int movementTick                                                  = 0;
        
        protected int cartPresentSensorTick                                         = 0;
        
        protected int returnReelPresentSensorTick                                   = 0;
        
        protected int unloadReelReportTick                                          = 0;
        
        protected int systemIdleStateTick                                           = -1;
        
        protected int stateQueryId                                                  = 1;
        
        protected int currentLoadReelTower                                          = -1;
        
        protected int currentUnloadReelTower                                        = -1;
        
        protected int totalLoadReelCountValue                                       = 0;
        
        protected int totalReturnReelCountValue                                     = 0;
        
        protected int totalUnloadReelCountValue                                     = 0;
        
        protected int loadErrorCountValue                                           = 0;
        
        protected int returnErrorCountValue                                         = 0;
        
        protected int unloadErrorCountValue                                         = 0;
        
        protected int visionAlignError                                              = 0;
        
        protected int visionDecodeError                                             = 0;
        
        protected int visionProcessResultState                                      = 0;
        
        protected int robotProgramStateCheckRetry                                   = 0;
        
        protected int retryLimitOfRobotProgramStateCheck                            = 10;

        protected int visionProcessLockState                                        = 0;

        protected int lastCheckupTick                                               = 0;

        protected int reservedOutPort                                               = 0;

        protected int towerStatePolling                                             = 0;

        protected int firstInitializationTick                                       = 0;

        protected double distanceXOfAlignError                                      = 20.0;
        
        protected double distanceYOfAlignError                                      = 20.0;
        
        protected string alignmentCoordX                                            = string.Empty;
        
        protected string alignmentCoordY                                            = string.Empty;
        
        protected string currentLoadReelTowerId                                     = string.Empty;
        
        protected string currentUnloadReelTowerId                                   = string.Empty;
        
        protected string robotOperationState                                        = string.Empty;
        
        protected string transferMaterialObjectMode                                 = string.Empty;

        protected string storedTowerId                                              = string.Empty;

        protected Dictionary<string, string> unloadConfirmedMaterials               = new Dictionary<string, string>();

        protected DateTime startCycleTime                                           = DateTime.Now;
        
        protected DateTime finishCycleTime                                          = DateTime.Now;
        
        protected TimeSpan lastCycleTime                                            = TimeSpan.Zero;

        protected DateTime lastUpdatedTowerStatusTime                               = DateTime.Now;

        protected ImageProcssingResults imageProcessingResult                       = ImageProcssingResults.Success;
        
        protected ReelDiameters currentReelTypeOfCart                               = ReelDiameters.Unknown;
        
        protected ReelDiameters currentReelTypeOfReturn                             = ReelDiameters.Unknown;
        
        protected ReelDiameters detectedReelTypeOfReturn                            = ReelDiameters.Unknown;
        
        protected ReelTowerGroupSteps previousReelTowerGroupStep                    = ReelTowerGroupSteps.None;
        
        protected ReelTowerGroupSteps reelTowerGroupStep                            = ReelTowerGroupSteps.Ready;
        
        protected SubSequenceSteps reelTowerGroupSubStep                            = SubSequenceSteps.Prepare;
        
        protected SubSequenceSteps mobileRobotSubStep                               = SubSequenceSteps.Prepare;
        
        protected ReelHandlerSteps previousRobotStep                                = ReelHandlerSteps.None;
        
        protected ReelHandlerSteps reelHandlerStep                                  = ReelHandlerSteps.Ready;
        
        protected SubSequenceSteps robotSubStep                                     = SubSequenceSteps.Prepare;
        
        protected SubSequenceSteps robotProgramStateStep                            = SubSequenceSteps.Prepare;
        
        protected CartPresentStates cartPresnetState                                = CartPresentStates.Unknown;
        
        protected OperationStates operationState                                    = OperationStates.PowerOn;
        
        protected RobotCommunicationStates responseOfRobotSequence                  = RobotCommunicationStates.Unknown;
        
        protected BarcodeConfirmStates barcodeConfirmState                          = BarcodeConfirmStates.Prepared;

        protected InitializeMode initializeMode                                     = InitializeMode.All;
        
        protected InitializeSteps systemInitializeStep                              = InitializeSteps.Unknown;
        
        protected InitializeSteps reelTowerGrouptInitializeStep                     = InitializeSteps.Unknown;
        
        protected SubSequenceSteps reelTowerGroupInitializeSubStep                  = SubSequenceSteps.Prepare;        

        protected FormMessageExt unloadwaitNotification                             = null;        

        protected Thread threadReelTowerNotification                                = null;

        protected Thread compositedProcess                                          = null;

        protected MaterialStorageState currentUnloadTaget                           = null;
        
        protected MaterialStorageState currentLoadTaget                             = null;
        
        protected List<int> currentProductionCountOfWorkSlot                        = new List<int>() { 0,0,0,0,0,0 };
        
        protected List<Thread> processThreads                                       = new List<Thread>();
        
        protected Dictionary<string, Thread> initializeThreads                      = new Dictionary<string, Thread>();
        
        protected MaterialStorageState responseOfReelTower                          = new MaterialStorageState();
        
        protected MaterialStorageState currentLoadReelState                         = new MaterialStorageState();
        
        protected MaterialStorageState currentUnloadReelState                       = new MaterialStorageState();

        protected BarcodeKeyInData barcodeKeyInData                                 = new BarcodeKeyInData();
        
        protected WaitHandle[] sequenceEvents                                       = new WaitHandle[2];
        
        protected MaterialData reelBarcodeContexts                                  = new MaterialData();
        
        protected Dictionary<ErrorCode, Pair<string, string>> alarmList             = new Dictionary<ErrorCode, Pair<string, string>>();
        
        protected List<Pair<int, ReelDiameters>> reelSensingStates                  = new List<Pair<int, ReelDiameters>>();
        
        protected Queue<string> reelTowerNotifications                              = new Queue<string>();
        
        protected Dictionary<Notifications, int> notificationTicks                  = new Dictionary<Notifications, int>();

        protected Dictionary<int, FormMessage> managedInformations                  = new Dictionary<int, FormMessage>();

        protected List<MaterialStoragePacket> lostSendPackets                       = new List<MaterialStoragePacket>();

        protected Dictionary<string, Pair<DateTime, MaterialStoragePacket>> waitReponsePackets    = new Dictionary<string, Pair<DateTime, MaterialStoragePacket>>();

        protected Dictionary<string, string> normalUnloadPendingMaterials           = new Dictionary<string, string>();
        #endregion

        #region Properties
        public virtual int TimeoutOfRobotControllerConnection                       { get; set; }
        
        public virtual int TimeoutOfMobileRobotCartInCheck                          { get; set; }
        
        public virtual int TimeoutOfReturnInputReelCheck                            { get; set; }
        
        public virtual int TimeoutOfReelType                                        { get; set; }

        public virtual int RetryLimitOfPickupFailure                                { get; set; }

        public virtual bool CycleStop                                               => cycleStop;
        
        public virtual bool Initialized                                             => initialized;

        public virtual bool AllNetworkConnected                                     => (ReelHandlerObject.IsConnected || !Config.ReelHandlerUsage) && !ReelTowerGroupObject.IsAllTowerOffline;

        public virtual bool IsPossibleToUnloadReel                                  => (ReelHandlerObject.IsConnected || !Config.ReelHandlerUsage) && ReelHandlerActionState != RobotActionStates.Loading && !IsStoring;

        public bool IsPossibleToRejectReel = false;
        public virtual bool IsRequiredReset                                         => operationState == OperationStates.Alarm;

        public virtual bool IsWaitBarcodeInput                                      => reelHandlerStep == ReelHandlerSteps.WaitForBarcodeInput;

        public virtual bool IsStoring                                               => !string.IsNullOrEmpty(storedTowerId);

        public virtual bool RunnableCondition                                       => (AllNetworkConnected && initialized);

        public virtual bool IsFinishedLoadReelFromCart                              => finishedLoadReelFromCart;

        public virtual int CurrentWorkSlotOfCart                                    => currentWorkSlotOfCart;

        public virtual bool IsReelTowerQueryRetryOver                               => reelTowerQueryRetryCount >= retryLimitOfReelTowerQuery;

        public virtual bool IsRobotVisionRetryOver                                  => robotVisionRetryCount >= retryLimitOfRobotVisionCheck;

        public virtual bool IsRobotVisionRetryAttemptsOver                          => robotVisionRetryAttemptsCount >= retryLimitOfRobotVisionCheckAttempts;
        
        public virtual bool IsRobotActionRetryOver                                  => robotActionRetryCount >= retryLimitOfRobotActionCheck;
        
        public virtual bool IsRobotProgramStateCheckRetryOver                       => robotProgramStateCheckRetry >= retryLimitOfRobotProgramStateCheck;
        
        public virtual bool IsReelTowerStatePollingDelayOver(int delay)             => (TimeSpan.FromMilliseconds(App.TickCount - reelTowerTick).TotalMilliseconds >= delay);
        
        public virtual bool IsRobotActionDelayOver(int delay)                       => (TimeSpan.FromMilliseconds(App.TickCount - robotTick).TotalMilliseconds >= delay);
        
        public virtual bool IsVisionProcessDelayOver(int delay)                     => (TimeSpan.FromMilliseconds(App.TickCount - visionTick).TotalMilliseconds >= delay);
        
        public virtual bool IsReturnReelSensingDelayOver(int delay)                 => (TimeSpan.FromMilliseconds(App.TickCount - returnReelPresentSensorTick).TotalMilliseconds >= delay);
        
        public virtual bool IsOverDelayTime(int delay, int tick)                    => (TimeSpan.FromMilliseconds(App.TickCount - tick).TotalMilliseconds >= delay);
        
        public virtual bool IsCartPresentSensingDelayOver(int delay)                => (TimeSpan.FromMilliseconds(App.TickCount - cartPresentSensorTick).TotalMilliseconds >= delay);

        public virtual bool IsUnloadReelStateUpdateDelayOver(int delay)             => (TimeSpan.FromMilliseconds(App.TickCount - unloadReelReportTick).TotalMilliseconds >= delay);
        
        public virtual bool IsOverMaterialInfoUpdateDelay(int delay)                => (TimeSpan.FromMilliseconds(App.TickCount - materialInfoUpdateTick).TotalMilliseconds >= delay);
        
        public virtual int RetryLimitOfVisionError                                  => retryLimitOfRobotVisionCheck;
        
        public virtual int InitializeStep                                           => Convert.ToInt32(reelTowerGrouptInitializeStep);
        
        public virtual int TotalLoadReels                                           => totalLoadReelCountValue;
        
        public virtual int TotalReturnReels                                         => totalReturnReelCountValue;
        
        public virtual int TotalUnloadReels                                         => totalUnloadReelCountValue;
        
        public virtual int LoadErrors                                               => loadErrorCountValue;
        
        public virtual int ReturnErrors                                             => returnErrorCountValue;
        
        public virtual int UnloadErrors                                             => unloadErrorCountValue;
        
        public virtual int VisionAlignErrors                                        => visionAlignError;
        
        public virtual int VisionDecodeErrors                                       => visionDecodeError;

        public virtual int ReservedOutPort
        {
            get
            {
                if (reservedOutPort >= Config.OutStageIds.Count)
                    return reservedOutPort = 0;

                return reservedOutPort;
            }
        }

        public virtual double DistanceXOfAlignError                                 => distanceXOfAlignError;
        
        public virtual double DistanceYOfAlignError                                 => distanceYOfAlignError;

        public virtual string CurrentOperator                                       => ReelTowerGroupObject.CurrentOperator;

        public virtual string LastReservedProvideJob                                => ReelTowerGroupObject.LastReservedProvideJob;

        public virtual string GetTowerNameById(string id) => ReelTowerGroupObject.GetTowerNameById(id);

        public virtual ReelDiameters CurrentReelTypeOfCart                          => currentReelTypeOfCart;

        public virtual ReelDiameters CurrentReelTypeOfReturn                        => currentReelTypeOfReturn;

        public virtual CommunicationStates CommunicationStatesOfWebService          => ReelTowerNotificationListenerObject.State;

        public virtual IReadOnlyList<int> CurrentProductionCountOfWorkSlot          => currentProductionCountOfWorkSlot;
        
        public virtual OperationStates OperationState                               => operationState;
        
        public virtual CartPresentStates CartPresentState                           => cartPresnetState;

        public virtual ReelHandlerSteps ReelHandlerStep                             => reelHandlerStep;
        
        public virtual ReelTowerGroupSteps ReelTowerStep                            => reelTowerGroupStep;
        
        public virtual Queue<string> ReelTowerNotifications                         => reelTowerNotifications;

        public virtual TimeSpan LastCycleTime                                       => lastCycleTime;

        public virtual MaterialData ReelBarcodeContexts                             => reelBarcodeContexts;      

        public virtual ReelTowerGroup ReelTowerGroupObject                          => Singleton<ReelTowerGroup>.Instance;

        public virtual CombineModuleManager CombineModuleManager                    => Singleton<CombineModuleManager>.Instance;

        public virtual ReelTowerNotificationListener ReelTowerNotificationListenerObject  => Singleton<ReelTowerNotificationListener>.Instance;

        public virtual ReelTowerAdapterServer ReelTowerAdapterServerObject                => Singleton<ReelTowerAdapterServer>.Instance;

        public virtual ReelHandlerManager ReelHandlerObject                               => Singleton<ReelHandlerManager>.Instance;

        public virtual bool HasProvideJob                                           => ReelTowerGroupObject.IsWaitToProvide;

        public virtual bool IsCombinedAll()                                         => this.CombineModuleManager.IsStartedAll();

        public virtual bool RemoveAccount(string user)                              => ReelTowerGroupObject.DeleteAccount(user);

        public virtual DataSet QueryAccount(string user)                            => ReelTowerGroupObject.QueryAccount(user);

        public virtual DataSet RefreshJob()                                         => ReelTowerGroupObject.RefreshJob();

        public virtual bool ProvideJob(string jobname)                              => ReelTowerGroupObject.ProvideJob(jobname);

        public virtual bool CancelJob(string jobname)                               => ReelTowerGroupObject.CancelJob(jobname);

        public virtual bool RemoveJob(string jobname, bool flush = true)            => ReelTowerGroupObject.RemoveJob(jobname, flush);

        public virtual bool IsFinishedJob(string jobname)                           => ReelTowerGroupObject.IsFinishedJob(jobname);

        public virtual string CreateProvideJobName(string prefix)                   => ReelTowerGroupObject.CreateProvideJobName(prefix);

        public virtual ProvideJobListData.States GetProvideJobState(string jobname) => ReelTowerGroupObject.GetProvideJobState(jobname);

        public virtual bool LoginAccountManager(string user, string password)       => ReelTowerGroupObject.LoginAccountManager(user, password);

        public virtual void LogoutAccountManager()                                  => ReelTowerGroupObject.LogoutAccountManager();

        public virtual bool LoginUser(string user)                                  => ReelTowerGroupObject.LoginUser(user);

        public virtual void LogoutUser()                                            => ReelTowerGroupObject.LogoutUser();

        public virtual bool RemoveArticle(string articlename)                       => ReelTowerGroupObject.RemoveArticle(articlename);

        public virtual bool RemoveCarrier(string carriername)                       => ReelTowerGroupObject.RemoveCarrier(carriername);

        public virtual bool AddNewAccount(UserGroup gid, string user, string password, string fullname, string remark)  => ReelTowerGroupObject.AddNewAccount(gid, user, password, fullname, remark);

        public virtual bool AddProvideJob(string jobname, string user, int outport, List<ProvideMaterialData> items)
        {
            bool result_ = false;

            if (result_ = ReelTowerGroupObject.AddProvideJob(jobname, user, outport, items))
                SetReservedOutPort(outport);

            return result_;
        }


        public Dictionary<string, MaterialData> AMMBarcode_ = new Dictionary<string, MaterialData>();

        //public virtual MaterialData AMMBarcode_ { get; set; }

        public virtual RobotActionStates ReelHandlerActionState                     => ReelHandlerObject.ActionState;

        public virtual string Connect()                                             => ReelTowerGroupObject.Connect();

        public virtual string SetEq()                                               => ReelTowerGroupObject.SetEq();

        public virtual string SetEqEnd()                                            => ReelTowerGroupObject.SetEqEnd();

        public virtual int SetEqAlive(int nAlive)                                   => ReelTowerGroupObject.SetEqAlive(nAlive);

        public virtual DataTable GetPickingID()                                     => ReelTowerGroupObject.GetPickingID();

        public virtual string GetReelqty(MaterialData materialData)                 => ReelTowerGroupObject.GetReelqty(materialData);

        public virtual string SetLoadComplete(MaterialData materialData, bool bWebService) => ReelTowerGroupObject.SetLoadComplete(materialData, bWebService);

        public virtual string SetUnloadStart(string pickingid) => ReelTowerGroupObject.SetUnloadStart(pickingid);

        //public virtual string SetUnloadOut(string uid, bool bWebService) => ReelTowerGroupObject.SetUnloadOut(uid, bWebService);
        public string SetUnloadOut(string carriername_, bool bWebService, string towerid = "", bool another = true)
        {
            string result = string.Empty;
            string res_ = string.Empty;
            if ((App.MainForm as FormMain).InvokeRequired)
            {
                (App.MainForm as FormMain).BeginInvoke(new Action(() =>
                {
                    try
                    {
                        if (another && !string.IsNullOrEmpty(towerid))
                        {
                            Debug.WriteLine($"SetUnloadOut TOWER={towerid} Reel ON/OFF = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff} TowerJobState = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate}");
                            //ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                            //newammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                            ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                            newammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                            Debug.WriteLine($"SetUnloadOut TOWER={towerid} Reel ON/OFF = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff} TowerJobState = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate}");
                            Set_Twr_State(towerid, ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff,
                                ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate);

                            Debug.WriteLine($"SetUnloadOut GET TOWER={towerid} State={Get_Twr_State(towerid)} Get Reel={Get_Twr_State_Reel(towerid)} Get Job={Get_Twr_State_Job(towerid)}");                            
                        }
                        Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {carriername_}, WebService : {bWebService}");
                        res_ = ReelTowerGroupObject.SetUnloadOut(carriername_, AMMWebServiceResult);
                        Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {carriername_}, WebService : {bWebService}");
                    }
                    catch
                    {
                        res_ = "FAILDE_WEBSERVICE";
                        AMMWebServiceResult = false;
                        //SetUnloadOut(carriername_, AMMWebServiceResult);
                        Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");
                    }
                    finally
                    {
                        if (res_ != "OK" && res_ != "NG")
                        {
                            res_ = "FAILDE_WEBSERVICE";
                            AMMWebServiceResult = false;
                            ReelTowerGroupObject.SetUnloadOut(carriername_, AMMWebServiceResult);
                            Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                        }
                    }

                    if (res_ == "FAILDE_WEBSERVICE")
                    {
                        AMMWebServiceResult = false;
                        Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");

                        if (!AMMstatusUpdateTimer.Enabled)
                            AMMstatusUpdateTimer.Enabled = true;
                    }
                    else if (res_ == "NG")
                    {
                        CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                        CommunicationWaitOfAMM = CommunicationStates.None;
                        Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");
                    }

                    if (another)
                    {
                        ProvideJobManager.RemoveItem(pickingid, carriername_);
                        if (ProvideJobManager.IsCompleted(pickingid))
                        {
                            try
                            {
                                if (SetUnloadEnd(pickingid) == "NG")
                                {
                                    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                    CommunicationWaitOfAMM = CommunicationStates.None;
                                    Logger.Alarm($"AMM Alarm=SetUnloadEnd:NG");
                                }
                            }
                            finally
                            {
                                //if (SetEqStatus("RUN", "COMPLETE") == "NG")
                                //{
                                //    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                //    CommunicationWaitOfAMM = CommunicationStates.None;
                                //    Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                                //}

                                CommunicationWaitOfAMM = CommunicationStates.None;
                                ProvideJobManager.RemoveJob(pickingid);
                                if (ProvideJobManager.jobs.Count == 0)
                                {
                                    ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                                    newammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                                    Set_Twr_State(towerid, ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff,
                                        ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate);
                                }
                                pickingid = string.Empty;
                            }
                        }
                    }
                }));
            }
            else
            {
                try
                {
                    if (another && !string.IsNullOrEmpty(towerid))
                    {
                        Debug.WriteLine($"SetUnloadOut TOWER={towerid} Reel ON/OFF = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff} TowerJobState = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate}");
                        //ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                        //newammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                        ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                        newammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                        Debug.WriteLine($"SetUnloadOut TOWER={towerid} Reel ON/OFF = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff} TowerJobState = {ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate}");
                        Set_Twr_State(towerid, ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff,
                            ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate);
                    }
                    Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {carriername_}, WebService : {bWebService}");
                    res_ = ReelTowerGroupObject.SetUnloadOut(carriername_, AMMWebServiceResult);
                    Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {carriername_}, WebService : {bWebService}");
                }
                catch
                {
                    res_ = "FAILDE_WEBSERVICE";
                    AMMWebServiceResult = false;
                    //SetUnloadOut(carriername_, AMMWebServiceResult);
                    Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");
                }
                finally
                {
                    if (res_ != "OK" && res_ != "NG")
                    {
                        res_ = "FAILDE_WEBSERVICE";
                        AMMWebServiceResult = false;
                        ReelTowerGroupObject.SetUnloadOut(carriername_, AMMWebServiceResult);
                        Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                    }
                }

                if (res_ == "FAILDE_WEBSERVICE")
                {
                    AMMWebServiceResult = false;
                    Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");

                    if (!AMMstatusUpdateTimer.Enabled)
                        AMMstatusUpdateTimer.Enabled = true;
                }
                else if (res_ == "NG")
                {
                    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                    CommunicationWaitOfAMM = CommunicationStates.None;
                    Logger.Alarm($"AMM Alarm=SetUnloadOut:{res_}");
                }

                if (another)
                {
                    ProvideJobManager.RemoveItem(pickingid, carriername_);
                    if (ProvideJobManager.IsCompleted(pickingid))
                    {
                        try
                        {
                            if (SetUnloadEnd(pickingid) == "NG")
                            {
                                CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                CommunicationWaitOfAMM = CommunicationStates.None;
                                Logger.Alarm($"AMM Alarm=SetUnloadEnd:NG");
                            }
                        }
                        finally
                        {
                            //if (SetEqStatus("RUN", "COMPLETE") == "NG")
                            //{
                            //    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                            //    CommunicationWaitOfAMM = CommunicationStates.None;
                            //    Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                            //}

                            CommunicationWaitOfAMM = CommunicationStates.None;
                            ProvideJobManager.RemoveJob(pickingid);
                            pickingid = string.Empty;
                        }
                    }
                }
            }
            return result;
        }

        //public virtual string SetUnloadOut_Manual(string uid, bool bWebService) => ReelTowerGroupObject.SetUnloadOut_Manual(uid, bWebService);
        public virtual string SetUnloadOut_Manual(string uid, bool bWebService, string towerid = "")
        {
            string result = string.Empty;
            if ((App.MainForm as FormMain).InvokeRequired)
            {
                (App.MainForm as FormMain).BeginInvoke(new Action(() =>
                {
                    try
                    {
                        if (string.IsNullOrEmpty(towerid))
                        {
                            //ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                            //newammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                            ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                            newammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                            Set_Twr_State(towerid, ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff,
                                ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate);
                        }
                        Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {uid}, WebServiceFlag : {AMMWebServiceResult}");
                        result = ReelTowerGroupObject.SetUnloadOut_Manual(uid, bWebService);
                        if (result == "FAILDE_WEBSERVICE")
                            AMMWebServiceResult = false;
                    }
                    catch (Exception)
                    {
                        result = "FAILDE_WEBSERVICE";
                        AMMWebServiceResult = false;
                    }
                }));
            }
            else
            {
                try
                {
                    if (string.IsNullOrEmpty(towerid))
                    {
                        //ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                        //newammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate = "RUN";
                        ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                        newammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff = "ON";
                        Set_Twr_State(towerid, ammtwrstatus["TOWER" + towerid.Substring(4, 1)].reelonoff,
                            ammtwrstatus["TOWER" + towerid.Substring(4, 1)].towerjobstate);
                    }
                    Logger.Trace($"{this.GetType().Name}.{MethodBase.GetCurrentMethod().Name}: UID : {uid}, WebServiceFlag : {AMMWebServiceResult}");
                    result = ReelTowerGroupObject.SetUnloadOut_Manual(uid, bWebService);
                    if (result == "FAILDE_WEBSERVICE")
                        AMMWebServiceResult = false;
                }
                catch (Exception ex)
                { 
                    result = "FAILDE_WEBSERVICE";
                    AMMWebServiceResult = false;
                }
            }
            return result;
        }

        public virtual string SetUnloadEnd(string pickingid) => ReelTowerGroupObject.SetUnloadEnd(pickingid);

        public virtual string SetEqStatus(string state, string substate = "", string firstid = "", string secondid = "") => ReelTowerGroupObject.SetEqStatus(state, substate, firstid, secondid);

        public virtual string SetEqEvent() => ReelTowerGroupObject.SetEqEvent();

        public virtual string User_check(string usernum) => ReelTowerGroupObject.User_check(usernum);

        // UPDATED: 20200728 (jm.choi)
        public virtual string SetPickingList_Cancel(string pickingid) => ReelTowerGroupObject.SetPickingList_Cancel(pickingid);

        public virtual DataTable GetMTLInfo(int index, string data) => ReelTowerGroupObject.GetMTLInfo(index, data);

        // UPDATED: 20210202 (jm.choi)
        public virtual string Set_Twr_State(string TowerID, string ReelOnOff, string TowerJobState) => ReelTowerGroupObject.Set_Twr_State(TowerID, ReelOnOff, TowerJobState);

        public virtual string Get_Twr_State(string TowerID) => ReelTowerGroupObject.Get_Twr_State(TowerID);

        public virtual string Get_Twr_State_Job(string TowerID) => ReelTowerGroupObject.Get_Twr_State_Job(TowerID);

        public virtual string Get_Twr_State_Reel(string TowerID) => ReelTowerGroupObject.Get_Twr_State_Reel(TowerID);



        public string pickingid = string.Empty;

        public bool WaitPicking = false;

        protected Thread ReelTowerGetPicking;

        public CommunicationStates CommunicationStatesOfAMM = CommunicationStates.None;

        public CommunicationStates CommunicationWaitOfAMM = CommunicationStates.None;

        public System.Windows.Forms.Timer AMMstatusUpdateTimer = new System.Windows.Forms.Timer();

        public System.Windows.Forms.Timer AMMAliveTimer = new System.Windows.Forms.Timer();

        protected int AMMstatusTimeCount = 0;

        protected int AMMAliveTimeCount = 0;

        public bool AMMWebServiceResult = true;

        public bool AMMAliveResult = false;

        public System.Windows.Forms.Timer PrepareToLoadTimer = new System.Windows.Forms.Timer();

        public Dictionary<string, towerinfo> preparetowerinfo = new Dictionary<string, towerinfo>();

        protected int PrepareToLoadTimeCount = 0;

        protected bool PrepareToLoadSuccess = false;

        public Dictionary<string, AMMTWRSTATUS> ammtwrstatus = new Dictionary<string, AMMTWRSTATUS>();
        public Dictionary<string, AMMTWRSTATUS> newammtwrstatus = new Dictionary<string, AMMTWRSTATUS>();

        public bool IsTowerPendingUnload(string towerid) => normalUnloadPendingMaterials.ContainsKey(towerid);

        public JobManager ProvideJobManager => Singleton<JobManager>.Instance;

        public bool AutoTaught => throw new NotImplementedException();

        public bool Calibrated => throw new NotImplementedException();

        public int AutoTechStep => throw new NotImplementedException();

        public int CalibrationStep => throw new NotImplementedException();
        #endregion

        #region Events
        public virtual event EventHandler OperationStateChanged;
        
        public virtual event EventHandler OperationModeChanged;
        
        public virtual event EventHandler FinishedCycleStop;
        
        public virtual event EventHandler CycleStopOrderStateChanged;
        
        public virtual event EventHandler<CartPresentStates> CartPresentStateChanged;
        
        public virtual event EventHandler<int> ChangedReelSizeOfCart;
        
        public virtual event EventHandler<Pair<string, bool>> NotifyEvent;
        
        public virtual event EventHandler<MaterialData> NotifyToShowBarcodeInputWindow;
        
        public virtual event EventHandler<bool> NotifyToShowDockCartWindow;
        
        public virtual event EventHandler NotifyProductionInformation;
        
        public virtual event EventHandler<string> ReportAlarmLog;

        public virtual event EventHandler<Pair<ReelTowerGroup.NotificationCodes, string[]>> ReportReelTowerGroupNotification;

        public virtual event EventHandler<string[]> ReportProvideMaterialState;

        public virtual event EventHandler<string[]> ProvideJobStateChanged;

        public virtual event EventHandler<string[]> NotifyReelTowerGroupRequestLoad;

        public virtual event EventHandler<Pair<string, ProvideJobListData>> InitializeProvideJos;

        public virtual event EventHandler<DataTable> AddPickingJobs;

        public event EventHandler<CommunicationStates> AMMCommunicationStateChanged;
        #endregion

        #region Constructors
        public ReelTowerGroupSequence()
        {
            sequenceEvents[0]           = App.MainForm.ShutdownEvent;
            sequenceEvents[1]           = new ManualResetEvent(false);

            totalLoadReelCountValue     = ProductionRecord._TotalLoadCountInt;
            totalReturnReelCountValue   = ProductionRecord._TotalReturnCountInt;
            totalUnloadReelCountValue   = ProductionRecord._TotalUnloadCountInt;
            loadErrorCountValue         = ProductionRecord._TotalLoadErrorCountInt;
            returnErrorCountValue       = ProductionRecord._TotalReturnErrorCountInt;
            unloadErrorCountValue       = ProductionRecord._TotalUnloadErrorCountInt;
            visionAlignError            = ProductionRecord._VisionAlignmentErrorCountInt;
            visionDecodeError           = ProductionRecord._VisionDecodeErrorCountInt;

            this.ReelTowerNotificationListenerObject.Create((App.MainForm as FormMain).RouteReelTowerNotification);
            this.ReelTowerAdapterServerObject.Create();

            if (this.ReelTowerNotificationListenerObject.Start(10000) == CommunicationStates.Listening &&
                this.ReelTowerAdapterServerObject.Start(10000) == System.ServiceModel.CommunicationState.Opened)
            {
                this.CombineModuleManager.Create((App.MainForm as FormMain), OnAllModulesCombined);
                this.CombineModuleManager.StartAll();
                this.ReelTowerNotificationListenerObject.GetMessage();
            }

            ammtwrstatus.Add("TOWER1", new AMMTWRSTATUS());
            ammtwrstatus.Add("TOWER2", new AMMTWRSTATUS());
            ammtwrstatus.Add("TOWER3", new AMMTWRSTATUS());
            ammtwrstatus.Add("TOWER4", new AMMTWRSTATUS());
            newammtwrstatus.Add("TOWER1", new AMMTWRSTATUS());
            newammtwrstatus.Add("TOWER2", new AMMTWRSTATUS());
            newammtwrstatus.Add("TOWER3", new AMMTWRSTATUS());
            newammtwrstatus.Add("TOWER4", new AMMTWRSTATUS());

            newammtwrstatus["TOWER1"].reelonoff = "OFF";
            newammtwrstatus["TOWER2"].reelonoff = "OFF";
            newammtwrstatus["TOWER3"].reelonoff = "OFF";
            newammtwrstatus["TOWER4"].reelonoff = "OFF";
            newammtwrstatus["TOWER1"].towerjobstate = "RUN";
            newammtwrstatus["TOWER2"].towerjobstate = "RUN";
            newammtwrstatus["TOWER3"].towerjobstate = "RUN";
            newammtwrstatus["TOWER4"].towerjobstate = "RUN";



        }
        #endregion

        #region Protected methods
        #region Dispose methods
        protected override void DisposeManagedObjects()
        {
            ReelHandlerObject.Dispose();

            if (threadReelTowerNotification != null)
                threadReelTowerNotification.Join();

            this.CombineModuleManager.Destroy();
            this.ReelTowerAdapterServerObject.Destroy();
            this.ReelTowerNotificationListenerObject.Destroy();
            this.ReelTowerGroupObject.Destroy();
            this.ReelHandlerObject.Destroy();
            RemoveAllLostPackets();
            RemoveAllWaitResponsePacket();
            RemoveAllManagedInformation();
            base.DisposeManagedObjects();
        }
        #endregion

        #region Event call methods
        protected virtual void FireNotifyReelTowerGroupRequestLoad(params string[] args)
        {
            NotifyReelTowerGroupRequestLoad?.Invoke(this, args);
        }

        protected virtual void FireProductionInformation(bool reset = false)
        {
            if (reset)
                ResetBarcodeContexts();

            NotifyProductionInformation?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void FirePopupBarcodeInputWindow(MaterialData data = null)
        {
            try
            {
                lock (barcodeKeyInData)
                    barcodeKeyInData.Clear();

                NotifyToShowBarcodeInputWindow?.Invoke(this, data);
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void FirePopupManualCartDockWindow(bool dock = true)
        {
            try
            {
                NotifyToShowDockCartWindow?.Invoke(this, dock);
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void FireShowNotification(string msg, bool multiple = true)
        {
            try
            {
                NotifyEvent?.Invoke(this, new Pair<string, bool>(msg.ToString(), multiple));
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected void FireRunableConditionFailure(bool reset = true)
        {
        }
        #endregion

        #region Notification methods
        public virtual bool IsNotificationDelayOver(Notifications key, int delay)
        {
            bool result_ = false;

            try
            { 
                if (notificationTicks.ContainsKey(key))
                {
                    if (result_ = (TimeSpan.FromMilliseconds(App.TickCount - notificationTicks[key]).TotalMilliseconds >= delay))
                        RemoveNotificationWatcher(key);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        protected virtual void RemoveNotificationWatcher(Notifications key)
        {
            try
            {
                if (notificationTicks.ContainsKey(key))
                {
                    lock (notificationTicks)
                        notificationTicks.Remove(key);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void RemoveAllNotificationWatcher()
        {
            if (notificationTicks.Count > 0)
            {
                lock (notificationTicks)
                    notificationTicks.Clear();
            }
        }

        protected virtual void FireShowNotification(Notifications key, string message)
        {
            if (!notificationTicks.ContainsKey(key))
                notificationTicks.Add(key, App.TickCount);

            if (IsNotificationDelayOver(key, timeoutOfNotification))
            {
                FireShowNotification(message);
                ResetSequenceSteps();
            }
        }
        #endregion

        #region Managed information methods
        protected virtual void OnFormClosedManagedInformation(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (sender is FormMessage)
                {
                    int id_ = (sender as FormMessage).Id;
                    DisposeManagedInformation(id_);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void DisposeManagedInformation(int key)
        {
            try
            {
                if (managedInformations.ContainsKey(key))
                {
                    lock (managedInformations)
                    {
                        managedInformations.Remove(key);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void ShowManagedInformation(int key, string message)
        {
            CloseManagedInformation(key);

            lock (managedInformations)
            {
                managedInformations.Add(key, FormMessageExt.ShowManagedInformation(key, message, Buttons.Ok, OnFormClosedManagedInformation));
            }
        }

        protected virtual void CloseManagedInformation(int key)
        {
            try
            {
                if (!Config.ReelHandlerUsage && managedInformations.ContainsKey(key))
                {
                    if (managedInformations[key] != null)
                    {
                        if (managedInformations[key].IsHandleCreated)
                            managedInformations[key].Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        protected virtual void ProcessLostSendPacket()
        {
            if (lostSendPackets.Count > 0)
            {
                lock (lostSendPackets)
                {
                    MaterialStoragePacket packet_ = lostSendPackets.First();

                    if (packet_ != null)
                    {
                        SendMessageToReelHandler(packet_.Command, packet_.Data, packet_.TowerId, packet_.State, packet_.Code, packet_.Message);
                        packet_.Dispose();
                        lostSendPackets.Remove(packet_);
                    }
                }
            }
        }

        protected virtual void ProcessWaitResponsePacket()
        {
            if (waitReponsePackets.Count > 0)
            {
                List<Pair<DateTime, MaterialStoragePacket>> packets_ = waitReponsePackets.Values.ToList();
                packets_.Sort(delegate (Pair<DateTime, MaterialStoragePacket> d1, Pair<DateTime, MaterialStoragePacket> d2)
                {
                    return d1.first.CompareTo(d2.first);
                });

                Pair<DateTime, MaterialStoragePacket> packet_ = packets_.First();
                if ((DateTime.Now - packets_.First().first).TotalSeconds > Config.TimeoutOfReject)
                {
                    //210202 Reel On 아닌데 UnloadComplete 전송해야하면 삭제부분추가
                    if (packet_.second.Command == ReelTowerCommands.REQUEST_UNLOAD_COMPLETE && ammtwrstatus["TOWER" + packet_.second.TowerId.Substring(4,1)].reelonoff == "OFF")
                    {                        
                        RemoveWaitResponsePacket(packet_.second.TowerId, (packet_.second.Data as ProvideMaterialData).Name);
                    }
                    else
                    {
                        SendMessageToReelHandler(packet_.second.Command, packet_.second.Data, packet_.second.TowerId, packet_.second.State, packet_.second.Code, packet_.second.Message);
                    }
                    IsPossibleToRejectReel = false;
                }
            }
        }

        protected virtual void RemoveAllLostPackets()
        {
            if (lostSendPackets.Count > 0)
            {
                lock (lostSendPackets)
                {
                    foreach (MaterialStoragePacket packet_ in lostSendPackets)
                        packet_.Dispose();

                    lostSendPackets.Clear();
                }
            }
        }

        protected virtual void RemoveAllManagedInformation()
        {
            try
            {
                if (managedInformations.Count > 0)
                {
                    foreach (FormMessage form_ in managedInformations.Values)
                    {
                        if (form_ != null)
                        {
                            if (form_.IsHandleCreated)
                                form_.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
            finally
            {
                if (managedInformations.Count > 0)
                {
                    lock (managedInformations)
                    {
                        managedInformations.Clear();
                    }
                }
            }
        }

        protected virtual bool IsWaitResponsePacket(string carriername)
        {
            return waitReponsePackets.ContainsKey(carriername);
        }

        protected virtual bool FlushWaitResponsePackImmediately(string towername, bool dispatch = false)
        {
            bool result_ = false;

            if (waitReponsePackets.Count > 0)
            {
                lock (waitReponsePackets)
                {
                    foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in waitReponsePackets)
                    {
                        if (packet_.Value.second.TowerId == towername)
                        {
                            if (dispatch)
                                SendMessageToReelHandler(packet_.Value.second.Command, packet_.Value.second.Data, packet_.Value.second.TowerId, packet_.Value.second.State, packet_.Value.second.Code, packet_.Value.second.Message);
                            packet_.Value.second.Dispose();
                            packet_.Value.second = null;
                            result_ = true;
                            break;
                        }
                    }
                }
            }

            return result_;
        }

        protected virtual void AddWaitResponsePacket(string carriername, MaterialStoragePacket packet)
        {
            bool dispose_ = true;

            if (!waitReponsePackets.ContainsKey(carriername))
            {
                if (!waitReponsePackets.Where(x_ => x_.Value.second.TowerId == packet.TowerId).Any())
                {
                    dispose_ = false;

                    lock (waitReponsePackets)
                        waitReponsePackets.Add(carriername, new Pair<DateTime, MaterialStoragePacket>(DateTime.Now, packet));

                    Logger.Trace($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Added a delayed message ({carriername})");
                }
            }

            if (dispose_)
            {
                if (packet != null)
                    packet.Dispose();
            }
        }

        protected virtual void RemoveAllWaitResponsePacket()
        {
            if (waitReponsePackets.Count > 0)
            {
                lock (waitReponsePackets)
                {
                    foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in waitReponsePackets)
                    {
                        packet_.Value.second.Dispose();
                        packet_.Value.second = null;
                    }

                    waitReponsePackets.Clear();
                }
            }
        }

        protected virtual void RemoveWaitResponsePacket(string towername, string carriername)
        {
            if (waitReponsePackets.Count > 0)
            {
                lock (waitReponsePackets)
                {
                    var packets_ = waitReponsePackets.Where(x_ => x_.Key == carriername &&
                    x_.Value.second.Command == ReelTowerCommands.REQUEST_UNLOAD_COMPLETE &&
                        x_.Value.second.TowerId == towername).ToList();

                    if (packets_ != null)
                    {
                        foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in packets_)
                        {
                            string packetmaterial_ = (packet_.Value.second.Data as ProvideMaterialData).Name;
                            if (packetmaterial_.ToLower().Contains("reject") || packetmaterial_ == carriername)
                            {
                                packet_.Value.second.Dispose();
                                packet_.Value.second = null;
                                waitReponsePackets.Remove(carriername);
                            }
                        }
                    }
                }
            }
        }

        protected virtual void UpdateWaitResponsePacket(ReelTowerCommands command, string towername, string carriername)
        {
            if (waitReponsePackets.Count > 0)
            {
                lock (waitReponsePackets)
                {
                    switch (command)
                    {
                        case ReelTowerCommands.REQUEST_UNLOAD_COMPLETE:
                            {
                                var packets_ = waitReponsePackets.Where(x_ => x_.Key == carriername &&
                                    x_.Value.second.Command == ReelTowerCommands.REQUEST_UNLOAD_COMPLETE &&
                                    x_.Value.second.TowerId == towername &&
                                    (x_.Value.second.Data as ProvideMaterialData).Name == carriername).ToList();

                                if (packets_ != null)
                                {
                                    foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in packets_)
                                        packet_.Value.first = DateTime.Now;
                                }
                            }
                            break;
                        case ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET:
                            {
                                var packets_ = waitReponsePackets.Where(x_ => x_.Value.second.Command == ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET).ToList();

                                if (packets_ != null)
                                {
                                    foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in packets_)
                                        packet_.Value.first = DateTime.Now;
                                }
                            }
                            break;
                    }
                }
            }
        }

        protected virtual void RemoveWaitResponsePacketByTowerName(string towername, bool forced = false)
        {
            if (waitReponsePackets.Count > 0)
            {
                lock (waitReponsePackets)
                {
                    var packets_ = waitReponsePackets.Where(x_ => x_.Value.second.Command == ReelTowerCommands.REQUEST_UNLOAD_COMPLETE &&
                        x_.Value.second.TowerId == towername).ToList();

                    if (packets_ != null)
                    {
                        foreach (KeyValuePair<string, Pair<DateTime, MaterialStoragePacket>> packet_ in packets_)
                        {
                            if (packet_.Value.second != null && (packet_.Key.Contains($"reject_{towername}") || forced))
                            {
                                packet_.Value.second.Dispose();
                                packet_.Value.second = null;
                                waitReponsePackets.Remove(packet_.Key);
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Reset or clear gui contents
        protected virtual void ResetBarcodeContexts()
        {
            reelBarcodeContexts.Clear();
        }

        public void ResetProductionCount()
        {
            this.totalLoadReelCountValue    = 0;
            this.totalReturnReelCountValue  = 0;
            this.totalUnloadReelCountValue  = 0;
            this.loadErrorCountValue        = 0;
            this.returnErrorCountValue      = 0;
            this.unloadErrorCountValue      = 0;
            this.visionAlignError           = 0;
            this.visionDecodeError          = 0;
        }
        #endregion

        #region Reserved out port methods
        protected void SetReservedOutPort(int outport)
        {
            reservedOutPort = outport;
        }
        #endregion

        #region Reel tower sequence
        protected virtual void FunctionReelTowerGroup()
        {
            bool result_    = false;
            int wrongstate_ = 0, idlestate_  = 0;
            string log_     = "Changed reel tower group step.";

            if (reelTowerGroupStep != previousReelTowerGroupStep)
            {
                Logger.ProcessTrace(MethodBase.GetCurrentMethod().Name, $"{reelTowerGroupStep}", $"From={previousReelTowerGroupStep},To={reelTowerGroupStep}:{log_}");
                previousReelTowerGroupStep  = reelTowerGroupStep;
                reelTowerGroupSubStep       = SubSequenceSteps.Prepare;
            }

            switch (reelTowerGroupStep)
            {
                #region Check reel tower state and define robot operation order
                case ReelTowerGroupSteps.None:
                case ReelTowerGroupSteps.Ready:
                    {
                        if (IsPossibleToUnloadReel || !Config.ReelHandlerUsage || IsPossibleToRejectReel)
                        {
                            if (ReelTowerGroupObject.IsProviding)
                            {   // Wait for complete of the current pended providing job
                                reelTowerGroupStep = ReelTowerGroupSteps.CheckProvideJobState;
                            }
                            else
                            {
                                if (((ReelHandlerObject.ActionState != RobotActionStates.Loading &&
                                    ReelHandlerObject.ActionState != RobotActionStates.Unload &&
                                    ReelHandlerObject.ActionState != RobotActionStates.Unloading)||
                                    ReelHandlerObject.ActionState == RobotActionStates.Stop) &&
                                    ReelTowerGroupObject.IsPossibleToProvideJob())
                                {
                                    Pair<string, ProvideJobListData> job_ = null;

                                    if (ReelTowerGroupObject.StartProvideJob(ref job_, Config.RemapCreateTimeByMFG))
                                    {
                                        SendMessageToReelHandler(ReelTowerCommands.SEND_PICKING_LIST, job_);
                                        reelTowerGroupStep = ReelTowerGroupSteps.CheckProvideJobState;
                                        pickingid = job_.first;
                                    }
                                }
                                else
                                {
                                    reelTowerGroupStep = ReelTowerGroupSteps.CheckProvideJobState;
                                }
                            }
                        }
                    }
                    break;
                #endregion

                #region Query reel tower state to search idle tower
                case ReelTowerGroupSteps.CheckProvideJobState:
                    {
                        if (IsOverDelayTime(1000, lastCheckupTick))
                        {
                            ProcessLostSendPacket();
                            ProcessWaitResponsePacket();
                            reelTowerGroupStep  = ReelTowerGroupSteps.Done;
                            lastCheckupTick     = App.TickCount;
                        }
                    }
                    break;
                case ReelTowerGroupSteps.Done:
                    {
                        switch (reelTowerGroupSubStep)
                        {
                            case SubSequenceSteps.Prepare:
                                {
                                    if (towerStatePolling++ > 7)
                                    {
                                        ReelTowerGroupObject.PeriodicUpdateTowerStatus(Config.AMMUsage);
                                        towerStatePolling = 0;
                                    }

                                    reelTowerGroupSubStep = SubSequenceSteps.Proceed;
                                }
                                break;
                            case SubSequenceSteps.Proceed:
                                {
                                    reelTowerGroupSubStep = SubSequenceSteps.Post;
                                }
                                break;
                            case SubSequenceSteps.Post:
                                {
                                    reelTowerGroupStep = ReelTowerGroupSteps.Ready;
                                }
                                break;
                        }
                    }
                    break;
                #endregion
            }
        }
        #endregion

        #region Process control methods
        protected bool StartTasks()
        {
            if (!autoRunning)
            {
                autoRunning = true;
                processThreads.Add(compositedProcess = new Thread(RunCompositedProcess));

                foreach (Thread thread in processThreads)
                    thread.Start();
                
                if (Config.AMMUsage)
                {
                    ReelTowerGetPicking = new Thread(RunAMMProcess);
                    ReelTowerGetPicking.Start();
                    AMMstatusUpdateTimer.Tick += AMMstatusUpdateTimer_Tick;
                    AMMstatusUpdateTimer.Interval = 1000;
                    AMMAliveTimer.Tick += AMMAliveTimer_Tick;
                    AMMAliveTimer.Interval = 1000;
                    AMMAliveTimer.Enabled = true;
                    
                    if (Config.AMMWebserviceUsage)
                    {
                        AMMWebServiceResult = true;

                        if (AMMstatusUpdateTimer.Enabled)
                            AMMstatusUpdateTimer.Enabled = false;
                    }

                    //System.ComponentModel.BackgroundWorker backgroundWorkerAMMAlive = new System.ComponentModel.BackgroundWorker();
                    //backgroundWorkerAMMAlive.WorkerReportsProgress = true;
                    //backgroundWorkerAMMAlive.WorkerSupportsCancellation = true;
                    //backgroundWorkerAMMAlive.DoWork += backgroundWorkerAMMAlive_DoWork;
                    //backgroundWorkerAMMAlive.RunWorkerCompleted += backgroundWorkerAMMAlive_RunWorkerCompleted;


                    //if (backgroundWorkerAMMAlive.IsBusy != true)
                    //    backgroundWorkerAMMAlive.RunWorkerAsync();
                }

                PrepareToLoadTimer.Tick += PrepareToLoadTimer_Tick;
                PrepareToLoadTimer.Interval = 1000;
                PrepareToLoadTimer.Enabled = true;
            }

            return autoRunning;
        }

        private void AMMstatusUpdateTimer_Tick(object sender, EventArgs e)
        {
            if (AMMstatusTimeCount == 300)
            {
                if (Config.AMMWebserviceUsage)
                {
                    if (!AMMWebServiceResult)
                        AMMWebServiceResult = true;
                }
                else
                {
                    AMMWebServiceResult = false;
                }

                AMMstatusUpdateTimer.Enabled = false;
                AMMstatusTimeCount = 0;
            }
            else
            {
                AMMstatusTimeCount++;
            }
        }

        private void AMMAliveTimer_Tick(object sender, EventArgs e)
        {
            if (AMMAliveTimeCount == 28)
            {
                AMMAliveResult = !AMMAliveResult;
                AMMAliveTimeCount = 0;
                if (AMMAliveResult)
                    SetEqAlive(1);
                else
                    SetEqAlive(0);
            }
            else
            {
                AMMAliveTimeCount++;
            }
        }

        private void PrepareToLoadTimer_Tick(object sender, EventArgs e)
        {
            string towername = string.Empty;
            for (int i = 1; i < 5; i++)
            {
                towername = ReelTowerGroupObject.Towers[i].Name;
                if (preparetowerinfo.Count > 0 && preparetowerinfo.ContainsKey(towername))
                {
                    if (!preparetowerinfo[towername].preparesuccess)
                    {
                        
                        if (preparetowerinfo[towername].preparetoload_count == 50)
                        {
                            if (preparetowerinfo[towername].preparetoload_retry < 3)
                            {
                                LoadReel(preparetowerinfo[towername].towerid, towername, preparetowerinfo[towername].barcode);
                                preparetowerinfo[towername].preparetoload_retry++;
                            }
                            else
                            {   // Retry count over
                                (App.MainSequence as ReelTowerGroupSequence).SetTowerState(towername, MaterialStorageState.StorageOperationStates.Abort);
                                RequestRejectLoadAbortedMaterial(preparetowerinfo[towername].towerid, towername, preparetowerinfo[towername].carrier);
                                IsPossibleToRejectReel = true;
                                preparetowerinfo.Remove(towername);
                            }
                            preparetowerinfo[towername].preparetoload_count = 0;
                        }
                        else
                        {
                            preparetowerinfo[towername].preparetoload_count++;
                        }
                    }
                    else
                    {
                        preparetowerinfo.Remove(towername);
                    }
                }
            }
        }

        protected bool StopTasks()
        {
            try
            {
                if (autoRunning)
                {
                    autoRunning = false;

                    if (processThreads.Count > 0)
                    {
                        foreach (Thread thread in processThreads)
                            thread.Join();

                        compositedProcess = null;
                    }

                    processThreads.Clear();
                    ReelTowerGetPicking.Join();
                    ReelTowerGetPicking = null;
                }
            }
            catch (Exception ex)
            {
                Logger.Trace($"{GetType()}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return !autoRunning;
        }

        protected void RunCompositedProcess()
        {
            #region Fields
            bool state_             = false;
            reelTowerGroupSubStep   = SubSequenceSteps.Prepare;
            mobileRobotSubStep      = SubSequenceSteps.Prepare;
            robotSubStep            = SubSequenceSteps.Prepare;
            StringBuilder messages_ = new StringBuilder();
            #endregion

            while (autoRunning)
            {
                if (state_ = RunnableCondition)
                {
                    try
                    {
                        FunctionReelTowerGroup();
                    }
                    catch (CycleStopException ex)
                    {
                        Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}(CycleStop)={ex.Message}");
                        PauseByCycleStop();
                    }
                    catch (PauseException<ErrorCode> ex)
                    {
                        Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}(Pause)={ex.Message}");
                        Pause(ex.Code);
                        ResetSequenceSteps();
                    }
                    catch (Exception ex)
                    {
                        Logger.Trace($"{GetType()}.{MethodBase.GetCurrentMethod().Name}(Exception)={ex.Message}");
                    }

                    RemoveAllNotificationWatcher();
                }
                else
                {
                    if (Config.ReelHandlerUsage && !ReelHandlerObject.IsConnected)
                        FireShowNotification(Notifications.ReelHadlerNotification, $"{Properties.Resources.String_Information_Check_System_Running_Environment}\r\nREELHANDLER=DISCONNECTED");
                    
                    if (ReelTowerGroupObject.IsAllTowerOffline)
                        FireShowNotification(Notifications.ReelTowerNotification, $"{Properties.Resources.String_Information_Check_System_Running_Environment}\r\nREELTOWER=ALL OFFLINE");
                }

                FireRunableConditionFailure(state_);
                Thread.Sleep(threadScheduleInterval);
            }
        }

        protected void RunAMMProcess()
        {
            int items_ = 0;
            bool valid_ = false;
            string jobid_ = string.Empty;
            string user_ = string.Empty;
            string token_ = string.Empty;
            string log_ = string.Empty;
            DataTable jobtbl_ = null;
            List<string> uids_ = new List<string>();
            
            while (autoRunning)
            {
                if (CommunicationStatesOfAMM == CommunicationStates.Connected)
                {
                    jobtbl_ = GetPickingID();
                    
                    if (jobtbl_.Rows.Count > 0)
                    {
                        jobtbl_.DefaultView.Sort = "PICKID";
                        jobtbl_ = jobtbl_.DefaultView.ToTable();

                        for (int x = 0; x < jobtbl_.Rows.Count; x++)
                        {
                            log_ = string.Format($"DateTime={jobtbl_.Rows[x][0].ToString()}, lincode={jobtbl_.Rows[x][1].ToString()},equipid={jobtbl_.Rows[x][2].ToString()}, pickid={jobtbl_.Rows[x][3].ToString()}, qty={jobtbl_.Rows[x][4].ToString()}, requestor={jobtbl_.Rows[x][5].ToString()}");
                            Logger.Trace(log_);
                        }
                        for (int i = 0; i < jobtbl_.Rows.Count; i++)
                        {
                            jobid_ = jobtbl_.Rows[i][3].ToString();
                            token_ = SetUnloadStart(jobid_);

                            if (token_ == "0")
                            {
                                SetUnloadEnd(jobid_);
                                ProvideJobManager.RemoveJob(jobid_);
                            }
                            else if (token_ == "NG")
                            {
                                CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                CommunicationWaitOfAMM = CommunicationStates.None;
                                Logger.Alarm($"AMM Alarm=SetUnloadStart:{token_}");
                            }
                            else
                            {
                                items_ = token_.Split(';').Count() - 1;
                                user_ = User_check(jobtbl_.Rows[i][5].ToString());
                                uids_.Clear();

                                for (int count = 0; count < items_; count++)
                                    uids_.Add(token_.Split(';')[count + 1]);

                                ProvideJobManager.AddJob(jobid_, user_, uids_);

                                // if (pickingsids.ContainsKey(local_pickingid) || pickinguids.ContainsKey(local_pickingid))
                                //     continue;
                                // 
                                // pickingqty = token_.Split(';').Count() - 1;
                                // pickingusername = User_check(jobtbl_.Rows[i][5].ToString());
                                // pickinguid.Clear();
                                // 
                                // for (int count = 0; count < pickingqty; count++)
                                // {
                                //     pickinguid.Add(token_.Split(';')[count + 1]);
                                // }

                                // if (PickingProvideJob(local_pickingid))
                                // {
                                //     //CommunicationWaitOfAMM = CommunicationStates.Accepted;
                                //     //WaitPick();
                                // }
                            }
                        }
                    }

                    Thread.Sleep(1000);
                }
            }
        }

        protected void WaitPick()
        {
            while (CommunicationWaitOfAMM == CommunicationStates.Accepted)
            {
                Thread.Sleep(500);
            }
        }

        protected void DoIdleStateProcess()
        {
        }

        protected void ResetState()
        {
            barcodeKeyInData.Clear();
        }

        protected void RecheckInterlockState()
        {
        }

        protected void CheckOperationPanelState()
        {   // Emergency stop
        }
        #endregion

        #region Initialize methods
        protected virtual void FireInitializeProvideJobs()
        {
            if (InitializeProvideJos != null)
            {
                foreach (Pair<string, ProvideJobListData> job_ in ReelTowerGroupObject.ProvideJobs)
                    InitializeProvideJos?.Invoke(this, job_);
            }
        }

        protected virtual void RunInitialize()
        {
            try
            {
                InitializeSteps step = InitializeSteps.Done;
                bool updatejobs_ = !ReelTowerGroupObject.IsInitialized;
                string log = "Started robot homing.";

                while (!autoRunning &&
                    !stopInitialize &&
                    reelTowerGrouptInitializeStep < InitializeSteps.Done)
                {
                    if ((systemInitializeStep = reelTowerGrouptInitializeStep) != step)
                    {
                        step = reelTowerGrouptInitializeStep;
                        reelTowerGroupInitializeSubStep = SubSequenceSteps.Prepare;
                        Logger.ProcessTrace($"{MethodBase.GetCurrentMethod().Name}", step.ToString(), log);
                    }

                    switch (reelTowerGrouptInitializeStep)
                    {
                        case InitializeSteps.CheckTowerInformation:
                            {
                                switch (reelTowerGroupInitializeSubStep)
                                {
                                    case SubSequenceSteps.Prepare:
                                        {
                                            if (!ReelTowerGroupObject.IsInitialized)
                                            {
                                                SendMessageToReelHandler(ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET, null, ReelTowerGroupObject.AllTowerNameList);
                                                firstInitializationTick = App.TickCount;
                                            }

                                            reelTowerGroupInitializeSubStep = SubSequenceSteps.Proceed;
                                        }
                                        break;
                                    case SubSequenceSteps.Proceed:
                                        {
                                            if (IsOverDelayTime(1000, firstInitializationTick))
                                                reelTowerGroupInitializeSubStep = SubSequenceSteps.Post;
                                        }
                                        break;
                                    case SubSequenceSteps.Post:
                                        {
                                            if (ReelTowerGroupObject.TowerIds.Count > 0)
                                            {
                                                if (ReelTowerGroupObject.Init(CONST_DATA_PATH))
                                                {
                                                    if (updatejobs_)
                                                    {
                                                        FireInitializeProvideJobs();
                                                    }

                                                    reelTowerGrouptInitializeStep = InitializeSteps.CheckNotificationListener;
                                                }
                                            }
                                            else
                                                reelTowerGrouptInitializeStep = InitializeSteps.Failed;
                                        }
                                        break;
                                }
                            }
                            break;
                        case InitializeSteps.CheckNotificationListener:
                            {
                                if (ReelTowerAdapterServerObject.Initialized && ReelTowerNotificationListenerObject.Initialized)
                                    reelTowerGrouptInitializeStep = InitializeSteps.CheckReelHandler;
                            }
                            break;
                        case InitializeSteps.CheckReelHandler:
                            {
                                if (Config.AMMUsage)
                                    reelTowerGrouptInitializeStep = InitializeSteps.CheckAMM;
                                else
                                    reelTowerGrouptInitializeStep = InitializeSteps.PrepareInitialize;
                            }
                            break;
                        case InitializeSteps.CheckAMM:
                            {
                                if (CommunicationStatesOfAMM != CommunicationStates.Connected)
                                {
                                    string result_ = AMMSetting();
                                    if (result_.ToUpper() == "OK")
                                    {
                                        CommunicationStatesOfAMM = CommunicationStates.Connected;
                                        reelTowerGrouptInitializeStep = InitializeSteps.PrepareInitialize;
                                    }
                                    else
                                    {
                                        CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                        CommunicationWaitOfAMM = CommunicationStates.None;
                                        reelTowerGrouptInitializeStep = InitializeSteps.Failed;
                                    }
                                    AMMCommunicationStateChanged?.Invoke(this, CommunicationStatesOfAMM);
                                }
                                else
                                {
                                    reelTowerGrouptInitializeStep = InitializeSteps.PrepareInitialize;
                                }
                            }
                            break;
                        case InitializeSteps.PrepareInitialize:
                            {
                                switch (reelTowerGroupInitializeSubStep)
                                {
                                    case SubSequenceSteps.Prepare:
                                        {
                                            log = "Searching home.";
                                            reelTowerGroupInitializeSubStep = SubSequenceSteps.Proceed;
                                        }
                                        break;
                                    case SubSequenceSteps.Proceed:
                                        {
                                            reelTowerGroupInitializeSubStep = SubSequenceSteps.Post;
                                        }
                                        break;
                                    case SubSequenceSteps.Post:
                                        {
                                            reelTowerGrouptInitializeStep = InitializeSteps.Initializing;
                                        }
                                        break;
                                }
                            }
                            break;
                        case InitializeSteps.Initializing:
                            {
                                switch (reelTowerGroupInitializeSubStep)
                                {
                                    case SubSequenceSteps.Prepare:
                                        {
                                            log = "Homing.";
                                            reelTowerGroupInitializeSubStep = SubSequenceSteps.Proceed;
                                        }
                                        break;
                                    case SubSequenceSteps.Proceed:
                                        {
                                            if (ReelTowerGroupObject.Towers.Count <= 0 || !ReelTowerGroupObject.AccountDB.Initialized || !ReelTowerAdapterServerObject.Running || !ReelTowerNotificationListenerObject.Running)
                                                systemInitializeStep = (reelTowerGrouptInitializeStep = InitializeSteps.Failed);

                                            reelTowerGroupInitializeSubStep = SubSequenceSteps.Post;
                                        }
                                        break;
                                    case SubSequenceSteps.Post:
                                        {
                                            reelTowerGrouptInitializeStep = InitializeSteps.PostInitialize;
                                        }
                                        break;
                                }
                            }
                            break;
                        case InitializeSteps.PostInitialize:
                            {
                                if (reelTowerGrouptInitializeStep == InitializeSteps.Failed)
                                    stopInitialize = true;
                                else
                                {
                                    log = "Completed initialization.";
                                    systemInitializeStep = (reelTowerGrouptInitializeStep = InitializeSteps.Done);
                                }
                            }
                            break;
                    }

                    Thread.Sleep(CONST_THREAD_POLLING_INTERVAL);
                }
            }
            catch (Exception ex)
            {
                systemInitializeStep = (reelTowerGrouptInitializeStep = InitializeSteps.Unknown);
                stopInitialize = true;
                Logger.Trace($"{GetType()}.{MethodBase.GetCurrentMethod()}: Exception={ex.Message}");
            }
            finally
            {
                switch (systemInitializeStep)
                {
                    default:
                        { // Aborted by operator
                            Pause(ErrorCode.AbortInitialize);
                        }
                        break;
                    case InitializeSteps.Done:
                        {
                            initialized             = true;
                            reelTowerGroupStep      = ReelTowerGroupSteps.Ready;
                            reelHandlerStep         = ReelHandlerSteps.Ready;
                            reelTowerGroupSubStep   = SubSequenceSteps.Prepare;
                            mobileRobotSubStep      = SubSequenceSteps.Prepare;
                            robotSubStep            = SubSequenceSteps.Prepare;
                            Stop();
                            ClearStates();
                        }
                        break;
                    case InitializeSteps.Failed:
                    case InitializeSteps.Unknown:
                        {
                            Pause(ErrorCode.FailedInitialize);
                        }
                        break;
                }
            }
        }
        #endregion

        #region Module event handling methods
        protected virtual void RequestUnloadMaterial(ProvideMaterialData data)
        {
            try
            {
                bool updated_ = false;

                lock (unloadConfirmedMaterials)
                {
                    if (unloadConfirmedMaterials.ContainsKey(data.TowerId))
                    {
                        if (unloadConfirmedMaterials[data.TowerId] != data.Name)
                        {
                            updated_ = true;
                            unloadConfirmedMaterials[data.TowerId] = data.Name;
                        }
                    }
                    else
                    {
                        updated_ = true;
                        unloadConfirmedMaterials.Add(data.TowerId, data.Name);
                    }
                }

                if (updated_)
                {
                    if (Config.ReelHandlerUsage)
                    {
                        if (!IsTowerPendingUnload(data.TowerId))
                            normalUnloadPendingMaterials.Add(data.TowerId, $"{data.TowerName}_{data.Name}_{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");

                        SendMessageToReelHandler(ReelTowerCommands.REQUEST_UNLOAD_COMPLETE, data, data.TowerName);
                    }
                    else
                    {
                        int key_ = 0;
                        switch (key_ = Convert.ToInt32(data.TowerName.Last()))
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                                {
                                    ShowManagedInformation(key_, $"Please, take out the reel ({data.Name}) on tower ({data.TowerName})");
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        public virtual void RequestRejectLoadAbortedMaterial(string towerid, string towername, string carriername)
        {   // Normal abort to load case.
            if (string.IsNullOrEmpty(towerid) || string.IsNullOrEmpty(towername) || string.IsNullOrEmpty(carriername))
                return;

            // UPDATED: 20200410 (Marcus)
            // Added aborted load reel handling.
            ReelTowerGroupObject.ResetTowerStateByName(towername);
            ProvideMaterialData data_ = new ProvideMaterialData(towerid);
            data_.Name = $"reject_{towername}_" + carriername;
            data_.TowerId = towerid;
            data_.TowerName = towername;
            data_.Text = $"Reject_No_{Config.AssignedRejectPort}";
            AddWaitResponsePacket(data_.Name,
                new MaterialStoragePacket(ReelTowerCommands.REQUEST_UNLOAD_COMPLETE,
                data_,
                towername,
                string.Empty,
                "-2",
                $"Load material operation was failed timeout ({Config.TimeoutOfReject})",
                true));
        }

        protected virtual void RequestRejectMaterial(string towerid, string towername, string carriername, int outport, ProvideMaterialData data, string code = "0", string message = "Reject material")
        {
            if (string.IsNullOrEmpty(towerid) || string.IsNullOrEmpty(towername) || data == null)
                return;

            // UPDATED: 20200410 (Marcus)
            // Added aborted load reel handling.
            ReelTowerGroupObject.ResetTowerStateByName(towername);
            data.Name = string.IsNullOrEmpty(carriername)? $"reject_{towername}_{DateTime.Now.ToString("yyyyMMddHH")}" : carriername;
            data.TowerId = towerid;
            data.TowerName = towername;
            data.Text = $"Reject_No_{Config.AssignedRejectPort}";
            AddWaitResponsePacket(data.Name,
                new MaterialStoragePacket(ReelTowerCommands.REQUEST_UNLOAD_COMPLETE,
                data,
                towername,
                string.Empty,
                code,
                message,
                true));
        }

        protected virtual void ProcessReelTowerNotification()
        {
            bool stop_ = false;
            bool failed_ = false;
            string res_ = string.Empty;
            int statuscode_ = -1;
            List<WaitHandle> events_ = new List<WaitHandle>();
            ProvideMaterialData data_ = null;
            events_.Add(App.ShutdownEvent);
            
            while (!stop_)
            {
                switch (WaitHandle.WaitAny(events_.ToArray(), 10))
                {
                    case 0:
                        {
                            stop_ = true;
                        }
                        break;
                    case 1:
                    case System.Threading.WaitHandle.WaitTimeout:
                    {
                            string statusmessage_   = string.Empty;
                            string articlename_     = string.Empty;
                            string carriername_     = string.Empty;
                            string towerid_         = string.Empty;
                            string jobname_         = string.Empty;
                            string jobstate_        = string.Empty;
                            string productionstate_ = string.Empty;
                            string[] tokens_        = null;
                            string[] messgages_     = null;
                            ReelTowerGroup.NotificationCodes code_ = ReelTowerGroup.NotificationCodes.Unknown;

                            try
                            {
                                if (reelTowerNotifications.Count() > 0)
                                {
                                    lock (reelTowerNotifications)
                                        messgages_ = reelTowerNotifications.Dequeue().Split(CONST_NEWLINE_DELIMITERS, StringSplitOptions.RemoveEmptyEntries);

                                    foreach (string message_ in messgages_)
                                    {
                                        tokens_ = message_.Split(CONST_NOTIFICATION_DELIMITERS, StringSplitOptions.RemoveEmptyEntries);

                                        if (tokens_ != null && tokens_.Length >= 3)
                                        {
                                            switch (code_ = (ReelTowerGroup.NotificationCodes)Enum.Parse(typeof(ReelTowerGroup.NotificationCodes), tokens_[2]))
                                            {
                                                case ReelTowerGroup.NotificationCodes.WakeUpWebService:
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.RequestLoad:
                                                    {
                                                        ReelTowerGroupObject.UpdateRequestToLoadState(tokens_[3], ref towerid_, ref carriername_);

                                                        if (!string.IsNullOrEmpty(towerid_) && !string.IsNullOrEmpty(carriername_))
                                                            FireNotifyReelTowerGroupRequestLoad(towerid_, carriername_);
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.RequestUnload:
                                                    {
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.RequestCarrierData:
                                                case ReelTowerGroup.NotificationCodes.RequestComponentData:
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyTowerStatus:
                                                    {
                                                        ReelTowerState obj_ = null;

                                                        switch (statuscode_ = ReelTowerGroupObject.UpdateTowerStatus(tokens_[3], ref obj_))
                                                        {
                                                            case 1031:
                                                                break;
                                                            default:
                                                            case 310117:
                                                            case 310102:
                                                            case 310177:
                                                            case 310105:
                                                            case 1032:
                                                                {
                                                                    if (obj_ != null && !obj_.StatusText.ToLower().Contains("initializing"))
                                                                    {
                                                                        switch (obj_.State)
                                                                        {
                                                                            case MaterialStorageState.StorageOperationStates.RequestedToLoad:
                                                                            case MaterialStorageState.StorageOperationStates.PrepareToLoad:
                                                                            case MaterialStorageState.StorageOperationStates.Load:
                                                                                {
                                                                                    MaterialData tempdata_ = null;
                                                                                    if ((tempdata_ = ReelTowerGroupObject.GetLoadMaterialName(obj_.Id)) == null)
                                                                                    {   // Abnormal case 1
                                                                                        RequestRejectMaterial(obj_.Id, obj_.Name, string.Empty, 1, new ProvideMaterialData(obj_.Id), "-2", Properties.Resources.String_Warning_Reject_Message_MaterialInformationNotExist);
                                                                                        IsPossibleToRejectReel = true;

                                                                                        if (preparetowerinfo.ContainsKey(obj_.Name))
                                                                                            preparetowerinfo[obj_.Name].preparesuccess = true;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        if ((DateTime.Now - tempdata_.EventDateTime).TotalSeconds > Config.TimeoutOfReject)
                                                                                        {
                                                                                            if (ReelTowerGroupObject.CancelRemoveLoadMaterialName(obj_.Id))
                                                                                            {   // Abnormal case 2
                                                                                                RequestRejectMaterial(obj_.Id, obj_.Name, string.Empty, 1, new ProvideMaterialData(tempdata_), "-2", string.Format(Properties.Resources.String_Warning_Reject_Message_LoadMaterialOperationTimeout, Config.TimeoutOfReject));
                                                                                                IsPossibleToRejectReel = true;

                                                                                                if (preparetowerinfo.ContainsKey(obj_.Name))
                                                                                                    preparetowerinfo[obj_.Name].preparesuccess = true;
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                                break;
                                                                            case MaterialStorageState.StorageOperationStates.Unknown:
                                                                                break;
                                                                            case MaterialStorageState.StorageOperationStates.Idle:
                                                                            case MaterialStorageState.StorageOperationStates.Run:
                                                                            case MaterialStorageState.StorageOperationStates.Down:
                                                                            case MaterialStorageState.StorageOperationStates.Error:
                                                                            case MaterialStorageState.StorageOperationStates.Wait:
                                                                            case MaterialStorageState.StorageOperationStates.Full:
                                                                                {   // Reject state filter.
                                                                                    if ((obj_.StatusText.ToLower() != "ready" || obj_.StatusText.ToLower().Contains("component in terminal")) && !IsTowerPendingUnload(obj_.Id))
                                                                                    {   // Abnormal case 3
                                                                                        if (statuscode_ > 3000)
                                                                                            statusmessage_ = obj_.StatusText;
                                                                                        else
                                                                                            statusmessage_ = Properties.Resources.String_Warning_Reject_Message_WrongMaterialInformation;

                                                                                        RequestRejectMaterial(obj_.Id, obj_.Name, string.Empty, 1, new ProvideMaterialData(obj_.Id), "-2", statusmessage_);
                                                                                        IsPossibleToRejectReel = true;

                                                                                        if (preparetowerinfo.ContainsKey(obj_.Name))
                                                                                            preparetowerinfo[obj_.Name].preparesuccess = true;
                                                                                    }
                                                                                }
                                                                                break;
                                                                            case MaterialStorageState.StorageOperationStates.RequestedToUnload:
                                                                            case MaterialStorageState.StorageOperationStates.PrepareToUnload:
                                                                            case MaterialStorageState.StorageOperationStates.Unload:
                                                                                {
                                                                                    if ((data_ = ReelTowerGroupObject.GetUnloadMaterialName(obj_.Id)) != null)
                                                                                    {
                                                                                        if (ReelTowerGroupObject.GetProvideMaterialData(data_.Name, obj_.Id, ProvideMaterialData.States.Providing, ref data_))  // Normal case 1
                                                                                            RequestUnloadMaterial(data_);
                                                                                    }
                                                                                }
                                                                                break;
                                                                            case MaterialStorageState.StorageOperationStates.Abort:
                                                                                {
                                                                                    string towername_ = ReelTowerGroupObject.GetTowerNameById(obj_.Id);
                                                                                    CloseManagedInformation(obj_.Index);
                                                                                    RemoveWaitResponsePacketByTowerName(towername_, obj_.State == MaterialStorageState.StorageOperationStates.Abort);
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                                break;
                                                            case 26:
                                                            case 1041:
                                                                {
                                                                    if (obj_ != null)
                                                                    {
                                                                        switch (obj_.Index)
                                                                        {
                                                                            case 1:
                                                                            case 2:
                                                                            case 3:
                                                                            case 4:
                                                                                {
                                                                                    switch (obj_.State)
                                                                                    {
                                                                                        default:
                                                                                            {
                                                                                                if (statuscode_ == 26 && IsTowerPendingUnload(obj_.Id))
                                                                                                    normalUnloadPendingMaterials.Remove(obj_.Id);

                                                                                                string towername_ = ReelTowerGroupObject.GetTowerNameById(obj_.Id);
                                                                                                CloseManagedInformation(obj_.Index);
                                                                                                RemoveWaitResponsePacketByTowerName(towername_, obj_.State == MaterialStorageState.StorageOperationStates.Abort);                                                                                                
                                                                                            }
                                                                                            break;
                                                                                    }
                                                                                }
                                                                                break;
                                                                        }
                                                                    }
                                                                }
                                                                break;
                                                            case 1040:
                                                                {
                                                                    if (Config.AMMUsage)
                                                                    {
                                                                        if (SetEqStatus("RUN", "UNLOAD", pickingid, string.Empty) == "NG")
                                                                        {
                                                                            CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                                                            CommunicationWaitOfAMM = CommunicationStates.None;
                                                                            Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                                                                        }
                                                                    }
                                                                }
                                                                break;
                                                        }

                                                        lastUpdatedTowerStatusTime = DateTime.Now;
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyStSysStarted:
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierLoad:
                                                    {
                                                        ReelTowerGroupObject.UpdateTowerStatusByIdAfterCarrierLoad(tokens_[3], ref towerid_);
                                                        if (Config.AMMUsage)
                                                        {
                                                            string trans_towerid_ = ReelTowerGroupObject.GetTowerNameById(towerid_);
                                                            try
                                                            {                                                                
                                                                res_ = SetLoadComplete(AMMBarcode_[trans_towerid_], AMMWebServiceResult);
                                                            }
                                                            catch (Exception exp)
                                                            {
                                                                res_ = "FAILDE_WEBSERVICE";
                                                                AMMWebServiceResult = false;
                                                                SetLoadComplete(AMMBarcode_[trans_towerid_], AMMWebServiceResult);
                                                                Logger.Alarm($"AMM Alarm=SetLoadComplete:{res_}");
                                                            }

                                                            if (res_ == "FAILDE_WEBSERVICE")
                                                            {
                                                                AMMWebServiceResult = false;
                                                                Logger.Alarm($"AMM Alarm=SetLoadComplete:{res_}");
                                                                if (!AMMstatusUpdateTimer.Enabled)
                                                                    AMMstatusUpdateTimer.Enabled = true;
                                                            }
                                                            else if (res_ == "NG")
                                                            {
                                                                CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                                                CommunicationWaitOfAMM = CommunicationStates.None;
                                                                Logger.Alarm($"AMM Alarm=SetLoadComplete:{res_}");
                                                            }

                                                            //if (AMMBarcode_[trans_towerid_].LoadType.ToString().ToUpper() != "CART")
                                                            //{
                                                            //    //if (SetEqStatus("RUN", "COMPLETE") == "NG")
                                                            //    //{
                                                            //    //    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                                            //    //    CommunicationWaitOfAMM = CommunicationStates.None;
                                                            //    //    Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                                                            //    //}
                                                            //}

                                                            if (preparetowerinfo.ContainsKey(trans_towerid_))
                                                                preparetowerinfo[trans_towerid_].preparesuccess = true;
                                                            AMMBarcode_.Remove(trans_towerid_);
                                                        }
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierUnload:
                                                    {
                                                        try
                                                        {
                                                            ReelTowerGroupObject.UpdateRequestToUnloadState(tokens_[3]);

                                                            if (ReelTowerGroupObject.UpdatePrepareToUnloadState(tokens_[3], ref towerid_, ref carriername_, ref data_))
                                                            {
                                                                if (data_ != null)
                                                                {
                                                                    if (Config.AMMUsage)
                                                                    {
                                                                        // AMM에서 Job 생성하여 전송 시 pickingid가 저장되나
                                                                        // Enqueue 버튼으로 Job 생성 시 pickingid가 저장되지않음
                                                                        string trans_towerid_ = ReelTowerGroupObject.GetTowerNameById(towerid_);
                                                                        if (!string.IsNullOrEmpty(pickingid))
                                                                        {
                                                                            SetUnloadOut(carriername_, AMMWebServiceResult, trans_towerid_);                                                                            
                                                                        }
                                                                        else
                                                                        {
                                                                            try
                                                                            {
                                                                                res_ = SetUnloadOut_Manual(carriername_, AMMWebServiceResult, trans_towerid_);
                                                                            }
                                                                            catch (Exception exp)
                                                                            {
                                                                                res_ = "FAILDE_WEBSERVICE";
                                                                                AMMWebServiceResult = false;
                                                                                SetUnloadOut_Manual(carriername_, AMMWebServiceResult);
                                                                                Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                                                                            }
                                                                            finally
                                                                            {
                                                                                if (res_ != "OK" && res_ != "NG")
                                                                                {
                                                                                    res_ = "FAILDE_WEBSERVICE";
                                                                                    AMMWebServiceResult = false;
                                                                                    SetUnloadOut_Manual(carriername_, AMMWebServiceResult);
                                                                                    Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                                                                                }
                                                                            }
                                                                            if (res_ == "FAILDE_WEBSERVICE")
                                                                            {
                                                                                AMMWebServiceResult = false;
                                                                                Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                                                                                if (!AMMstatusUpdateTimer.Enabled)
                                                                                    AMMstatusUpdateTimer.Enabled = true;
                                                                            }
                                                                            else if (res_ == "NG")
                                                                            {
                                                                                CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                                                                CommunicationWaitOfAMM = CommunicationStates.None;
                                                                                Logger.Alarm($"AMM Alarm=SetUnloadOut_Manual:{res_}");
                                                                            }
                                                                            //if (SetEqStatus("RUN", "COMPLETE") == "NG")
                                                                            //{
                                                                            //    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                                                            //    CommunicationWaitOfAMM = CommunicationStates.None;
                                                                            //    Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                                                                            //}

                                                                            ProvideJobManager.RemoveItem(pickingid, carriername_);
                                                                            //pickinguids[pickingid].Remove(carriername_);
                                                                            //pickingsids[pickingid].Remove(pickingsid[0]);
                                                                            //pickingsid.Remove(pickingsid[0]);
                                                                            //pickinguid.Remove(carriername_);

                                                                        }
                                                                    }
                                                                    if (Config.ReelHandlerUsage && !takeOutByManual)
                                                                    {
                                                                        // Normal case 2
                                                                        RequestUnloadMaterial(data_);
                                                                    }
                                                                    else
                                                                    {
                                                                        failed_ = true;
                                                                    }
                                                                }
                                                                else
                                                                    failed_ = true;
                                                            }
                                                            else
                                                            {
                                                                if (Config.ReelHandlerUsage && data_ == null)   // Abnormal case 4
                                                                {
                                                                    Logger.Trace($"Wrong tower state and material information is not available: {towerid_},{carriername_}");
                                                                    RequestRejectMaterial(towerid_, ReelTowerGroupObject.GetTowerNameById(towerid_), carriername_, 1, new ProvideMaterialData(towerid_), "-2", "Wrong tower state and material information is not available.");
                                                                    IsPossibleToRejectReel = true;
                                                                }
                                                                else
                                                                    failed_ = true;
                                                            }

                                                            if (failed_)
                                                                ReelTowerGroupObject.FireProvideMaterialStateChanged(towerid_, carriername_);
                                                        }
                                                        catch (Exception ex)
                                                        {
                                                        }
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierNew:
                                                    {
                                                        ReelTowerGroupObject.UpdateCarrierStatus(tokens_[2], tokens_[3], ref carriername_, ref towerid_, ref data_);
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierDelete:
                                                    {
                                                        ReelTowerGroupObject.UpdateCarrierStatus(tokens_[2], tokens_[3], ref carriername_, ref towerid_, ref data_);
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyComponentNew:
                                                case ReelTowerGroup.NotificationCodes.NotifyComponentDelete:
                                                    {
                                                        ReelTowerGroupObject.UpdateArticleStatus(tokens_[2], tokens_[3]);
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyJoblistStateChanged:
                                                    {
                                                        if (ReelTowerGroupObject.UpdateProvideJobState(tokens_[3], ref jobname_, ref productionstate_, ref jobstate_))
                                                        {
                                                            ReelTowerGroupObject.RemoveProvidedCarriers(jobname_);
                                                            FireProvideJobState(new string[] { jobname_, productionstate_, jobstate_ });
                                                        }
                                                    }
                                                    break;
                                                case ReelTowerGroup.NotificationCodes.NotifyTowerHumidity:
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierMSLreached:
                                                case ReelTowerGroup.NotificationCodes.NotifyCarrierExpired:
                                                    break;
                                            }
                                        }

                                        FireReelTowerGroupNotification(code_, tokens_);
                                        // Logger.Trace($"{code_}:{message_}");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
                            }
                        }
                        break;
                }
            }
        }

        protected void ProgramStart()
        {
            if (!ReelTowerGroupObject.IsInitialized && ReelTowerGroupObject.HasReservedJob())
            {
                if (FormMessageExt.ShowQuestion(string.Format(Properties.Resources.String_FormMain_Question_ImportJob, Environment.NewLine)) == DialogResult.No)
                    ReelTowerGroupObject.IgnorePastReservedJob(true);
            }

            (App.MainForm as FormMain).buttonAutoRun.PerformClick();
        }

        protected void ProgramStop()
        {
            FormMessageExt.ShowInformation(Properties.Resources.String_Notification_CheckReelStorageProgramStatus, Buttons.Ok);
        }

        protected void OnAllModulesCombined(object sender, Pair<bool, bool> state)
        {
            if ((App.MainForm as FormMain).InvokeRequired)
            {
                (App.MainForm as FormMain).BeginInvoke(new Action(() =>
                {
                    if (state.first)
                        ProgramStart();
                    else
                        ProgramStop();
                }));
            }
            else
            {
                if (state.first)
                    ProgramStart();
                else
                    ProgramStop();
            }
        }
        #endregion

        #region Update reel tower state
        protected ReelTowerState GetReelTowerState(string towername, ref string result, ref string code_, ref string message_, string defaultvalue= null)
        {
            ReelTowerState state_ = ReelTowerGroupObject.GetTowerStateByName(towername);

            if (state_ != null)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: TowerName={towername},Online={state_.OnlineState},HasAlarm={state_.HasAlarm},State={state_.State},StatusCode={state_.StatusCode},StatusText={state_.StatusText}");

                if (state_.OnlineState && ReelTowerGroupObject.Towers[state_.Index].Usage.Equals("true"))
                {
                    if (state_.HasAlarm)
                        result += "ERROR";
                    else
                    {
                        switch (state_.State)
                        {
                            case MaterialStorageState.StorageOperationStates.Unknown:
                                result += "UNKNOWN";
                                break;
                            case MaterialStorageState.StorageOperationStates.Idle:
                                {
                                    if (string.IsNullOrEmpty(defaultvalue))
                                    {
                                        if (state_.StatusText.ToLower() == "ready" && state_.StatusCode == 26)
                                        {
                                            result += "IDLE";
                                        }
                                        else
                                        {
                                            if (state_.StatusText.Contains("Remove"))
                                                result += "UNLOAD";
                                            else if (state_.StatusText.Contains("Moving") || state_.StatusText.Contains("Detecting"))
                                                result += "LOAD";
                                            else
                                                result += "UNKNOWN"; // Check
                                        }
                                    }
                                    else
                                        result += $"{defaultvalue}";

                                    code_ = "0";
                                }
                                break;
                            case MaterialStorageState.StorageOperationStates.Run:
                                result += "RUN";
                                break;
                            case MaterialStorageState.StorageOperationStates.Down:
                                result += "DOWN";
                                break;
                            case MaterialStorageState.StorageOperationStates.Error:
                                result += "ERROR";
                                break;
                            case MaterialStorageState.StorageOperationStates.RequestedToLoad:
                            case MaterialStorageState.StorageOperationStates.PrepareToLoad:
                            case MaterialStorageState.StorageOperationStates.Load:
                                result += "LOAD";
                                break;
                            case MaterialStorageState.StorageOperationStates.RequestedToUnload:
                            case MaterialStorageState.StorageOperationStates.PrepareToUnload:
                            case MaterialStorageState.StorageOperationStates.Unload:
                                result += "UNLOAD";
                                break;
                            case MaterialStorageState.StorageOperationStates.Wait:
                                result += "WAIT";
                                break;
                            case MaterialStorageState.StorageOperationStates.Full:
                                result += "FULL";
                                break;
                            case MaterialStorageState.StorageOperationStates.Abort:
                                result += "ABORT";
                                break;
                        }
                    }
                }
                else
                    result += "DOWN";
            }
            else
                result += "UNKNOWN";

            return state_;
        }
        #endregion

        #region Public methods
        #region Parameter import methods
        public void Create()
        {
            LoadParameters();
            LoadAlarmList();
            (this.threadReelTowerNotification = new Thread(ProcessReelTowerNotification))?.Start();

            if (Config.ReelHandlerUsage)
                this.ReelHandlerObject.Create(Config.ReelHandlerEndPoint);
        }

        public virtual void LoadParameters()
        {
            ReelTowerGroupObject.ManualOperation      = !Config.ReelHandlerUsage;
            ReelHandlerObject.TimeoutOfTowerResponse  = Config.TimeoutOfReelHandlerResponse;
            ReelHandlerObject.IntervalOfPing          = Config.IntervalOfReelHandlerPing;
            ReelHandlerObject.LimitOfRetry            = Config.LimitOfRetry;
        }

        public virtual async void LoadAlarmList(FileExtensions ext = FileExtensions.Xml)
        {
            try
            {
                string filePath_ = $"{App.Path}Config\\Alarmlist";
                alarmList.Clear();

                switch (ext)
                {
                    case FileExtensions.Xml:
                        {
                            if (File.Exists(filePath_ += ".xml"))
                            {
                                int aid = 0;
                                string name = string.Empty;
                                string desc = string.Empty;

                                XmlDocument xml = new XmlDocument();
                                xml.Load(filePath_);

                                foreach (XmlNode element_ in xml.DocumentElement.ChildNodes)
                                {
                                    switch (element_.Name.ToLower())
                                    {
                                        case "alarm":
                                            {
                                                aid = int.Parse(element_.Attributes["id"].Value);
                                                name = element_.Attributes["name"].Value;

                                                foreach (XmlNode child_ in element_.ChildNodes)
                                                {
                                                    if (child_.Name.ToLower() == "description" && child_.Attributes["culture"].Value == App.CultureInfoCode)
                                                    {
                                                        desc = child_.InnerText;
                                                        break;
                                                    }
                                                }

                                                if (!alarmList.ContainsKey((ErrorCode)aid))
                                                    alarmList.Add((ErrorCode)aid, new Pair<string, string>(name, desc));
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                        break;
                    case FileExtensions.csv:
                        {
                            if (File.Exists(filePath_ += ".csv"))
                            {
                                using (FileStream fs = new FileStream(filePath_, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                                {
                                    using (StreamReader sw = new StreamReader(fs, Encoding.UTF8))
                                    {
                                        string contents_ = await sw.ReadToEndAsync();
                                        string[] tokens_ = contents_.Split('\n');

                                        foreach (string token_ in tokens_)
                                        {
                                            int numeric_ = -1;
                                            string[] items_ = token_.Split(';');

                                            if (items_.Length >= 3)
                                            {
                                                if (int.TryParse(items_[0], out numeric_))
                                                {
                                                    ErrorCode code_ = (ErrorCode)Enum.Parse(typeof(ErrorCode), items_[0]);

                                                    if (!alarmList.ContainsKey(code_))
                                                        alarmList.Add(code_, new Pair<string, string>(items_[1], items_[2]));
                                                }
                                            }
                                        }

                                        sw.Close();
                                    }

                                    fs.Close();
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }
        #endregion

        #region Process control methods
        public bool Start()
        {
            if (operationState == OperationStates.Run)
                return true;

            Initialize();

            if (initialized)
            {
                if (processThreads.Count > 0)
                {
                    FormMessageExt.ShowWarning("System is not ready to run state.");
                    return false;
                }

                operationState = OperationStates.Run;
                ReelTowerGroupObject.process_state = true;
                FireOperationStateChanged();
                ClearStates();

                if (StartTasks())
                {
                    return true;
                }
                else
                {
                    Stop();
                    return false;
                }
            }
            else
                return false;
        }

        public bool Stop()
        {
            StopTasks();

            if (operationState == OperationStates.Stop)
                return true;

            if (cycleStop)
                TryCycleStop(!cycleStop);

            operationState = OperationStates.Stop;
            ReelTowerGroupObject.process_state = false;
            FireOperationStateChanged();

            if (IsRequiredReset)
                Reset();

            return true;
        }

        public void TryCycleStop(bool state = true)
        {
            if (cycleStop != state)
            {
                cycleStop = state;
                FireCycleStopStateChanged();
            }
        }

        public void Pause(ErrorCode code)
        {
            try
            {
                if (operationState == OperationStates.Alarm)
                    return;

                string message_ = $"ALARM={code}";
                string unloadinfo_ = string.Empty;
                string alarmlog_ = string.Empty;

                switch (code)
                {
                    case ErrorCode.RobotVisionFailure:
                        {   // Important check.
                            // Actually, barcode contexts should be empty.
                            // Barcode contexts are loaded after alignment value gathering.
                            // You need check actual message sent.
                            visionAlignError++;
                        }
                        break;
                    case ErrorCode.RobotVisionDecodeBarcodeFailure:
                        {
                            visionDecodeError++;
                        }
                        break;
                    case ErrorCode.FailedToPickupReelFromCart:
                        {
                            loadErrorCountValue++;
                        }
                        break;
                    case ErrorCode.FailedToPickupReelFromReturn:
                        {
                            returnErrorCountValue++;
                        }
                        break;
                    case ErrorCode.FailedToPickUnloadReel:
                        {
                            unloadinfo_ = $"TOWER={currentUnloadReelTowerId}";

                            if (currentUnloadReelState.PendingData != null)
                                unloadinfo_ += $"\nUID={currentUnloadReelState.PendingData.Name}";

                            unloadErrorCountValue++;
                        }
                        break;
                }

                operationState = OperationStates.Alarm;
                FireOperationStateChanged();

                if (alarmList.ContainsKey(code))
                {
                    message_ = string.Format("ALARM={0}({1:0000})\n", alarmList[code].first, Convert.ToInt32(code));
                    message_ += string.Format("DESCRIPTION={0}", alarmList[code].second);

                    if (!string.IsNullOrEmpty(unloadinfo_))
                        message_ += unloadinfo_;

                    Logger.Alarm(alarmlog_ = $"Alarm={Convert.ToInt32(code):0000}({alarmList[code].first}),Desc={alarmList[code].second}");
                }

                if (Config.OneshotRecovery)
                {
                    if (code == ErrorCode.AMMConnectFailure)
                        FormMessageExt.ShowAlert(message_);
                    else
                        FormMessageExt.ShowAlertWithRecovery(message_);
                }
                else
                    FormMessageExt.ShowAlert(message_);
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        public bool Reset()
        {
            if (operationState == OperationStates.Run)
                return false;

            try
            {
                ResetState();
                RecheckInterlockState();

                if (operationState != OperationStates.Stop)
                    Stop();

                if (cycleStop)
                {
                    FormMessageExt.ShowWarning(Properties.Resources.String_Warning_Reset_Cycle_Stop);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
                CheckOperationPanelState();
            }

            return false;
        }

        public bool Resume()
        {
            if (!initialized || operationState != OperationStates.Stop || IsRequiredReset)
                return false;

            operationState = OperationStates.Run;
            FireOperationStateChanged();
            return true;
        }

        public void FinishCycleStop()
        {
            cycleStop = false;
            Stop();
        }

        public void PauseByCycleStop()
        {
            try
            {
                if (operationState == OperationStates.Alarm)
                    return;

                operationState = OperationStates.Alarm;
                new Thread(FireFinishedCycleStop).Start();
            }
            catch (Exception ex)
            {
                Logger.Trace($"{ClassName}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        public void ClearStates(bool all = true)
        {
            if (all)
                ReelHandlerObject.ClearAllWaitMessages();

            lock (unloadConfirmedMaterials)
                unloadConfirmedMaterials.Clear();
        }

        public void ResetSequenceSteps(bool initialize = false)
        {   // Reset process step to ready.
            // Recover reel tower sequence step
            reelTowerGroupStep = ReelTowerGroupSteps.Ready;
            // Recover robot sequence step
            robotSubStep = SubSequenceSteps.Prepare;
        }
        #endregion

        #region Initialize methods
        public bool Initialize()
        {
            if (App.OperationState == OperationStates.PowerOn || App.OperationState == OperationStates.Stop)
            {
                if (IsRequiredReset)
                    Reset();

                ClearStates();
                operationState = OperationStates.Initialize;
                ResetSequenceSteps(true);
                FireOperationStateChanged();

                if ((new FormInitialization(InitializeMode.All).ShowDialog()) == DialogResult.OK)
                    return true;
            }
            else if (operationState == OperationStates.Initialize)
            {
                Stop();
            }

            return false;
        }

        public void Init(InitializeMode mode)
        {
            StopInit();

            initializeMode                  = mode;
            initialized                     = false;
            reelTowerGrouptInitializeStep   = InitializeSteps.CheckTowerInformation;
            initializeThreads.Add("SystemInitialize", new Thread(RunInitialize));
            initializeThreads["SystemInitialize"].Start();            
        }

        public void AutomaticTeachRobot(AutomaticTeachMode mode)
        {
        }

        public void StopInit()
        {
            if (initializeThreads.ContainsKey("SystemInitialize"))
            {
                stopInitialize = true;
                initializeThreads["SystemInitialize"].Join();
                initializeThreads["SystemInitialize"] = null;
                initializeThreads.Remove("SystemInitialize");
            }

            stopInitialize = false;
        }
        #endregion

        #region Event call methods
        public void FireOperationStateChanged()
        {
            ReelTowerGroupObject.AutoRun = (initialized && operationState == OperationStates.Run);
            OperationStateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void FireOperationModeChanged()
        {
            OperationModeChanged?.Invoke(this, EventArgs.Empty);
        }

        public void FireFinishedCycleStop()
        {
            FinishedCycleStop?.Invoke(this, EventArgs.Empty);
        }

        public void FireCycleStopStateChanged()
        {
            CycleStopOrderStateChanged?.Invoke(this, EventArgs.Empty);
        }

        public void FireCartPresentStateChanged(CartPresentStates state)
        {
            CartPresentStateChanged?.Invoke(this, cartPresnetState = state);
        }

        public void FireChagedReelSizeOfCart(ReelDiameters reeltype)
        {
            if (reeltype > ReelDiameters.Unknown)
                ChangedReelSizeOfCart?.Invoke(this, Convert.ToInt32(reeltype));
        }

        public void FireUpdateAlarmLog(string text = null)
        {
            ReportAlarmLog?.Invoke(this, text);
        }

        public void FireReelTowerGroupNotification(ReelTowerGroup.NotificationCodes code, string[] message)
        {
            ReportReelTowerGroupNotification?.Invoke(this, new Pair<ReelTowerGroup.NotificationCodes, string[]>(code, message));
        }

        public void FireReportProvideMaterialState(string[] tokens)
        {
            ReportProvideMaterialState?.Invoke(this, tokens);
        }

        public void FireProvideJobState(string[] tokens)
        {
            ProvideJobStateChanged?.Invoke(this, tokens);
        }
        #endregion

        #region Gui contents handling methods
        public void SetBarcodeInputData(BarcodeKeyInData src)
        {
            lock (barcodeKeyInData)
                barcodeKeyInData.CopyFrom(src);
        }
        #endregion

        #region Module event handling methods
        public virtual void ProcessReelTowerNotifications(string message)
        {
            lock (reelTowerNotifications)
                reelTowerNotifications.Enqueue(message);
        }

        public void TryReelHandlerConnect(IPEndPoint endpoint)
        {
            if (!ReelHandlerObject.IsConnected)
                ReelHandlerObject.TryClientConnecting(endpoint.Address, endpoint.Port);
        }

        public virtual void StopRobotController()
        {
        }
        #endregion

        #region Reel tower handling methods
        public virtual bool CreateCarrierInformation(string towername, string articlename, string carriername, string lotid, string supplier, string mfg, string data, int qty, ReelDiameters diameter, ReelThicknesses thickness, LoadMaterialTypes loadtype = LoadMaterialTypes.Cart)
        {
            return ReelTowerGroupObject.CreateCarrier(towername, articlename, carriername, lotid, supplier, mfg,  data, qty, diameter, thickness, loadtype, Config.RemapCreateTimeByMFG);
        }

        public virtual bool UpdateCarrierInformation(string towername, string articlename, string carriername, string lotid, string supplier, string mfg, string data, int qty, ReelDiameters diameter, ReelThicknesses thickness, LoadMaterialTypes loadtype = LoadMaterialTypes.Cart)
        {
            return ReelTowerGroupObject.UpdateCarrier(towername, articlename, carriername, lotid, supplier, mfg, data, qty, diameter, thickness, loadtype, Config.RemapCreateTimeByMFG);
        }

        public virtual bool RequestToLoad(string towername, string articlename, string carriername, string lotid, string supplier, string mfg, int size, string data, string comment, int qty, ReelDiameters diameter, ReelThicknesses thickness, LoadMaterialTypes loadtype = LoadMaterialTypes.Cart)
        {
            bool result_ = false;

            if (result_ = ReelTowerGroupObject.AddLoadReel(towername, articlename, carriername, lotid, supplier, mfg, size, data, comment, qty, diameter, thickness, loadtype))
            {
                storedTowerId = towername;
            }

            if (Config.AMMUsage)
            {
                if (!AMMBarcode_.ContainsKey(towername))
                    AMMBarcode_.Add(towername, new MaterialData());

                AMMBarcode_[towername] = AddAMMBarcode(towername, articlename, carriername, lotid, supplier, mfg, size, data, comment, qty, diameter, thickness, loadtype);
                string AMMresult_ = GetReelqty(AMMBarcode_[towername]);
                
                if (AMMresult_.ToUpper() == "NG")
                {
                    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                    CommunicationWaitOfAMM = CommunicationStates.None;
                    return false;
                }
                //else
                //{
                //    AMMBarcode_[towername].Quantity = Convert.ToInt32(AMMresult_);
                //}

            }

            return result_;
        }

        public MaterialData AddAMMBarcode(string towername, string articlename, string carriername, string lotid, string supplier, string mfg, int size, string data, string comment, int qty, ReelDiameters diameter, ReelThicknesses thickness, LoadMaterialTypes loadtype = LoadMaterialTypes.Cart)
        {
            MaterialData result_ = new MaterialData();

            result_.TowerId = towername;
            result_.Category = articlename;
            result_.Name = carriername;
            result_.LotId = lotid;
            result_.Supplier = supplier;
            result_.ManufacturedDatetime = mfg;
            result_.Size = size;
            result_.Comment = comment;
            result_.Quantity = qty;
            result_.ReelType = diameter;
            result_.ReelThickness = thickness;
            result_.LoadType = loadtype;

            return result_;
        }

        public virtual void LoadReel(string towerid, string towername= null, MaterialData barcode = null)
        {
            if (barcode != null)
            {
                new TaskFactory().StartNew(new Action<object>((x_) =>
                {
                    if (x_ != null)
                    {
                        ThreeField<string, string, string> data_ = new ThreeField<string, string, string>(string.Empty, string.Empty, string.Empty);
                        MaterialEventArgs obj_ = x_ as MaterialEventArgs;
                        ReelTowerGroupObject.FireMaterialEventRaised(obj_);
                        if (ReelTowerGroupObject.LoadReel(obj_.Port, obj_.Equipment, ref data_))
                        {
                            storedTowerId = string.Empty;
                            ReelHandlerObject.ActionState = RobotActionStates.LoadCompleted;
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(data_.second) && !string.IsNullOrEmpty(data_.third))
                                (App.MainSequence as ReelTowerGroupSequence).RemoveCarrier(data_.third);

                            // Abnormal case !
                            (App.MainSequence as ReelTowerGroupSequence).SetTowerState(towername, MaterialStorageState.StorageOperationStates.Abort);
                            RequestRejectLoadAbortedMaterial(towerid, towername, data_.third);
                            IsPossibleToRejectReel = true;
                            if (preparetowerinfo.ContainsKey(towername))
                                preparetowerinfo[towername].preparesuccess = true;
                        }
                    }
                }), new MaterialEventArgs(towername,
                    towerid,
                    barcode.Category,
                    barcode.Name,
                    MaterialEventArgs.MaterialActions.PreapareLoad,
                    barcode));
            }
            else
            {
                new TaskFactory().StartNew(new Action<object>((x_) =>
                {
                    if (x_ != null)
                    {
                        ThreeField<string, string, string> data_ = new ThreeField<string, string, string>(string.Empty, string.Empty, string.Empty);
                        Pair<string, string> args_ = (Pair<string, string>)x_;
                        if (ReelTowerGroupObject.LoadReel(args_.first, args_.second, ref data_))
                        {
                            storedTowerId = string.Empty;
                            ReelHandlerObject.ActionState = RobotActionStates.LoadCompleted;
                        }
                    }
                }), new Pair<string, string>(towerid, towername));
            }
        }

        public virtual DataSet QueryReelsByManual(List<Pair<string, string>> items)
        {
            int countOfParse_   = 0;
            string val_         = string.Empty;
            string query_       = "SELECT Carrier.Carrier As UID, Article.Article As SID, Carrier.CreateDate As CREATE_DATE, Carrier.CreateTime As CREATE_TIME, Carrier.Depot As LOCATION, Carrier.DepotDate As LOCATION_DATE, Carrier.Stock As PARTS, Carrier.Diameter As TYPE, Carrier.Height As THICKNESS, Carrier.Manufactur As SUPPLIER, Carrier.Custom1 As LOTID, Carrier.Custom2 As MFG FROM Article LEFT JOIN Carrier ON Article.ID = Carrier.Article ";
            string wherephase_  = "WHERE";
            DataSet result_     = null;

            try
            {
                foreach (Pair<string, string> item_ in items)
                {
                    switch (item_.first)
                    {
                        case "Carrier.Depot LIKE ":
                            {
                                if (!string.IsNullOrEmpty(val_ = item_.second))
                                    wherephase_ += (countOfParse_ > 0 ? $" AND {item_.first} '%{val_}%'" : $" {item_.first} '%{val_}%'");
                                else
                                    break;
                            }
                            break;
                        case "Carrier.Article LIKE ":
                            {
                                val_ = ReelTowerGroupObject.GetArticleIdByName(item_.second, true).ToString();

                                if (!string.IsNullOrEmpty(val_))
                                    wherephase_ += (countOfParse_ > 0 ? $" AND {item_.first}='{val_}'" : $" {item_.first} '{val_}'");
                                else
                                    break;
                            }
                            break;
                        case "Carrier.Article=":
                            {
                                val_ = ReelTowerGroupObject.GetArticleIdByName(item_.second).ToString();

                                if (!string.IsNullOrEmpty(val_))
                                    wherephase_ += (countOfParse_ > 0 ? $" AND {item_.first}{val_}" : $" {item_.first}{val_}");
                                else
                                    break;
                            }
                            break;
                        default:
                            wherephase_ += (countOfParse_ > 0 ? $" AND {item_.first}{item_.second}" : $" {item_.first}{item_.second}");
                            break;
                    }

                    countOfParse_++;
                }

                wherephase_ += " And Depot Is Not Null And Depot <> 'Unknown' And Depot <> 'Unnown' And Depot Like 'Tower%'";

                if (countOfParse_ == items.Count)
                    result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        public virtual DataSet SearchReelsByArticle(string article, string supplier, int reels, bool orderbycreate = true)
        {
            string val_         = string.Empty;
            string query_       = "SELECT Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot FROM Article INNER JOIN Carrier ON Article.ID = Carrier.Article ";
            string wherephase_  = $"WHERE (((Carrier.Depot) Is Not Null And (Carrier.Depot) <> 'Unknown' And (Carrier.Depot) <> 'Unnown' AND (Article.Article) = '{article}' AND (Carrier.Manufactur) = '{supplier}')) ";
            string groupby_     = "GROUP BY Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot";
            string havingphase_ = $" ORDER BY Carrier.Stock DESC";
            DataSet result_     = null;

            try
            {
                if (orderbycreate)
                {
                    groupby_ += ", Carrier.CreateDate";
                    havingphase_ += ", Carrier.CreateDate";
                }

                result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_ + groupby_ + havingphase_);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        public virtual DataSet SearchReelsByCarrier(string article, string carrier, string supplier, int reels, bool orderbycreate = true)
        {
            string val_         = string.Empty;
            string query_       = "SELECT Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot FROM Article INNER JOIN Carrier ON Article.ID = Carrier.Article ";
            string wherephase_  = $"WHERE (((Carrier.Depot) Is Not Null And (Carrier.Depot) <> 'Unknown' And (Carrier.Depot) <> 'Unnown' AND (Article.Article) = '{article}' AND (Carrier.Carrier) = '{carrier}' AND (Carrier.Manufactur) = '{supplier}')) ";
            string groupby_     = "GROUP BY Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot";
            string havingphase_ = $" ORDER BY Carrier.Stock DESC";
            DataSet result_     = null;

            try
            {
                if (orderbycreate)
                {
                    groupby_ += ", Carrier.CreateDate";
                    havingphase_ += ", Carrier.CreateDate";
                }

                result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_ + groupby_ + havingphase_);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        public virtual DataSet SearchReelsByArticle(List<Pair<MaterialIdentifiers, string>> items, int reels)
        {
            int countOfParse_   = 0;
            string val_         = string.Empty;
            string query_       = "SELECT Article.Article, Carrier.Manufactur, Count(Carrier.Manufactur) AS Reels FROM Article INNER JOIN Carrier ON Article.ID = Carrier.Article ";
            string wherephase_  = "WHERE (((Carrier.Depot) Is Not Null And (Carrier.Depot) <> 'Unknown' And (Carrier.Depot) <> 'Unnown')";
            string groupby_     = "GROUP BY Article.Article, Carrier.Manufactur";
            string havingphase_ = " HAVING (";
            DataSet result_     = null;

            try
            {
                foreach (Pair<MaterialIdentifiers, string> item_ in items)
                {
                    switch (item_.first)
                    {
                        case MaterialIdentifiers.Article:
                            {
                                if (item_.second.Length >= 5)
                                    havingphase_ += (countOfParse_ > 0 ? $" AND ((Article.Article) = '{item_.second}')" : $"((Article.Article) = '{item_.second}')");
                                else
                                    havingphase_ += (countOfParse_ > 0 ? $" AND ((Article.Article) Like '%{item_.second}')" : $"((Article.Article) Like '%{item_.second}')");
                            }
                            break;
                    }

                    countOfParse_++;
                }

                wherephase_     += ") ";
                havingphase_    += ") ORDER BY Count(Carrier.Manufactur)";
                
                if (countOfParse_ == items.Count)
                    result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_ + groupby_ + havingphase_);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        public virtual DataSet SearchReelsByCarrier(List<Pair<MaterialIdentifiers, string>> items, int reels)
        {
            int countOfParse_   = 0;
            string val_         = string.Empty;
            string query_       = "SELECT Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot FROM Article INNER JOIN Carrier ON Article.ID = Carrier.Article ";
            string wherephase_  = "WHERE (((Carrier.Depot) Is Not Null And (Carrier.Depot) <> 'Unknown' And (Carrier.Depot) <> 'Unnown' And (Carrier.Depot) Like 'Tower %')) ";
            string groupby_     = "GROUP BY Article.Article, Carrier.Carrier, Carrier.Manufactur, Carrier.Stock, Carrier.Depot";
            string havingphase_ = " HAVING (";
            DataSet result_     = null;

            try
            {
                foreach (Pair<MaterialIdentifiers, string> item_ in items)
                {
                    switch (item_.first)
                    {
                        case MaterialIdentifiers.Carrier:
                            {
                                if (item_.second.Length >= 5)
                                    havingphase_ += (countOfParse_ > 0 ? $" AND ((Carrier.Carrier) = '{item_.second}')" : $"((Carrier.Carrier) = '{item_.second}')");
                                else
                                    havingphase_ += (countOfParse_ > 0 ? $" AND ((Carrier.Carrier) Like '%{item_.second}')" : $"((Carrier.Carrier) Like '%{item_.second}')");
                            }
                            break;
                    }

                    countOfParse_++;
                }

                havingphase_    += ") ORDER BY Carrier.Stock";

                if (countOfParse_ == items.Count)
                    result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_ + groupby_ + havingphase_);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }

            return result_;
        }

        public virtual void CleanUpDatabase()
        {
            RemoveNotExistCarriers();
            RemoveNotExistArticle();
        }

        public virtual void RemoveNotExistArticle()
        {
            int countOfParse_   = 0;
            string val_         = string.Empty;
            string query_       = "SELECT * FROM Article ";
            string wherephase_  = "WHERE ReelCount = 0";
            DataSet result_     = null;

            try
            {
                result_ = ReelTowerGroupObject.QueryArticle(query_ + wherephase_);

                if (result_ != null && result_.Tables.Count > 0 && result_.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row_ in result_.Tables[0].Rows)
                        RemoveArticle(row_["Article"].ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }

        public virtual void RemoveNotExistCarriers()
        { 
            int countOfParse_   = 0;
            string val_         = string.Empty;
            string query_       = "SELECT * FROM Carrier ";
            string wherephase_  = "WHERE Depot Is Null Or Depot = 'Unknown' Or Depot = 'Unnown' Or NOT Depot Like 'Tower %'";
            DataSet result_     = null;

            try
            {
                result_ = ReelTowerGroupObject.QueryCarrier(query_ + wherephase_);

                if (result_ != null && result_.Tables.Count > 0 && result_.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row_ in result_.Tables[0].Rows)
                        RemoveCarrier(row_["Carrier"].ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Exception={ex.Message}");
            }
        }
        #endregion

        #region Process reel handler request commands
        public virtual void ProcessReelHandlerRequest(ReelTowerCommands command, MaterialStorageMessage message)
        {
            string code_            = "-2";
            string state_           = string.Empty;            
            string message_         = string.Empty;
            string depot_           = string.Empty;
            string towerid_         = string.Empty;
            string[] towers_        = null;
            ReelTowerState obj_     = null;
            MaterialData barcode_   = null;

            if (!RunnableCondition || takeOutByManual)
                return;

            switch (command)
            {
                case ReelTowerCommands.REQUEST_LOAD_RESET:
                case ReelTowerCommands.REQUEST_UNLOAD_RESET:
                case ReelTowerCommands.REQUEST_ALL_LOAD_RESET:
                case ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET:
                case ReelTowerCommands.REQUEST_ALL_ALARM_RESET:
                    {
                        ReelHandlerObject.ActionState = RobotActionStates.Stop;
                        ReelTowerGroupObject.ResetTowerStateByName(message.TowerId);
                        storedTowerId = string.Empty;
                    }
                    break;
                case ReelTowerCommands.REQUEST_TOWER_STATE:
                    {
                        ReelHandlerObject.ActionState = RobotActionStates.Stop;

                        if (operationState == OperationStates.Run && !string.IsNullOrEmpty(message.TowerId) && !ReelTowerGroupObject.IsWaitToProvide)
                        {
                            towers_ = message.TowerId.Split(CONST_NOTIFICATION_DELIMITERS, StringSplitOptions.RemoveEmptyEntries);

                            for (int i_ = 0; i_ < towers_.Length; i_++)
                            {
                                state_ += (state_.Length > 0 ? ";" : string.Empty);
                                obj_ = GetReelTowerState(towers_[i_], ref state_, ref code_, ref message_);                                
                                code_ = "0";
                            }

                            SendMessageToReelHandler(ReelTowerCommands.REPLY_TOWER_STATE, null, message.TowerId, state_, code_, message_);
                        }
                    }
                    break;
                case ReelTowerCommands.REQUEST_REEL_LOAD_MOVE:
                    {
                        ReelHandlerObject.ActionState = RobotActionStates.Load;

                        if (operationState == OperationStates.Run && !string.IsNullOrEmpty(message.TowerId))
                        {
                            if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                                barcode_ = new MaterialData(message.Data);

                            if ((obj_ = ReelTowerGroupObject.GetTowerStateByName(message.TowerId)) != null)
                            {
                                if (obj_.OnlineState && ReelTowerGroupObject.Towers[obj_.Index].Usage.Equals("true"))
                                {
                                    switch (obj_.State)
                                    {
                                        case MaterialStorageState.StorageOperationStates.Idle:
                                            {
                                                state_ += (state_.Length > 0 ? ";LOAD" : "LOAD");
                                                code_ = (ReelTowerGroupObject.IsWaitToProvide? "-1" : "0");                                                
                                            }
                                            break;
                                    }
                                }
                            }

                            SendMessageToReelHandler(ReelTowerCommands.REPLY_REEL_LOAD_MOVE, barcode_, message.TowerId, state_, code_, message_);

                            //if (Config.AMMUsage)
                            //{                                
                            //    if (SetEqStatus("RUN", "LOAD") == "NG")
                            //    {
                            //        CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                            //        Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                            //    }
                            //}
                        }
                    }
                    break;
                case ReelTowerCommands.REQUEST_BARCODEINFO_CONFIRM:
                    {
                        if (operationState == OperationStates.Run && !string.IsNullOrEmpty(message.TowerId))
                        {
                            if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                                barcode_ = new MaterialData(message.Data);

                            if (barcode_ != null)
                            {
                                if ((obj_ = ReelTowerGroupObject.GetTowerStateByName(message.TowerId)) != null)
                                {
                                    if (obj_.OnlineState && ReelTowerGroupObject.Towers[obj_.Index].Usage.Equals("true"))
                                    {
                                        switch (obj_.State)
                                        {
                                            case MaterialStorageState.StorageOperationStates.Idle:
                                                {
                                                    state_ += (state_.Length > 0 ? ";LOAD" : "LOAD");

                                                    barcode_.ReelThickness = (ReelTowerGroupObject.SpecialMaterials.Where(p => p.Key == barcode_.Category).Any()) ?
                                                        (ReelThicknesses)Enum.Parse(typeof(ReelThicknesses), ReelTowerGroupObject.SpecialMaterials.Where(p => p.Key == barcode_.Category).First().Value) : ReelThicknesses.Unknown;

                                                    if (ReelTowerGroupObject.IsRecordExistCarrier(barcode_.Name))
                                                    {
                                                        //code_ = "-2";
                                                        code_ = "-3";
                                                    }
                                                    else
                                                    {
                                                        if (CreateCarrierInformation(
                                                            message.TowerId,
                                                            barcode_.Category,
                                                            barcode_.Name,
                                                            barcode_.LotId,
                                                            barcode_.Supplier,
                                                            barcode_.ManufacturedDatetime,
                                                            barcode_.Comment,
                                                            barcode_.Quantity,
                                                            barcode_.ReelType,
                                                            barcode_.ReelThickness,
                                                            barcode_.LoadType))
                                                            code_ = (ReelTowerGroupObject.IsWaitToProvide ? "-1" : "0");
                                                        else
                                                            message_ = "Failed to create carrier information";
                                                    }

                                                    if (code_ == "0" && RequestToLoad(message.TowerId,
                                                        barcode_.Category,
                                                        barcode_.Name,
                                                        barcode_.LotId,
                                                        barcode_.Supplier,
                                                        barcode_.ManufacturedDatetime,
                                                        barcode_.Size,
                                                        string.Empty,
                                                        barcode_.Comment,
                                                        barcode_.Quantity,
                                                        barcode_.ReelType,
                                                        barcode_.ReelThickness,
                                                        barcode_.LoadType))
                                                    {
                                                        int val_ = 0;
                                                        obj_.State = MaterialStorageState.StorageOperationStates.RequestedToLoad;
                                                        ReelHandlerObject.ActionState = RobotActionStates.Loading;
                                                    }
                                                    else if (code_ == "-3")
                                                    {
                                                        code_ = "-2";
                                                        message_ = $"DUPLICATE ERROR. article={barcode_.Category}, carrier={barcode_.Name}";
                                                    }
                                                    else
                                                    {
                                                        code_ = "-2";
                                                        message_ = $"Failed to request a reel load. article={barcode_.Category}, carrier={barcode_.Name}";
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                }
                                if (Config.AMMUsage && code_ == "0")
                                {
                                    string load_type = string.Empty;
                                    if (barcode_.LoadType.ToString().ToUpper() == "RETURN")
                                        load_type = "RETURN";
                                    else
                                        load_type = "LOAD";
                                    if (SetEqStatus("RUN", load_type, AMMBarcode_[message.TowerId].Category, AMMBarcode_[message.TowerId].Name) == "NG")
                                    {
                                        CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                                        CommunicationWaitOfAMM = CommunicationStates.None;
                                        Logger.Alarm($"AMM Alarm=SetEqStatus:NG");
                                    }
                                }
                                SendMessageToReelHandler(ReelTowerCommands.REPLY_BARCODEINFO_CONFIRM, barcode_, message.TowerId, state_, code_, message_);
                            }
                        }
                    }
                    break;
                case ReelTowerCommands.REQUEST_REEL_LOAD_ASSIGN:
                    {
                        if (!string.IsNullOrEmpty(message.TowerId))
                        {
                            if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                                barcode_ = new MaterialData(message.Data);

                            if ((obj_ = ReelTowerGroupObject.GetTowerStateByName(message.TowerId)) != null)
                            {
                                if (obj_.OnlineState && ReelTowerGroupObject.Towers[obj_.Index].Usage.Equals("true"))
                                {
                                    switch (obj_.State)
                                    {
                                        case MaterialStorageState.StorageOperationStates.Idle:
                                        case MaterialStorageState.StorageOperationStates.RequestedToLoad:
                                        case MaterialStorageState.StorageOperationStates.PrepareToLoad:
                                            {
                                                if (obj_.RequestToLoad)
                                                {
                                                    towerid_ = ReelTowerGroupObject.GetTowerIdByName(message.TowerId);

                                                    if (!string.IsNullOrEmpty(towerid_))
                                                    {   // We need some other recover way from abnormal state of reel handler robot.
                                                        LoadReel(towerid_, message.TowerId, barcode_);
                                                        code_ = "0";
                                                    }
                                                }
                                            }
                                            break;
                                    }
                                }
                            }

                            ReelHandlerObject.ActionState = RobotActionStates.Stop;
                            SendMessageToReelHandler(ReelTowerCommands.REPLY_REEL_LOAD_ASSIGN, barcode_, message.TowerId, state_, code_, message_);
                            if (Config.AMMUsage)
                            {
                                AMMBarcode_[message.TowerId].TowerId = message.TowerId;
                            }
                            towerinfo towerinfo = new towerinfo();
                            towerinfo.towerid = ReelTowerGroupObject.GetTowerIdByName(message.TowerId);
                            towerinfo.towername = message.TowerId;
                            towerinfo.carrier = barcode_.Name;
                            towerinfo.barcode = new MaterialData(message.Data);

                            if (preparetowerinfo.ContainsKey(message.TowerId))
                                preparetowerinfo.Remove(message.TowerId);

                            preparetowerinfo.Add(message.TowerId, towerinfo);
                        }
                    }
                    break;
                case ReelTowerCommands.REQUEST_CART_LOAD_FINISH:
                    if (SetEqStatus("READY") == "NG")
                    {
                        CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                        Pause(ErrorCode.AMMConnectFailure);
                        break;
                    }
                    break;
                case ReelTowerCommands.REQUEST_REEL_UNLOAD_MOVE:
                    {
                        if (operationState == OperationStates.Run && !string.IsNullOrEmpty(message.TowerId))
                        {
                            ReelHandlerObject.ActionState = RobotActionStates.Unloading;

                            if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                                barcode_ = new MaterialData(message.Data);

                            if ((obj_ = ReelTowerGroupObject.GetTowerStateByName(message.TowerId)) != null)
                            {
                                //if (obj_.OnlineState && ReelTowerGroupObject.Towers[obj_.Index].Usage.Equals("true"))
                                if (obj_.OnlineState)
                                {
                                    bool reply_ = false;
                                    bool dispatch_ = false;

                                    switch (obj_.State)
                                    {
                                        case MaterialStorageState.StorageOperationStates.Unknown:
                                        case MaterialStorageState.StorageOperationStates.Idle:
                                        case MaterialStorageState.StorageOperationStates.Run:
                                        case MaterialStorageState.StorageOperationStates.Down:
                                        case MaterialStorageState.StorageOperationStates.Error:
                                        case MaterialStorageState.StorageOperationStates.Wait:
                                        case MaterialStorageState.StorageOperationStates.Full:
                                        case MaterialStorageState.StorageOperationStates.RequestedToLoad:
                                        case MaterialStorageState.StorageOperationStates.PrepareToLoad:
                                        case MaterialStorageState.StorageOperationStates.Load:
                                        case MaterialStorageState.StorageOperationStates.Abort:
                                            {
                                                if (barcode_.Name.Contains("reject_"))
                                                {
                                                    code_ = "-2";
                                                    reply_ = true;
                                                }
                                                // else if (!ReelTowerGroupObject.IsRecordExistCarrier(barcode_.Name) && !IsTowerPendingUnload(ReelTowerGroupObject.Towers[obj_.Index].Id))
                                                // {
                                                //     code_ = "-2";
                                                //     dispatch_ = true;
                                                // }
                                            }
                                            break;
                                        case MaterialStorageState.StorageOperationStates.RequestedToUnload:
                                        case MaterialStorageState.StorageOperationStates.PrepareToUnload:
                                        case MaterialStorageState.StorageOperationStates.Unload:
                                            {   // Update unload material information
                                                // If the value is not exist, we need to put the material into reject basket.
                                                reply_ = true;

                                                if (string.IsNullOrEmpty(code_ = message.ReturnCode))
                                                    code_ = "0";
                                            }
                                            break;
                                    }

                                    if (reply_)
                                    {
                                        obj_.State = MaterialStorageState.StorageOperationStates.Unload;
                                        ReelTowerGroupObject.FireProvideMaterialStateChangedByTowerName(message.TowerId, barcode_.Name);
                                    }
                                    else if (dispatch_)
                                    {
                                        obj_.State = MaterialStorageState.StorageOperationStates.Unload;
                                        ReelTowerGroupObject.FireProvideMaterialStateChangedByTowerName(message.TowerId, barcode_.Name);
                                    }

                                    SendMessageToReelHandler(ReelTowerCommands.REPLY_REEL_UNLOAD_MOVE, barcode_, message.TowerId, state_, code_, message_);

                                    // if (dispatch_)
                                    //     SendMessageToReelHandler(ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET, null, ReelTowerGroupObject.AllTowerNameList);
                                }
                            }
                        }
                    }
                    break;
                case ReelTowerCommands.REQUEST_REEL_UNLOAD_ASSIGN:
                    {
                        ReelHandlerObject.ActionState = RobotActionStates.UnloadCompleted;

                        if (!string.IsNullOrEmpty(message.TowerId))
                        {
                            if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                                barcode_ = new MaterialData(message.Data);

                            if ((obj_ = ReelTowerGroupObject.GetTowerStateByName(message.TowerId)) != null)
                            {
                                //if (obj_.OnlineState && ReelTowerGroupObject.Towers[obj_.Index].Usage.Equals("true"))
                                if (obj_.OnlineState)
                                {
                                    switch (obj_.State)
                                    {
                                        case MaterialStorageState.StorageOperationStates.RequestedToUnload:
                                        case MaterialStorageState.StorageOperationStates.PrepareToUnload:
                                            break;
                                        case MaterialStorageState.StorageOperationStates.Unload:
                                            obj_.State = MaterialStorageState.StorageOperationStates.Idle;
                                            break;
                                    }

                                    if (barcode_ != null)
                                        RemoveWaitResponsePacket(message.TowerId, barcode_.Name);

                                    ReelHandlerObject.ActionState = RobotActionStates.Stop;
                                    SendMessageToReelHandler(ReelTowerCommands.REPLY_REEL_UNLOAD_ASSIGN, barcode_, message.TowerId, state_, code_ = "0", message_);
                                    //if (Config.AMMUsage)
                                    //{
                                    //    SetUnloadOut(pickinguid[0]);
                                    //    pickinguid.Remove(pickinguid[0]);
                                    //    pickingsid.Remove(pickingsid[0]);

                                    //    if (pickinguid.Count() == 0)
                                    //    {
                                    //        SetUnloadEnd(pickingid);
                                    //        SetEqStatus("RUN", "COMPLETE");
                                    //        CommunicationWaitOfAMM = CommunicationStates.None;
                                    //    }
                                    //}
                                }
                            }
                        }
                    }
                    break;
                case ReelTowerCommands.REPLY_UNLOAD_COMPLETE:
                    {
                        if (message.Data != null && !string.IsNullOrEmpty(message.Data.Name))
                            barcode_ = new MaterialData(message.Data);

                        if (barcode_ != null)
                        {
                            ReelHandlerObject.ActionState = RobotActionStates.Unload;
                            UpdateWaitResponsePacket(ReelTowerCommands.REQUEST_UNLOAD_COMPLETE, message.TowerId, barcode_.Name);
                        }
                    }
                    break;
                case ReelTowerCommands.REPLY_ALL_LOAD_RESET:
                case ReelTowerCommands.REPLY_ALL_ALARM_RESET:
                    break;
                case ReelTowerCommands.REPLY_ALL_UNLOAD_RESET:
                    {
                        ReelHandlerObject.ActionState = RobotActionStates.Stop;
                        UpdateWaitResponsePacket(ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET, ReelTowerGroupObject.AllTowerNameList, string.Empty);
                    }
                    break;
            }
        }
        #endregion

        #region Reel handler message methods
        public virtual void SendMessageToReelHandler(ReelTowerCommands command, object data = null, string towerid= null, string state= null, string code = "0", string message = "done")
        {
            if (Config.ReelHandlerUsage && !takeOutByManual)
            {
                new TaskFactory().StartNew(new Action<object>((x_) => {
                    if (x_ != null)
                    {
                        Coord3DField<ReelTowerCommands, object, string, string, string, string> arg_ = x_ as Coord3DField<ReelTowerCommands, object, string, string, string, string>;

                        if (ReelHandlerObject.SendMessage(arg_.first, arg_.second, arg_.third, arg_.fourth, arg_.fifth, arg_.sixth, true))
                        {
                             switch (command)
                             {
                                case ReelTowerCommands.SEND_PICKING_LIST:
                                    {
                                        ClearStates(false);
                                    }
                                    break;
                                case ReelTowerCommands.REQUEST_UNLOAD_COMPLETE:
                                    {
                                        ProvideMaterialData data_ = arg_.second as ProvideMaterialData;
                                        // ReelHandlerObject.ActionState = RobotActionStates.Unload;
                                        UpdateWaitResponsePacket(command, arg_.third, data_.Name);
                                    }
                                    break;
                                case ReelTowerCommands.REPLY_REEL_UNLOAD_MOVE:
                                    {
                                        MaterialData data_ = arg_.second as MaterialData;
                                        ReelTowerGroupObject.RemoveUnloadReelInformation(ReelTowerGroupObject.GetTowerIdByName(arg_.third), data_.Name);
                                    }
                                    break;
                                case ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET:
                                    {
                                        UpdateWaitResponsePacket(ReelTowerCommands.REQUEST_ALL_UNLOAD_RESET, ReelTowerGroupObject.AllTowerNameList, string.Empty);
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            switch (command)
                            {
                                case ReelTowerCommands.SEND_PICKING_LIST:
                                case ReelTowerCommands.REQUEST_UNLOAD_COMPLETE:
                                    {
                                        lock (lostSendPackets)
                                            lostSendPackets.Add(new MaterialStoragePacket(arg_.first, arg_.second, arg_.third, arg_.fourth, arg_.fifth, arg_.sixth, true));
                                    }
                                    break;
                            }
                        }
                    }
                }), new Coord3DField<ReelTowerCommands, object, string, string, string, string>(command, data, towerid, state, code, message));
            }
        }
        #endregion

        #region Take out mode methods
        public virtual void SetTakeOutMode(bool state)
        {
            if (takeOutByManual = state)
            {
                RemoveAllLostPackets();
                RemoveAllWaitResponsePacket();
                ReelHandlerObject.ClearAllWaitMessages();
            }
        }
        #endregion

        #region Shutdown process
        public virtual bool IsPossibleShutdown(ref MaterialStorageState.MaterialHandlingDestination orderstate)
        {
            switch (ReelTowerGroupObject.GetStorageHandlingDestination())
            {
                case MaterialStorageState.MaterialHandlingDestination.LoadToStorage:
                    {
                        orderstate = MaterialStorageState.MaterialHandlingDestination.LoadToStorage;
                        return (ReelHandlerObject.ActionState == RobotActionStates.Unknown || ReelHandlerObject.ActionState == RobotActionStates.Stop || ReelHandlerObject.ActionState == RobotActionStates.LoadCompleted || ReelHandlerObject.ActionState == RobotActionStates.UnloadCompleted) ? true : false;
                    }
                case MaterialStorageState.MaterialHandlingDestination.UnloadToOutStage:
                    {
                        orderstate = MaterialStorageState.MaterialHandlingDestination.UnloadToOutStage;
                        return ReelTowerGroupObject.CleanUpMaterials();
                    }
                default:
                    {
                        orderstate = MaterialStorageState.MaterialHandlingDestination.None;
                        return true;
                    }
            }
        }

        public virtual void FlushProvideJobs()
        {
            ReelTowerGroupObject.FlushProvideJobs();
        }
        #endregion
		
        #region Set tower state
        public void SetTowerState(string towername, MaterialStorageState.StorageOperationStates state)
        {
            ReelTowerGroupObject.SetTowerState(towername, state);
        }
        #endregion

        #region AMM Process
        #region AMMSetting
        protected string AMMSetting()
        {
            string result_ = Connect();

            if (result_.ToUpper() == "OK")
            {
                result_ = SetEq();
                if (result_.ToUpper() == "OK")
                {
                    result_ = SetEqStatus("READY");
                }
            }

            return result_;
        }
        #endregion

        public bool PickingProvideJob(string jobid, string user, List<string> uids, ref List<string> sids)
        {
            bool result_ = false;
            List<DataSet> data_ = new List<DataSet>();
            string uid = string.Empty;

            if (PickingSearchReel(ref data_, ref sids, uids, jobid))
            {
                if (data_.Count() > 0)
                {
                    PickingJobCreate(ref data_, jobid, user);
                    result_ = true;
                }
            }

            return result_;
        }

        protected bool PickingSearchReel(ref List<DataSet> data, ref List<string> sids, List<string> uids, string jobid)
        {
            int pickindex = 0;
            bool existtwr_ = false;
            List<Pair<MaterialIdentifiers, string>> items_ = new List<Pair<MaterialIdentifiers, string>>();
            string empty_ = string.Empty;
            string res_ = string.Empty;
            bool valid_ = false;
            List<string> delete_uid = new List<string>();

            foreach (string uid_ in uids)
            {
                items_.Add(new Pair<MaterialIdentifiers, string>(MaterialIdentifiers.Carrier, uid_));
                var temp_ = SearchReelsByCarrier(items_, 1);

                if (temp_.Tables[0].Rows.Count > 0)
                {
                    data.Add(SearchReelsByCarrier(items_, 1));
                    sids.Add(temp_.Tables[0].Rows[0][0].ToString());
                    items_ = new List<Pair<MaterialIdentifiers, string>>();
                    valid_ = true;
                }
                else
                {
                    SetUnloadOut(uid_, AMMWebServiceResult, "", false);

                    empty_ += $"{uid_};";
                }

                items_ = new List<Pair<MaterialIdentifiers, string>>();
            }

            if (data.Count <= 0 || empty_.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Length == uids.Count)
            {
                if (SetUnloadEnd(jobid) == "NG")
                {
                    CommunicationStatesOfAMM = CommunicationStates.Disconnected;
                    CommunicationWaitOfAMM = CommunicationStates.None;
                    Logger.Alarm($"AMM Alarm=SetUnloadEnd:NG");
                }

                ProvideJobManager.RemoveJob(jobid);
                uids.Clear();
                return false;
            }
            else if (empty_.Length > 0)
            {
                string[] garbage_ = empty_.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string item_ in garbage_)
                    uids.Remove(item_);
            }

            List<int> removerows_ = new List<int>();
            List<FourField<string, string, string, int>> alreadyassigned_ = null;
            List<ThreeField<string, string, string>> provideitems_ = new List<ThreeField<string, string, string>>();

            foreach (DataSet table_ in data)
            {
                foreach (DataRow row_ in table_.Tables[0].Rows)

                provideitems_.Add(new ThreeField<string, string, string>(
                    row_["Article"].ToString(),
                    row_["Carrier"].ToString(),
                    row_["Manufactur"].ToString()));

                alreadyassigned_ = ReelTowerGroupObject.GetProvideJobReel(provideitems_);

                if (alreadyassigned_ != null)
                {
                    for (int i_ = 0; i_ < data[pickindex].Tables[0].Rows.Count; i_++)
                    {
                        DataRow row_ = data[pickindex].Tables[0].Rows[i_];

                        if (alreadyassigned_.Where(x_ => x_.first == row_["Article"].ToString() && x_.second == row_["Carrier"].ToString() && x_.third == row_["Manufactur"].ToString()).Any())
                            removerows_.Add(i_);
                    }

                    foreach (int i_ in removerows_)
                        data[pickindex].Tables[0].Rows.RemoveAt(i_);
                }
            }

            return true;
        }

        protected void PickingJobCreate(ref List<DataSet> data, string jobid, string user)
        {
            bool result_ = false;
            int index_ = 0;
            int pickindex = 0;
            string depot_ = string.Empty;
            string jobname_ = string.Empty;
            string tempjob_ = jobid;
            List<Pair<string, string>> alreadyassigned_ = null;
            List<FiveField<string, string, string, int, string>> provideitems_ = new List<FiveField<string, string, string, int, string>>();

            foreach (DataSet table_ in data)
            {
                foreach (DataRow row_ in table_.Tables[0].Rows)
                {
                    provideitems_.Add(new FiveField<string, string, string, int, string>(
                        row_["Article"].ToString(),
                        row_["Carrier"].ToString(),
                        row_["Manufactur"].ToString(),
                        int.Parse(row_["Stock"].ToString()),
                        row_["Depot"].ToString()));
                }
                pickindex++;
            }

            alreadyassigned_ = ReelTowerGroupObject.HasProvideJobReel(provideitems_);

            if (alreadyassigned_ != null)
            {
                if (FormMessageExt.ShowQuestion(Properties.Resources.String_FormMain_Question_DuplicatedMaterialInformation) == DialogResult.No)
                    return;
                else
                {
                    foreach (Pair<string, string> item_ in alreadyassigned_)
                    {
                        FiveField<string, string, string, int, string> element_ = provideitems_.Find(x_ => x_.first == item_.first && x_.second == item_.second);

                        if (element_ != null)
                            provideitems_.Remove(element_);
                    }

                    if (provideitems_.Count > 0)
                        result_ = true;
                }
            }
            else
                result_ = true;

            if (result_)
            {
                // Outport 선정 방식?
                
                var stages_ = Config.OutStageIds.Where(x_ => x_.Value == "S010" + (ReservedOutPort + 1).ToString()).ToList();

                if (stages_ != null && stages_.Count > 0 && !string.IsNullOrEmpty(stages_.First().Value))
                {
                    List<List<ProvideMaterialData>> containers_ = new List<List<ProvideMaterialData>>();

                    if (provideitems_.Count > Config.JobSplitReelCount)
                    {
                        containers_.Add(new List<ProvideMaterialData>());

                        foreach (FiveField<string, string, string, int, string> item_ in provideitems_)
                        {
                            if (containers_[index_].Count == Config.JobSplitReelCount)
                            {
                                index_++;
                                containers_.Add(new List<ProvideMaterialData>());
                            }

                            ProvideMaterialData carrier_ = new ProvideMaterialData(new string[] { item_.first, item_.second, item_.third, item_.fourth.ToString(), item_.fifth });
                            carrier_.State = ProvideMaterialData.States.Ready;
                            containers_[index_].Add(carrier_);
                        }
                    }
                    else
                    {
                        List<ProvideMaterialData> carriers_ = new List<ProvideMaterialData>();

                        foreach (FiveField<string, string, string, int, string> item_ in provideitems_)
                        {
                            ProvideMaterialData carrier_ = new ProvideMaterialData(new string[] { item_.first, item_.second, item_.third, item_.fourth.ToString(), item_.fifth });
                            carrier_.State = ProvideMaterialData.States.Ready;
                            carriers_.Add(carrier_);
                        }

                        containers_.Add(carriers_);
                    }

                    if (containers_.Count > 0)
                    {
                        index_ = 0;
                        foreach (List<ProvideMaterialData> job_ in containers_)
                        {
                            jobname_ = tempjob_;

                            if (index_ > 0)
                                jobname_ += $"_{index_}";

                            try
                            {
                                if ((App.MainForm as FormMain).InvokeRequired)
                                {
                                    (App.MainForm as FormMain).BeginInvoke(new Action(() =>
                                    {
                                        (App.MainForm as FormMain).QueuedJobCreate(jobname_, user, stages_.First().Key, containers_[index_].Count());
                                    }));
                                }
                                else
                                {
                                    (App.MainForm as FormMain).QueuedJobCreate(jobname_, user, stages_.First().Key, containers_[index_].Count());
                                }
                            }
                            catch (Exception ex)
                            {

                            }
                            

                            if (AddProvideJob(jobname_, user, stages_.First().Key, containers_[index_]))
                            {
                                result_ = true;
                            }

                            index_++;
                        }
                    }
                }
                else
                {
                    FormMessageExt.ShowNotification(Properties.Resources.String_FormMain_Message_SelectProperOutput);
                }
            }
        }

        public DataTable MissMatchSearch(int index, string data_)
        {
            return GetMTLInfo(index, data_);
        }

        #endregion
        #endregion
        public void ReelHandlerReset()
        {            
            SendMessageToReelHandler(ReelTowerCommands.REPLY_LOAD_RESET, null, ReelTowerGroupObject.AllTowerNameList);
            SendMessageToReelHandler(ReelTowerCommands.REPLY_UNLOAD_RESET, null, ReelTowerGroupObject.AllTowerNameList);
        }

        public void AutoTeach(AutomaticTeachMode mode)
        {
            throw new NotImplementedException();
        }

        public void CalDevices(CalibrationMode mode)
        {
            throw new NotImplementedException();
        }

        public void StopAutoTech()
        {
            throw new NotImplementedException();
        }

        public void StopCalDevices()
        {
            throw new NotImplementedException();
        }
        #endregion

        //private void backgroundWorkerAMMAlive_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{
        //    while (!shutdownApp)
        //    {
        //        if (InvokeRequired)
        //        {
        //            BeginInvoke(new Action(() =>
        //            {
        //                //Send heart beat
        //                {
        //                    if (mainSequence.CommunicationStatesOfAMM != CommunicationStates.Disconnected && Config.AMMUsage)
        //                    {
        //                        mainSequence.SetEqAlive(
        //                                            ++heartbeat_ % 2
        //                                            );
        //                    }

        //                }
        //            }));
        //        }
        //        else
        //        {
        //            //Send heart beat
        //            {
        //                if (mainSequence.CommunicationStatesOfAMM != CommunicationStates.Disconnected && Config.AMMUsage)
        //                {
        //                    mainSequence.SetEqAlive(
        //                                        ++heartbeat_ % 2
        //                                        );
        //                }
        //            }
        //        }
        //        Thread.Sleep(30000);
        //    }
        //}

        //private void backgroundWorkerAMMAlive_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //{
        //    if (e.Cancelled == true)
        //    {
        //        Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Canceled");
        //    }
        //    else if (e.Error != null)
        //    {
        //        Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Error={e.Error.Message}");
        //    }
        //    else
        //    {
        //        Debug.WriteLine($"{GetType().Name}.{MethodBase.GetCurrentMethod().Name}: Done");
        //    }

        //}
    }
    public class towerinfo
    {
        public string towername = string.Empty;
        public string towerid = string.Empty;
        public string carrier = string.Empty;
        public int preparetoload_count = 0;
        public int preparetoload_retry = 0;
        public bool preparesuccess = false;
        public MaterialData barcode = new MaterialData();
    }

    public class AMMTWRSTATUS
    {
        public string reelonoff = string.Empty;
        public string towerjobstate = string.Empty;
    }
}
#endregion