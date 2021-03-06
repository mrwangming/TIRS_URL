﻿namespace TechFloor
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Log", 4, 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelRobotState = new System.Windows.Forms.Label();
            this.labelRobotStatus = new System.Windows.Forms.Label();
            this.labelTower1Status = new System.Windows.Forms.Label();
            this.buttonAutoRun = new System.Windows.Forms.Button();
            this.tableLayoutPanelTitle = new System.Windows.Forms.TableLayoutPanel();
            this.buttonTakeoutByRobot = new System.Windows.Forms.Button();
            this.labelAMMStatusValue = new System.Windows.Forms.Label();
            this.labelAMMStatus = new System.Windows.Forms.Label();
            this.labelTower4Status = new System.Windows.Forms.Label();
            this.labelTower3StatusValue = new System.Windows.Forms.Label();
            this.labelTower3Status = new System.Windows.Forms.Label();
            this.labelTower2Status = new System.Windows.Forms.Label();
            this.labelOperationState = new System.Windows.Forms.Label();
            this.labelWebServiceStatusValue = new System.Windows.Forms.Label();
            this.labelWerServiceStatus = new System.Windows.Forms.Label();
            this.labelTower1StatusValue = new System.Windows.Forms.Label();
            this.labelTower2StatusValue = new System.Windows.Forms.Label();
            this.labelTower4StatusValue = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageAMM = new System.Windows.Forms.TabPage();
            this.tabPageProvideOperation = new System.Windows.Forms.TabPage();
            this.tabControlOperation = new System.Windows.Forms.TabControl();
            this.tabPageProvideLoginOperator = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelLoginOperator = new System.Windows.Forms.TableLayoutPanel();
            this.labelLoginOperator = new System.Windows.Forms.Label();
            this.textBoxLoginOperatorValue = new System.Windows.Forms.TextBox();
            this.tabPageProvideSearchReel = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSearchReel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAssignJob = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelJobInformation = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnqueueJob = new System.Windows.Forms.Button();
            this.buttonRemoveReels = new System.Windows.Forms.Button();
            this.labelAssignJobName = new System.Windows.Forms.Label();
            this.labelAssignJobUser = new System.Windows.Forms.Label();
            this.labelAssignJobTotalReels = new System.Windows.Forms.Label();
            this.labelAssignJobOutport = new System.Windows.Forms.Label();
            this.groupBoxAssignedReels = new System.Windows.Forms.GroupBox();
            this.dataGridViewAssignedReels = new System.Windows.Forms.DataGridView();
            this.labelAssignJobNameValue = new System.Windows.Forms.Label();
            this.labelAssignJobUserValue = new System.Windows.Forms.Label();
            this.labelAssignJobTotalReelsValue = new System.Windows.Forms.Label();
            this.comboBoxAssignJobOutportValue = new System.Windows.Forms.ComboBox();
            this.groupBoxSearchOptions = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelReelInformation = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxReelId = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelReelId = new System.Windows.Forms.TableLayoutPanel();
            this.labelSearchReelIdType = new System.Windows.Forms.Label();
            this.labelSearchReelId = new System.Windows.Forms.Label();
            this.labelAssignReels = new System.Windows.Forms.Label();
            this.comboBoxSearchReelIdTypeValue = new System.Windows.Forms.ComboBox();
            this.textBoxSearchReelIdValue = new System.Windows.Forms.TextBox();
            this.numericUpDownAssignReelsValue = new System.Windows.Forms.NumericUpDown();
            this.buttonSearchReel = new System.Windows.Forms.Button();
            this.buttonAssignReel = new System.Windows.Forms.Button();
            this.checkBoxSearchReelId = new System.Windows.Forms.CheckBox();
            this.splitContainerSearchReels = new System.Windows.Forms.SplitContainer();
            this.groupBoxSearchedReels = new System.Windows.Forms.GroupBox();
            this.dataGridViewSearchedReels = new System.Windows.Forms.DataGridView();
            this.tabPageProvideJobMonitor = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMonitor = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxQueuedUnloadJobs = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelQueuedJobs = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewQueuedJobs = new System.Windows.Forms.DataGridView();
            this.buttonCleanUpMaterials = new System.Windows.Forms.Button();
            this.buttonRemoveJob = new System.Windows.Forms.Button();
            this.checkBoxTakeoutByRobot = new System.Windows.Forms.CheckBox();
            this.groupBoxUnloadingReel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelProcessingReel = new System.Windows.Forms.TableLayoutPanel();
            this.labelProcessingReelQtyValue = new System.Windows.Forms.Label();
            this.labelProcessingReelMfgValue = new System.Windows.Forms.Label();
            this.labelProcessingReelSupplierValue = new System.Windows.Forms.Label();
            this.labelProcessingReelLotIdValue = new System.Windows.Forms.Label();
            this.labelProcessingReelCarrierValue = new System.Windows.Forms.Label();
            this.labelProcessingReelArticleValue = new System.Windows.Forms.Label();
            this.labelProcessingReelDstValue = new System.Windows.Forms.Label();
            this.labelProcessingReelJobName = new System.Windows.Forms.Label();
            this.labelProcessingReelUser = new System.Windows.Forms.Label();
            this.labelProcessingReelTower = new System.Windows.Forms.Label();
            this.labelProcessingReelTowerStatus = new System.Windows.Forms.Label();
            this.labelProcessingReelSrc = new System.Windows.Forms.Label();
            this.labelProcessingReelDst = new System.Windows.Forms.Label();
            this.labelProcessingReelArticle = new System.Windows.Forms.Label();
            this.labelProcessingReelCarrier = new System.Windows.Forms.Label();
            this.labelProcessingReelLotId = new System.Windows.Forms.Label();
            this.labelProcessingReelSupplier = new System.Windows.Forms.Label();
            this.labelProcessingReelQty = new System.Windows.Forms.Label();
            this.labelProcessingReelMfg = new System.Windows.Forms.Label();
            this.labelProcessingReelJobNameValue = new System.Windows.Forms.Label();
            this.labelProcessingReelUserValue = new System.Windows.Forms.Label();
            this.labelProcessingReelTowerIdValud = new System.Windows.Forms.Label();
            this.labelProcessingReelTowerStatusValue = new System.Windows.Forms.Label();
            this.labelProcessingReelSrcValue = new System.Windows.Forms.Label();
            this.groupBoxPendedReels = new System.Windows.Forms.GroupBox();
            this.listViewPendedReels = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblURClientConnectState = new System.Windows.Forms.Label();
            this.btnClientConnect = new System.Windows.Forms.Button();
            this.tabPageStoreOperation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelStoreReel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxStoreReel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelLoadReel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearLoadReelRequest = new System.Windows.Forms.Button();
            this.buttonRequestLoadReel = new System.Windows.Forms.Button();
            this.comboBoxLoadReelTypeValue = new System.Windows.Forms.ComboBox();
            this.labelLoadReelTowerId = new System.Windows.Forms.Label();
            this.comboBoxLoadReelTowerIdValue = new System.Windows.Forms.ComboBox();
            this.textBoxLoadReelArticleValue = new System.Windows.Forms.TextBox();
            this.labelLoadReelType = new System.Windows.Forms.Label();
            this.labelLoadReelSize = new System.Windows.Forms.Label();
            this.labelLoadReelThickness = new System.Windows.Forms.Label();
            this.labelLoadReelArticle = new System.Windows.Forms.Label();
            this.labelLoadReelCarrier = new System.Windows.Forms.Label();
            this.labelLoadReelLotId = new System.Windows.Forms.Label();
            this.labelLoadReelSupplier = new System.Windows.Forms.Label();
            this.labelLoadReelMfg = new System.Windows.Forms.Label();
            this.labelLoadReelQty = new System.Windows.Forms.Label();
            this.comboBoxLoadReelThicknessValue = new System.Windows.Forms.ComboBox();
            this.textBoxLoadReelCarrierValue = new System.Windows.Forms.TextBox();
            this.comboBoxLoadReelSizeValue = new System.Windows.Forms.ComboBox();
            this.textBoxLoadReelLotIdValue = new System.Windows.Forms.TextBox();
            this.textBoxLoadReelSupplierValue = new System.Windows.Forms.TextBox();
            this.textBoxLoadReelMfgValue = new System.Windows.Forms.TextBox();
            this.numericUpDownLoadReelQtyValue = new System.Windows.Forms.NumericUpDown();
            this.labelLoadReelComment = new System.Windows.Forms.Label();
            this.textBoxLoadReelCommentValue = new System.Windows.Forms.TextBox();
            this.groupBoxQueryReels = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelQueryReels = new System.Windows.Forms.TableLayoutPanel();
            this.buttonExecuteTowerSync = new System.Windows.Forms.Button();
            this.textBoxQueryLotIDValue = new System.Windows.Forms.TextBox();
            this.buttonExecuteDBSync = new System.Windows.Forms.Button();
            this.checkBoxQueryByCustomerDB = new System.Windows.Forms.CheckBox();
            this.checkBoxQueryByTowerId = new System.Windows.Forms.CheckBox();
            this.buttonExecuteQueryReels = new System.Windows.Forms.Button();
            this.checkBoxQueryByReelSize = new System.Windows.Forms.CheckBox();
            this.comboBoxQueryReelTowerIdValue = new System.Windows.Forms.ComboBox();
            this.checkBoxQueryByLotID = new System.Windows.Forms.CheckBox();
            this.comboBoxQueryReelSizeValue = new System.Windows.Forms.ComboBox();
            this.checkBoxQueryByArticle = new System.Windows.Forms.CheckBox();
            this.checkBoxQueryByCarrier = new System.Windows.Forms.CheckBox();
            this.textBoxQueryReelArticleValue = new System.Windows.Forms.TextBox();
            this.textBoxQueryReelCarrierValue = new System.Windows.Forms.TextBox();
            this.labelQueryReelCreateDateCondition = new System.Windows.Forms.Label();
            this.checkBox6QueryBySupplier = new System.Windows.Forms.CheckBox();
            this.textBoxQueryReelSupplierValue = new System.Windows.Forms.TextBox();
            this.checkBoxQueryByDatetime = new System.Windows.Forms.CheckBox();
            this.dateTimePickerQueryReeCreateDateValue = new System.Windows.Forms.DateTimePicker();
            this.checkBoxQueryByQty = new System.Windows.Forms.CheckBox();
            this.numericUpDownQueryReelQtyValue = new System.Windows.Forms.NumericUpDown();
            this.comboBoxQueryReelQtyOptionValue = new System.Windows.Forms.ComboBox();
            this.labelQueryReelQtyCondition = new System.Windows.Forms.Label();
            this.groupBoxQueryResults = new System.Windows.Forms.GroupBox();
            this.dataGridViewQueryResults = new System.Windows.Forms.DataGridView();
            this.buttonClearQueryReels = new System.Windows.Forms.Button();
            this.comboBoxQueryDatetimeOptionValue = new System.Windows.Forms.ComboBox();
            this.buttonMissmathSearch = new System.Windows.Forms.Button();
            this.radioButtonSearchAll = new System.Windows.Forms.RadioButton();
            this.radioButtonSerachMissmatch = new System.Windows.Forms.RadioButton();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelAccountManager = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxAccountManager = new System.Windows.Forms.GroupBox();
            this.buttonAccountManagerLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanelAccountManagerLogin = new System.Windows.Forms.TableLayoutPanel();
            this.labelAccountManagerId = new System.Windows.Forms.Label();
            this.labelAccountManagerPassword = new System.Windows.Forms.Label();
            this.textBoxAccountManagerIdValue = new System.Windows.Forms.TextBox();
            this.textBoxAccountManagerPasswordValue = new System.Windows.Forms.TextBox();
            this.groupBoxNewAccount = new System.Windows.Forms.GroupBox();
            this.buttonQueryUser = new System.Windows.Forms.Button();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.tableLayoutPanelAccount = new System.Windows.Forms.TableLayoutPanel();
            this.labelUserGroup = new System.Windows.Forms.Label();
            this.comboBoxAccountGroupIdValue = new System.Windows.Forms.ComboBox();
            this.labelUserRemark = new System.Windows.Forms.Label();
            this.textBoxUserFullnameValue = new System.Windows.Forms.TextBox();
            this.labelUserFullname = new System.Windows.Forms.Label();
            this.textBoxUserPasswordValue = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBoxUserIdValue = new System.Windows.Forms.TextBox();
            this.textBoxUserRemarkValue = new System.Windows.Forms.TextBox();
            this.tabPageReelTowerManager = new System.Windows.Forms.TabPage();
            this.tabPageReelTowerNotifier = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelNotificationListener = new System.Windows.Forms.TableLayoutPanel();
            this.listViewReelTowerGroupNotifications = new System.Windows.Forms.ListView();
            this.labelElapsed = new System.Windows.Forms.Label();
            this.labelElapsedValue = new System.Windows.Forms.Label();
            this.labelApplicationVersion = new System.Windows.Forms.Label();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.buttonSaveTower = new System.Windows.Forms.Button();
            this.buttonSaveMaterialInformation = new System.Windows.Forms.Button();
            this.groupBoxTower = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTower = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewTower = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBoxMaterialInformation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMaterialInformation = new System.Windows.Forms.TableLayoutPanel();
            this.labelMaterialName = new System.Windows.Forms.Label();
            this.dataGridViewMaterialInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnArticleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxMaterialNameValue = new System.Windows.Forms.TextBox();
            this.labelMaterialType = new System.Windows.Forms.Label();
            this.comboBoxMaterialTypeValue = new System.Windows.Forms.ComboBox();
            this.buttonDeleteMaterialInformation = new System.Windows.Forms.Button();
            this.buttonFindMaterialInformation = new System.Windows.Forms.Button();
            this.buttonAddMaterialInformation = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelProperties = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxAMMWebserviceUsageValue = new System.Windows.Forms.ComboBox();
            this.checkBoxAMMWebserviceUsage = new System.Windows.Forms.CheckBox();
            this.comboBoxRejectAutoUsageValue = new System.Windows.Forms.ComboBox();
            this.checkBoxRejectAutoUsage = new System.Windows.Forms.CheckBox();
            this.comboBoxAMMUsageValue = new System.Windows.Forms.ComboBox();
            this.checkBoxAMMUsage = new System.Windows.Forms.CheckBox();
            this.comboBoxAssignedRejectPortValue = new System.Windows.Forms.ComboBox();
            this.checkBoxAssignedRejectPort = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeoutOfReject = new System.Windows.Forms.CheckBox();
            this.checkBoxJobSplitReelCount = new System.Windows.Forms.CheckBox();
            this.checkBoxReelHandlerUsage = new System.Windows.Forms.CheckBox();
            this.checkBoxMaterialValidation = new System.Windows.Forms.CheckBox();
            this.checkBoxMaterialArriveReport = new System.Windows.Forms.CheckBox();
            this.checkBoxMaterialRemoveReport = new System.Windows.Forms.CheckBox();
            this.comboBoxMaterialValidationValue = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterialArriveReportValue = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterialRemoveReportValue = new System.Windows.Forms.ComboBox();
            this.comboBoxReelHandlerUsageValue = new System.Windows.Forms.ComboBox();
            this.numericUpDownJobSplitReelCountValue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTimeoutOfRejectValue = new System.Windows.Forms.NumericUpDown();
            this.checkBoxProvideMode = new System.Windows.Forms.CheckBox();
            this.checkBoxRemapCreateTimeByMFG = new System.Windows.Forms.CheckBox();
            this.comboBoxProvideModeValue = new System.Windows.Forms.ComboBox();
            this.comboBoxRemapCreateTimeByMFGValue = new System.Windows.Forms.ComboBox();
            this.buttonSaveCombineModules = new System.Windows.Forms.Button();
            this.buttonSaveDevices = new System.Windows.Forms.Button();
            this.groupBoxCombineModules = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCombineModules = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCombineModules = new System.Windows.Forms.DataGridView();
            this.ColumnOfCombineModuleIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfCombineModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfCombineModulePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfCombineModuleCaption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDevices = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDevices = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.ColumnOfDeviceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDeviceHid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnOfDeviceHardwareId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDeviceSerialSettings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDeviceEthernetSettings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveDatabase = new System.Windows.Forms.Button();
            this.buttonSaveGuiSettings = new System.Windows.Forms.Button();
            this.buttonSaveModel = new System.Windows.Forms.Button();
            this.groupBoxModel = new System.Windows.Forms.GroupBox();
            this.groupBoxMaterialStorage = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelModelVisionProperties = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDelayLoadStartValue = new System.Windows.Forms.TextBox();
            this.textBoxUnloadRejectMaterialValue = new System.Windows.Forms.TextBox();
            this.textBoxNotifyRejectFullValue = new System.Windows.Forms.TextBox();
            this.checkBoxUnloadRejectMaterial = new System.Windows.Forms.CheckBox();
            this.checkBoxNotifyRejectFull = new System.Windows.Forms.CheckBox();
            this.checkBoxDelayLoadStart = new System.Windows.Forms.CheckBox();
            this.groupBoxTimeoutProperties = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelTimeout = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxReelTowerCommunicationTimeoutValue = new System.Windows.Forms.TextBox();
            this.textBoxReelHandlerCommunicationTimeoutValue = new System.Windows.Forms.TextBox();
            this.textBoxReelHandlerActionTimeoutValue = new System.Windows.Forms.TextBox();
            this.checkBoxReelTowerCommunicationTimeout = new System.Windows.Forms.CheckBox();
            this.checkBoxReelHandlerCommunicationTimeout = new System.Windows.Forms.CheckBox();
            this.checkBoxReelHandlerActionTimeout = new System.Windows.Forms.CheckBox();
            this.buttonSaveNetworks = new System.Windows.Forms.Button();
            this.groupBoxNetworks = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelNetwork = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewReelTowerNetworks = new System.Windows.Forms.DataGridView();
            this.ColumnOfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxGuiSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDisplayLanguage = new System.Windows.Forms.TableLayoutPanel();
            this.labelDisplayLanguage = new System.Windows.Forms.Label();
            this.comboBoxDisplayLanguage = new System.Windows.Forms.ComboBox();
            this.groupBoxDatabases = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDatabase = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.ColumnOfDbIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDbServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfDbFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOfUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.tabControlLogPage = new System.Windows.Forms.TabControl();
            this.tabPageReelTowerLog = new System.Windows.Forms.TabPage();
            this.listBoxReelTowerComm = new System.Windows.Forms.ListBox();
            this.tabPageRobotLog = new System.Windows.Forms.TabPage();
            this.listBoxReelHandlerComm = new System.Windows.Forms.ListBox();
            this.tabPageProvideJobLog = new System.Windows.Forms.TabPage();
            this.listBoxProvideJobLog = new System.Windows.Forms.ListBox();
            this.tabPageAlarmHistory = new System.Windows.Forms.TabPage();
            this.treeViewLog = new System.Windows.Forms.TreeView();
            this.imageListFileSystem = new System.Windows.Forms.ImageList(this.components);
            this.listBoxAlarmHistory = new System.Windows.Forms.ListBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.tableLayoutPanelMainFrame = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelProvidePage = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonLoginOperator = new System.Windows.Forms.RadioButton();
            this.radioButtonSearchReel = new System.Windows.Forms.RadioButton();
            this.radioButtonJobMonitor = new System.Windows.Forms.RadioButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerAMMAlive = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanelTitle.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageProvideOperation.SuspendLayout();
            this.tabControlOperation.SuspendLayout();
            this.tabPageProvideLoginOperator.SuspendLayout();
            this.tableLayoutPanelLoginOperator.SuspendLayout();
            this.tabPageProvideSearchReel.SuspendLayout();
            this.tableLayoutPanelSearchReel.SuspendLayout();
            this.groupBoxAssignJob.SuspendLayout();
            this.tableLayoutPanelJobInformation.SuspendLayout();
            this.groupBoxAssignedReels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedReels)).BeginInit();
            this.groupBoxSearchOptions.SuspendLayout();
            this.tableLayoutPanelReelInformation.SuspendLayout();
            this.groupBoxReelId.SuspendLayout();
            this.tableLayoutPanelReelId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssignReelsValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchReels)).BeginInit();
            this.splitContainerSearchReels.Panel2.SuspendLayout();
            this.splitContainerSearchReels.SuspendLayout();
            this.groupBoxSearchedReels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedReels)).BeginInit();
            this.tabPageProvideJobMonitor.SuspendLayout();
            this.tableLayoutPanelMonitor.SuspendLayout();
            this.groupBoxQueuedUnloadJobs.SuspendLayout();
            this.tableLayoutPanelQueuedJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueuedJobs)).BeginInit();
            this.groupBoxUnloadingReel.SuspendLayout();
            this.tableLayoutPanelProcessingReel.SuspendLayout();
            this.groupBoxPendedReels.SuspendLayout();
            this.tabPageStoreOperation.SuspendLayout();
            this.tableLayoutPanelStoreReel.SuspendLayout();
            this.groupBoxStoreReel.SuspendLayout();
            this.tableLayoutPanelLoadReel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadReelQtyValue)).BeginInit();
            this.groupBoxQueryReels.SuspendLayout();
            this.tableLayoutPanelQueryReels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueryReelQtyValue)).BeginInit();
            this.groupBoxQueryResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).BeginInit();
            this.tabPageAccount.SuspendLayout();
            this.tableLayoutPanelAccountManager.SuspendLayout();
            this.groupBoxAccountManager.SuspendLayout();
            this.tableLayoutPanelAccountManagerLogin.SuspendLayout();
            this.groupBoxNewAccount.SuspendLayout();
            this.tableLayoutPanelAccount.SuspendLayout();
            this.tabPageReelTowerNotifier.SuspendLayout();
            this.tableLayoutPanelNotificationListener.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.groupBoxTower.SuspendLayout();
            this.tableLayoutPanelTower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTower)).BeginInit();
            this.groupBoxMaterialInformation.SuspendLayout();
            this.tableLayoutPanelMaterialInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialInformation)).BeginInit();
            this.groupBoxConfig.SuspendLayout();
            this.tableLayoutPanelProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJobSplitReelCountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutOfRejectValue)).BeginInit();
            this.groupBoxCombineModules.SuspendLayout();
            this.tableLayoutPanelCombineModules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombineModules)).BeginInit();
            this.groupBoxDevices.SuspendLayout();
            this.tableLayoutPanelDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            this.groupBoxModel.SuspendLayout();
            this.groupBoxMaterialStorage.SuspendLayout();
            this.tableLayoutPanelModelVisionProperties.SuspendLayout();
            this.groupBoxTimeoutProperties.SuspendLayout();
            this.tableLayoutPanelTimeout.SuspendLayout();
            this.groupBoxNetworks.SuspendLayout();
            this.tableLayoutPanelNetwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReelTowerNetworks)).BeginInit();
            this.groupBoxGuiSettings.SuspendLayout();
            this.tableLayoutPanelDisplayLanguage.SuspendLayout();
            this.groupBoxDatabases.SuspendLayout();
            this.tableLayoutPanelDatabase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.tabPageLog.SuspendLayout();
            this.tabControlLogPage.SuspendLayout();
            this.tabPageReelTowerLog.SuspendLayout();
            this.tabPageRobotLog.SuspendLayout();
            this.tabPageProvideJobLog.SuspendLayout();
            this.tabPageAlarmHistory.SuspendLayout();
            this.tableLayoutPanelMainFrame.SuspendLayout();
            this.tableLayoutPanelProvidePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.LightCoral;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonExit.Location = new System.Drawing.Point(1820, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.tableLayoutPanelTitle.SetRowSpan(this.buttonExit, 2);
            this.buttonExit.Size = new System.Drawing.Size(100, 80);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.OnClickButtonExit);
            // 
            // labelRobotState
            // 
            this.labelRobotState.BackColor = System.Drawing.SystemColors.Window;
            this.labelRobotState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRobotState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelRobotState.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelRobotState.Location = new System.Drawing.Point(1457, 43);
            this.labelRobotState.Margin = new System.Windows.Forms.Padding(3);
            this.labelRobotState.Name = "labelRobotState";
            this.labelRobotState.Size = new System.Drawing.Size(160, 34);
            this.labelRobotState.TabIndex = 0;
            this.labelRobotState.Text = "IDLE";
            this.labelRobotState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRobotStatus
            // 
            this.labelRobotStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelRobotStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRobotStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRobotStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelRobotStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.labelRobotStatus.Location = new System.Drawing.Point(1457, 3);
            this.labelRobotStatus.Margin = new System.Windows.Forms.Padding(3);
            this.labelRobotStatus.Name = "labelRobotStatus";
            this.labelRobotStatus.Size = new System.Drawing.Size(160, 34);
            this.labelRobotStatus.TabIndex = 0;
            this.labelRobotStatus.Text = "ROBOT";
            this.labelRobotStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRobotStatus.DoubleClick += new System.EventHandler(this.labelRobotStatus_DoubleClick);
            // 
            // labelTower1Status
            // 
            this.labelTower1Status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTower1Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTower1Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower1Status.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTower1Status.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTower1Status.Location = new System.Drawing.Point(793, 3);
            this.labelTower1Status.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower1Status.Name = "labelTower1Status";
            this.labelTower1Status.Size = new System.Drawing.Size(160, 34);
            this.labelTower1Status.TabIndex = 0;
            this.labelTower1Status.Text = "TOWER1";
            this.labelTower1Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAutoRun
            // 
            this.buttonAutoRun.BackColor = System.Drawing.Color.Red;
            this.buttonAutoRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAutoRun.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAutoRun.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAutoRun.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonAutoRun.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAutoRun.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAutoRun.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonAutoRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAutoRun.Location = new System.Drawing.Point(1720, 0);
            this.buttonAutoRun.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAutoRun.Name = "buttonAutoRun";
            this.tableLayoutPanelTitle.SetRowSpan(this.buttonAutoRun, 2);
            this.buttonAutoRun.Size = new System.Drawing.Size(100, 80);
            this.buttonAutoRun.TabIndex = 0;
            this.buttonAutoRun.TabStop = false;
            this.buttonAutoRun.Text = "STOP";
            this.buttonAutoRun.UseVisualStyleBackColor = false;
            this.buttonAutoRun.Click += new System.EventHandler(this.OnClickButtonAutoRun);
            // 
            // tableLayoutPanelTitle
            // 
            this.tableLayoutPanelTitle.ColumnCount = 11;
            this.tableLayoutPanelMainFrame.SetColumnSpan(this.tableLayoutPanelTitle, 3);
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelTitle.Controls.Add(this.buttonTakeoutByRobot, 8, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelAMMStatusValue, 1, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.labelAMMStatus, 2, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower4Status, 6, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower3StatusValue, 5, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower3Status, 5, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.buttonAutoRun, 9, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower2Status, 4, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelOperationState, 0, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower1Status, 3, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelWebServiceStatusValue, 0, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.labelWerServiceStatus, 1, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower1StatusValue, 3, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower2StatusValue, 4, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.buttonExit, 10, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelRobotStatus, 7, 0);
            this.tableLayoutPanelTitle.Controls.Add(this.labelRobotState, 7, 1);
            this.tableLayoutPanelTitle.Controls.Add(this.labelTower4StatusValue, 6, 1);
            this.tableLayoutPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTitle.Name = "tableLayoutPanelTitle";
            this.tableLayoutPanelTitle.RowCount = 2;
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTitle.Size = new System.Drawing.Size(1920, 80);
            this.tableLayoutPanelTitle.TabIndex = 221;
            // 
            // buttonTakeoutByRobot
            // 
            this.buttonTakeoutByRobot.BackColor = System.Drawing.Color.LightGreen;
            this.buttonTakeoutByRobot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTakeoutByRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTakeoutByRobot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonTakeoutByRobot.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTakeoutByRobot.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonTakeoutByRobot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTakeoutByRobot.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonTakeoutByRobot.ForeColor = System.Drawing.Color.Green;
            this.buttonTakeoutByRobot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTakeoutByRobot.Location = new System.Drawing.Point(1620, 0);
            this.buttonTakeoutByRobot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTakeoutByRobot.Name = "buttonTakeoutByRobot";
            this.tableLayoutPanelTitle.SetRowSpan(this.buttonTakeoutByRobot, 2);
            this.buttonTakeoutByRobot.Size = new System.Drawing.Size(100, 80);
            this.buttonTakeoutByRobot.TabIndex = 4;
            this.buttonTakeoutByRobot.TabStop = false;
            this.buttonTakeoutByRobot.Text = "로봇 배출";
            this.buttonTakeoutByRobot.UseVisualStyleBackColor = false;
            this.buttonTakeoutByRobot.Click += new System.EventHandler(this.buttonTakeoutByRobot_Click);
            // 
            // labelAMMStatusValue
            // 
            this.labelAMMStatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelAMMStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAMMStatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelAMMStatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAMMStatusValue.Location = new System.Drawing.Point(627, 43);
            this.labelAMMStatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelAMMStatusValue.Name = "labelAMMStatusValue";
            this.labelAMMStatusValue.Size = new System.Drawing.Size(160, 34);
            this.labelAMMStatusValue.TabIndex = 3;
            this.labelAMMStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAMMStatus
            // 
            this.labelAMMStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelAMMStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAMMStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAMMStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAMMStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAMMStatus.Location = new System.Drawing.Point(627, 3);
            this.labelAMMStatus.Margin = new System.Windows.Forms.Padding(3);
            this.labelAMMStatus.Name = "labelAMMStatus";
            this.labelAMMStatus.Size = new System.Drawing.Size(160, 34);
            this.labelAMMStatus.TabIndex = 2;
            this.labelAMMStatus.Text = "AMM";
            this.labelAMMStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower4Status
            // 
            this.labelTower4Status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTower4Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTower4Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower4Status.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTower4Status.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTower4Status.Location = new System.Drawing.Point(1291, 3);
            this.labelTower4Status.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower4Status.Name = "labelTower4Status";
            this.labelTower4Status.Size = new System.Drawing.Size(160, 34);
            this.labelTower4Status.TabIndex = 0;
            this.labelTower4Status.Text = "TOWER4";
            this.labelTower4Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower3StatusValue
            // 
            this.labelTower3StatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelTower3StatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower3StatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTower3StatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTower3StatusValue.Location = new System.Drawing.Point(1125, 43);
            this.labelTower3StatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower3StatusValue.Name = "labelTower3StatusValue";
            this.labelTower3StatusValue.Size = new System.Drawing.Size(160, 34);
            this.labelTower3StatusValue.TabIndex = 0;
            this.labelTower3StatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower3Status
            // 
            this.labelTower3Status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTower3Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTower3Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower3Status.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTower3Status.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTower3Status.Location = new System.Drawing.Point(1125, 3);
            this.labelTower3Status.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower3Status.Name = "labelTower3Status";
            this.labelTower3Status.Size = new System.Drawing.Size(160, 34);
            this.labelTower3Status.TabIndex = 0;
            this.labelTower3Status.Text = "TOWER3";
            this.labelTower3Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower2Status
            // 
            this.labelTower2Status.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelTower2Status.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTower2Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower2Status.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTower2Status.ForeColor = System.Drawing.SystemColors.Window;
            this.labelTower2Status.Location = new System.Drawing.Point(959, 3);
            this.labelTower2Status.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower2Status.Name = "labelTower2Status";
            this.labelTower2Status.Size = new System.Drawing.Size(160, 34);
            this.labelTower2Status.TabIndex = 0;
            this.labelTower2Status.Text = "TOWER2";
            this.labelTower2Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOperationState
            // 
            this.labelOperationState.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOperationState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOperationState.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.labelOperationState.ForeColor = System.Drawing.SystemColors.Window;
            this.labelOperationState.Location = new System.Drawing.Point(3, 3);
            this.labelOperationState.Margin = new System.Windows.Forms.Padding(3);
            this.labelOperationState.Name = "labelOperationState";
            this.tableLayoutPanelTitle.SetRowSpan(this.labelOperationState, 2);
            this.labelOperationState.Size = new System.Drawing.Size(406, 74);
            this.labelOperationState.TabIndex = 0;
            this.labelOperationState.Text = "PAUSE";
            this.labelOperationState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWebServiceStatusValue
            // 
            this.labelWebServiceStatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelWebServiceStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWebServiceStatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelWebServiceStatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelWebServiceStatusValue.Location = new System.Drawing.Point(415, 43);
            this.labelWebServiceStatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelWebServiceStatusValue.Name = "labelWebServiceStatusValue";
            this.labelWebServiceStatusValue.Size = new System.Drawing.Size(206, 34);
            this.labelWebServiceStatusValue.TabIndex = 0;
            this.labelWebServiceStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWerServiceStatus
            // 
            this.labelWerServiceStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelWerServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelWerServiceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWerServiceStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelWerServiceStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.labelWerServiceStatus.Location = new System.Drawing.Point(415, 3);
            this.labelWerServiceStatus.Margin = new System.Windows.Forms.Padding(3);
            this.labelWerServiceStatus.Name = "labelWerServiceStatus";
            this.labelWerServiceStatus.Size = new System.Drawing.Size(206, 34);
            this.labelWerServiceStatus.TabIndex = 0;
            this.labelWerServiceStatus.Text = "WEB SERVICE";
            this.labelWerServiceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWerServiceStatus.DoubleClick += new System.EventHandler(this.OnDoubleClickReelTowerManager);
            // 
            // labelTower1StatusValue
            // 
            this.labelTower1StatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelTower1StatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower1StatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTower1StatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTower1StatusValue.Location = new System.Drawing.Point(793, 43);
            this.labelTower1StatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower1StatusValue.Name = "labelTower1StatusValue";
            this.labelTower1StatusValue.Size = new System.Drawing.Size(160, 34);
            this.labelTower1StatusValue.TabIndex = 0;
            this.labelTower1StatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower2StatusValue
            // 
            this.labelTower2StatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelTower2StatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower2StatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTower2StatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTower2StatusValue.Location = new System.Drawing.Point(959, 43);
            this.labelTower2StatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower2StatusValue.Name = "labelTower2StatusValue";
            this.labelTower2StatusValue.Size = new System.Drawing.Size(160, 34);
            this.labelTower2StatusValue.TabIndex = 0;
            this.labelTower2StatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTower4StatusValue
            // 
            this.labelTower4StatusValue.BackColor = System.Drawing.SystemColors.Window;
            this.labelTower4StatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTower4StatusValue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTower4StatusValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTower4StatusValue.Location = new System.Drawing.Point(1291, 43);
            this.labelTower4StatusValue.Margin = new System.Windows.Forms.Padding(3);
            this.labelTower4StatusValue.Name = "labelTower4StatusValue";
            this.labelTower4StatusValue.Size = new System.Drawing.Size(160, 34);
            this.labelTower4StatusValue.TabIndex = 1;
            this.labelTower4StatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tableLayoutPanelMainFrame.SetColumnSpan(this.tabControlMain, 3);
            this.tabControlMain.Controls.Add(this.tabPageAMM);
            this.tabControlMain.Controls.Add(this.tabPageProvideOperation);
            this.tabControlMain.Controls.Add(this.tabPageStoreOperation);
            this.tabControlMain.Controls.Add(this.tabPageAccount);
            this.tabControlMain.Controls.Add(this.tabPageReelTowerManager);
            this.tabControlMain.Controls.Add(this.tabPageReelTowerNotifier);
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlMain.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMain.ItemSize = new System.Drawing.Size(140, 40);
            this.tabControlMain.Location = new System.Drawing.Point(3, 83);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1914, 935);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlMain.TabIndex = 223;
            this.tabControlMain.TabStop = false;
            this.tabControlMain.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnTabControlDrawItem);
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedTabControlMain);
            this.tabControlMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.tabControlMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            // 
            // tabPageAMM
            // 
            this.tabPageAMM.Location = new System.Drawing.Point(4, 44);
            this.tabPageAMM.Name = "tabPageAMM";
            this.tabPageAMM.Size = new System.Drawing.Size(1906, 887);
            this.tabPageAMM.TabIndex = 7;
            this.tabPageAMM.Text = "     AMM     ";
            this.tabPageAMM.UseVisualStyleBackColor = true;
            // 
            // tabPageProvideOperation
            // 
            this.tabPageProvideOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageProvideOperation.Controls.Add(this.tabControlOperation);
            this.tabPageProvideOperation.Controls.Add(this.lblURClientConnectState);
            this.tabPageProvideOperation.Controls.Add(this.btnClientConnect);
            this.tabPageProvideOperation.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProvideOperation.Location = new System.Drawing.Point(4, 44);
            this.tabPageProvideOperation.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProvideOperation.Name = "tabPageProvideOperation";
            this.tabPageProvideOperation.Size = new System.Drawing.Size(1906, 887);
            this.tabPageProvideOperation.TabIndex = 0;
            this.tabPageProvideOperation.Text = "     PROVIDE       ";
            this.tabPageProvideOperation.UseVisualStyleBackColor = true;
            // 
            // tabControlOperation
            // 
            this.tabControlOperation.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlOperation.Controls.Add(this.tabPageProvideLoginOperator);
            this.tabControlOperation.Controls.Add(this.tabPageProvideSearchReel);
            this.tabControlOperation.Controls.Add(this.tabPageProvideJobMonitor);
            this.tabControlOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOperation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.tabControlOperation.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabControlOperation.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControlOperation.Location = new System.Drawing.Point(0, 0);
            this.tabControlOperation.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlOperation.Name = "tabControlOperation";
            this.tabControlOperation.Padding = new System.Drawing.Point(0, 0);
            this.tabControlOperation.SelectedIndex = 0;
            this.tabControlOperation.Size = new System.Drawing.Size(1904, 885);
            this.tabControlOperation.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlOperation.TabIndex = 0;
            this.tabControlOperation.TabStop = false;
            this.tabControlOperation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.tabControlOperation.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            // 
            // tabPageProvideLoginOperator
            // 
            this.tabPageProvideLoginOperator.Controls.Add(this.tableLayoutPanelLoginOperator);
            this.tabPageProvideLoginOperator.Location = new System.Drawing.Point(4, 5);
            this.tabPageProvideLoginOperator.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProvideLoginOperator.Name = "tabPageProvideLoginOperator";
            this.tabPageProvideLoginOperator.Size = new System.Drawing.Size(1896, 876);
            this.tabPageProvideLoginOperator.TabIndex = 0;
            this.tabPageProvideLoginOperator.Text = " OPERATOR ";
            // 
            // tableLayoutPanelLoginOperator
            // 
            this.tableLayoutPanelLoginOperator.ColumnCount = 5;
            this.tableLayoutPanelLoginOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLoginOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelLoginOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelLoginOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tableLayoutPanelLoginOperator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLoginOperator.Controls.Add(this.labelLoginOperator, 2, 1);
            this.tableLayoutPanelLoginOperator.Controls.Add(this.textBoxLoginOperatorValue, 2, 3);
            this.tableLayoutPanelLoginOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLoginOperator.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLoginOperator.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelLoginOperator.Name = "tableLayoutPanelLoginOperator";
            this.tableLayoutPanelLoginOperator.RowCount = 5;
            this.tableLayoutPanelLoginOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLoginOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLoginOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoginOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelLoginOperator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelLoginOperator.Size = new System.Drawing.Size(1896, 876);
            this.tableLayoutPanelLoginOperator.TabIndex = 6;
            // 
            // labelLoginOperator
            // 
            this.labelLoginOperator.AutoSize = true;
            this.labelLoginOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoginOperator.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginOperator.Location = new System.Drawing.Point(751, 396);
            this.labelLoginOperator.Name = "labelLoginOperator";
            this.labelLoginOperator.Size = new System.Drawing.Size(394, 40);
            this.labelLoginOperator.TabIndex = 1;
            this.labelLoginOperator.Text = "ENTER USER ID";
            this.labelLoginOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLoginOperatorValue
            // 
            this.textBoxLoginOperatorValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoginOperatorValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoginOperatorValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoginOperatorValue.Location = new System.Drawing.Point(751, 442);
            this.textBoxLoginOperatorValue.Name = "textBoxLoginOperatorValue";
            this.textBoxLoginOperatorValue.Size = new System.Drawing.Size(394, 29);
            this.textBoxLoginOperatorValue.TabIndex = 2;
            this.textBoxLoginOperatorValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoginOperatorValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpUnloadReelPages);
            // 
            // tabPageProvideSearchReel
            // 
            this.tabPageProvideSearchReel.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProvideSearchReel.Controls.Add(this.tableLayoutPanelSearchReel);
            this.tabPageProvideSearchReel.Location = new System.Drawing.Point(4, 5);
            this.tabPageProvideSearchReel.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProvideSearchReel.Name = "tabPageProvideSearchReel";
            this.tabPageProvideSearchReel.Size = new System.Drawing.Size(1896, 876);
            this.tabPageProvideSearchReel.TabIndex = 1;
            this.tabPageProvideSearchReel.Text = " SEARCH ";
            // 
            // tableLayoutPanelSearchReel
            // 
            this.tableLayoutPanelSearchReel.ColumnCount = 2;
            this.tableLayoutPanelSearchReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchReel.Controls.Add(this.groupBoxAssignJob, 1, 0);
            this.tableLayoutPanelSearchReel.Controls.Add(this.groupBoxSearchOptions, 0, 0);
            this.tableLayoutPanelSearchReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearchReel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSearchReel.Name = "tableLayoutPanelSearchReel";
            this.tableLayoutPanelSearchReel.RowCount = 1;
            this.tableLayoutPanelSearchReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearchReel.Size = new System.Drawing.Size(1896, 876);
            this.tableLayoutPanelSearchReel.TabIndex = 4;
            // 
            // groupBoxAssignJob
            // 
            this.groupBoxAssignJob.Controls.Add(this.tableLayoutPanelJobInformation);
            this.groupBoxAssignJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAssignJob.Location = new System.Drawing.Point(951, 3);
            this.groupBoxAssignJob.Name = "groupBoxAssignJob";
            this.groupBoxAssignJob.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxAssignJob.Size = new System.Drawing.Size(942, 870);
            this.groupBoxAssignJob.TabIndex = 0;
            this.groupBoxAssignJob.TabStop = false;
            this.groupBoxAssignJob.Text = " JOB INFORMATION ";
            // 
            // tableLayoutPanelJobInformation
            // 
            this.tableLayoutPanelJobInformation.ColumnCount = 9;
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelJobInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelJobInformation.Controls.Add(this.buttonEnqueueJob, 7, 0);
            this.tableLayoutPanelJobInformation.Controls.Add(this.buttonRemoveReels, 7, 8);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobName, 1, 0);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobUser, 1, 2);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobTotalReels, 1, 4);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobOutport, 1, 6);
            this.tableLayoutPanelJobInformation.Controls.Add(this.groupBoxAssignedReels, 0, 10);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobNameValue, 3, 0);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobUserValue, 3, 2);
            this.tableLayoutPanelJobInformation.Controls.Add(this.labelAssignJobTotalReelsValue, 3, 4);
            this.tableLayoutPanelJobInformation.Controls.Add(this.comboBoxAssignJobOutportValue, 3, 6);
            this.tableLayoutPanelJobInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelJobInformation.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelJobInformation.Name = "tableLayoutPanelJobInformation";
            this.tableLayoutPanelJobInformation.RowCount = 11;
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelJobInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelJobInformation.Size = new System.Drawing.Size(928, 834);
            this.tableLayoutPanelJobInformation.TabIndex = 0;
            // 
            // buttonEnqueueJob
            // 
            this.buttonEnqueueJob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEnqueueJob.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonEnqueueJob.Location = new System.Drawing.Point(720, 0);
            this.buttonEnqueueJob.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEnqueueJob.Name = "buttonEnqueueJob";
            this.tableLayoutPanelJobInformation.SetRowSpan(this.buttonEnqueueJob, 7);
            this.buttonEnqueueJob.Size = new System.Drawing.Size(200, 137);
            this.buttonEnqueueJob.TabIndex = 2;
            this.buttonEnqueueJob.Text = "ENQUEUE";
            this.buttonEnqueueJob.UseVisualStyleBackColor = true;
            this.buttonEnqueueJob.Click += new System.EventHandler(this.OnClickButtonEnqueueJob);
            // 
            // buttonRemoveReels
            // 
            this.buttonRemoveReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemoveReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveReels.Location = new System.Drawing.Point(720, 140);
            this.buttonRemoveReels.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveReels.Name = "buttonRemoveReels";
            this.buttonRemoveReels.Size = new System.Drawing.Size(200, 40);
            this.buttonRemoveReels.TabIndex = 0;
            this.buttonRemoveReels.TabStop = false;
            this.buttonRemoveReels.Text = "REMOVE";
            this.buttonRemoveReels.UseVisualStyleBackColor = true;
            this.buttonRemoveReels.Click += new System.EventHandler(this.OnClickButtonRemoveReels);
            // 
            // labelAssignJobName
            // 
            this.labelAssignJobName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAssignJobName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobName.Location = new System.Drawing.Point(7, 0);
            this.labelAssignJobName.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobName.Name = "labelAssignJobName";
            this.labelAssignJobName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAssignJobName.Size = new System.Drawing.Size(200, 32);
            this.labelAssignJobName.TabIndex = 0;
            this.labelAssignJobName.Text = "NAME";
            this.labelAssignJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssignJobUser
            // 
            this.labelAssignJobUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAssignJobUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobUser.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobUser.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobUser.Location = new System.Drawing.Point(7, 35);
            this.labelAssignJobUser.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobUser.Name = "labelAssignJobUser";
            this.labelAssignJobUser.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAssignJobUser.Size = new System.Drawing.Size(200, 32);
            this.labelAssignJobUser.TabIndex = 0;
            this.labelAssignJobUser.Text = "USER";
            this.labelAssignJobUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssignJobTotalReels
            // 
            this.labelAssignJobTotalReels.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAssignJobTotalReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobTotalReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobTotalReels.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobTotalReels.Location = new System.Drawing.Point(7, 70);
            this.labelAssignJobTotalReels.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobTotalReels.Name = "labelAssignJobTotalReels";
            this.labelAssignJobTotalReels.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAssignJobTotalReels.Size = new System.Drawing.Size(200, 32);
            this.labelAssignJobTotalReels.TabIndex = 0;
            this.labelAssignJobTotalReels.Text = "TOTAL REELS";
            this.labelAssignJobTotalReels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssignJobOutport
            // 
            this.labelAssignJobOutport.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAssignJobOutport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobOutport.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobOutport.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobOutport.Location = new System.Drawing.Point(7, 105);
            this.labelAssignJobOutport.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobOutport.Name = "labelAssignJobOutport";
            this.labelAssignJobOutport.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAssignJobOutport.Size = new System.Drawing.Size(200, 32);
            this.labelAssignJobOutport.TabIndex = 0;
            this.labelAssignJobOutport.Text = "OUT PORT";
            this.labelAssignJobOutport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxAssignedReels
            // 
            this.tableLayoutPanelJobInformation.SetColumnSpan(this.groupBoxAssignedReels, 9);
            this.groupBoxAssignedReels.Controls.Add(this.dataGridViewAssignedReels);
            this.groupBoxAssignedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAssignedReels.Location = new System.Drawing.Point(3, 186);
            this.groupBoxAssignedReels.Name = "groupBoxAssignedReels";
            this.groupBoxAssignedReels.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxAssignedReels.Size = new System.Drawing.Size(922, 645);
            this.groupBoxAssignedReels.TabIndex = 0;
            this.groupBoxAssignedReels.TabStop = false;
            this.groupBoxAssignedReels.Text = " ASSIGNED REELS ";
            // 
            // dataGridViewAssignedReels
            // 
            this.dataGridViewAssignedReels.AllowUserToAddRows = false;
            this.dataGridViewAssignedReels.AllowUserToDeleteRows = false;
            this.dataGridViewAssignedReels.AllowUserToResizeRows = false;
            this.dataGridViewAssignedReels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAssignedReels.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewAssignedReels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAssignedReels.Location = new System.Drawing.Point(7, 29);
            this.dataGridViewAssignedReels.Name = "dataGridViewAssignedReels";
            this.dataGridViewAssignedReels.RowHeadersVisible = false;
            this.dataGridViewAssignedReels.RowTemplate.Height = 23;
            this.dataGridViewAssignedReels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAssignedReels.ShowEditingIcon = false;
            this.dataGridViewAssignedReels.ShowRowErrors = false;
            this.dataGridViewAssignedReels.Size = new System.Drawing.Size(908, 609);
            this.dataGridViewAssignedReels.TabIndex = 0;
            this.dataGridViewAssignedReels.TabStop = false;
            // 
            // labelAssignJobNameValue
            // 
            this.labelAssignJobNameValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanelJobInformation.SetColumnSpan(this.labelAssignJobNameValue, 3);
            this.labelAssignJobNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobNameValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobNameValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobNameValue.Location = new System.Drawing.Point(210, 0);
            this.labelAssignJobNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobNameValue.Name = "labelAssignJobNameValue";
            this.labelAssignJobNameValue.Size = new System.Drawing.Size(507, 32);
            this.labelAssignJobNameValue.TabIndex = 0;
            this.labelAssignJobNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAssignJobUserValue
            // 
            this.labelAssignJobUserValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanelJobInformation.SetColumnSpan(this.labelAssignJobUserValue, 3);
            this.labelAssignJobUserValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobUserValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobUserValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobUserValue.Location = new System.Drawing.Point(210, 35);
            this.labelAssignJobUserValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobUserValue.Name = "labelAssignJobUserValue";
            this.labelAssignJobUserValue.Size = new System.Drawing.Size(507, 32);
            this.labelAssignJobUserValue.TabIndex = 0;
            this.labelAssignJobUserValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAssignJobTotalReelsValue
            // 
            this.labelAssignJobTotalReelsValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanelJobInformation.SetColumnSpan(this.labelAssignJobTotalReelsValue, 3);
            this.labelAssignJobTotalReelsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignJobTotalReelsValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignJobTotalReelsValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignJobTotalReelsValue.Location = new System.Drawing.Point(210, 70);
            this.labelAssignJobTotalReelsValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignJobTotalReelsValue.Name = "labelAssignJobTotalReelsValue";
            this.labelAssignJobTotalReelsValue.Size = new System.Drawing.Size(507, 32);
            this.labelAssignJobTotalReelsValue.TabIndex = 0;
            this.labelAssignJobTotalReelsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAssignJobOutportValue
            // 
            this.comboBoxAssignJobOutportValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelJobInformation.SetColumnSpan(this.comboBoxAssignJobOutportValue, 3);
            this.comboBoxAssignJobOutportValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAssignJobOutportValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAssignJobOutportValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignJobOutportValue.FormattingEnabled = true;
            this.comboBoxAssignJobOutportValue.Location = new System.Drawing.Point(213, 108);
            this.comboBoxAssignJobOutportValue.Name = "comboBoxAssignJobOutportValue";
            this.comboBoxAssignJobOutportValue.Size = new System.Drawing.Size(501, 30);
            this.comboBoxAssignJobOutportValue.TabIndex = 1;
            this.comboBoxAssignJobOutportValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // groupBoxSearchOptions
            // 
            this.groupBoxSearchOptions.Controls.Add(this.tableLayoutPanelReelInformation);
            this.groupBoxSearchOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchOptions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSearchOptions.Name = "groupBoxSearchOptions";
            this.groupBoxSearchOptions.Size = new System.Drawing.Size(942, 870);
            this.groupBoxSearchOptions.TabIndex = 0;
            this.groupBoxSearchOptions.TabStop = false;
            this.groupBoxSearchOptions.Text = " OPTIONS ";
            // 
            // tableLayoutPanelReelInformation
            // 
            this.tableLayoutPanelReelInformation.ColumnCount = 1;
            this.tableLayoutPanelReelInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelReelInformation.Controls.Add(this.groupBoxReelId, 0, 0);
            this.tableLayoutPanelReelInformation.Controls.Add(this.splitContainerSearchReels, 0, 2);
            this.tableLayoutPanelReelInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReelInformation.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanelReelInformation.Name = "tableLayoutPanelReelInformation";
            this.tableLayoutPanelReelInformation.RowCount = 5;
            this.tableLayoutPanelReelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanelReelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReelInformation.Size = new System.Drawing.Size(936, 842);
            this.tableLayoutPanelReelInformation.TabIndex = 0;
            // 
            // groupBoxReelId
            // 
            this.groupBoxReelId.Controls.Add(this.tableLayoutPanelReelId);
            this.groupBoxReelId.Controls.Add(this.checkBoxSearchReelId);
            this.groupBoxReelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxReelId.Location = new System.Drawing.Point(3, 3);
            this.groupBoxReelId.Name = "groupBoxReelId";
            this.groupBoxReelId.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxReelId.Size = new System.Drawing.Size(930, 184);
            this.groupBoxReelId.TabIndex = 0;
            this.groupBoxReelId.TabStop = false;
            // 
            // tableLayoutPanelReelId
            // 
            this.tableLayoutPanelReelId.ColumnCount = 7;
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelReelId.Controls.Add(this.labelSearchReelIdType, 0, 0);
            this.tableLayoutPanelReelId.Controls.Add(this.labelSearchReelId, 0, 2);
            this.tableLayoutPanelReelId.Controls.Add(this.labelAssignReels, 0, 4);
            this.tableLayoutPanelReelId.Controls.Add(this.comboBoxSearchReelIdTypeValue, 2, 0);
            this.tableLayoutPanelReelId.Controls.Add(this.textBoxSearchReelIdValue, 2, 2);
            this.tableLayoutPanelReelId.Controls.Add(this.numericUpDownAssignReelsValue, 2, 4);
            this.tableLayoutPanelReelId.Controls.Add(this.buttonSearchReel, 6, 0);
            this.tableLayoutPanelReelId.Controls.Add(this.buttonAssignReel, 6, 6);
            this.tableLayoutPanelReelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelReelId.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelReelId.Name = "tableLayoutPanelReelId";
            this.tableLayoutPanelReelId.RowCount = 7;
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelReelId.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelReelId.Size = new System.Drawing.Size(916, 148);
            this.tableLayoutPanelReelId.TabIndex = 1;
            // 
            // labelSearchReelIdType
            // 
            this.labelSearchReelIdType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSearchReelIdType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchReelIdType.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelSearchReelIdType.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSearchReelIdType.Location = new System.Drawing.Point(0, 0);
            this.labelSearchReelIdType.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchReelIdType.Name = "labelSearchReelIdType";
            this.labelSearchReelIdType.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelSearchReelIdType.Size = new System.Drawing.Size(200, 32);
            this.labelSearchReelIdType.TabIndex = 169;
            this.labelSearchReelIdType.Text = "ID TYPE";
            this.labelSearchReelIdType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSearchReelId
            // 
            this.labelSearchReelId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSearchReelId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSearchReelId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelSearchReelId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelSearchReelId.Location = new System.Drawing.Point(0, 35);
            this.labelSearchReelId.Margin = new System.Windows.Forms.Padding(0);
            this.labelSearchReelId.Name = "labelSearchReelId";
            this.labelSearchReelId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelSearchReelId.Size = new System.Drawing.Size(200, 32);
            this.labelSearchReelId.TabIndex = 170;
            this.labelSearchReelId.Text = "VALUE";
            this.labelSearchReelId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAssignReels
            // 
            this.labelAssignReels.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAssignReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAssignReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAssignReels.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAssignReels.Location = new System.Drawing.Point(0, 70);
            this.labelAssignReels.Margin = new System.Windows.Forms.Padding(0);
            this.labelAssignReels.Name = "labelAssignReels";
            this.labelAssignReels.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAssignReels.Size = new System.Drawing.Size(200, 32);
            this.labelAssignReels.TabIndex = 171;
            this.labelAssignReels.Text = "REELS";
            this.labelAssignReels.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSearchReelIdTypeValue
            // 
            this.comboBoxSearchReelIdTypeValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelReelId.SetColumnSpan(this.comboBoxSearchReelIdTypeValue, 3);
            this.comboBoxSearchReelIdTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSearchReelIdTypeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSearchReelIdTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchReelIdTypeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxSearchReelIdTypeValue.FormattingEnabled = true;
            this.comboBoxSearchReelIdTypeValue.Items.AddRange(new object[] {
            "SID",
            "UID"});
            this.comboBoxSearchReelIdTypeValue.Location = new System.Drawing.Point(203, 0);
            this.comboBoxSearchReelIdTypeValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSearchReelIdTypeValue.Name = "comboBoxSearchReelIdTypeValue";
            this.comboBoxSearchReelIdTypeValue.Size = new System.Drawing.Size(509, 30);
            this.comboBoxSearchReelIdTypeValue.TabIndex = 0;
            this.comboBoxSearchReelIdTypeValue.TabStop = false;
            this.comboBoxSearchReelIdTypeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxSearchReelIdTypeValue.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedComboBoxSearchReelIdType);
            // 
            // textBoxSearchReelIdValue
            // 
            this.textBoxSearchReelIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelReelId.SetColumnSpan(this.textBoxSearchReelIdValue, 3);
            this.textBoxSearchReelIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSearchReelIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxSearchReelIdValue.Location = new System.Drawing.Point(203, 37);
            this.textBoxSearchReelIdValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxSearchReelIdValue.Name = "textBoxSearchReelIdValue";
            this.textBoxSearchReelIdValue.Size = new System.Drawing.Size(509, 29);
            this.textBoxSearchReelIdValue.TabIndex = 1;
            this.textBoxSearchReelIdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearchReelIdValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpUnloadReelPages);
            // 
            // numericUpDownAssignReelsValue
            // 
            this.numericUpDownAssignReelsValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelReelId.SetColumnSpan(this.numericUpDownAssignReelsValue, 3);
            this.numericUpDownAssignReelsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownAssignReelsValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numericUpDownAssignReelsValue.Location = new System.Drawing.Point(203, 72);
            this.numericUpDownAssignReelsValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.numericUpDownAssignReelsValue.Name = "numericUpDownAssignReelsValue";
            this.numericUpDownAssignReelsValue.Size = new System.Drawing.Size(509, 29);
            this.numericUpDownAssignReelsValue.TabIndex = 2;
            this.numericUpDownAssignReelsValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSearchReel
            // 
            this.buttonSearchReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearchReel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSearchReel.Location = new System.Drawing.Point(715, 0);
            this.buttonSearchReel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSearchReel.Name = "buttonSearchReel";
            this.tableLayoutPanelReelId.SetRowSpan(this.buttonSearchReel, 5);
            this.buttonSearchReel.Size = new System.Drawing.Size(201, 102);
            this.buttonSearchReel.TabIndex = 3;
            this.buttonSearchReel.Text = "SEARCH";
            this.buttonSearchReel.UseVisualStyleBackColor = true;
            this.buttonSearchReel.Click += new System.EventHandler(this.OnClickButtonSearchReel);
            // 
            // buttonAssignReel
            // 
            this.buttonAssignReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAssignReel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAssignReel.Location = new System.Drawing.Point(715, 105);
            this.buttonAssignReel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAssignReel.Name = "buttonAssignReel";
            this.buttonAssignReel.Size = new System.Drawing.Size(201, 43);
            this.buttonAssignReel.TabIndex = 4;
            this.buttonAssignReel.Text = "ASSIGN";
            this.buttonAssignReel.UseVisualStyleBackColor = true;
            this.buttonAssignReel.Click += new System.EventHandler(this.OnClickButtonAssignReel);
            // 
            // checkBoxSearchReelId
            // 
            this.checkBoxSearchReelId.AutoSize = true;
            this.checkBoxSearchReelId.Checked = true;
            this.checkBoxSearchReelId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSearchReelId.Location = new System.Drawing.Point(7, -3);
            this.checkBoxSearchReelId.Name = "checkBoxSearchReelId";
            this.checkBoxSearchReelId.Size = new System.Drawing.Size(104, 26);
            this.checkBoxSearchReelId.TabIndex = 0;
            this.checkBoxSearchReelId.TabStop = false;
            this.checkBoxSearchReelId.Text = "REEL ID";
            this.checkBoxSearchReelId.UseVisualStyleBackColor = true;
            // 
            // splitContainerSearchReels
            // 
            this.splitContainerSearchReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerSearchReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.splitContainerSearchReels.Location = new System.Drawing.Point(3, 196);
            this.splitContainerSearchReels.Name = "splitContainerSearchReels";
            this.splitContainerSearchReels.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainerSearchReels.Panel1Collapsed = true;
            // 
            // splitContainerSearchReels.Panel2
            // 
            this.splitContainerSearchReels.Panel2.Controls.Add(this.groupBoxSearchedReels);
            this.tableLayoutPanelReelInformation.SetRowSpan(this.splitContainerSearchReels, 3);
            this.splitContainerSearchReels.Size = new System.Drawing.Size(930, 643);
            this.splitContainerSearchReels.SplitterDistance = 25;
            this.splitContainerSearchReels.TabIndex = 1;
            // 
            // groupBoxSearchedReels
            // 
            this.groupBoxSearchedReels.Controls.Add(this.dataGridViewSearchedReels);
            this.groupBoxSearchedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchedReels.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchedReels.Name = "groupBoxSearchedReels";
            this.groupBoxSearchedReels.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxSearchedReels.Size = new System.Drawing.Size(930, 643);
            this.groupBoxSearchedReels.TabIndex = 0;
            this.groupBoxSearchedReels.TabStop = false;
            this.groupBoxSearchedReels.Text = " RESULTS ";
            // 
            // dataGridViewSearchedReels
            // 
            this.dataGridViewSearchedReels.AllowUserToAddRows = false;
            this.dataGridViewSearchedReels.AllowUserToDeleteRows = false;
            this.dataGridViewSearchedReels.AllowUserToResizeRows = false;
            this.dataGridViewSearchedReels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchedReels.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSearchedReels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchedReels.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewSearchedReels.MultiSelect = false;
            this.dataGridViewSearchedReels.Name = "dataGridViewSearchedReels";
            this.dataGridViewSearchedReels.ReadOnly = true;
            this.dataGridViewSearchedReels.RowHeadersVisible = false;
            this.dataGridViewSearchedReels.RowTemplate.Height = 23;
            this.dataGridViewSearchedReels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchedReels.ShowCellErrors = false;
            this.dataGridViewSearchedReels.ShowCellToolTips = false;
            this.dataGridViewSearchedReels.ShowEditingIcon = false;
            this.dataGridViewSearchedReels.ShowRowErrors = false;
            this.dataGridViewSearchedReels.Size = new System.Drawing.Size(918, 609);
            this.dataGridViewSearchedReels.TabIndex = 0;
            this.dataGridViewSearchedReels.TabStop = false;
            this.dataGridViewSearchedReels.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellContentDoubleClickSearchReel);
            // 
            // tabPageProvideJobMonitor
            // 
            this.tabPageProvideJobMonitor.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageProvideJobMonitor.Controls.Add(this.tableLayoutPanelMonitor);
            this.tabPageProvideJobMonitor.Location = new System.Drawing.Point(4, 5);
            this.tabPageProvideJobMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageProvideJobMonitor.Name = "tabPageProvideJobMonitor";
            this.tabPageProvideJobMonitor.Size = new System.Drawing.Size(1896, 876);
            this.tabPageProvideJobMonitor.TabIndex = 2;
            this.tabPageProvideJobMonitor.Text = " MONITOR ";
            // 
            // tableLayoutPanelMonitor
            // 
            this.tableLayoutPanelMonitor.ColumnCount = 2;
            this.tableLayoutPanelMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMonitor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMonitor.Controls.Add(this.groupBoxQueuedUnloadJobs, 0, 0);
            this.tableLayoutPanelMonitor.Controls.Add(this.groupBoxUnloadingReel, 1, 0);
            this.tableLayoutPanelMonitor.Controls.Add(this.groupBoxPendedReels, 1, 1);
            this.tableLayoutPanelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMonitor.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMonitor.Name = "tableLayoutPanelMonitor";
            this.tableLayoutPanelMonitor.RowCount = 2;
            this.tableLayoutPanelMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanelMonitor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMonitor.Size = new System.Drawing.Size(1896, 876);
            this.tableLayoutPanelMonitor.TabIndex = 5;
            // 
            // groupBoxQueuedUnloadJobs
            // 
            this.groupBoxQueuedUnloadJobs.Controls.Add(this.tableLayoutPanelQueuedJobs);
            this.groupBoxQueuedUnloadJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQueuedUnloadJobs.Location = new System.Drawing.Point(3, 3);
            this.groupBoxQueuedUnloadJobs.Name = "groupBoxQueuedUnloadJobs";
            this.groupBoxQueuedUnloadJobs.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanelMonitor.SetRowSpan(this.groupBoxQueuedUnloadJobs, 2);
            this.groupBoxQueuedUnloadJobs.Size = new System.Drawing.Size(942, 870);
            this.groupBoxQueuedUnloadJobs.TabIndex = 0;
            this.groupBoxQueuedUnloadJobs.TabStop = false;
            this.groupBoxQueuedUnloadJobs.Text = " QUEUED JOBS ";
            // 
            // tableLayoutPanelQueuedJobs
            // 
            this.tableLayoutPanelQueuedJobs.ColumnCount = 9;
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueuedJobs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueuedJobs.Controls.Add(this.dataGridViewQueuedJobs, 0, 2);
            this.tableLayoutPanelQueuedJobs.Controls.Add(this.buttonCleanUpMaterials, 8, 0);
            this.tableLayoutPanelQueuedJobs.Controls.Add(this.buttonRemoveJob, 6, 0);
            this.tableLayoutPanelQueuedJobs.Controls.Add(this.checkBoxTakeoutByRobot, 0, 0);
            this.tableLayoutPanelQueuedJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQueuedJobs.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelQueuedJobs.Name = "tableLayoutPanelQueuedJobs";
            this.tableLayoutPanelQueuedJobs.RowCount = 3;
            this.tableLayoutPanelQueuedJobs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelQueuedJobs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueuedJobs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQueuedJobs.Size = new System.Drawing.Size(928, 834);
            this.tableLayoutPanelQueuedJobs.TabIndex = 0;
            // 
            // dataGridViewQueuedJobs
            // 
            this.dataGridViewQueuedJobs.AllowUserToAddRows = false;
            this.dataGridViewQueuedJobs.AllowUserToDeleteRows = false;
            this.dataGridViewQueuedJobs.AllowUserToResizeRows = false;
            this.dataGridViewQueuedJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQueuedJobs.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewQueuedJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanelQueuedJobs.SetColumnSpan(this.dataGridViewQueuedJobs, 9);
            this.dataGridViewQueuedJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQueuedJobs.Location = new System.Drawing.Point(0, 43);
            this.dataGridViewQueuedJobs.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewQueuedJobs.MultiSelect = false;
            this.dataGridViewQueuedJobs.Name = "dataGridViewQueuedJobs";
            this.dataGridViewQueuedJobs.RowHeadersVisible = false;
            this.dataGridViewQueuedJobs.RowTemplate.Height = 23;
            this.dataGridViewQueuedJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewQueuedJobs.Size = new System.Drawing.Size(928, 791);
            this.dataGridViewQueuedJobs.TabIndex = 0;
            // 
            // buttonCleanUpMaterials
            // 
            this.buttonCleanUpMaterials.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCleanUpMaterials.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonCleanUpMaterials.Location = new System.Drawing.Point(728, 0);
            this.buttonCleanUpMaterials.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCleanUpMaterials.Name = "buttonCleanUpMaterials";
            this.buttonCleanUpMaterials.Size = new System.Drawing.Size(200, 40);
            this.buttonCleanUpMaterials.TabIndex = 1;
            this.buttonCleanUpMaterials.TabStop = false;
            this.buttonCleanUpMaterials.Text = "CLEAN UP";
            this.buttonCleanUpMaterials.UseVisualStyleBackColor = true;
            this.buttonCleanUpMaterials.Click += new System.EventHandler(this.OnClickButtonCleanUp);
            // 
            // buttonRemoveJob
            // 
            this.buttonRemoveJob.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveJob.Location = new System.Drawing.Point(525, 0);
            this.buttonRemoveJob.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemoveJob.Name = "buttonRemoveJob";
            this.buttonRemoveJob.Size = new System.Drawing.Size(200, 40);
            this.buttonRemoveJob.TabIndex = 0;
            this.buttonRemoveJob.TabStop = false;
            this.buttonRemoveJob.Text = "REMOVE";
            this.buttonRemoveJob.UseVisualStyleBackColor = true;
            this.buttonRemoveJob.Click += new System.EventHandler(this.OnClickButtonDeleteJob);
            // 
            // checkBoxTakeoutByRobot
            // 
            this.checkBoxTakeoutByRobot.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxTakeoutByRobot.AutoSize = true;
            this.checkBoxTakeoutByRobot.Checked = true;
            this.checkBoxTakeoutByRobot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTakeoutByRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxTakeoutByRobot.Location = new System.Drawing.Point(0, 0);
            this.checkBoxTakeoutByRobot.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxTakeoutByRobot.Name = "checkBoxTakeoutByRobot";
            this.checkBoxTakeoutByRobot.Size = new System.Drawing.Size(200, 40);
            this.checkBoxTakeoutByRobot.TabIndex = 2;
            this.checkBoxTakeoutByRobot.Text = "AUTO MODE";
            this.checkBoxTakeoutByRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxTakeoutByRobot.UseVisualStyleBackColor = true;
            this.checkBoxTakeoutByRobot.CheckedChanged += new System.EventHandler(this.OnCheckedChangedAutoMode);
            // 
            // groupBoxUnloadingReel
            // 
            this.groupBoxUnloadingReel.Controls.Add(this.tableLayoutPanelProcessingReel);
            this.groupBoxUnloadingReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUnloadingReel.Location = new System.Drawing.Point(951, 3);
            this.groupBoxUnloadingReel.Name = "groupBoxUnloadingReel";
            this.groupBoxUnloadingReel.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxUnloadingReel.Size = new System.Drawing.Size(942, 244);
            this.groupBoxUnloadingReel.TabIndex = 1;
            this.groupBoxUnloadingReel.TabStop = false;
            this.groupBoxUnloadingReel.Text = "PROCESSING REEL ";
            // 
            // tableLayoutPanelProcessingReel
            // 
            this.tableLayoutPanelProcessingReel.ColumnCount = 7;
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelQtyValue, 6, 10);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelMfgValue, 2, 10);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelSupplierValue, 6, 8);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelLotIdValue, 2, 8);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelCarrierValue, 6, 6);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelArticleValue, 2, 6);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelDstValue, 6, 4);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelJobName, 0, 0);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelUser, 4, 0);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelTower, 0, 2);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelTowerStatus, 4, 2);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelSrc, 0, 4);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelDst, 4, 4);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelArticle, 0, 6);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelCarrier, 4, 6);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelLotId, 0, 8);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelSupplier, 4, 8);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelQty, 4, 10);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelMfg, 0, 10);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelJobNameValue, 2, 0);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelUserValue, 6, 0);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelTowerIdValud, 2, 2);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelTowerStatusValue, 6, 2);
            this.tableLayoutPanelProcessingReel.Controls.Add(this.labelProcessingReelSrcValue, 2, 4);
            this.tableLayoutPanelProcessingReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProcessingReel.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelProcessingReel.Name = "tableLayoutPanelProcessingReel";
            this.tableLayoutPanelProcessingReel.RowCount = 11;
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProcessingReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelProcessingReel.Size = new System.Drawing.Size(928, 208);
            this.tableLayoutPanelProcessingReel.TabIndex = 0;
            // 
            // labelProcessingReelQtyValue
            // 
            this.labelProcessingReelQtyValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelQtyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelQtyValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelQtyValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelQtyValue.Location = new System.Drawing.Point(589, 175);
            this.labelProcessingReelQtyValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelQtyValue.Name = "labelProcessingReelQtyValue";
            this.labelProcessingReelQtyValue.Size = new System.Drawing.Size(339, 33);
            this.labelProcessingReelQtyValue.TabIndex = 185;
            this.labelProcessingReelQtyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelMfgValue
            // 
            this.labelProcessingReelMfgValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelMfgValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelMfgValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelMfgValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelMfgValue.Location = new System.Drawing.Point(124, 175);
            this.labelProcessingReelMfgValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelMfgValue.Name = "labelProcessingReelMfgValue";
            this.labelProcessingReelMfgValue.Size = new System.Drawing.Size(339, 33);
            this.labelProcessingReelMfgValue.TabIndex = 185;
            this.labelProcessingReelMfgValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelSupplierValue
            // 
            this.labelProcessingReelSupplierValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelSupplierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelSupplierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelSupplierValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelSupplierValue.Location = new System.Drawing.Point(589, 140);
            this.labelProcessingReelSupplierValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelSupplierValue.Name = "labelProcessingReelSupplierValue";
            this.labelProcessingReelSupplierValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelSupplierValue.TabIndex = 185;
            this.labelProcessingReelSupplierValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelLotIdValue
            // 
            this.labelProcessingReelLotIdValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelLotIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelLotIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelLotIdValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelLotIdValue.Location = new System.Drawing.Point(124, 140);
            this.labelProcessingReelLotIdValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelLotIdValue.Name = "labelProcessingReelLotIdValue";
            this.labelProcessingReelLotIdValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelLotIdValue.TabIndex = 185;
            this.labelProcessingReelLotIdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelCarrierValue
            // 
            this.labelProcessingReelCarrierValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelCarrierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelCarrierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelCarrierValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelCarrierValue.Location = new System.Drawing.Point(589, 105);
            this.labelProcessingReelCarrierValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelCarrierValue.Name = "labelProcessingReelCarrierValue";
            this.labelProcessingReelCarrierValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelCarrierValue.TabIndex = 185;
            this.labelProcessingReelCarrierValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelArticleValue
            // 
            this.labelProcessingReelArticleValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelArticleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelArticleValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelArticleValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelArticleValue.Location = new System.Drawing.Point(124, 105);
            this.labelProcessingReelArticleValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelArticleValue.Name = "labelProcessingReelArticleValue";
            this.labelProcessingReelArticleValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelArticleValue.TabIndex = 185;
            this.labelProcessingReelArticleValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelDstValue
            // 
            this.labelProcessingReelDstValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelDstValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelDstValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelDstValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelDstValue.Location = new System.Drawing.Point(589, 70);
            this.labelProcessingReelDstValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelDstValue.Name = "labelProcessingReelDstValue";
            this.labelProcessingReelDstValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelDstValue.TabIndex = 185;
            this.labelProcessingReelDstValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelJobName
            // 
            this.labelProcessingReelJobName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelJobName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelJobName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelJobName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelJobName.Location = new System.Drawing.Point(0, 0);
            this.labelProcessingReelJobName.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelJobName.Name = "labelProcessingReelJobName";
            this.labelProcessingReelJobName.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelJobName.Size = new System.Drawing.Size(121, 32);
            this.labelProcessingReelJobName.TabIndex = 170;
            this.labelProcessingReelJobName.Text = "JOB NAME";
            this.labelProcessingReelJobName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelUser
            // 
            this.labelProcessingReelUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelUser.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelUser.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelUser.Location = new System.Drawing.Point(466, 0);
            this.labelProcessingReelUser.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelUser.Name = "labelProcessingReelUser";
            this.labelProcessingReelUser.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelUser.Size = new System.Drawing.Size(120, 32);
            this.labelProcessingReelUser.TabIndex = 171;
            this.labelProcessingReelUser.Text = "USER";
            this.labelProcessingReelUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelTower
            // 
            this.labelProcessingReelTower.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelTower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelTower.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelTower.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelTower.Location = new System.Drawing.Point(0, 35);
            this.labelProcessingReelTower.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelTower.Name = "labelProcessingReelTower";
            this.labelProcessingReelTower.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelTower.Size = new System.Drawing.Size(121, 32);
            this.labelProcessingReelTower.TabIndex = 172;
            this.labelProcessingReelTower.Text = "TOWER";
            this.labelProcessingReelTower.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelTowerStatus
            // 
            this.labelProcessingReelTowerStatus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelTowerStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelTowerStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelTowerStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelTowerStatus.Location = new System.Drawing.Point(466, 35);
            this.labelProcessingReelTowerStatus.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelTowerStatus.Name = "labelProcessingReelTowerStatus";
            this.labelProcessingReelTowerStatus.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelTowerStatus.Size = new System.Drawing.Size(120, 32);
            this.labelProcessingReelTowerStatus.TabIndex = 173;
            this.labelProcessingReelTowerStatus.Text = "STATUS";
            this.labelProcessingReelTowerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelSrc
            // 
            this.labelProcessingReelSrc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelSrc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelSrc.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelSrc.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelSrc.Location = new System.Drawing.Point(0, 70);
            this.labelProcessingReelSrc.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelSrc.Name = "labelProcessingReelSrc";
            this.labelProcessingReelSrc.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelSrc.Size = new System.Drawing.Size(121, 32);
            this.labelProcessingReelSrc.TabIndex = 174;
            this.labelProcessingReelSrc.Text = "FROM";
            this.labelProcessingReelSrc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelDst
            // 
            this.labelProcessingReelDst.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelDst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelDst.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelDst.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelDst.Location = new System.Drawing.Point(466, 70);
            this.labelProcessingReelDst.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelDst.Name = "labelProcessingReelDst";
            this.labelProcessingReelDst.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelDst.Size = new System.Drawing.Size(120, 32);
            this.labelProcessingReelDst.TabIndex = 175;
            this.labelProcessingReelDst.Text = "TO";
            this.labelProcessingReelDst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelArticle
            // 
            this.labelProcessingReelArticle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelArticle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelArticle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelArticle.Location = new System.Drawing.Point(0, 105);
            this.labelProcessingReelArticle.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelArticle.Name = "labelProcessingReelArticle";
            this.labelProcessingReelArticle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelArticle.Size = new System.Drawing.Size(121, 32);
            this.labelProcessingReelArticle.TabIndex = 176;
            this.labelProcessingReelArticle.Text = "SID";
            this.labelProcessingReelArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelCarrier
            // 
            this.labelProcessingReelCarrier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelCarrier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelCarrier.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelCarrier.Location = new System.Drawing.Point(466, 105);
            this.labelProcessingReelCarrier.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelCarrier.Name = "labelProcessingReelCarrier";
            this.labelProcessingReelCarrier.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelCarrier.Size = new System.Drawing.Size(120, 32);
            this.labelProcessingReelCarrier.TabIndex = 177;
            this.labelProcessingReelCarrier.Text = "UID";
            this.labelProcessingReelCarrier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelLotId
            // 
            this.labelProcessingReelLotId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelLotId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelLotId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelLotId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelLotId.Location = new System.Drawing.Point(0, 140);
            this.labelProcessingReelLotId.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelLotId.Name = "labelProcessingReelLotId";
            this.labelProcessingReelLotId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelLotId.Size = new System.Drawing.Size(121, 32);
            this.labelProcessingReelLotId.TabIndex = 178;
            this.labelProcessingReelLotId.Text = "LOT ID";
            this.labelProcessingReelLotId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelSupplier
            // 
            this.labelProcessingReelSupplier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelSupplier.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelSupplier.Location = new System.Drawing.Point(466, 140);
            this.labelProcessingReelSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelSupplier.Name = "labelProcessingReelSupplier";
            this.labelProcessingReelSupplier.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelSupplier.Size = new System.Drawing.Size(120, 32);
            this.labelProcessingReelSupplier.TabIndex = 179;
            this.labelProcessingReelSupplier.Text = "SUPPLIER";
            this.labelProcessingReelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelQty
            // 
            this.labelProcessingReelQty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelQty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelQty.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelQty.Location = new System.Drawing.Point(466, 175);
            this.labelProcessingReelQty.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelQty.Name = "labelProcessingReelQty";
            this.labelProcessingReelQty.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelQty.Size = new System.Drawing.Size(120, 33);
            this.labelProcessingReelQty.TabIndex = 181;
            this.labelProcessingReelQty.Text = "QTY";
            this.labelProcessingReelQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelMfg
            // 
            this.labelProcessingReelMfg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelProcessingReelMfg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelMfg.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelMfg.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelMfg.Location = new System.Drawing.Point(0, 175);
            this.labelProcessingReelMfg.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelMfg.Name = "labelProcessingReelMfg";
            this.labelProcessingReelMfg.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelProcessingReelMfg.Size = new System.Drawing.Size(121, 33);
            this.labelProcessingReelMfg.TabIndex = 180;
            this.labelProcessingReelMfg.Text = "MFG";
            this.labelProcessingReelMfg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProcessingReelJobNameValue
            // 
            this.labelProcessingReelJobNameValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelJobNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelJobNameValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelJobNameValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelJobNameValue.Location = new System.Drawing.Point(124, 0);
            this.labelProcessingReelJobNameValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelJobNameValue.Name = "labelProcessingReelJobNameValue";
            this.labelProcessingReelJobNameValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelJobNameValue.TabIndex = 182;
            this.labelProcessingReelJobNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelUserValue
            // 
            this.labelProcessingReelUserValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelUserValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelUserValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelUserValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelUserValue.Location = new System.Drawing.Point(589, 0);
            this.labelProcessingReelUserValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelUserValue.Name = "labelProcessingReelUserValue";
            this.labelProcessingReelUserValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelUserValue.TabIndex = 183;
            this.labelProcessingReelUserValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelTowerIdValud
            // 
            this.labelProcessingReelTowerIdValud.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelTowerIdValud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelTowerIdValud.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelTowerIdValud.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelTowerIdValud.Location = new System.Drawing.Point(124, 35);
            this.labelProcessingReelTowerIdValud.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelTowerIdValud.Name = "labelProcessingReelTowerIdValud";
            this.labelProcessingReelTowerIdValud.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelTowerIdValud.TabIndex = 184;
            this.labelProcessingReelTowerIdValud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelTowerStatusValue
            // 
            this.labelProcessingReelTowerStatusValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelTowerStatusValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelTowerStatusValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelTowerStatusValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelTowerStatusValue.Location = new System.Drawing.Point(589, 35);
            this.labelProcessingReelTowerStatusValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelTowerStatusValue.Name = "labelProcessingReelTowerStatusValue";
            this.labelProcessingReelTowerStatusValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelTowerStatusValue.TabIndex = 185;
            this.labelProcessingReelTowerStatusValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessingReelSrcValue
            // 
            this.labelProcessingReelSrcValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelProcessingReelSrcValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessingReelSrcValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelProcessingReelSrcValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelProcessingReelSrcValue.Location = new System.Drawing.Point(124, 70);
            this.labelProcessingReelSrcValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelProcessingReelSrcValue.Name = "labelProcessingReelSrcValue";
            this.labelProcessingReelSrcValue.Size = new System.Drawing.Size(339, 32);
            this.labelProcessingReelSrcValue.TabIndex = 186;
            this.labelProcessingReelSrcValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxPendedReels
            // 
            this.groupBoxPendedReels.Controls.Add(this.listViewPendedReels);
            this.groupBoxPendedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPendedReels.Location = new System.Drawing.Point(951, 253);
            this.groupBoxPendedReels.Name = "groupBoxPendedReels";
            this.groupBoxPendedReels.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxPendedReels.Size = new System.Drawing.Size(942, 620);
            this.groupBoxPendedReels.TabIndex = 2;
            this.groupBoxPendedReels.TabStop = false;
            this.groupBoxPendedReels.Text = " PENDED REELS ";
            // 
            // listViewPendedReels
            // 
            this.listViewPendedReels.BackColor = System.Drawing.SystemColors.Desktop;
            this.listViewPendedReels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPendedReels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewPendedReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPendedReels.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewPendedReels.FullRowSelect = true;
            this.listViewPendedReels.GridLines = true;
            this.listViewPendedReels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPendedReels.HideSelection = false;
            this.listViewPendedReels.Location = new System.Drawing.Point(7, 29);
            this.listViewPendedReels.MultiSelect = false;
            this.listViewPendedReels.Name = "listViewPendedReels";
            this.listViewPendedReels.Size = new System.Drawing.Size(928, 584);
            this.listViewPendedReels.TabIndex = 0;
            this.listViewPendedReels.UseCompatibleStateImageBehavior = false;
            this.listViewPendedReels.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "INDEX";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "SID";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "UID";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SUPPLIER";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "QUANTITY";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STATE";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 130;
            // 
            // lblURClientConnectState
            // 
            this.lblURClientConnectState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lblURClientConnectState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblURClientConnectState.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblURClientConnectState.Location = new System.Drawing.Point(1520, 1026);
            this.lblURClientConnectState.Name = "lblURClientConnectState";
            this.lblURClientConnectState.Size = new System.Drawing.Size(77, 31);
            this.lblURClientConnectState.TabIndex = 131;
            this.lblURClientConnectState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientConnect
            // 
            this.btnClientConnect.BackColor = System.Drawing.Color.DimGray;
            this.btnClientConnect.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClientConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnClientConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClientConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientConnect.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClientConnect.Location = new System.Drawing.Point(1390, 1027);
            this.btnClientConnect.Name = "btnClientConnect";
            this.btnClientConnect.Size = new System.Drawing.Size(139, 30);
            this.btnClientConnect.TabIndex = 130;
            this.btnClientConnect.Text = "[D/B Client]";
            this.btnClientConnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientConnect.UseVisualStyleBackColor = false;
            // 
            // tabPageStoreOperation
            // 
            this.tabPageStoreOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageStoreOperation.Controls.Add(this.tableLayoutPanelStoreReel);
            this.tabPageStoreOperation.Location = new System.Drawing.Point(4, 44);
            this.tabPageStoreOperation.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageStoreOperation.Name = "tabPageStoreOperation";
            this.tabPageStoreOperation.Size = new System.Drawing.Size(1906, 887);
            this.tabPageStoreOperation.TabIndex = 6;
            this.tabPageStoreOperation.Text = "     STORE      ";
            this.tabPageStoreOperation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelStoreReel
            // 
            this.tableLayoutPanelStoreReel.ColumnCount = 2;
            this.tableLayoutPanelStoreReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStoreReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStoreReel.Controls.Add(this.groupBoxStoreReel, 0, 0);
            this.tableLayoutPanelStoreReel.Controls.Add(this.groupBoxQueryReels, 0, 2);
            this.tableLayoutPanelStoreReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStoreReel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelStoreReel.Name = "tableLayoutPanelStoreReel";
            this.tableLayoutPanelStoreReel.RowCount = 5;
            this.tableLayoutPanelStoreReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanelStoreReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelStoreReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelStoreReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelStoreReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelStoreReel.Size = new System.Drawing.Size(1904, 885);
            this.tableLayoutPanelStoreReel.TabIndex = 0;
            // 
            // groupBoxStoreReel
            // 
            this.tableLayoutPanelStoreReel.SetColumnSpan(this.groupBoxStoreReel, 2);
            this.groupBoxStoreReel.Controls.Add(this.tableLayoutPanelLoadReel);
            this.groupBoxStoreReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStoreReel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxStoreReel.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStoreReel.Name = "groupBoxStoreReel";
            this.groupBoxStoreReel.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxStoreReel.Size = new System.Drawing.Size(1898, 208);
            this.groupBoxStoreReel.TabIndex = 0;
            this.groupBoxStoreReel.TabStop = false;
            this.groupBoxStoreReel.Text = " STORE REEL ";
            // 
            // tableLayoutPanelLoadReel
            // 
            this.tableLayoutPanelLoadReel.ColumnCount = 15;
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLoadReel.Controls.Add(this.buttonClearLoadReelRequest, 12, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.buttonRequestLoadReel, 14, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.comboBoxLoadReelTypeValue, 6, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelTowerId, 0, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.comboBoxLoadReelTowerIdValue, 2, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelArticleValue, 2, 4);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelType, 4, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelSize, 0, 2);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelThickness, 4, 2);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelArticle, 0, 4);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelCarrier, 4, 4);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelLotId, 0, 6);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelSupplier, 4, 6);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelMfg, 0, 8);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelQty, 4, 8);
            this.tableLayoutPanelLoadReel.Controls.Add(this.comboBoxLoadReelThicknessValue, 6, 2);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelCarrierValue, 6, 4);
            this.tableLayoutPanelLoadReel.Controls.Add(this.comboBoxLoadReelSizeValue, 2, 2);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelLotIdValue, 2, 6);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelSupplierValue, 6, 6);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelMfgValue, 2, 8);
            this.tableLayoutPanelLoadReel.Controls.Add(this.numericUpDownLoadReelQtyValue, 6, 8);
            this.tableLayoutPanelLoadReel.Controls.Add(this.labelLoadReelComment, 8, 0);
            this.tableLayoutPanelLoadReel.Controls.Add(this.textBoxLoadReelCommentValue, 10, 0);
            this.tableLayoutPanelLoadReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLoadReel.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelLoadReel.Name = "tableLayoutPanelLoadReel";
            this.tableLayoutPanelLoadReel.RowCount = 9;
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelLoadReel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelLoadReel.Size = new System.Drawing.Size(1884, 172);
            this.tableLayoutPanelLoadReel.TabIndex = 0;
            // 
            // buttonClearLoadReelRequest
            // 
            this.buttonClearLoadReelRequest.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClearLoadReelRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearLoadReelRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLoadReelRequest.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonClearLoadReelRequest.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonClearLoadReelRequest.Location = new System.Drawing.Point(1416, 3);
            this.buttonClearLoadReelRequest.Name = "buttonClearLoadReelRequest";
            this.tableLayoutPanelLoadReel.SetRowSpan(this.buttonClearLoadReelRequest, 3);
            this.buttonClearLoadReelRequest.Size = new System.Drawing.Size(194, 61);
            this.buttonClearLoadReelRequest.TabIndex = 0;
            this.buttonClearLoadReelRequest.TabStop = false;
            this.buttonClearLoadReelRequest.Text = "CLEAR";
            this.buttonClearLoadReelRequest.UseVisualStyleBackColor = false;
            this.buttonClearLoadReelRequest.Click += new System.EventHandler(this.OnClickButtonClearLoadReelRequest);
            // 
            // buttonRequestLoadReel
            // 
            this.buttonRequestLoadReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRequestLoadReel.Location = new System.Drawing.Point(1619, 3);
            this.buttonRequestLoadReel.Name = "buttonRequestLoadReel";
            this.tableLayoutPanelLoadReel.SetRowSpan(this.buttonRequestLoadReel, 3);
            this.buttonRequestLoadReel.Size = new System.Drawing.Size(262, 61);
            this.buttonRequestLoadReel.TabIndex = 0;
            this.buttonRequestLoadReel.TabStop = false;
            this.buttonRequestLoadReel.Text = "REQUEST";
            this.buttonRequestLoadReel.UseVisualStyleBackColor = true;
            this.buttonRequestLoadReel.Click += new System.EventHandler(this.OnClickButtonRequestLoadReel);
            // 
            // comboBoxLoadReelTypeValue
            // 
            this.comboBoxLoadReelTypeValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLoadReelTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLoadReelTypeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLoadReelTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadReelTypeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxLoadReelTypeValue.FormattingEnabled = true;
            this.comboBoxLoadReelTypeValue.Items.AddRange(new object[] {
            "NEW",
            "RETURN"});
            this.comboBoxLoadReelTypeValue.Location = new System.Drawing.Point(674, 0);
            this.comboBoxLoadReelTypeValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxLoadReelTypeValue.Name = "comboBoxLoadReelTypeValue";
            this.comboBoxLoadReelTypeValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxLoadReelTypeValue.TabIndex = 0;
            this.comboBoxLoadReelTypeValue.TabStop = false;
            this.comboBoxLoadReelTypeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // labelLoadReelTowerId
            // 
            this.labelLoadReelTowerId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelTowerId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelTowerId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelTowerId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelTowerId.Location = new System.Drawing.Point(0, 0);
            this.labelLoadReelTowerId.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelTowerId.Name = "labelLoadReelTowerId";
            this.labelLoadReelTowerId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelTowerId.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelTowerId.TabIndex = 0;
            this.labelLoadReelTowerId.Text = "TOWER";
            this.labelLoadReelTowerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxLoadReelTowerIdValue
            // 
            this.comboBoxLoadReelTowerIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLoadReelTowerIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLoadReelTowerIdValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLoadReelTowerIdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadReelTowerIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxLoadReelTowerIdValue.FormattingEnabled = true;
            this.comboBoxLoadReelTowerIdValue.Location = new System.Drawing.Point(203, 0);
            this.comboBoxLoadReelTowerIdValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxLoadReelTowerIdValue.Name = "comboBoxLoadReelTowerIdValue";
            this.comboBoxLoadReelTowerIdValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxLoadReelTowerIdValue.TabIndex = 0;
            this.comboBoxLoadReelTowerIdValue.TabStop = false;
            this.comboBoxLoadReelTowerIdValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // textBoxLoadReelArticleValue
            // 
            this.textBoxLoadReelArticleValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoadReelArticleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelArticleValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelArticleValue.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxLoadReelArticleValue.Location = new System.Drawing.Point(203, 72);
            this.textBoxLoadReelArticleValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelArticleValue.Name = "textBoxLoadReelArticleValue";
            this.textBoxLoadReelArticleValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxLoadReelArticleValue.TabIndex = 1;
            this.textBoxLoadReelArticleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoadReelArticleValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // labelLoadReelType
            // 
            this.labelLoadReelType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelType.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelType.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelType.Location = new System.Drawing.Point(471, 0);
            this.labelLoadReelType.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelType.Name = "labelLoadReelType";
            this.labelLoadReelType.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelType.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelType.TabIndex = 0;
            this.labelLoadReelType.Text = "LOAD TYPE";
            this.labelLoadReelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelSize
            // 
            this.labelLoadReelSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelSize.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelSize.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelSize.Location = new System.Drawing.Point(0, 35);
            this.labelLoadReelSize.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelSize.Name = "labelLoadReelSize";
            this.labelLoadReelSize.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelSize.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelSize.TabIndex = 0;
            this.labelLoadReelSize.Text = "REEL SIZE";
            this.labelLoadReelSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelThickness
            // 
            this.labelLoadReelThickness.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelThickness.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelThickness.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelThickness.Location = new System.Drawing.Point(471, 35);
            this.labelLoadReelThickness.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelThickness.Name = "labelLoadReelThickness";
            this.labelLoadReelThickness.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelThickness.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelThickness.TabIndex = 0;
            this.labelLoadReelThickness.Text = "REEL THICKNESS";
            this.labelLoadReelThickness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelArticle
            // 
            this.labelLoadReelArticle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelArticle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelArticle.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelArticle.Location = new System.Drawing.Point(0, 70);
            this.labelLoadReelArticle.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelArticle.Name = "labelLoadReelArticle";
            this.labelLoadReelArticle.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelArticle.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelArticle.TabIndex = 0;
            this.labelLoadReelArticle.Text = "SID";
            this.labelLoadReelArticle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelCarrier
            // 
            this.labelLoadReelCarrier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelCarrier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelCarrier.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelCarrier.Location = new System.Drawing.Point(471, 70);
            this.labelLoadReelCarrier.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelCarrier.Name = "labelLoadReelCarrier";
            this.labelLoadReelCarrier.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelCarrier.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelCarrier.TabIndex = 0;
            this.labelLoadReelCarrier.Text = "UID";
            this.labelLoadReelCarrier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelLotId
            // 
            this.labelLoadReelLotId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelLotId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelLotId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelLotId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelLotId.Location = new System.Drawing.Point(0, 105);
            this.labelLoadReelLotId.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelLotId.Name = "labelLoadReelLotId";
            this.labelLoadReelLotId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelLotId.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelLotId.TabIndex = 0;
            this.labelLoadReelLotId.Text = "LOT ID";
            this.labelLoadReelLotId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelSupplier
            // 
            this.labelLoadReelSupplier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelSupplier.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelSupplier.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelSupplier.Location = new System.Drawing.Point(471, 105);
            this.labelLoadReelSupplier.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelSupplier.Name = "labelLoadReelSupplier";
            this.labelLoadReelSupplier.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelSupplier.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelSupplier.TabIndex = 0;
            this.labelLoadReelSupplier.Text = "SUPPLIER";
            this.labelLoadReelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelMfg
            // 
            this.labelLoadReelMfg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelMfg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelMfg.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelMfg.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelMfg.Location = new System.Drawing.Point(0, 140);
            this.labelLoadReelMfg.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelMfg.Name = "labelLoadReelMfg";
            this.labelLoadReelMfg.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelMfg.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelMfg.TabIndex = 0;
            this.labelLoadReelMfg.Text = "MFG";
            this.labelLoadReelMfg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLoadReelQty
            // 
            this.labelLoadReelQty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelQty.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelQty.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelQty.Location = new System.Drawing.Point(471, 140);
            this.labelLoadReelQty.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelQty.Name = "labelLoadReelQty";
            this.labelLoadReelQty.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelQty.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelQty.TabIndex = 0;
            this.labelLoadReelQty.Text = "QTY";
            this.labelLoadReelQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxLoadReelThicknessValue
            // 
            this.comboBoxLoadReelThicknessValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLoadReelThicknessValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLoadReelThicknessValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLoadReelThicknessValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadReelThicknessValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxLoadReelThicknessValue.FormattingEnabled = true;
            this.comboBoxLoadReelThicknessValue.Location = new System.Drawing.Point(674, 35);
            this.comboBoxLoadReelThicknessValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxLoadReelThicknessValue.Name = "comboBoxLoadReelThicknessValue";
            this.comboBoxLoadReelThicknessValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxLoadReelThicknessValue.TabIndex = 0;
            this.comboBoxLoadReelThicknessValue.TabStop = false;
            this.comboBoxLoadReelThicknessValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // textBoxLoadReelCarrierValue
            // 
            this.textBoxLoadReelCarrierValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoadReelCarrierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelCarrierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelCarrierValue.Location = new System.Drawing.Point(674, 72);
            this.textBoxLoadReelCarrierValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelCarrierValue.Name = "textBoxLoadReelCarrierValue";
            this.textBoxLoadReelCarrierValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxLoadReelCarrierValue.TabIndex = 2;
            this.textBoxLoadReelCarrierValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoadReelCarrierValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // comboBoxLoadReelSizeValue
            // 
            this.comboBoxLoadReelSizeValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxLoadReelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxLoadReelSizeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLoadReelSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoadReelSizeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxLoadReelSizeValue.FormattingEnabled = true;
            this.comboBoxLoadReelSizeValue.Location = new System.Drawing.Point(203, 35);
            this.comboBoxLoadReelSizeValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxLoadReelSizeValue.Name = "comboBoxLoadReelSizeValue";
            this.comboBoxLoadReelSizeValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxLoadReelSizeValue.TabIndex = 0;
            this.comboBoxLoadReelSizeValue.TabStop = false;
            this.comboBoxLoadReelSizeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // textBoxLoadReelLotIdValue
            // 
            this.textBoxLoadReelLotIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoadReelLotIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelLotIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelLotIdValue.Location = new System.Drawing.Point(203, 107);
            this.textBoxLoadReelLotIdValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelLotIdValue.Name = "textBoxLoadReelLotIdValue";
            this.textBoxLoadReelLotIdValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxLoadReelLotIdValue.TabIndex = 3;
            this.textBoxLoadReelLotIdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoadReelLotIdValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // textBoxLoadReelSupplierValue
            // 
            this.textBoxLoadReelSupplierValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoadReelSupplierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelSupplierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelSupplierValue.Location = new System.Drawing.Point(674, 107);
            this.textBoxLoadReelSupplierValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelSupplierValue.Name = "textBoxLoadReelSupplierValue";
            this.textBoxLoadReelSupplierValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxLoadReelSupplierValue.TabIndex = 4;
            this.textBoxLoadReelSupplierValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoadReelSupplierValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // textBoxLoadReelMfgValue
            // 
            this.textBoxLoadReelMfgValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxLoadReelMfgValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelMfgValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelMfgValue.Location = new System.Drawing.Point(203, 142);
            this.textBoxLoadReelMfgValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelMfgValue.Name = "textBoxLoadReelMfgValue";
            this.textBoxLoadReelMfgValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxLoadReelMfgValue.TabIndex = 5;
            this.textBoxLoadReelMfgValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLoadReelMfgValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // numericUpDownLoadReelQtyValue
            // 
            this.numericUpDownLoadReelQtyValue.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownLoadReelQtyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownLoadReelQtyValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numericUpDownLoadReelQtyValue.Location = new System.Drawing.Point(674, 140);
            this.numericUpDownLoadReelQtyValue.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownLoadReelQtyValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownLoadReelQtyValue.Name = "numericUpDownLoadReelQtyValue";
            this.numericUpDownLoadReelQtyValue.Size = new System.Drawing.Size(265, 29);
            this.numericUpDownLoadReelQtyValue.TabIndex = 6;
            this.numericUpDownLoadReelQtyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelLoadReelComment
            // 
            this.labelLoadReelComment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLoadReelComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoadReelComment.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelLoadReelComment.ForeColor = System.Drawing.SystemColors.Window;
            this.labelLoadReelComment.Location = new System.Drawing.Point(942, 0);
            this.labelLoadReelComment.Margin = new System.Windows.Forms.Padding(0);
            this.labelLoadReelComment.Name = "labelLoadReelComment";
            this.labelLoadReelComment.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelLoadReelComment.Size = new System.Drawing.Size(200, 32);
            this.labelLoadReelComment.TabIndex = 11;
            this.labelLoadReelComment.Text = "COMMENT";
            this.labelLoadReelComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLoadReelCommentValue
            // 
            this.textBoxLoadReelCommentValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelLoadReel.SetColumnSpan(this.textBoxLoadReelCommentValue, 2);
            this.textBoxLoadReelCommentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLoadReelCommentValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxLoadReelCommentValue.Location = new System.Drawing.Point(1145, 2);
            this.textBoxLoadReelCommentValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxLoadReelCommentValue.Multiline = true;
            this.textBoxLoadReelCommentValue.Name = "textBoxLoadReelCommentValue";
            this.tableLayoutPanelLoadReel.SetRowSpan(this.textBoxLoadReelCommentValue, 9);
            this.textBoxLoadReelCommentValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLoadReelCommentValue.Size = new System.Drawing.Size(268, 170);
            this.textBoxLoadReelCommentValue.TabIndex = 7;
            this.textBoxLoadReelCommentValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUpStoreReelPage);
            // 
            // groupBoxQueryReels
            // 
            this.tableLayoutPanelStoreReel.SetColumnSpan(this.groupBoxQueryReels, 2);
            this.groupBoxQueryReels.Controls.Add(this.tableLayoutPanelQueryReels);
            this.groupBoxQueryReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQueryReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxQueryReels.Location = new System.Drawing.Point(3, 220);
            this.groupBoxQueryReels.Name = "groupBoxQueryReels";
            this.groupBoxQueryReels.Padding = new System.Windows.Forms.Padding(7);
            this.tableLayoutPanelStoreReel.SetRowSpan(this.groupBoxQueryReels, 3);
            this.groupBoxQueryReels.Size = new System.Drawing.Size(1898, 662);
            this.groupBoxQueryReels.TabIndex = 1;
            this.groupBoxQueryReels.TabStop = false;
            this.groupBoxQueryReels.Text = " QUERY REELS ";
            // 
            // tableLayoutPanelQueryReels
            // 
            this.tableLayoutPanelQueryReels.ColumnCount = 17;
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQueryReels.Controls.Add(this.buttonExecuteTowerSync, 8, 2);
            this.tableLayoutPanelQueryReels.Controls.Add(this.textBoxQueryLotIDValue, 2, 4);
            this.tableLayoutPanelQueryReels.Controls.Add(this.buttonExecuteDBSync, 8, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByCustomerDB, 4, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByTowerId, 0, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.buttonExecuteQueryReels, 16, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByReelSize, 0, 2);
            this.tableLayoutPanelQueryReels.Controls.Add(this.comboBoxQueryReelTowerIdValue, 2, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByLotID, 0, 4);
            this.tableLayoutPanelQueryReels.Controls.Add(this.comboBoxQueryReelSizeValue, 2, 2);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByArticle, 10, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByCarrier, 10, 2);
            this.tableLayoutPanelQueryReels.Controls.Add(this.textBoxQueryReelArticleValue, 12, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.textBoxQueryReelCarrierValue, 12, 2);
            this.tableLayoutPanelQueryReels.Controls.Add(this.labelQueryReelCreateDateCondition, 4, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBox6QueryBySupplier, 10, 4);
            this.tableLayoutPanelQueryReels.Controls.Add(this.textBoxQueryReelSupplierValue, 12, 4);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByDatetime, 0, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.dateTimePickerQueryReeCreateDateValue, 2, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.checkBoxQueryByQty, 10, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.numericUpDownQueryReelQtyValue, 12, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.comboBoxQueryReelQtyOptionValue, 16, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.labelQueryReelQtyCondition, 14, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.groupBoxQueryResults, 0, 8);
            this.tableLayoutPanelQueryReels.Controls.Add(this.buttonClearQueryReels, 14, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.comboBoxQueryDatetimeOptionValue, 6, 6);
            this.tableLayoutPanelQueryReels.Controls.Add(this.buttonMissmathSearch, 6, 0);
            this.tableLayoutPanelQueryReels.Controls.Add(this.radioButtonSearchAll, 6, 4);
            this.tableLayoutPanelQueryReels.Controls.Add(this.radioButtonSerachMissmatch, 8, 4);
            this.tableLayoutPanelQueryReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQueryReels.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelQueryReels.Name = "tableLayoutPanelQueryReels";
            this.tableLayoutPanelQueryReels.RowCount = 9;
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelQueryReels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelQueryReels.Size = new System.Drawing.Size(1884, 626);
            this.tableLayoutPanelQueryReels.TabIndex = 12;
            // 
            // buttonExecuteTowerSync
            // 
            this.buttonExecuteTowerSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExecuteTowerSync.Location = new System.Drawing.Point(812, 38);
            this.buttonExecuteTowerSync.Name = "buttonExecuteTowerSync";
            this.buttonExecuteTowerSync.Size = new System.Drawing.Size(126, 26);
            this.buttonExecuteTowerSync.TabIndex = 18;
            this.buttonExecuteTowerSync.TabStop = false;
            this.buttonExecuteTowerSync.Text = "TWR SYNC";
            this.buttonExecuteTowerSync.UseVisualStyleBackColor = true;
            this.buttonExecuteTowerSync.Visible = false;
            this.buttonExecuteTowerSync.Click += new System.EventHandler(this.buttonExecuteTowerSync_Click);
            // 
            // textBoxQueryLotIDValue
            // 
            this.textBoxQueryLotIDValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxQueryLotIDValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQueryLotIDValue.Enabled = false;
            this.textBoxQueryLotIDValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxQueryLotIDValue.Location = new System.Drawing.Point(203, 72);
            this.textBoxQueryLotIDValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxQueryLotIDValue.Name = "textBoxQueryLotIDValue";
            this.textBoxQueryLotIDValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxQueryLotIDValue.TabIndex = 17;
            this.textBoxQueryLotIDValue.TabStop = false;
            this.textBoxQueryLotIDValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExecuteDBSync
            // 
            this.buttonExecuteDBSync.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExecuteDBSync.Location = new System.Drawing.Point(812, 3);
            this.buttonExecuteDBSync.Name = "buttonExecuteDBSync";
            this.buttonExecuteDBSync.Size = new System.Drawing.Size(126, 26);
            this.buttonExecuteDBSync.TabIndex = 13;
            this.buttonExecuteDBSync.TabStop = false;
            this.buttonExecuteDBSync.Text = "DB SYNC";
            this.buttonExecuteDBSync.UseVisualStyleBackColor = true;
            this.buttonExecuteDBSync.Visible = false;
            this.buttonExecuteDBSync.Click += new System.EventHandler(this.buttonExecuteDBSync_Click);
            // 
            // checkBoxQueryByCustomerDB
            // 
            this.checkBoxQueryByCustomerDB.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByCustomerDB.AutoSize = true;
            this.checkBoxQueryByCustomerDB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByCustomerDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByCustomerDB.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByCustomerDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByCustomerDB.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByCustomerDB.Location = new System.Drawing.Point(471, 0);
            this.checkBoxQueryByCustomerDB.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByCustomerDB.Name = "checkBoxQueryByCustomerDB";
            this.tableLayoutPanelQueryReels.SetRowSpan(this.checkBoxQueryByCustomerDB, 5);
            this.checkBoxQueryByCustomerDB.Size = new System.Drawing.Size(200, 102);
            this.checkBoxQueryByCustomerDB.TabIndex = 13;
            this.checkBoxQueryByCustomerDB.TabStop = false;
            this.checkBoxQueryByCustomerDB.Text = "COMPARE WITH CUSTOMER DB";
            this.checkBoxQueryByCustomerDB.UseVisualStyleBackColor = false;
            this.checkBoxQueryByCustomerDB.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // checkBoxQueryByTowerId
            // 
            this.checkBoxQueryByTowerId.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByTowerId.AutoSize = true;
            this.checkBoxQueryByTowerId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByTowerId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByTowerId.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByTowerId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByTowerId.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByTowerId.Location = new System.Drawing.Point(0, 0);
            this.checkBoxQueryByTowerId.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByTowerId.Name = "checkBoxQueryByTowerId";
            this.checkBoxQueryByTowerId.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByTowerId.TabIndex = 0;
            this.checkBoxQueryByTowerId.TabStop = false;
            this.checkBoxQueryByTowerId.Text = "TOWER";
            this.checkBoxQueryByTowerId.UseVisualStyleBackColor = false;
            this.checkBoxQueryByTowerId.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // buttonExecuteQueryReels
            // 
            this.buttonExecuteQueryReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExecuteQueryReels.Location = new System.Drawing.Point(1621, 3);
            this.buttonExecuteQueryReels.Name = "buttonExecuteQueryReels";
            this.tableLayoutPanelQueryReels.SetRowSpan(this.buttonExecuteQueryReels, 3);
            this.buttonExecuteQueryReels.Size = new System.Drawing.Size(260, 61);
            this.buttonExecuteQueryReels.TabIndex = 0;
            this.buttonExecuteQueryReels.TabStop = false;
            this.buttonExecuteQueryReels.Text = "QUERY";
            this.buttonExecuteQueryReels.UseVisualStyleBackColor = true;
            this.buttonExecuteQueryReels.Click += new System.EventHandler(this.OnClickButtonExecuteQueryReels);
            // 
            // checkBoxQueryByReelSize
            // 
            this.checkBoxQueryByReelSize.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByReelSize.AutoSize = true;
            this.checkBoxQueryByReelSize.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByReelSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByReelSize.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByReelSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByReelSize.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByReelSize.Location = new System.Drawing.Point(0, 35);
            this.checkBoxQueryByReelSize.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByReelSize.Name = "checkBoxQueryByReelSize";
            this.checkBoxQueryByReelSize.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByReelSize.TabIndex = 0;
            this.checkBoxQueryByReelSize.TabStop = false;
            this.checkBoxQueryByReelSize.Text = "REEL SIZE";
            this.checkBoxQueryByReelSize.UseVisualStyleBackColor = false;
            this.checkBoxQueryByReelSize.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // comboBoxQueryReelTowerIdValue
            // 
            this.comboBoxQueryReelTowerIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxQueryReelTowerIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxQueryReelTowerIdValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxQueryReelTowerIdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryReelTowerIdValue.Enabled = false;
            this.comboBoxQueryReelTowerIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxQueryReelTowerIdValue.FormattingEnabled = true;
            this.comboBoxQueryReelTowerIdValue.Location = new System.Drawing.Point(203, 0);
            this.comboBoxQueryReelTowerIdValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxQueryReelTowerIdValue.Name = "comboBoxQueryReelTowerIdValue";
            this.comboBoxQueryReelTowerIdValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxQueryReelTowerIdValue.TabIndex = 0;
            this.comboBoxQueryReelTowerIdValue.TabStop = false;
            this.comboBoxQueryReelTowerIdValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // checkBoxQueryByLotID
            // 
            this.checkBoxQueryByLotID.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByLotID.AutoSize = true;
            this.checkBoxQueryByLotID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByLotID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByLotID.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByLotID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByLotID.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByLotID.Location = new System.Drawing.Point(0, 70);
            this.checkBoxQueryByLotID.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByLotID.Name = "checkBoxQueryByLotID";
            this.checkBoxQueryByLotID.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByLotID.TabIndex = 0;
            this.checkBoxQueryByLotID.TabStop = false;
            this.checkBoxQueryByLotID.Text = "LOTID";
            this.checkBoxQueryByLotID.UseVisualStyleBackColor = false;
            this.checkBoxQueryByLotID.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // comboBoxQueryReelSizeValue
            // 
            this.comboBoxQueryReelSizeValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxQueryReelSizeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxQueryReelSizeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxQueryReelSizeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryReelSizeValue.Enabled = false;
            this.comboBoxQueryReelSizeValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxQueryReelSizeValue.FormattingEnabled = true;
            this.comboBoxQueryReelSizeValue.Location = new System.Drawing.Point(203, 35);
            this.comboBoxQueryReelSizeValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxQueryReelSizeValue.Name = "comboBoxQueryReelSizeValue";
            this.comboBoxQueryReelSizeValue.Size = new System.Drawing.Size(265, 30);
            this.comboBoxQueryReelSizeValue.TabIndex = 0;
            this.comboBoxQueryReelSizeValue.TabStop = false;
            this.comboBoxQueryReelSizeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // checkBoxQueryByArticle
            // 
            this.checkBoxQueryByArticle.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByArticle.AutoSize = true;
            this.checkBoxQueryByArticle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByArticle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByArticle.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByArticle.Location = new System.Drawing.Point(944, 0);
            this.checkBoxQueryByArticle.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByArticle.Name = "checkBoxQueryByArticle";
            this.checkBoxQueryByArticle.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByArticle.TabIndex = 0;
            this.checkBoxQueryByArticle.TabStop = false;
            this.checkBoxQueryByArticle.Text = "SID";
            this.checkBoxQueryByArticle.UseVisualStyleBackColor = false;
            this.checkBoxQueryByArticle.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // checkBoxQueryByCarrier
            // 
            this.checkBoxQueryByCarrier.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByCarrier.AutoSize = true;
            this.checkBoxQueryByCarrier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByCarrier.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByCarrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByCarrier.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByCarrier.Location = new System.Drawing.Point(944, 35);
            this.checkBoxQueryByCarrier.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByCarrier.Name = "checkBoxQueryByCarrier";
            this.checkBoxQueryByCarrier.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByCarrier.TabIndex = 0;
            this.checkBoxQueryByCarrier.TabStop = false;
            this.checkBoxQueryByCarrier.Text = "UID";
            this.checkBoxQueryByCarrier.UseVisualStyleBackColor = false;
            this.checkBoxQueryByCarrier.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // textBoxQueryReelArticleValue
            // 
            this.textBoxQueryReelArticleValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxQueryReelArticleValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQueryReelArticleValue.Enabled = false;
            this.textBoxQueryReelArticleValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxQueryReelArticleValue.Location = new System.Drawing.Point(1147, 2);
            this.textBoxQueryReelArticleValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxQueryReelArticleValue.Name = "textBoxQueryReelArticleValue";
            this.textBoxQueryReelArticleValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxQueryReelArticleValue.TabIndex = 0;
            this.textBoxQueryReelArticleValue.TabStop = false;
            this.textBoxQueryReelArticleValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxQueryReelCarrierValue
            // 
            this.textBoxQueryReelCarrierValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxQueryReelCarrierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQueryReelCarrierValue.Enabled = false;
            this.textBoxQueryReelCarrierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxQueryReelCarrierValue.Location = new System.Drawing.Point(1147, 37);
            this.textBoxQueryReelCarrierValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxQueryReelCarrierValue.Name = "textBoxQueryReelCarrierValue";
            this.textBoxQueryReelCarrierValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxQueryReelCarrierValue.TabIndex = 0;
            this.textBoxQueryReelCarrierValue.TabStop = false;
            this.textBoxQueryReelCarrierValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelQueryReelCreateDateCondition
            // 
            this.labelQueryReelCreateDateCondition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelQueryReelCreateDateCondition.Enabled = false;
            this.labelQueryReelCreateDateCondition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelQueryReelCreateDateCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.labelQueryReelCreateDateCondition.Location = new System.Drawing.Point(471, 105);
            this.labelQueryReelCreateDateCondition.Margin = new System.Windows.Forms.Padding(0);
            this.labelQueryReelCreateDateCondition.Name = "labelQueryReelCreateDateCondition";
            this.labelQueryReelCreateDateCondition.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelQueryReelCreateDateCondition.Size = new System.Drawing.Size(200, 32);
            this.labelQueryReelCreateDateCondition.TabIndex = 0;
            this.labelQueryReelCreateDateCondition.Text = "OPTION";
            this.labelQueryReelCreateDateCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox6QueryBySupplier
            // 
            this.checkBox6QueryBySupplier.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox6QueryBySupplier.AutoSize = true;
            this.checkBox6QueryBySupplier.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox6QueryBySupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox6QueryBySupplier.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBox6QueryBySupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox6QueryBySupplier.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBox6QueryBySupplier.Location = new System.Drawing.Point(944, 70);
            this.checkBox6QueryBySupplier.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox6QueryBySupplier.Name = "checkBox6QueryBySupplier";
            this.checkBox6QueryBySupplier.Size = new System.Drawing.Size(200, 32);
            this.checkBox6QueryBySupplier.TabIndex = 0;
            this.checkBox6QueryBySupplier.TabStop = false;
            this.checkBox6QueryBySupplier.Text = "SUPPLIER";
            this.checkBox6QueryBySupplier.UseVisualStyleBackColor = false;
            this.checkBox6QueryBySupplier.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // textBoxQueryReelSupplierValue
            // 
            this.textBoxQueryReelSupplierValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxQueryReelSupplierValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQueryReelSupplierValue.Enabled = false;
            this.textBoxQueryReelSupplierValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxQueryReelSupplierValue.Location = new System.Drawing.Point(1147, 72);
            this.textBoxQueryReelSupplierValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxQueryReelSupplierValue.Name = "textBoxQueryReelSupplierValue";
            this.textBoxQueryReelSupplierValue.Size = new System.Drawing.Size(265, 29);
            this.textBoxQueryReelSupplierValue.TabIndex = 0;
            this.textBoxQueryReelSupplierValue.TabStop = false;
            this.textBoxQueryReelSupplierValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxQueryByDatetime
            // 
            this.checkBoxQueryByDatetime.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByDatetime.AutoSize = true;
            this.checkBoxQueryByDatetime.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByDatetime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByDatetime.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByDatetime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByDatetime.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByDatetime.Location = new System.Drawing.Point(0, 105);
            this.checkBoxQueryByDatetime.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByDatetime.Name = "checkBoxQueryByDatetime";
            this.checkBoxQueryByDatetime.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByDatetime.TabIndex = 0;
            this.checkBoxQueryByDatetime.TabStop = false;
            this.checkBoxQueryByDatetime.Text = "DATE";
            this.checkBoxQueryByDatetime.UseVisualStyleBackColor = false;
            this.checkBoxQueryByDatetime.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // dateTimePickerQueryReeCreateDateValue
            // 
            this.dateTimePickerQueryReeCreateDateValue.CalendarFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerQueryReeCreateDateValue.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerQueryReeCreateDateValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerQueryReeCreateDateValue.Enabled = false;
            this.dateTimePickerQueryReeCreateDateValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerQueryReeCreateDateValue.Location = new System.Drawing.Point(206, 108);
            this.dateTimePickerQueryReeCreateDateValue.Name = "dateTimePickerQueryReeCreateDateValue";
            this.dateTimePickerQueryReeCreateDateValue.Size = new System.Drawing.Size(259, 29);
            this.dateTimePickerQueryReeCreateDateValue.TabIndex = 0;
            this.dateTimePickerQueryReeCreateDateValue.TabStop = false;
            // 
            // checkBoxQueryByQty
            // 
            this.checkBoxQueryByQty.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxQueryByQty.AutoSize = true;
            this.checkBoxQueryByQty.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxQueryByQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxQueryByQty.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.checkBoxQueryByQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxQueryByQty.ForeColor = System.Drawing.SystemColors.Window;
            this.checkBoxQueryByQty.Location = new System.Drawing.Point(944, 105);
            this.checkBoxQueryByQty.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxQueryByQty.Name = "checkBoxQueryByQty";
            this.checkBoxQueryByQty.Size = new System.Drawing.Size(200, 32);
            this.checkBoxQueryByQty.TabIndex = 0;
            this.checkBoxQueryByQty.TabStop = false;
            this.checkBoxQueryByQty.Text = "QTY";
            this.checkBoxQueryByQty.UseVisualStyleBackColor = false;
            this.checkBoxQueryByQty.CheckedChanged += new System.EventHandler(this.OnCheckedChangedQueryReels);
            // 
            // numericUpDownQueryReelQtyValue
            // 
            this.numericUpDownQueryReelQtyValue.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownQueryReelQtyValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownQueryReelQtyValue.Enabled = false;
            this.numericUpDownQueryReelQtyValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.numericUpDownQueryReelQtyValue.Location = new System.Drawing.Point(1147, 105);
            this.numericUpDownQueryReelQtyValue.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownQueryReelQtyValue.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDownQueryReelQtyValue.Name = "numericUpDownQueryReelQtyValue";
            this.numericUpDownQueryReelQtyValue.Size = new System.Drawing.Size(265, 29);
            this.numericUpDownQueryReelQtyValue.TabIndex = 0;
            this.numericUpDownQueryReelQtyValue.TabStop = false;
            this.numericUpDownQueryReelQtyValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxQueryReelQtyOptionValue
            // 
            this.comboBoxQueryReelQtyOptionValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxQueryReelQtyOptionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxQueryReelQtyOptionValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxQueryReelQtyOptionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryReelQtyOptionValue.Enabled = false;
            this.comboBoxQueryReelQtyOptionValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxQueryReelQtyOptionValue.FormattingEnabled = true;
            this.comboBoxQueryReelQtyOptionValue.Items.AddRange(new object[] {
            "Equal (==)",
            "Not equal to (!=)",
            "Less-than or equal to (<=)",
            "Less-than (<)",
            "Greater-than or equal to (>=)",
            "Greater-than (>)"});
            this.comboBoxQueryReelQtyOptionValue.Location = new System.Drawing.Point(1618, 105);
            this.comboBoxQueryReelQtyOptionValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxQueryReelQtyOptionValue.Name = "comboBoxQueryReelQtyOptionValue";
            this.comboBoxQueryReelQtyOptionValue.Size = new System.Drawing.Size(266, 30);
            this.comboBoxQueryReelQtyOptionValue.TabIndex = 0;
            this.comboBoxQueryReelQtyOptionValue.TabStop = false;
            this.comboBoxQueryReelQtyOptionValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // labelQueryReelQtyCondition
            // 
            this.labelQueryReelQtyCondition.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelQueryReelQtyCondition.Enabled = false;
            this.labelQueryReelQtyCondition.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelQueryReelQtyCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.labelQueryReelQtyCondition.Location = new System.Drawing.Point(1415, 105);
            this.labelQueryReelQtyCondition.Margin = new System.Windows.Forms.Padding(0);
            this.labelQueryReelQtyCondition.Name = "labelQueryReelQtyCondition";
            this.labelQueryReelQtyCondition.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelQueryReelQtyCondition.Size = new System.Drawing.Size(200, 32);
            this.labelQueryReelQtyCondition.TabIndex = 0;
            this.labelQueryReelQtyCondition.Text = "OPTION";
            this.labelQueryReelQtyCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxQueryResults
            // 
            this.tableLayoutPanelQueryReels.SetColumnSpan(this.groupBoxQueryResults, 17);
            this.groupBoxQueryResults.Controls.Add(this.dataGridViewQueryResults);
            this.groupBoxQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxQueryResults.Location = new System.Drawing.Point(3, 143);
            this.groupBoxQueryResults.Name = "groupBoxQueryResults";
            this.groupBoxQueryResults.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxQueryResults.Size = new System.Drawing.Size(1878, 480);
            this.groupBoxQueryResults.TabIndex = 2;
            this.groupBoxQueryResults.TabStop = false;
            this.groupBoxQueryResults.Text = " RESULTS ";
            // 
            // dataGridViewQueryResults
            // 
            this.dataGridViewQueryResults.AllowUserToAddRows = false;
            this.dataGridViewQueryResults.AllowUserToDeleteRows = false;
            this.dataGridViewQueryResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewQueryResults.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewQueryResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewQueryResults.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridViewQueryResults.Location = new System.Drawing.Point(7, 29);
            this.dataGridViewQueryResults.MultiSelect = false;
            this.dataGridViewQueryResults.Name = "dataGridViewQueryResults";
            this.dataGridViewQueryResults.RowHeadersVisible = false;
            this.dataGridViewQueryResults.RowTemplate.Height = 23;
            this.dataGridViewQueryResults.Size = new System.Drawing.Size(1864, 444);
            this.dataGridViewQueryResults.TabIndex = 0;
            this.dataGridViewQueryResults.TabStop = false;
            // 
            // buttonClearQueryReels
            // 
            this.buttonClearQueryReels.BackColor = System.Drawing.Color.LightCoral;
            this.buttonClearQueryReels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearQueryReels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearQueryReels.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonClearQueryReels.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonClearQueryReels.Location = new System.Drawing.Point(1418, 3);
            this.buttonClearQueryReels.Name = "buttonClearQueryReels";
            this.tableLayoutPanelQueryReels.SetRowSpan(this.buttonClearQueryReels, 3);
            this.buttonClearQueryReels.Size = new System.Drawing.Size(194, 61);
            this.buttonClearQueryReels.TabIndex = 0;
            this.buttonClearQueryReels.TabStop = false;
            this.buttonClearQueryReels.Text = "CLEAR";
            this.buttonClearQueryReels.UseVisualStyleBackColor = false;
            this.buttonClearQueryReels.Click += new System.EventHandler(this.OnClickButtonClearQueryReels);
            // 
            // comboBoxQueryDatetimeOptionValue
            // 
            this.comboBoxQueryDatetimeOptionValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelQueryReels.SetColumnSpan(this.comboBoxQueryDatetimeOptionValue, 3);
            this.comboBoxQueryDatetimeOptionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxQueryDatetimeOptionValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxQueryDatetimeOptionValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueryDatetimeOptionValue.Enabled = false;
            this.comboBoxQueryDatetimeOptionValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.comboBoxQueryDatetimeOptionValue.FormattingEnabled = true;
            this.comboBoxQueryDatetimeOptionValue.Items.AddRange(new object[] {
            "Equal (==)",
            "Not equal to (!=)",
            "Less-than or equal to (<=)",
            "Less-than (<)",
            "Greater-than or equal to (>=)",
            "Greater-than (>)"});
            this.comboBoxQueryDatetimeOptionValue.Location = new System.Drawing.Point(674, 105);
            this.comboBoxQueryDatetimeOptionValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxQueryDatetimeOptionValue.Name = "comboBoxQueryDatetimeOptionValue";
            this.comboBoxQueryDatetimeOptionValue.Size = new System.Drawing.Size(267, 30);
            this.comboBoxQueryDatetimeOptionValue.TabIndex = 0;
            this.comboBoxQueryDatetimeOptionValue.TabStop = false;
            this.comboBoxQueryDatetimeOptionValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // buttonMissmathSearch
            // 
            this.buttonMissmathSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMissmathSearch.Location = new System.Drawing.Point(677, 3);
            this.buttonMissmathSearch.Name = "buttonMissmathSearch";
            this.tableLayoutPanelQueryReels.SetRowSpan(this.buttonMissmathSearch, 3);
            this.buttonMissmathSearch.Size = new System.Drawing.Size(126, 61);
            this.buttonMissmathSearch.TabIndex = 14;
            this.buttonMissmathSearch.TabStop = false;
            this.buttonMissmathSearch.Text = "SEARCH";
            this.buttonMissmathSearch.UseVisualStyleBackColor = true;
            this.buttonMissmathSearch.Visible = false;
            this.buttonMissmathSearch.Click += new System.EventHandler(this.buttonMissmathSearch_Click);
            // 
            // radioButtonSearchAll
            // 
            this.radioButtonSearchAll.AutoSize = true;
            this.radioButtonSearchAll.Location = new System.Drawing.Point(677, 73);
            this.radioButtonSearchAll.Name = "radioButtonSearchAll";
            this.radioButtonSearchAll.Size = new System.Drawing.Size(65, 26);
            this.radioButtonSearchAll.TabIndex = 15;
            this.radioButtonSearchAll.Text = "ALL";
            this.radioButtonSearchAll.UseVisualStyleBackColor = true;
            this.radioButtonSearchAll.Visible = false;
            // 
            // radioButtonSerachMissmatch
            // 
            this.radioButtonSerachMissmatch.AutoSize = true;
            this.radioButtonSerachMissmatch.Checked = true;
            this.radioButtonSerachMissmatch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonSerachMissmatch.Location = new System.Drawing.Point(812, 73);
            this.radioButtonSerachMissmatch.Name = "radioButtonSerachMissmatch";
            this.radioButtonSerachMissmatch.Size = new System.Drawing.Size(123, 23);
            this.radioButtonSerachMissmatch.TabIndex = 16;
            this.radioButtonSerachMissmatch.TabStop = true;
            this.radioButtonSerachMissmatch.Text = "MISSMATCH";
            this.radioButtonSerachMissmatch.UseVisualStyleBackColor = true;
            this.radioButtonSerachMissmatch.Visible = false;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageAccount.Controls.Add(this.tableLayoutPanelAccountManager);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 44);
            this.tabPageAccount.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(1906, 887);
            this.tabPageAccount.TabIndex = 4;
            this.tabPageAccount.Text = "    ACCOUNT    ";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelAccountManager
            // 
            this.tableLayoutPanelAccountManager.ColumnCount = 2;
            this.tableLayoutPanelAccountManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccountManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccountManager.Controls.Add(this.groupBoxAccountManager, 0, 0);
            this.tableLayoutPanelAccountManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAccountManager.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanelAccountManager.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAccountManager.Name = "tableLayoutPanelAccountManager";
            this.tableLayoutPanelAccountManager.RowCount = 2;
            this.tableLayoutPanelAccountManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccountManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAccountManager.Size = new System.Drawing.Size(1904, 885);
            this.tableLayoutPanelAccountManager.TabIndex = 0;
            // 
            // groupBoxAccountManager
            // 
            this.groupBoxAccountManager.Controls.Add(this.buttonAccountManagerLogin);
            this.groupBoxAccountManager.Controls.Add(this.tableLayoutPanelAccountManagerLogin);
            this.groupBoxAccountManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAccountManager.Location = new System.Drawing.Point(3, 3);
            this.groupBoxAccountManager.Name = "groupBoxAccountManager";
            this.groupBoxAccountManager.Padding = new System.Windows.Forms.Padding(7, 32, 7, 7);
            this.groupBoxAccountManager.Size = new System.Drawing.Size(946, 436);
            this.groupBoxAccountManager.TabIndex = 0;
            this.groupBoxAccountManager.TabStop = false;
            this.groupBoxAccountManager.Text = " ACCOUNT MANAGER ";
            // 
            // buttonAccountManagerLogin
            // 
            this.buttonAccountManagerLogin.Location = new System.Drawing.Point(732, 8);
            this.buttonAccountManagerLogin.Name = "buttonAccountManagerLogin";
            this.buttonAccountManagerLogin.Size = new System.Drawing.Size(200, 40);
            this.buttonAccountManagerLogin.TabIndex = 2;
            this.buttonAccountManagerLogin.Text = "LOGIN";
            this.buttonAccountManagerLogin.UseVisualStyleBackColor = true;
            this.buttonAccountManagerLogin.Click += new System.EventHandler(this.OnClickButtonAccountManagerLogin);
            // 
            // tableLayoutPanelAccountManagerLogin
            // 
            this.tableLayoutPanelAccountManagerLogin.ColumnCount = 5;
            this.tableLayoutPanelAccountManagerLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelAccountManagerLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelAccountManagerLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccountManagerLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAccountManagerLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelAccountManagerLogin.Controls.Add(this.labelAccountManagerId, 1, 0);
            this.tableLayoutPanelAccountManagerLogin.Controls.Add(this.labelAccountManagerPassword, 1, 2);
            this.tableLayoutPanelAccountManagerLogin.Controls.Add(this.textBoxAccountManagerIdValue, 3, 0);
            this.tableLayoutPanelAccountManagerLogin.Controls.Add(this.textBoxAccountManagerPasswordValue, 3, 2);
            this.tableLayoutPanelAccountManagerLogin.Controls.Add(this.groupBoxNewAccount, 0, 4);
            this.tableLayoutPanelAccountManagerLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAccountManagerLogin.Location = new System.Drawing.Point(7, 54);
            this.tableLayoutPanelAccountManagerLogin.Name = "tableLayoutPanelAccountManagerLogin";
            this.tableLayoutPanelAccountManagerLogin.RowCount = 5;
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAccountManagerLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelAccountManagerLogin.Size = new System.Drawing.Size(932, 375);
            this.tableLayoutPanelAccountManagerLogin.TabIndex = 0;
            // 
            // labelAccountManagerId
            // 
            this.labelAccountManagerId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAccountManagerId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagerId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAccountManagerId.Location = new System.Drawing.Point(7, 0);
            this.labelAccountManagerId.Margin = new System.Windows.Forms.Padding(0);
            this.labelAccountManagerId.Name = "labelAccountManagerId";
            this.labelAccountManagerId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAccountManagerId.Size = new System.Drawing.Size(200, 32);
            this.labelAccountManagerId.TabIndex = 1;
            this.labelAccountManagerId.Text = "USER ID";
            this.labelAccountManagerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAccountManagerPassword
            // 
            this.labelAccountManagerPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelAccountManagerPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelAccountManagerPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.labelAccountManagerPassword.Location = new System.Drawing.Point(7, 35);
            this.labelAccountManagerPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelAccountManagerPassword.Name = "labelAccountManagerPassword";
            this.labelAccountManagerPassword.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelAccountManagerPassword.Size = new System.Drawing.Size(200, 32);
            this.labelAccountManagerPassword.TabIndex = 2;
            this.labelAccountManagerPassword.Text = "PASSWORD";
            this.labelAccountManagerPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAccountManagerIdValue
            // 
            this.textBoxAccountManagerIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAccountManagerIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAccountManagerIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxAccountManagerIdValue.Location = new System.Drawing.Point(210, 2);
            this.textBoxAccountManagerIdValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxAccountManagerIdValue.Name = "textBoxAccountManagerIdValue";
            this.textBoxAccountManagerIdValue.Size = new System.Drawing.Size(715, 29);
            this.textBoxAccountManagerIdValue.TabIndex = 0;
            // 
            // textBoxAccountManagerPasswordValue
            // 
            this.textBoxAccountManagerPasswordValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxAccountManagerPasswordValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAccountManagerPasswordValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxAccountManagerPasswordValue.Location = new System.Drawing.Point(210, 37);
            this.textBoxAccountManagerPasswordValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxAccountManagerPasswordValue.Name = "textBoxAccountManagerPasswordValue";
            this.textBoxAccountManagerPasswordValue.PasswordChar = '*';
            this.textBoxAccountManagerPasswordValue.Size = new System.Drawing.Size(715, 29);
            this.textBoxAccountManagerPasswordValue.TabIndex = 1;
            // 
            // groupBoxNewAccount
            // 
            this.tableLayoutPanelAccountManagerLogin.SetColumnSpan(this.groupBoxNewAccount, 6);
            this.groupBoxNewAccount.Controls.Add(this.buttonQueryUser);
            this.groupBoxNewAccount.Controls.Add(this.buttonRemoveUser);
            this.groupBoxNewAccount.Controls.Add(this.buttonAddNewUser);
            this.groupBoxNewAccount.Controls.Add(this.tableLayoutPanelAccount);
            this.groupBoxNewAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNewAccount.Location = new System.Drawing.Point(7, 77);
            this.groupBoxNewAccount.Margin = new System.Windows.Forms.Padding(7);
            this.groupBoxNewAccount.Name = "groupBoxNewAccount";
            this.groupBoxNewAccount.Padding = new System.Windows.Forms.Padding(7, 32, 7, 7);
            this.groupBoxNewAccount.Size = new System.Drawing.Size(918, 291);
            this.groupBoxNewAccount.TabIndex = 0;
            this.groupBoxNewAccount.TabStop = false;
            this.groupBoxNewAccount.Text = " CREATE / REMOVE USER  ";
            this.groupBoxNewAccount.Visible = false;
            this.groupBoxNewAccount.VisibleChanged += new System.EventHandler(this.OnVisibleChangedUserInformation);
            // 
            // buttonQueryUser
            // 
            this.buttonQueryUser.Location = new System.Drawing.Point(299, 0);
            this.buttonQueryUser.Name = "buttonQueryUser";
            this.buttonQueryUser.Size = new System.Drawing.Size(200, 40);
            this.buttonQueryUser.TabIndex = 0;
            this.buttonQueryUser.TabStop = false;
            this.buttonQueryUser.Text = "QUERY";
            this.buttonQueryUser.UseVisualStyleBackColor = true;
            this.buttonQueryUser.Click += new System.EventHandler(this.OnClickButtonQueryUser);
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveUser.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRemoveUser.Location = new System.Drawing.Point(505, 0);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(200, 40);
            this.buttonRemoveUser.TabIndex = 0;
            this.buttonRemoveUser.TabStop = false;
            this.buttonRemoveUser.Text = "REMOVE";
            this.buttonRemoveUser.UseVisualStyleBackColor = false;
            this.buttonRemoveUser.Click += new System.EventHandler(this.OnClickButtonRemoveUser);
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Location = new System.Drawing.Point(711, 0);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(200, 40);
            this.buttonAddNewUser.TabIndex = 0;
            this.buttonAddNewUser.TabStop = false;
            this.buttonAddNewUser.Text = "CREATE";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.OnClickButtonAddNewUser);
            // 
            // tableLayoutPanelAccount
            // 
            this.tableLayoutPanelAccount.ColumnCount = 3;
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAccount.Controls.Add(this.labelUserGroup, 0, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.comboBoxAccountGroupIdValue, 2, 0);
            this.tableLayoutPanelAccount.Controls.Add(this.labelUserRemark, 0, 8);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxUserFullnameValue, 2, 6);
            this.tableLayoutPanelAccount.Controls.Add(this.labelUserFullname, 0, 6);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxUserPasswordValue, 2, 4);
            this.tableLayoutPanelAccount.Controls.Add(this.labelUserPassword, 0, 4);
            this.tableLayoutPanelAccount.Controls.Add(this.labelUserId, 0, 2);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxUserIdValue, 2, 2);
            this.tableLayoutPanelAccount.Controls.Add(this.textBoxUserRemarkValue, 2, 8);
            this.tableLayoutPanelAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAccount.Location = new System.Drawing.Point(7, 54);
            this.tableLayoutPanelAccount.Name = "tableLayoutPanelAccount";
            this.tableLayoutPanelAccount.RowCount = 9;
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelAccount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAccount.Size = new System.Drawing.Size(904, 230);
            this.tableLayoutPanelAccount.TabIndex = 0;
            // 
            // labelUserGroup
            // 
            this.labelUserGroup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserGroup.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserGroup.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserGroup.Location = new System.Drawing.Point(0, 0);
            this.labelUserGroup.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserGroup.Name = "labelUserGroup";
            this.labelUserGroup.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelUserGroup.Size = new System.Drawing.Size(200, 32);
            this.labelUserGroup.TabIndex = 2;
            this.labelUserGroup.Text = "USER GROUP";
            this.labelUserGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxAccountGroupIdValue
            // 
            this.comboBoxAccountGroupIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAccountGroupIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAccountGroupIdValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAccountGroupIdValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccountGroupIdValue.FormattingEnabled = true;
            this.comboBoxAccountGroupIdValue.Items.AddRange(new object[] {
            "Operator",
            "Engineer",
            "Manager"});
            this.comboBoxAccountGroupIdValue.Location = new System.Drawing.Point(203, 0);
            this.comboBoxAccountGroupIdValue.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxAccountGroupIdValue.Name = "comboBoxAccountGroupIdValue";
            this.comboBoxAccountGroupIdValue.Size = new System.Drawing.Size(701, 30);
            this.comboBoxAccountGroupIdValue.TabIndex = 0;
            this.comboBoxAccountGroupIdValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // labelUserRemark
            // 
            this.labelUserRemark.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserRemark.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserRemark.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserRemark.Location = new System.Drawing.Point(0, 140);
            this.labelUserRemark.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserRemark.Name = "labelUserRemark";
            this.labelUserRemark.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelUserRemark.Size = new System.Drawing.Size(200, 90);
            this.labelUserRemark.TabIndex = 8;
            this.labelUserRemark.Text = "REMARK";
            this.labelUserRemark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserFullnameValue
            // 
            this.textBoxUserFullnameValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUserFullnameValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxUserFullnameValue.Location = new System.Drawing.Point(203, 107);
            this.textBoxUserFullnameValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxUserFullnameValue.Name = "textBoxUserFullnameValue";
            this.textBoxUserFullnameValue.Size = new System.Drawing.Size(701, 29);
            this.textBoxUserFullnameValue.TabIndex = 3;
            // 
            // labelUserFullname
            // 
            this.labelUserFullname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserFullname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserFullname.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserFullname.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserFullname.Location = new System.Drawing.Point(0, 105);
            this.labelUserFullname.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserFullname.Name = "labelUserFullname";
            this.labelUserFullname.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelUserFullname.Size = new System.Drawing.Size(200, 32);
            this.labelUserFullname.TabIndex = 6;
            this.labelUserFullname.Text = "NAME";
            this.labelUserFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserPasswordValue
            // 
            this.textBoxUserPasswordValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUserPasswordValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserPasswordValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxUserPasswordValue.Location = new System.Drawing.Point(203, 72);
            this.textBoxUserPasswordValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxUserPasswordValue.Name = "textBoxUserPasswordValue";
            this.textBoxUserPasswordValue.PasswordChar = '*';
            this.textBoxUserPasswordValue.Size = new System.Drawing.Size(701, 29);
            this.textBoxUserPasswordValue.TabIndex = 2;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserPassword.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserPassword.Location = new System.Drawing.Point(0, 70);
            this.labelUserPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelUserPassword.Size = new System.Drawing.Size(200, 32);
            this.labelUserPassword.TabIndex = 3;
            this.labelUserPassword.Text = "PASSWORD";
            this.labelUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUserId
            // 
            this.labelUserId.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelUserId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUserId.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelUserId.ForeColor = System.Drawing.SystemColors.Window;
            this.labelUserId.Location = new System.Drawing.Point(0, 35);
            this.labelUserId.Margin = new System.Windows.Forms.Padding(0);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelUserId.Size = new System.Drawing.Size(200, 32);
            this.labelUserId.TabIndex = 185;
            this.labelUserId.Text = "USER ID";
            this.labelUserId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxUserIdValue
            // 
            this.textBoxUserIdValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUserIdValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserIdValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxUserIdValue.Location = new System.Drawing.Point(203, 37);
            this.textBoxUserIdValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxUserIdValue.Name = "textBoxUserIdValue";
            this.textBoxUserIdValue.Size = new System.Drawing.Size(701, 29);
            this.textBoxUserIdValue.TabIndex = 1;
            // 
            // textBoxUserRemarkValue
            // 
            this.textBoxUserRemarkValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUserRemarkValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUserRemarkValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxUserRemarkValue.Location = new System.Drawing.Point(203, 142);
            this.textBoxUserRemarkValue.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.textBoxUserRemarkValue.Multiline = true;
            this.textBoxUserRemarkValue.Name = "textBoxUserRemarkValue";
            this.textBoxUserRemarkValue.Size = new System.Drawing.Size(701, 88);
            this.textBoxUserRemarkValue.TabIndex = 4;
            // 
            // tabPageReelTowerManager
            // 
            this.tabPageReelTowerManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageReelTowerManager.Location = new System.Drawing.Point(4, 44);
            this.tabPageReelTowerManager.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageReelTowerManager.Name = "tabPageReelTowerManager";
            this.tabPageReelTowerManager.Size = new System.Drawing.Size(1906, 887);
            this.tabPageReelTowerManager.TabIndex = 3;
            this.tabPageReelTowerManager.Text = "    MANAGER    ";
            this.tabPageReelTowerManager.UseVisualStyleBackColor = true;
            // 
            // tabPageReelTowerNotifier
            // 
            this.tabPageReelTowerNotifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageReelTowerNotifier.Controls.Add(this.tableLayoutPanelNotificationListener);
            this.tabPageReelTowerNotifier.Location = new System.Drawing.Point(4, 44);
            this.tabPageReelTowerNotifier.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageReelTowerNotifier.Name = "tabPageReelTowerNotifier";
            this.tabPageReelTowerNotifier.Size = new System.Drawing.Size(1906, 887);
            this.tabPageReelTowerNotifier.TabIndex = 5;
            this.tabPageReelTowerNotifier.Text = "    NOTIFIER    ";
            this.tabPageReelTowerNotifier.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelNotificationListener
            // 
            this.tableLayoutPanelNotificationListener.ColumnCount = 15;
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelNotificationListener.Controls.Add(this.listViewReelTowerGroupNotifications, 0, 2);
            this.tableLayoutPanelNotificationListener.Controls.Add(this.labelElapsed, 0, 0);
            this.tableLayoutPanelNotificationListener.Controls.Add(this.labelElapsedValue, 2, 0);
            this.tableLayoutPanelNotificationListener.Controls.Add(this.labelApplicationVersion, 4, 0);
            this.tableLayoutPanelNotificationListener.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNotificationListener.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.tableLayoutPanelNotificationListener.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelNotificationListener.Name = "tableLayoutPanelNotificationListener";
            this.tableLayoutPanelNotificationListener.RowCount = 5;
            this.tableLayoutPanelNotificationListener.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelNotificationListener.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNotificationListener.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNotificationListener.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelNotificationListener.Size = new System.Drawing.Size(1904, 885);
            this.tableLayoutPanelNotificationListener.TabIndex = 0;
            // 
            // listViewReelTowerGroupNotifications
            // 
            this.listViewReelTowerGroupNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelNotificationListener.SetColumnSpan(this.listViewReelTowerGroupNotifications, 16);
            this.listViewReelTowerGroupNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewReelTowerGroupNotifications.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.listViewReelTowerGroupNotifications.FullRowSelect = true;
            this.listViewReelTowerGroupNotifications.GridLines = true;
            this.listViewReelTowerGroupNotifications.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewReelTowerGroupNotifications.HideSelection = false;
            this.listViewReelTowerGroupNotifications.Location = new System.Drawing.Point(3, 46);
            this.listViewReelTowerGroupNotifications.MultiSelect = false;
            this.listViewReelTowerGroupNotifications.Name = "listViewReelTowerGroupNotifications";
            this.tableLayoutPanelNotificationListener.SetRowSpan(this.listViewReelTowerGroupNotifications, 3);
            this.listViewReelTowerGroupNotifications.Size = new System.Drawing.Size(1898, 836);
            this.listViewReelTowerGroupNotifications.TabIndex = 0;
            this.listViewReelTowerGroupNotifications.TabStop = false;
            this.listViewReelTowerGroupNotifications.UseCompatibleStateImageBehavior = false;
            this.listViewReelTowerGroupNotifications.View = System.Windows.Forms.View.Details;
            // 
            // labelElapsed
            // 
            this.labelElapsed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelElapsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelElapsed.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelElapsed.ForeColor = System.Drawing.SystemColors.Window;
            this.labelElapsed.Location = new System.Drawing.Point(0, 0);
            this.labelElapsed.Margin = new System.Windows.Forms.Padding(0);
            this.labelElapsed.Name = "labelElapsed";
            this.labelElapsed.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelElapsed.Size = new System.Drawing.Size(200, 40);
            this.labelElapsed.TabIndex = 3;
            this.labelElapsed.Text = "ELAPSED";
            this.labelElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelElapsedValue
            // 
            this.labelElapsedValue.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelElapsedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelElapsedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelElapsedValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelElapsedValue.ForeColor = System.Drawing.SystemColors.Window;
            this.labelElapsedValue.Location = new System.Drawing.Point(203, 0);
            this.labelElapsedValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelElapsedValue.Name = "labelElapsedValue";
            this.labelElapsedValue.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.labelElapsedValue.Size = new System.Drawing.Size(200, 40);
            this.labelElapsedValue.TabIndex = 4;
            this.labelElapsedValue.Text = "00.00:00:00.000";
            this.labelElapsedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelApplicationVersion
            // 
            this.labelApplicationVersion.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelApplicationVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelApplicationVersion.ForeColor = System.Drawing.SystemColors.Window;
            this.labelApplicationVersion.Location = new System.Drawing.Point(406, 0);
            this.labelApplicationVersion.Margin = new System.Windows.Forms.Padding(0);
            this.labelApplicationVersion.Name = "labelApplicationVersion";
            this.labelApplicationVersion.Size = new System.Drawing.Size(200, 40);
            this.labelApplicationVersion.TabIndex = 0;
            this.labelApplicationVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageConfig.Controls.Add(this.buttonSaveTower);
            this.tabPageConfig.Controls.Add(this.buttonSaveMaterialInformation);
            this.tabPageConfig.Controls.Add(this.groupBoxTower);
            this.tabPageConfig.Controls.Add(this.groupBoxMaterialInformation);
            this.tabPageConfig.Controls.Add(this.buttonSaveConfig);
            this.tabPageConfig.Controls.Add(this.groupBoxConfig);
            this.tabPageConfig.Controls.Add(this.buttonSaveCombineModules);
            this.tabPageConfig.Controls.Add(this.buttonSaveDevices);
            this.tabPageConfig.Controls.Add(this.groupBoxCombineModules);
            this.tabPageConfig.Controls.Add(this.groupBoxDevices);
            this.tabPageConfig.Controls.Add(this.buttonSaveDatabase);
            this.tabPageConfig.Controls.Add(this.buttonSaveGuiSettings);
            this.tabPageConfig.Controls.Add(this.buttonSaveModel);
            this.tabPageConfig.Controls.Add(this.groupBoxModel);
            this.tabPageConfig.Controls.Add(this.buttonSaveNetworks);
            this.tabPageConfig.Controls.Add(this.groupBoxNetworks);
            this.tabPageConfig.Controls.Add(this.groupBoxGuiSettings);
            this.tabPageConfig.Controls.Add(this.groupBoxDatabases);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 44);
            this.tabPageConfig.Margin = new System.Windows.Forms.Padding(7);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(1906, 887);
            this.tabPageConfig.TabIndex = 2;
            this.tabPageConfig.Text = "     CONFIG     ";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTower
            // 
            this.buttonSaveTower.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveTower.Location = new System.Drawing.Point(1134, 6);
            this.buttonSaveTower.Name = "buttonSaveTower";
            this.buttonSaveTower.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveTower.TabIndex = 218;
            this.buttonSaveTower.TabStop = false;
            this.buttonSaveTower.Text = "SAVE";
            this.buttonSaveTower.UseVisualStyleBackColor = true;
            this.buttonSaveTower.Click += new System.EventHandler(this.buttonSaveTower_Click);
            // 
            // buttonSaveMaterialInformation
            // 
            this.buttonSaveMaterialInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveMaterialInformation.Location = new System.Drawing.Point(1765, 104);
            this.buttonSaveMaterialInformation.Name = "buttonSaveMaterialInformation";
            this.buttonSaveMaterialInformation.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveMaterialInformation.TabIndex = 3;
            this.buttonSaveMaterialInformation.TabStop = false;
            this.buttonSaveMaterialInformation.Text = "SAVE";
            this.buttonSaveMaterialInformation.UseVisualStyleBackColor = true;
            this.buttonSaveMaterialInformation.Visible = false;
            this.buttonSaveMaterialInformation.Click += new System.EventHandler(this.OnClickButtonSaveMaterialInformation);
            // 
            // groupBoxTower
            // 
            this.groupBoxTower.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxTower.Controls.Add(this.tableLayoutPanelTower);
            this.groupBoxTower.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxTower.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxTower.Location = new System.Drawing.Point(641, 21);
            this.groupBoxTower.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxTower.Name = "groupBoxTower";
            this.groupBoxTower.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxTower.Size = new System.Drawing.Size(620, 165);
            this.groupBoxTower.TabIndex = 219;
            this.groupBoxTower.TabStop = false;
            this.groupBoxTower.Text = " TOWER ";
            // 
            // tableLayoutPanelTower
            // 
            this.tableLayoutPanelTower.ColumnCount = 5;
            this.tableLayoutPanelTower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelTower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelTower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelTower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTower.Controls.Add(this.dataGridViewTower, 0, 0);
            this.tableLayoutPanelTower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTower.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelTower.Name = "tableLayoutPanelTower";
            this.tableLayoutPanelTower.RowCount = 4;
            this.tableLayoutPanelTower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelTower.Size = new System.Drawing.Size(606, 129);
            this.tableLayoutPanelTower.TabIndex = 217;
            // 
            // dataGridViewTower
            // 
            this.dataGridViewTower.AllowUserToAddRows = false;
            this.dataGridViewTower.AllowUserToDeleteRows = false;
            this.dataGridViewTower.AllowUserToResizeRows = false;
            this.dataGridViewTower.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTower.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewComboBoxColumn});
            this.tableLayoutPanelTower.SetColumnSpan(this.dataGridViewTower, 5);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTower.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTower.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewTower.Name = "dataGridViewTower";
            this.dataGridViewTower.RowHeadersVisible = false;
            this.tableLayoutPanelTower.SetRowSpan(this.dataGridViewTower, 4);
            this.dataGridViewTower.RowTemplate.Height = 23;
            this.dataGridViewTower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTower.Size = new System.Drawing.Size(600, 123);
            this.dataGridViewTower.TabIndex = 0;
            this.dataGridViewTower.TabStop = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.FillWeight = 161.0406F;
            this.dataGridViewTextBoxColumn1.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn
            // 
            this.dataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn.FillWeight = 161.0406F;
            this.dataGridViewComboBoxColumn.HeaderText = "USAGE";
            this.dataGridViewComboBoxColumn.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.dataGridViewComboBoxColumn.Name = "dataGridViewComboBoxColumn";
            this.dataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // groupBoxMaterialInformation
            // 
            this.groupBoxMaterialInformation.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMaterialInformation.Controls.Add(this.tableLayoutPanelMaterialInformation);
            this.groupBoxMaterialInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxMaterialInformation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxMaterialInformation.Location = new System.Drawing.Point(1272, 119);
            this.groupBoxMaterialInformation.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxMaterialInformation.Name = "groupBoxMaterialInformation";
            this.groupBoxMaterialInformation.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxMaterialInformation.Size = new System.Drawing.Size(620, 746);
            this.groupBoxMaterialInformation.TabIndex = 4;
            this.groupBoxMaterialInformation.TabStop = false;
            this.groupBoxMaterialInformation.Text = " MATERIAL INFORMATION ";
            // 
            // tableLayoutPanelMaterialInformation
            // 
            this.tableLayoutPanelMaterialInformation.ColumnCount = 11;
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelMaterialInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.labelMaterialName, 0, 0);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.dataGridViewMaterialInformation, 0, 4);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.textBoxMaterialNameValue, 2, 0);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.labelMaterialType, 6, 0);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.comboBoxMaterialTypeValue, 8, 0);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.buttonDeleteMaterialInformation, 8, 2);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.buttonFindMaterialInformation, 0, 2);
            this.tableLayoutPanelMaterialInformation.Controls.Add(this.buttonAddMaterialInformation, 4, 2);
            this.tableLayoutPanelMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMaterialInformation.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelMaterialInformation.Name = "tableLayoutPanelMaterialInformation";
            this.tableLayoutPanelMaterialInformation.RowCount = 5;
            this.tableLayoutPanelMaterialInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelMaterialInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelMaterialInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMaterialInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanelMaterialInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMaterialInformation.Size = new System.Drawing.Size(606, 710);
            this.tableLayoutPanelMaterialInformation.TabIndex = 217;
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.AutoSize = true;
            this.labelMaterialName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMaterialName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaterialName.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelMaterialName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMaterialName.Location = new System.Drawing.Point(0, 0);
            this.labelMaterialName.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(100, 34);
            this.labelMaterialName.TabIndex = 1;
            this.labelMaterialName.Text = "SID";
            this.labelMaterialName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewMaterialInformation
            // 
            this.dataGridViewMaterialInformation.AllowUserToAddRows = false;
            this.dataGridViewMaterialInformation.AllowUserToDeleteRows = false;
            this.dataGridViewMaterialInformation.AllowUserToResizeRows = false;
            this.dataGridViewMaterialInformation.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMaterialInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMaterialInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMaterialInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnArticleName,
            this.TYPE});
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.dataGridViewMaterialInformation, 11);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMaterialInformation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMaterialInformation.Location = new System.Drawing.Point(3, 91);
            this.dataGridViewMaterialInformation.Name = "dataGridViewMaterialInformation";
            this.dataGridViewMaterialInformation.ReadOnly = true;
            this.dataGridViewMaterialInformation.RowHeadersVisible = false;
            this.dataGridViewMaterialInformation.RowTemplate.Height = 23;
            this.dataGridViewMaterialInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMaterialInformation.Size = new System.Drawing.Size(600, 616);
            this.dataGridViewMaterialInformation.TabIndex = 0;
            this.dataGridViewMaterialInformation.TabStop = false;
            // 
            // dataGridViewTextBoxColumnArticleName
            // 
            this.dataGridViewTextBoxColumnArticleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumnArticleName.FillWeight = 70F;
            this.dataGridViewTextBoxColumnArticleName.HeaderText = "SID";
            this.dataGridViewTextBoxColumnArticleName.Name = "dataGridViewTextBoxColumnArticleName";
            this.dataGridViewTextBoxColumnArticleName.ReadOnly = true;
            this.dataGridViewTextBoxColumnArticleName.ToolTipText = "The article name";
            // 
            // TYPE
            // 
            this.TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TYPE.FillWeight = 30F;
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            this.TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TYPE.ToolTipText = "Material type";
            // 
            // textBoxMaterialNameValue
            // 
            this.textBoxMaterialNameValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.textBoxMaterialNameValue, 3);
            this.textBoxMaterialNameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMaterialNameValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxMaterialNameValue.Location = new System.Drawing.Point(106, 3);
            this.textBoxMaterialNameValue.Name = "textBoxMaterialNameValue";
            this.textBoxMaterialNameValue.Size = new System.Drawing.Size(194, 29);
            this.textBoxMaterialNameValue.TabIndex = 3;
            this.textBoxMaterialNameValue.TabStop = false;
            this.textBoxMaterialNameValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaterialType
            // 
            this.labelMaterialType.AutoSize = true;
            this.labelMaterialType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelMaterialType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMaterialType.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelMaterialType.ForeColor = System.Drawing.SystemColors.Window;
            this.labelMaterialType.Location = new System.Drawing.Point(306, 0);
            this.labelMaterialType.Margin = new System.Windows.Forms.Padding(0);
            this.labelMaterialType.Name = "labelMaterialType";
            this.labelMaterialType.Size = new System.Drawing.Size(97, 34);
            this.labelMaterialType.TabIndex = 2;
            this.labelMaterialType.Text = "TYPE";
            this.labelMaterialType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMaterialTypeValue
            // 
            this.comboBoxMaterialTypeValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.comboBoxMaterialTypeValue, 3);
            this.comboBoxMaterialTypeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMaterialTypeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMaterialTypeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialTypeValue.FormattingEnabled = true;
            this.comboBoxMaterialTypeValue.Items.AddRange(new object[] {
            "ReelThickness4",
            "ReelThickness8",
            "ReelThickness12",
            "ReelThickness16",
            "ReelThickness24",
            "ReelThickness32",
            "ReelThickness44",
            "ReelThickness56",
            "ReelThickness72"});
            this.comboBoxMaterialTypeValue.Location = new System.Drawing.Point(409, 3);
            this.comboBoxMaterialTypeValue.Name = "comboBoxMaterialTypeValue";
            this.comboBoxMaterialTypeValue.Size = new System.Drawing.Size(194, 30);
            this.comboBoxMaterialTypeValue.TabIndex = 9;
            this.comboBoxMaterialTypeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // buttonDeleteMaterialInformation
            // 
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.buttonDeleteMaterialInformation, 3);
            this.buttonDeleteMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteMaterialInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteMaterialInformation.Location = new System.Drawing.Point(406, 41);
            this.buttonDeleteMaterialInformation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteMaterialInformation.Name = "buttonDeleteMaterialInformation";
            this.buttonDeleteMaterialInformation.Size = new System.Drawing.Size(200, 40);
            this.buttonDeleteMaterialInformation.TabIndex = 7;
            this.buttonDeleteMaterialInformation.TabStop = false;
            this.buttonDeleteMaterialInformation.Text = "REMOVE";
            this.buttonDeleteMaterialInformation.UseVisualStyleBackColor = true;
            this.buttonDeleteMaterialInformation.Click += new System.EventHandler(this.OnClickButtonDeleteMaterialInformation);
            // 
            // buttonFindMaterialInformation
            // 
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.buttonFindMaterialInformation, 3);
            this.buttonFindMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFindMaterialInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonFindMaterialInformation.Location = new System.Drawing.Point(0, 41);
            this.buttonFindMaterialInformation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFindMaterialInformation.Name = "buttonFindMaterialInformation";
            this.buttonFindMaterialInformation.Size = new System.Drawing.Size(200, 40);
            this.buttonFindMaterialInformation.TabIndex = 8;
            this.buttonFindMaterialInformation.TabStop = false;
            this.buttonFindMaterialInformation.Text = "SEARCH";
            this.buttonFindMaterialInformation.UseVisualStyleBackColor = true;
            this.buttonFindMaterialInformation.Click += new System.EventHandler(this.OnClickButtonFindMaterialInformation);
            // 
            // buttonAddMaterialInformation
            // 
            this.tableLayoutPanelMaterialInformation.SetColumnSpan(this.buttonAddMaterialInformation, 3);
            this.buttonAddMaterialInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddMaterialInformation.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonAddMaterialInformation.Location = new System.Drawing.Point(203, 41);
            this.buttonAddMaterialInformation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddMaterialInformation.Name = "buttonAddMaterialInformation";
            this.buttonAddMaterialInformation.Size = new System.Drawing.Size(200, 40);
            this.buttonAddMaterialInformation.TabIndex = 5;
            this.buttonAddMaterialInformation.TabStop = false;
            this.buttonAddMaterialInformation.Text = "ADD";
            this.buttonAddMaterialInformation.UseVisualStyleBackColor = true;
            this.buttonAddMaterialInformation.Click += new System.EventHandler(this.OnClickButtonAddMaterialInformation_);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveConfig.Location = new System.Drawing.Point(503, 6);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveConfig.TabIndex = 0;
            this.buttonSaveConfig.TabStop = false;
            this.buttonSaveConfig.Text = "SAVE";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Visible = false;
            this.buttonSaveConfig.Click += new System.EventHandler(this.OnClickButtonSaveConfig);
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.tableLayoutPanelProperties);
            this.groupBoxConfig.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxConfig.Location = new System.Drawing.Point(10, 21);
            this.groupBoxConfig.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxConfig.Size = new System.Drawing.Size(620, 411);
            this.groupBoxConfig.TabIndex = 2;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = " PROPERTIES ";
            // 
            // tableLayoutPanelProperties
            // 
            this.tableLayoutPanelProperties.ColumnCount = 3;
            this.tableLayoutPanelProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxAMMWebserviceUsageValue, 1, 11);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxAMMWebserviceUsage, 0, 11);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxRejectAutoUsageValue, 1, 10);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxRejectAutoUsage, 0, 10);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxAMMUsageValue, 1, 9);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxAMMUsage, 0, 9);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxAssignedRejectPortValue, 1, 6);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxAssignedRejectPort, 0, 6);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxTimeoutOfReject, 0, 5);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxJobSplitReelCount, 0, 4);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxReelHandlerUsage, 0, 3);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxMaterialValidation, 0, 0);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxMaterialArriveReport, 0, 1);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxMaterialRemoveReport, 0, 2);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxMaterialValidationValue, 1, 0);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxMaterialArriveReportValue, 1, 1);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxMaterialRemoveReportValue, 1, 2);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxReelHandlerUsageValue, 1, 3);
            this.tableLayoutPanelProperties.Controls.Add(this.numericUpDownJobSplitReelCountValue, 1, 4);
            this.tableLayoutPanelProperties.Controls.Add(this.numericUpDownTimeoutOfRejectValue, 1, 5);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxProvideMode, 0, 8);
            this.tableLayoutPanelProperties.Controls.Add(this.checkBoxRemapCreateTimeByMFG, 0, 7);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxProvideModeValue, 1, 8);
            this.tableLayoutPanelProperties.Controls.Add(this.comboBoxRemapCreateTimeByMFGValue, 1, 7);
            this.tableLayoutPanelProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProperties.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelProperties.Name = "tableLayoutPanelProperties";
            this.tableLayoutPanelProperties.RowCount = 12;
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333402F));
            this.tableLayoutPanelProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.33257F));
            this.tableLayoutPanelProperties.Size = new System.Drawing.Size(606, 375);
            this.tableLayoutPanelProperties.TabIndex = 0;
            // 
            // comboBoxAMMWebserviceUsageValue
            // 
            this.comboBoxAMMWebserviceUsageValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAMMWebserviceUsageValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAMMWebserviceUsageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAMMWebserviceUsageValue.FormattingEnabled = true;
            this.comboBoxAMMWebserviceUsageValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxAMMWebserviceUsageValue.Location = new System.Drawing.Point(369, 344);
            this.comboBoxAMMWebserviceUsageValue.Name = "comboBoxAMMWebserviceUsageValue";
            this.comboBoxAMMWebserviceUsageValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxAMMWebserviceUsageValue.TabIndex = 12;
            this.comboBoxAMMWebserviceUsageValue.TabStop = false;
            this.comboBoxAMMWebserviceUsageValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxAMMWebserviceUsageValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // checkBoxAMMWebserviceUsage
            // 
            this.checkBoxAMMWebserviceUsage.AutoSize = true;
            this.checkBoxAMMWebserviceUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAMMWebserviceUsage.Location = new System.Drawing.Point(3, 344);
            this.checkBoxAMMWebserviceUsage.Name = "checkBoxAMMWebserviceUsage";
            this.checkBoxAMMWebserviceUsage.Size = new System.Drawing.Size(360, 28);
            this.checkBoxAMMWebserviceUsage.TabIndex = 11;
            this.checkBoxAMMWebserviceUsage.TabStop = false;
            this.checkBoxAMMWebserviceUsage.Text = "AMM WebService Usage";
            this.checkBoxAMMWebserviceUsage.UseVisualStyleBackColor = true;
            // 
            // comboBoxRejectAutoUsageValue
            // 
            this.comboBoxRejectAutoUsageValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxRejectAutoUsageValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRejectAutoUsageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRejectAutoUsageValue.FormattingEnabled = true;
            this.comboBoxRejectAutoUsageValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxRejectAutoUsageValue.Location = new System.Drawing.Point(369, 313);
            this.comboBoxRejectAutoUsageValue.Name = "comboBoxRejectAutoUsageValue";
            this.comboBoxRejectAutoUsageValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxRejectAutoUsageValue.TabIndex = 10;
            this.comboBoxRejectAutoUsageValue.TabStop = false;
            this.comboBoxRejectAutoUsageValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxRejectAutoUsageValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // checkBoxRejectAutoUsage
            // 
            this.checkBoxRejectAutoUsage.AutoSize = true;
            this.checkBoxRejectAutoUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxRejectAutoUsage.Location = new System.Drawing.Point(3, 313);
            this.checkBoxRejectAutoUsage.Name = "checkBoxRejectAutoUsage";
            this.checkBoxRejectAutoUsage.Size = new System.Drawing.Size(360, 25);
            this.checkBoxRejectAutoUsage.TabIndex = 9;
            this.checkBoxRejectAutoUsage.TabStop = false;
            this.checkBoxRejectAutoUsage.Text = "Reject Auto Usage";
            this.checkBoxRejectAutoUsage.UseVisualStyleBackColor = true;
            // 
            // comboBoxAMMUsageValue
            // 
            this.comboBoxAMMUsageValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAMMUsageValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAMMUsageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAMMUsageValue.FormattingEnabled = true;
            this.comboBoxAMMUsageValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxAMMUsageValue.Location = new System.Drawing.Point(369, 282);
            this.comboBoxAMMUsageValue.Name = "comboBoxAMMUsageValue";
            this.comboBoxAMMUsageValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxAMMUsageValue.TabIndex = 8;
            this.comboBoxAMMUsageValue.TabStop = false;
            this.comboBoxAMMUsageValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxAMMUsageValue.SelectedIndexChanged += new System.EventHandler(this.comboBoxAMMUsageValue_SelectedIndexChanged);
            this.comboBoxAMMUsageValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // checkBoxAMMUsage
            // 
            this.checkBoxAMMUsage.AutoSize = true;
            this.checkBoxAMMUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAMMUsage.Location = new System.Drawing.Point(3, 282);
            this.checkBoxAMMUsage.Name = "checkBoxAMMUsage";
            this.checkBoxAMMUsage.Size = new System.Drawing.Size(360, 25);
            this.checkBoxAMMUsage.TabIndex = 7;
            this.checkBoxAMMUsage.TabStop = false;
            this.checkBoxAMMUsage.Text = "AMM Usage";
            this.checkBoxAMMUsage.UseVisualStyleBackColor = true;
            // 
            // comboBoxAssignedRejectPortValue
            // 
            this.comboBoxAssignedRejectPortValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAssignedRejectPortValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxAssignedRejectPortValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAssignedRejectPortValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAssignedRejectPortValue.FormattingEnabled = true;
            this.comboBoxAssignedRejectPortValue.Location = new System.Drawing.Point(369, 189);
            this.comboBoxAssignedRejectPortValue.Name = "comboBoxAssignedRejectPortValue";
            this.comboBoxAssignedRejectPortValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxAssignedRejectPortValue.TabIndex = 6;
            this.comboBoxAssignedRejectPortValue.TabStop = false;
            this.comboBoxAssignedRejectPortValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxAssignedRejectPortValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // checkBoxAssignedRejectPort
            // 
            this.checkBoxAssignedRejectPort.AutoSize = true;
            this.checkBoxAssignedRejectPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxAssignedRejectPort.Location = new System.Drawing.Point(3, 189);
            this.checkBoxAssignedRejectPort.Name = "checkBoxAssignedRejectPort";
            this.checkBoxAssignedRejectPort.Size = new System.Drawing.Size(360, 25);
            this.checkBoxAssignedRejectPort.TabIndex = 6;
            this.checkBoxAssignedRejectPort.TabStop = false;
            this.checkBoxAssignedRejectPort.Text = "Assigned reject port";
            this.checkBoxAssignedRejectPort.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimeoutOfReject
            // 
            this.checkBoxTimeoutOfReject.AutoSize = true;
            this.checkBoxTimeoutOfReject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxTimeoutOfReject.Location = new System.Drawing.Point(3, 158);
            this.checkBoxTimeoutOfReject.Name = "checkBoxTimeoutOfReject";
            this.checkBoxTimeoutOfReject.Size = new System.Drawing.Size(360, 25);
            this.checkBoxTimeoutOfReject.TabIndex = 1;
            this.checkBoxTimeoutOfReject.TabStop = false;
            this.checkBoxTimeoutOfReject.Text = "Timeout of reject judgement";
            this.checkBoxTimeoutOfReject.UseVisualStyleBackColor = true;
            // 
            // checkBoxJobSplitReelCount
            // 
            this.checkBoxJobSplitReelCount.AutoSize = true;
            this.checkBoxJobSplitReelCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxJobSplitReelCount.Location = new System.Drawing.Point(3, 127);
            this.checkBoxJobSplitReelCount.Name = "checkBoxJobSplitReelCount";
            this.checkBoxJobSplitReelCount.Size = new System.Drawing.Size(360, 25);
            this.checkBoxJobSplitReelCount.TabIndex = 0;
            this.checkBoxJobSplitReelCount.TabStop = false;
            this.checkBoxJobSplitReelCount.Text = "Job split reel count";
            this.checkBoxJobSplitReelCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxReelHandlerUsage
            // 
            this.checkBoxReelHandlerUsage.AutoSize = true;
            this.checkBoxReelHandlerUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxReelHandlerUsage.Location = new System.Drawing.Point(3, 96);
            this.checkBoxReelHandlerUsage.Name = "checkBoxReelHandlerUsage";
            this.checkBoxReelHandlerUsage.Size = new System.Drawing.Size(360, 25);
            this.checkBoxReelHandlerUsage.TabIndex = 0;
            this.checkBoxReelHandlerUsage.TabStop = false;
            this.checkBoxReelHandlerUsage.Text = "Reel handler usage";
            this.checkBoxReelHandlerUsage.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaterialValidation
            // 
            this.checkBoxMaterialValidation.AutoSize = true;
            this.checkBoxMaterialValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMaterialValidation.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMaterialValidation.Name = "checkBoxMaterialValidation";
            this.checkBoxMaterialValidation.Size = new System.Drawing.Size(360, 25);
            this.checkBoxMaterialValidation.TabIndex = 0;
            this.checkBoxMaterialValidation.TabStop = false;
            this.checkBoxMaterialValidation.Text = "Material validation";
            this.checkBoxMaterialValidation.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaterialArriveReport
            // 
            this.checkBoxMaterialArriveReport.AutoSize = true;
            this.checkBoxMaterialArriveReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMaterialArriveReport.Location = new System.Drawing.Point(3, 34);
            this.checkBoxMaterialArriveReport.Name = "checkBoxMaterialArriveReport";
            this.checkBoxMaterialArriveReport.Size = new System.Drawing.Size(360, 25);
            this.checkBoxMaterialArriveReport.TabIndex = 0;
            this.checkBoxMaterialArriveReport.TabStop = false;
            this.checkBoxMaterialArriveReport.Text = "Material arrive report";
            this.checkBoxMaterialArriveReport.UseVisualStyleBackColor = true;
            // 
            // checkBoxMaterialRemoveReport
            // 
            this.checkBoxMaterialRemoveReport.AutoSize = true;
            this.checkBoxMaterialRemoveReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxMaterialRemoveReport.Location = new System.Drawing.Point(3, 65);
            this.checkBoxMaterialRemoveReport.Name = "checkBoxMaterialRemoveReport";
            this.checkBoxMaterialRemoveReport.Size = new System.Drawing.Size(360, 25);
            this.checkBoxMaterialRemoveReport.TabIndex = 0;
            this.checkBoxMaterialRemoveReport.TabStop = false;
            this.checkBoxMaterialRemoveReport.Text = "Material remove report";
            this.checkBoxMaterialRemoveReport.UseVisualStyleBackColor = true;
            // 
            // comboBoxMaterialValidationValue
            // 
            this.comboBoxMaterialValidationValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMaterialValidationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMaterialValidationValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMaterialValidationValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialValidationValue.FormattingEnabled = true;
            this.comboBoxMaterialValidationValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxMaterialValidationValue.Location = new System.Drawing.Point(369, 3);
            this.comboBoxMaterialValidationValue.Name = "comboBoxMaterialValidationValue";
            this.comboBoxMaterialValidationValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxMaterialValidationValue.TabIndex = 0;
            this.comboBoxMaterialValidationValue.TabStop = false;
            this.comboBoxMaterialValidationValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxMaterialValidationValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // comboBoxMaterialArriveReportValue
            // 
            this.comboBoxMaterialArriveReportValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMaterialArriveReportValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMaterialArriveReportValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMaterialArriveReportValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialArriveReportValue.FormattingEnabled = true;
            this.comboBoxMaterialArriveReportValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxMaterialArriveReportValue.Location = new System.Drawing.Point(369, 34);
            this.comboBoxMaterialArriveReportValue.Name = "comboBoxMaterialArriveReportValue";
            this.comboBoxMaterialArriveReportValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxMaterialArriveReportValue.TabIndex = 0;
            this.comboBoxMaterialArriveReportValue.TabStop = false;
            this.comboBoxMaterialArriveReportValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxMaterialArriveReportValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // comboBoxMaterialRemoveReportValue
            // 
            this.comboBoxMaterialRemoveReportValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxMaterialRemoveReportValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMaterialRemoveReportValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMaterialRemoveReportValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterialRemoveReportValue.FormattingEnabled = true;
            this.comboBoxMaterialRemoveReportValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxMaterialRemoveReportValue.Location = new System.Drawing.Point(369, 65);
            this.comboBoxMaterialRemoveReportValue.Name = "comboBoxMaterialRemoveReportValue";
            this.comboBoxMaterialRemoveReportValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxMaterialRemoveReportValue.TabIndex = 0;
            this.comboBoxMaterialRemoveReportValue.TabStop = false;
            this.comboBoxMaterialRemoveReportValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxMaterialRemoveReportValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // comboBoxReelHandlerUsageValue
            // 
            this.comboBoxReelHandlerUsageValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxReelHandlerUsageValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxReelHandlerUsageValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxReelHandlerUsageValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReelHandlerUsageValue.FormattingEnabled = true;
            this.comboBoxReelHandlerUsageValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxReelHandlerUsageValue.Location = new System.Drawing.Point(369, 96);
            this.comboBoxReelHandlerUsageValue.Name = "comboBoxReelHandlerUsageValue";
            this.comboBoxReelHandlerUsageValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxReelHandlerUsageValue.TabIndex = 0;
            this.comboBoxReelHandlerUsageValue.TabStop = false;
            this.comboBoxReelHandlerUsageValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxReelHandlerUsageValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // numericUpDownJobSplitReelCountValue
            // 
            this.numericUpDownJobSplitReelCountValue.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownJobSplitReelCountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownJobSplitReelCountValue.Location = new System.Drawing.Point(369, 127);
            this.numericUpDownJobSplitReelCountValue.Name = "numericUpDownJobSplitReelCountValue";
            this.numericUpDownJobSplitReelCountValue.Size = new System.Drawing.Size(114, 29);
            this.numericUpDownJobSplitReelCountValue.TabIndex = 0;
            this.numericUpDownJobSplitReelCountValue.TabStop = false;
            this.numericUpDownJobSplitReelCountValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownJobSplitReelCountValue.ValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // numericUpDownTimeoutOfRejectValue
            // 
            this.numericUpDownTimeoutOfRejectValue.BackColor = System.Drawing.SystemColors.Info;
            this.numericUpDownTimeoutOfRejectValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownTimeoutOfRejectValue.Location = new System.Drawing.Point(369, 158);
            this.numericUpDownTimeoutOfRejectValue.Name = "numericUpDownTimeoutOfRejectValue";
            this.numericUpDownTimeoutOfRejectValue.Size = new System.Drawing.Size(114, 29);
            this.numericUpDownTimeoutOfRejectValue.TabIndex = 2;
            this.numericUpDownTimeoutOfRejectValue.TabStop = false;
            this.numericUpDownTimeoutOfRejectValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTimeoutOfRejectValue.ValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // checkBoxProvideMode
            // 
            this.checkBoxProvideMode.AutoSize = true;
            this.checkBoxProvideMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxProvideMode.Location = new System.Drawing.Point(3, 251);
            this.checkBoxProvideMode.Name = "checkBoxProvideMode";
            this.checkBoxProvideMode.Size = new System.Drawing.Size(360, 25);
            this.checkBoxProvideMode.TabIndex = 5;
            this.checkBoxProvideMode.TabStop = false;
            this.checkBoxProvideMode.Text = "Provide mode";
            this.checkBoxProvideMode.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemapCreateTimeByMFG
            // 
            this.checkBoxRemapCreateTimeByMFG.AutoSize = true;
            this.checkBoxRemapCreateTimeByMFG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxRemapCreateTimeByMFG.Location = new System.Drawing.Point(3, 220);
            this.checkBoxRemapCreateTimeByMFG.Name = "checkBoxRemapCreateTimeByMFG";
            this.checkBoxRemapCreateTimeByMFG.Size = new System.Drawing.Size(360, 25);
            this.checkBoxRemapCreateTimeByMFG.TabIndex = 5;
            this.checkBoxRemapCreateTimeByMFG.TabStop = false;
            this.checkBoxRemapCreateTimeByMFG.Text = "Remap create time by MFG";
            this.checkBoxRemapCreateTimeByMFG.UseVisualStyleBackColor = true;
            // 
            // comboBoxProvideModeValue
            // 
            this.comboBoxProvideModeValue.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelProperties.SetColumnSpan(this.comboBoxProvideModeValue, 2);
            this.comboBoxProvideModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxProvideModeValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxProvideModeValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProvideModeValue.FormattingEnabled = true;
            this.comboBoxProvideModeValue.Items.AddRange(new object[] {
            "ByCreateTime",
            "ByOrderSequence"});
            this.comboBoxProvideModeValue.Location = new System.Drawing.Point(369, 251);
            this.comboBoxProvideModeValue.Name = "comboBoxProvideModeValue";
            this.comboBoxProvideModeValue.Size = new System.Drawing.Size(234, 30);
            this.comboBoxProvideModeValue.TabIndex = 5;
            this.comboBoxProvideModeValue.TabStop = false;
            this.comboBoxProvideModeValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxProvideModeValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // comboBoxRemapCreateTimeByMFGValue
            // 
            this.comboBoxRemapCreateTimeByMFGValue.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxRemapCreateTimeByMFGValue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxRemapCreateTimeByMFGValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemapCreateTimeByMFGValue.FormattingEnabled = true;
            this.comboBoxRemapCreateTimeByMFGValue.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxRemapCreateTimeByMFGValue.Location = new System.Drawing.Point(369, 220);
            this.comboBoxRemapCreateTimeByMFGValue.Name = "comboBoxRemapCreateTimeByMFGValue";
            this.comboBoxRemapCreateTimeByMFGValue.Size = new System.Drawing.Size(114, 30);
            this.comboBoxRemapCreateTimeByMFGValue.TabIndex = 5;
            this.comboBoxRemapCreateTimeByMFGValue.TabStop = false;
            this.comboBoxRemapCreateTimeByMFGValue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            this.comboBoxRemapCreateTimeByMFGValue.SelectedValueChanged += new System.EventHandler(this.OnComboBoxSelectedIndexChangedProperty);
            // 
            // buttonSaveCombineModules
            // 
            this.buttonSaveCombineModules.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveCombineModules.Location = new System.Drawing.Point(1134, 615);
            this.buttonSaveCombineModules.Name = "buttonSaveCombineModules";
            this.buttonSaveCombineModules.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveCombineModules.TabIndex = 0;
            this.buttonSaveCombineModules.TabStop = false;
            this.buttonSaveCombineModules.Text = "SAVE";
            this.buttonSaveCombineModules.UseVisualStyleBackColor = true;
            this.buttonSaveCombineModules.Visible = false;
            // 
            // buttonSaveDevices
            // 
            this.buttonSaveDevices.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveDevices.Location = new System.Drawing.Point(1134, 504);
            this.buttonSaveDevices.Name = "buttonSaveDevices";
            this.buttonSaveDevices.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveDevices.TabIndex = 0;
            this.buttonSaveDevices.TabStop = false;
            this.buttonSaveDevices.Text = "SAVE";
            this.buttonSaveDevices.UseVisualStyleBackColor = true;
            this.buttonSaveDevices.Visible = false;
            // 
            // groupBoxCombineModules
            // 
            this.groupBoxCombineModules.Controls.Add(this.tableLayoutPanelCombineModules);
            this.groupBoxCombineModules.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxCombineModules.Location = new System.Drawing.Point(641, 630);
            this.groupBoxCombineModules.Name = "groupBoxCombineModules";
            this.groupBoxCombineModules.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxCombineModules.Size = new System.Drawing.Size(620, 96);
            this.groupBoxCombineModules.TabIndex = 0;
            this.groupBoxCombineModules.TabStop = false;
            this.groupBoxCombineModules.Text = " COMBINE MODULES ";
            // 
            // tableLayoutPanelCombineModules
            // 
            this.tableLayoutPanelCombineModules.ColumnCount = 5;
            this.tableLayoutPanelCombineModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanelCombineModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelCombineModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanelCombineModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelCombineModules.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelCombineModules.Controls.Add(this.dataGridViewCombineModules, 0, 0);
            this.tableLayoutPanelCombineModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCombineModules.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelCombineModules.Name = "tableLayoutPanelCombineModules";
            this.tableLayoutPanelCombineModules.RowCount = 5;
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCombineModules.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCombineModules.Size = new System.Drawing.Size(606, 60);
            this.tableLayoutPanelCombineModules.TabIndex = 220;
            // 
            // dataGridViewCombineModules
            // 
            this.dataGridViewCombineModules.AllowUserToAddRows = false;
            this.dataGridViewCombineModules.AllowUserToDeleteRows = false;
            this.dataGridViewCombineModules.AllowUserToResizeRows = false;
            this.dataGridViewCombineModules.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCombineModules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCombineModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCombineModules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfCombineModuleIndex,
            this.ColumnOfCombineModuleName,
            this.ColumnOfCombineModulePath,
            this.ColumnOfCombineModuleCaption});
            this.tableLayoutPanelCombineModules.SetColumnSpan(this.dataGridViewCombineModules, 5);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCombineModules.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewCombineModules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCombineModules.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCombineModules.Name = "dataGridViewCombineModules";
            this.dataGridViewCombineModules.ReadOnly = true;
            this.dataGridViewCombineModules.RowHeadersVisible = false;
            this.tableLayoutPanelCombineModules.SetRowSpan(this.dataGridViewCombineModules, 5);
            this.dataGridViewCombineModules.RowTemplate.Height = 23;
            this.dataGridViewCombineModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCombineModules.Size = new System.Drawing.Size(600, 54);
            this.dataGridViewCombineModules.TabIndex = 0;
            this.dataGridViewCombineModules.TabStop = false;
            // 
            // ColumnOfCombineModuleIndex
            // 
            this.ColumnOfCombineModuleIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfCombineModuleIndex.FillWeight = 60F;
            this.ColumnOfCombineModuleIndex.HeaderText = "NO";
            this.ColumnOfCombineModuleIndex.Name = "ColumnOfCombineModuleIndex";
            this.ColumnOfCombineModuleIndex.ReadOnly = true;
            this.ColumnOfCombineModuleIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnOfCombineModuleName
            // 
            this.ColumnOfCombineModuleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfCombineModuleName.FillWeight = 140F;
            this.ColumnOfCombineModuleName.HeaderText = "NAME";
            this.ColumnOfCombineModuleName.Name = "ColumnOfCombineModuleName";
            this.ColumnOfCombineModuleName.ReadOnly = true;
            // 
            // ColumnOfCombineModulePath
            // 
            this.ColumnOfCombineModulePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfCombineModulePath.FillWeight = 200F;
            this.ColumnOfCombineModulePath.HeaderText = "PATH";
            this.ColumnOfCombineModulePath.Name = "ColumnOfCombineModulePath";
            this.ColumnOfCombineModulePath.ReadOnly = true;
            // 
            // ColumnOfCombineModuleCaption
            // 
            this.ColumnOfCombineModuleCaption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfCombineModuleCaption.FillWeight = 140F;
            this.ColumnOfCombineModuleCaption.HeaderText = "CAPTION";
            this.ColumnOfCombineModuleCaption.Name = "ColumnOfCombineModuleCaption";
            this.ColumnOfCombineModuleCaption.ReadOnly = true;
            // 
            // groupBoxDevices
            // 
            this.groupBoxDevices.Controls.Add(this.tableLayoutPanelDevices);
            this.groupBoxDevices.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxDevices.Location = new System.Drawing.Point(641, 519);
            this.groupBoxDevices.Name = "groupBoxDevices";
            this.groupBoxDevices.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxDevices.Size = new System.Drawing.Size(620, 96);
            this.groupBoxDevices.TabIndex = 0;
            this.groupBoxDevices.TabStop = false;
            this.groupBoxDevices.Text = " DEVICES ";
            // 
            // tableLayoutPanelDevices
            // 
            this.tableLayoutPanelDevices.ColumnCount = 5;
            this.tableLayoutPanelDevices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanelDevices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelDevices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanelDevices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelDevices.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelDevices.Controls.Add(this.dataGridViewDevices, 0, 0);
            this.tableLayoutPanelDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDevices.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelDevices.Name = "tableLayoutPanelDevices";
            this.tableLayoutPanelDevices.RowCount = 5;
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDevices.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDevices.Size = new System.Drawing.Size(606, 60);
            this.tableLayoutPanelDevices.TabIndex = 220;
            // 
            // dataGridViewDevices
            // 
            this.dataGridViewDevices.AllowUserToAddRows = false;
            this.dataGridViewDevices.AllowUserToDeleteRows = false;
            this.dataGridViewDevices.AllowUserToResizeRows = false;
            this.dataGridViewDevices.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfDeviceIndex,
            this.ColumnOfDeviceName,
            this.ColumnOfDeviceHid,
            this.ColumnOfDeviceHardwareId,
            this.ColumnOfDeviceSerialSettings,
            this.ColumnOfDeviceEthernetSettings});
            this.tableLayoutPanelDevices.SetColumnSpan(this.dataGridViewDevices, 5);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDevices.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDevices.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.ReadOnly = true;
            this.dataGridViewDevices.RowHeadersVisible = false;
            this.tableLayoutPanelDevices.SetRowSpan(this.dataGridViewDevices, 5);
            this.dataGridViewDevices.RowTemplate.Height = 23;
            this.dataGridViewDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDevices.Size = new System.Drawing.Size(600, 54);
            this.dataGridViewDevices.TabIndex = 0;
            this.dataGridViewDevices.TabStop = false;
            // 
            // ColumnOfDeviceIndex
            // 
            this.ColumnOfDeviceIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceIndex.FillWeight = 60F;
            this.ColumnOfDeviceIndex.HeaderText = "NO";
            this.ColumnOfDeviceIndex.Name = "ColumnOfDeviceIndex";
            this.ColumnOfDeviceIndex.ReadOnly = true;
            this.ColumnOfDeviceIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnOfDeviceName
            // 
            this.ColumnOfDeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceName.FillWeight = 200F;
            this.ColumnOfDeviceName.HeaderText = "NAME";
            this.ColumnOfDeviceName.Name = "ColumnOfDeviceName";
            this.ColumnOfDeviceName.ReadOnly = true;
            // 
            // ColumnOfDeviceHid
            // 
            this.ColumnOfDeviceHid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceHid.FillWeight = 140F;
            this.ColumnOfDeviceHid.HeaderText = "HID";
            this.ColumnOfDeviceHid.Name = "ColumnOfDeviceHid";
            this.ColumnOfDeviceHid.ReadOnly = true;
            this.ColumnOfDeviceHid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnOfDeviceHid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnOfDeviceHardwareId
            // 
            this.ColumnOfDeviceHardwareId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceHardwareId.FillWeight = 140F;
            this.ColumnOfDeviceHardwareId.HeaderText = "HWID";
            this.ColumnOfDeviceHardwareId.Name = "ColumnOfDeviceHardwareId";
            this.ColumnOfDeviceHardwareId.ReadOnly = true;
            // 
            // ColumnOfDeviceSerialSettings
            // 
            this.ColumnOfDeviceSerialSettings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceSerialSettings.HeaderText = "COM";
            this.ColumnOfDeviceSerialSettings.Name = "ColumnOfDeviceSerialSettings";
            this.ColumnOfDeviceSerialSettings.ReadOnly = true;
            // 
            // ColumnOfDeviceEthernetSettings
            // 
            this.ColumnOfDeviceEthernetSettings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDeviceEthernetSettings.HeaderText = "NET";
            this.ColumnOfDeviceEthernetSettings.Name = "ColumnOfDeviceEthernetSettings";
            this.ColumnOfDeviceEthernetSettings.ReadOnly = true;
            // 
            // buttonSaveDatabase
            // 
            this.buttonSaveDatabase.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveDatabase.Location = new System.Drawing.Point(1134, 367);
            this.buttonSaveDatabase.Name = "buttonSaveDatabase";
            this.buttonSaveDatabase.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveDatabase.TabIndex = 0;
            this.buttonSaveDatabase.TabStop = false;
            this.buttonSaveDatabase.Text = "SAVE";
            this.buttonSaveDatabase.UseVisualStyleBackColor = true;
            this.buttonSaveDatabase.Visible = false;
            // 
            // buttonSaveGuiSettings
            // 
            this.buttonSaveGuiSettings.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveGuiSettings.Location = new System.Drawing.Point(1763, 6);
            this.buttonSaveGuiSettings.Name = "buttonSaveGuiSettings";
            this.buttonSaveGuiSettings.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveGuiSettings.TabIndex = 0;
            this.buttonSaveGuiSettings.TabStop = false;
            this.buttonSaveGuiSettings.Text = "SAVE";
            this.buttonSaveGuiSettings.UseVisualStyleBackColor = true;
            this.buttonSaveGuiSettings.Visible = false;
            this.buttonSaveGuiSettings.Click += new System.EventHandler(this.OnClickButtonSaveGuiSettings);
            // 
            // buttonSaveModel
            // 
            this.buttonSaveModel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveModel.Location = new System.Drawing.Point(503, 525);
            this.buttonSaveModel.Name = "buttonSaveModel";
            this.buttonSaveModel.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveModel.TabIndex = 0;
            this.buttonSaveModel.TabStop = false;
            this.buttonSaveModel.Text = "SAVE";
            this.buttonSaveModel.UseVisualStyleBackColor = true;
            this.buttonSaveModel.Visible = false;
            this.buttonSaveModel.Click += new System.EventHandler(this.OnClickButtonSaveModel);
            // 
            // groupBoxModel
            // 
            this.groupBoxModel.Controls.Add(this.groupBoxMaterialStorage);
            this.groupBoxModel.Controls.Add(this.groupBoxTimeoutProperties);
            this.groupBoxModel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxModel.Location = new System.Drawing.Point(10, 539);
            this.groupBoxModel.Name = "groupBoxModel";
            this.groupBoxModel.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxModel.Size = new System.Drawing.Size(620, 326);
            this.groupBoxModel.TabIndex = 0;
            this.groupBoxModel.TabStop = false;
            this.groupBoxModel.Text = " MODEL ";
            // 
            // groupBoxMaterialStorage
            // 
            this.groupBoxMaterialStorage.Controls.Add(this.tableLayoutPanelModelVisionProperties);
            this.groupBoxMaterialStorage.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMaterialStorage.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxMaterialStorage.Location = new System.Drawing.Point(7, 170);
            this.groupBoxMaterialStorage.Margin = new System.Windows.Forms.Padding(7);
            this.groupBoxMaterialStorage.Name = "groupBoxMaterialStorage";
            this.groupBoxMaterialStorage.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxMaterialStorage.Size = new System.Drawing.Size(606, 149);
            this.groupBoxMaterialStorage.TabIndex = 0;
            this.groupBoxMaterialStorage.TabStop = false;
            this.groupBoxMaterialStorage.Text = " MATERIAL STORAGE ";
            // 
            // tableLayoutPanelModelVisionProperties
            // 
            this.tableLayoutPanelModelVisionProperties.ColumnCount = 3;
            this.tableLayoutPanelModelVisionProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelModelVisionProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelModelVisionProperties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.textBoxDelayLoadStartValue, 1, 2);
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.textBoxUnloadRejectMaterialValue, 1, 0);
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.textBoxNotifyRejectFullValue, 1, 1);
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.checkBoxUnloadRejectMaterial, 0, 0);
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.checkBoxNotifyRejectFull, 0, 1);
            this.tableLayoutPanelModelVisionProperties.Controls.Add(this.checkBoxDelayLoadStart, 0, 2);
            this.tableLayoutPanelModelVisionProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelModelVisionProperties.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelModelVisionProperties.Name = "tableLayoutPanelModelVisionProperties";
            this.tableLayoutPanelModelVisionProperties.RowCount = 3;
            this.tableLayoutPanelModelVisionProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelModelVisionProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelModelVisionProperties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelModelVisionProperties.Size = new System.Drawing.Size(592, 113);
            this.tableLayoutPanelModelVisionProperties.TabIndex = 219;
            // 
            // textBoxDelayLoadStartValue
            // 
            this.textBoxDelayLoadStartValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDelayLoadStartValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxDelayLoadStartValue.Location = new System.Drawing.Point(355, 77);
            this.textBoxDelayLoadStartValue.Name = "textBoxDelayLoadStartValue";
            this.textBoxDelayLoadStartValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxDelayLoadStartValue.TabIndex = 5;
            this.textBoxDelayLoadStartValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUnloadRejectMaterialValue
            // 
            this.textBoxUnloadRejectMaterialValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxUnloadRejectMaterialValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnloadRejectMaterialValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxUnloadRejectMaterialValue.Location = new System.Drawing.Point(355, 3);
            this.textBoxUnloadRejectMaterialValue.Name = "textBoxUnloadRejectMaterialValue";
            this.textBoxUnloadRejectMaterialValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxUnloadRejectMaterialValue.TabIndex = 1;
            this.textBoxUnloadRejectMaterialValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNotifyRejectFullValue
            // 
            this.textBoxNotifyRejectFullValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxNotifyRejectFullValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNotifyRejectFullValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxNotifyRejectFullValue.Location = new System.Drawing.Point(355, 40);
            this.textBoxNotifyRejectFullValue.Name = "textBoxNotifyRejectFullValue";
            this.textBoxNotifyRejectFullValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxNotifyRejectFullValue.TabIndex = 1;
            this.textBoxNotifyRejectFullValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxUnloadRejectMaterial
            // 
            this.checkBoxUnloadRejectMaterial.AutoSize = true;
            this.checkBoxUnloadRejectMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxUnloadRejectMaterial.Location = new System.Drawing.Point(3, 3);
            this.checkBoxUnloadRejectMaterial.Name = "checkBoxUnloadRejectMaterial";
            this.checkBoxUnloadRejectMaterial.Size = new System.Drawing.Size(346, 31);
            this.checkBoxUnloadRejectMaterial.TabIndex = 0;
            this.checkBoxUnloadRejectMaterial.TabStop = false;
            this.checkBoxUnloadRejectMaterial.Text = "Unload reject material";
            this.checkBoxUnloadRejectMaterial.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotifyRejectFull
            // 
            this.checkBoxNotifyRejectFull.AutoSize = true;
            this.checkBoxNotifyRejectFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxNotifyRejectFull.Location = new System.Drawing.Point(3, 40);
            this.checkBoxNotifyRejectFull.Name = "checkBoxNotifyRejectFull";
            this.checkBoxNotifyRejectFull.Size = new System.Drawing.Size(346, 31);
            this.checkBoxNotifyRejectFull.TabIndex = 0;
            this.checkBoxNotifyRejectFull.TabStop = false;
            this.checkBoxNotifyRejectFull.Text = "Notify reject full";
            this.checkBoxNotifyRejectFull.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelayLoadStart
            // 
            this.checkBoxDelayLoadStart.AutoSize = true;
            this.checkBoxDelayLoadStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxDelayLoadStart.Location = new System.Drawing.Point(3, 77);
            this.checkBoxDelayLoadStart.Name = "checkBoxDelayLoadStart";
            this.checkBoxDelayLoadStart.Size = new System.Drawing.Size(346, 33);
            this.checkBoxDelayLoadStart.TabIndex = 0;
            this.checkBoxDelayLoadStart.TabStop = false;
            this.checkBoxDelayLoadStart.Text = "Delay load start";
            this.checkBoxDelayLoadStart.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimeoutProperties
            // 
            this.groupBoxTimeoutProperties.Controls.Add(this.tableLayoutPanelTimeout);
            this.groupBoxTimeoutProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTimeoutProperties.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxTimeoutProperties.Location = new System.Drawing.Point(7, 32);
            this.groupBoxTimeoutProperties.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxTimeoutProperties.Name = "groupBoxTimeoutProperties";
            this.groupBoxTimeoutProperties.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxTimeoutProperties.Size = new System.Drawing.Size(606, 138);
            this.groupBoxTimeoutProperties.TabIndex = 0;
            this.groupBoxTimeoutProperties.TabStop = false;
            this.groupBoxTimeoutProperties.Text = " TIMEOUT ";
            // 
            // tableLayoutPanelTimeout
            // 
            this.tableLayoutPanelTimeout.ColumnCount = 3;
            this.tableLayoutPanelTimeout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTimeout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTimeout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelTimeout.Controls.Add(this.textBoxReelTowerCommunicationTimeoutValue, 1, 0);
            this.tableLayoutPanelTimeout.Controls.Add(this.textBoxReelHandlerCommunicationTimeoutValue, 1, 1);
            this.tableLayoutPanelTimeout.Controls.Add(this.textBoxReelHandlerActionTimeoutValue, 1, 2);
            this.tableLayoutPanelTimeout.Controls.Add(this.checkBoxReelTowerCommunicationTimeout, 0, 0);
            this.tableLayoutPanelTimeout.Controls.Add(this.checkBoxReelHandlerCommunicationTimeout, 0, 1);
            this.tableLayoutPanelTimeout.Controls.Add(this.checkBoxReelHandlerActionTimeout, 0, 2);
            this.tableLayoutPanelTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTimeout.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelTimeout.Name = "tableLayoutPanelTimeout";
            this.tableLayoutPanelTimeout.RowCount = 3;
            this.tableLayoutPanelTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTimeout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelTimeout.Size = new System.Drawing.Size(592, 102);
            this.tableLayoutPanelTimeout.TabIndex = 0;
            // 
            // textBoxReelTowerCommunicationTimeoutValue
            // 
            this.textBoxReelTowerCommunicationTimeoutValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxReelTowerCommunicationTimeoutValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxReelTowerCommunicationTimeoutValue.Location = new System.Drawing.Point(355, 3);
            this.textBoxReelTowerCommunicationTimeoutValue.Name = "textBoxReelTowerCommunicationTimeoutValue";
            this.textBoxReelTowerCommunicationTimeoutValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxReelTowerCommunicationTimeoutValue.TabIndex = 0;
            this.textBoxReelTowerCommunicationTimeoutValue.TabStop = false;
            this.textBoxReelTowerCommunicationTimeoutValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxReelHandlerCommunicationTimeoutValue
            // 
            this.textBoxReelHandlerCommunicationTimeoutValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxReelHandlerCommunicationTimeoutValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReelHandlerCommunicationTimeoutValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxReelHandlerCommunicationTimeoutValue.Location = new System.Drawing.Point(355, 37);
            this.textBoxReelHandlerCommunicationTimeoutValue.Name = "textBoxReelHandlerCommunicationTimeoutValue";
            this.textBoxReelHandlerCommunicationTimeoutValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxReelHandlerCommunicationTimeoutValue.TabIndex = 0;
            this.textBoxReelHandlerCommunicationTimeoutValue.TabStop = false;
            this.textBoxReelHandlerCommunicationTimeoutValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxReelHandlerActionTimeoutValue
            // 
            this.textBoxReelHandlerActionTimeoutValue.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxReelHandlerActionTimeoutValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxReelHandlerActionTimeoutValue.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.textBoxReelHandlerActionTimeoutValue.Location = new System.Drawing.Point(355, 71);
            this.textBoxReelHandlerActionTimeoutValue.Name = "textBoxReelHandlerActionTimeoutValue";
            this.textBoxReelHandlerActionTimeoutValue.Size = new System.Drawing.Size(114, 29);
            this.textBoxReelHandlerActionTimeoutValue.TabIndex = 0;
            this.textBoxReelHandlerActionTimeoutValue.TabStop = false;
            this.textBoxReelHandlerActionTimeoutValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxReelTowerCommunicationTimeout
            // 
            this.checkBoxReelTowerCommunicationTimeout.AutoSize = true;
            this.checkBoxReelTowerCommunicationTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxReelTowerCommunicationTimeout.Location = new System.Drawing.Point(3, 3);
            this.checkBoxReelTowerCommunicationTimeout.Name = "checkBoxReelTowerCommunicationTimeout";
            this.checkBoxReelTowerCommunicationTimeout.Size = new System.Drawing.Size(346, 28);
            this.checkBoxReelTowerCommunicationTimeout.TabIndex = 0;
            this.checkBoxReelTowerCommunicationTimeout.TabStop = false;
            this.checkBoxReelTowerCommunicationTimeout.Text = "Reel tower communication";
            this.checkBoxReelTowerCommunicationTimeout.UseVisualStyleBackColor = true;
            // 
            // checkBoxReelHandlerCommunicationTimeout
            // 
            this.checkBoxReelHandlerCommunicationTimeout.AutoSize = true;
            this.checkBoxReelHandlerCommunicationTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxReelHandlerCommunicationTimeout.Location = new System.Drawing.Point(3, 37);
            this.checkBoxReelHandlerCommunicationTimeout.Name = "checkBoxReelHandlerCommunicationTimeout";
            this.checkBoxReelHandlerCommunicationTimeout.Size = new System.Drawing.Size(346, 28);
            this.checkBoxReelHandlerCommunicationTimeout.TabIndex = 0;
            this.checkBoxReelHandlerCommunicationTimeout.TabStop = false;
            this.checkBoxReelHandlerCommunicationTimeout.Text = "Reel handler communication";
            this.checkBoxReelHandlerCommunicationTimeout.UseVisualStyleBackColor = true;
            // 
            // checkBoxReelHandlerActionTimeout
            // 
            this.checkBoxReelHandlerActionTimeout.AutoSize = true;
            this.checkBoxReelHandlerActionTimeout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxReelHandlerActionTimeout.Location = new System.Drawing.Point(3, 71);
            this.checkBoxReelHandlerActionTimeout.Name = "checkBoxReelHandlerActionTimeout";
            this.checkBoxReelHandlerActionTimeout.Size = new System.Drawing.Size(346, 28);
            this.checkBoxReelHandlerActionTimeout.TabIndex = 0;
            this.checkBoxReelHandlerActionTimeout.TabStop = false;
            this.checkBoxReelHandlerActionTimeout.Text = "Reel handler action";
            this.checkBoxReelHandlerActionTimeout.UseVisualStyleBackColor = true;
            // 
            // buttonSaveNetworks
            // 
            this.buttonSaveNetworks.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.buttonSaveNetworks.Location = new System.Drawing.Point(1134, 186);
            this.buttonSaveNetworks.Name = "buttonSaveNetworks";
            this.buttonSaveNetworks.Size = new System.Drawing.Size(120, 40);
            this.buttonSaveNetworks.TabIndex = 0;
            this.buttonSaveNetworks.TabStop = false;
            this.buttonSaveNetworks.Text = "SAVE";
            this.buttonSaveNetworks.UseVisualStyleBackColor = true;
            this.buttonSaveNetworks.Visible = false;
            // 
            // groupBoxNetworks
            // 
            this.groupBoxNetworks.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxNetworks.Controls.Add(this.tableLayoutPanelNetwork);
            this.groupBoxNetworks.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxNetworks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxNetworks.Location = new System.Drawing.Point(641, 201);
            this.groupBoxNetworks.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxNetworks.Name = "groupBoxNetworks";
            this.groupBoxNetworks.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxNetworks.Size = new System.Drawing.Size(620, 165);
            this.groupBoxNetworks.TabIndex = 0;
            this.groupBoxNetworks.TabStop = false;
            this.groupBoxNetworks.Text = " NETWORK ";
            // 
            // tableLayoutPanelNetwork
            // 
            this.tableLayoutPanelNetwork.ColumnCount = 5;
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelNetwork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelNetwork.Controls.Add(this.dataGridViewReelTowerNetworks, 0, 0);
            this.tableLayoutPanelNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelNetwork.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelNetwork.Name = "tableLayoutPanelNetwork";
            this.tableLayoutPanelNetwork.RowCount = 4;
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetwork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelNetwork.Size = new System.Drawing.Size(606, 129);
            this.tableLayoutPanelNetwork.TabIndex = 217;
            // 
            // dataGridViewReelTowerNetworks
            // 
            this.dataGridViewReelTowerNetworks.AllowUserToAddRows = false;
            this.dataGridViewReelTowerNetworks.AllowUserToDeleteRows = false;
            this.dataGridViewReelTowerNetworks.AllowUserToResizeRows = false;
            this.dataGridViewReelTowerNetworks.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewReelTowerNetworks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewReelTowerNetworks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReelTowerNetworks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfName,
            this.ColumnOfAddress,
            this.ColumnOfPort});
            this.tableLayoutPanelNetwork.SetColumnSpan(this.dataGridViewReelTowerNetworks, 5);
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewReelTowerNetworks.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewReelTowerNetworks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReelTowerNetworks.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewReelTowerNetworks.Name = "dataGridViewReelTowerNetworks";
            this.dataGridViewReelTowerNetworks.ReadOnly = true;
            this.dataGridViewReelTowerNetworks.RowHeadersVisible = false;
            this.tableLayoutPanelNetwork.SetRowSpan(this.dataGridViewReelTowerNetworks, 4);
            this.dataGridViewReelTowerNetworks.RowTemplate.Height = 23;
            this.dataGridViewReelTowerNetworks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReelTowerNetworks.Size = new System.Drawing.Size(600, 123);
            this.dataGridViewReelTowerNetworks.TabIndex = 0;
            this.dataGridViewReelTowerNetworks.TabStop = false;
            // 
            // ColumnOfName
            // 
            this.ColumnOfName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfName.FillWeight = 140F;
            this.ColumnOfName.HeaderText = "NAME";
            this.ColumnOfName.Name = "ColumnOfName";
            this.ColumnOfName.ReadOnly = true;
            // 
            // ColumnOfAddress
            // 
            this.ColumnOfAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfAddress.FillWeight = 200F;
            this.ColumnOfAddress.HeaderText = "ADDRESS";
            this.ColumnOfAddress.Name = "ColumnOfAddress";
            this.ColumnOfAddress.ReadOnly = true;
            // 
            // ColumnOfPort
            // 
            this.ColumnOfPort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfPort.FillWeight = 60F;
            this.ColumnOfPort.HeaderText = "PORT";
            this.ColumnOfPort.Name = "ColumnOfPort";
            this.ColumnOfPort.ReadOnly = true;
            // 
            // groupBoxGuiSettings
            // 
            this.groupBoxGuiSettings.Controls.Add(this.tableLayoutPanelDisplayLanguage);
            this.groupBoxGuiSettings.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxGuiSettings.Location = new System.Drawing.Point(1272, 21);
            this.groupBoxGuiSettings.Name = "groupBoxGuiSettings";
            this.groupBoxGuiSettings.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxGuiSettings.Size = new System.Drawing.Size(620, 72);
            this.groupBoxGuiSettings.TabIndex = 0;
            this.groupBoxGuiSettings.TabStop = false;
            this.groupBoxGuiSettings.Text = " GUI ";
            // 
            // tableLayoutPanelDisplayLanguage
            // 
            this.tableLayoutPanelDisplayLanguage.ColumnCount = 3;
            this.tableLayoutPanelDisplayLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDisplayLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDisplayLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDisplayLanguage.Controls.Add(this.labelDisplayLanguage, 0, 0);
            this.tableLayoutPanelDisplayLanguage.Controls.Add(this.comboBoxDisplayLanguage, 1, 0);
            this.tableLayoutPanelDisplayLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDisplayLanguage.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelDisplayLanguage.Name = "tableLayoutPanelDisplayLanguage";
            this.tableLayoutPanelDisplayLanguage.RowCount = 1;
            this.tableLayoutPanelDisplayLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDisplayLanguage.Size = new System.Drawing.Size(606, 36);
            this.tableLayoutPanelDisplayLanguage.TabIndex = 220;
            // 
            // labelDisplayLanguage
            // 
            this.labelDisplayLanguage.AutoSize = true;
            this.labelDisplayLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDisplayLanguage.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelDisplayLanguage.Location = new System.Drawing.Point(3, 0);
            this.labelDisplayLanguage.Name = "labelDisplayLanguage";
            this.labelDisplayLanguage.Size = new System.Drawing.Size(297, 36);
            this.labelDisplayLanguage.TabIndex = 0;
            this.labelDisplayLanguage.Text = "Display language";
            this.labelDisplayLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxDisplayLanguage
            // 
            this.comboBoxDisplayLanguage.BackColor = System.Drawing.SystemColors.Info;
            this.tableLayoutPanelDisplayLanguage.SetColumnSpan(this.comboBoxDisplayLanguage, 2);
            this.comboBoxDisplayLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDisplayLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxDisplayLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisplayLanguage.FormattingEnabled = true;
            this.comboBoxDisplayLanguage.Items.AddRange(new object[] {
            "English (en-US)",
            "Korean (ko-KR)"});
            this.comboBoxDisplayLanguage.Location = new System.Drawing.Point(306, 3);
            this.comboBoxDisplayLanguage.Name = "comboBoxDisplayLanguage";
            this.comboBoxDisplayLanguage.Size = new System.Drawing.Size(297, 30);
            this.comboBoxDisplayLanguage.TabIndex = 1;
            this.comboBoxDisplayLanguage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnComboBoxDrawItem);
            // 
            // groupBoxDatabases
            // 
            this.groupBoxDatabases.Controls.Add(this.tableLayoutPanelDatabase);
            this.groupBoxDatabases.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxDatabases.Location = new System.Drawing.Point(641, 385);
            this.groupBoxDatabases.Name = "groupBoxDatabases";
            this.groupBoxDatabases.Padding = new System.Windows.Forms.Padding(7);
            this.groupBoxDatabases.Size = new System.Drawing.Size(620, 119);
            this.groupBoxDatabases.TabIndex = 0;
            this.groupBoxDatabases.TabStop = false;
            this.groupBoxDatabases.Text = " DATABASE ";
            // 
            // tableLayoutPanelDatabase
            // 
            this.tableLayoutPanelDatabase.ColumnCount = 5;
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelDatabase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanelDatabase.Controls.Add(this.dataGridViewDatabase, 0, 0);
            this.tableLayoutPanelDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDatabase.Location = new System.Drawing.Point(7, 29);
            this.tableLayoutPanelDatabase.Name = "tableLayoutPanelDatabase";
            this.tableLayoutPanelDatabase.RowCount = 5;
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDatabase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDatabase.Size = new System.Drawing.Size(606, 83);
            this.tableLayoutPanelDatabase.TabIndex = 220;
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AllowUserToAddRows = false;
            this.dataGridViewDatabase.AllowUserToDeleteRows = false;
            this.dataGridViewDatabase.AllowUserToResizeRows = false;
            this.dataGridViewDatabase.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnOfDbIndex,
            this.ColumnOfDbServer,
            this.ColumnOfDbName,
            this.ColumnOfDbFile,
            this.ColumnOfUser});
            this.tableLayoutPanelDatabase.SetColumnSpan(this.dataGridViewDatabase, 5);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDatabase.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.ReadOnly = true;
            this.dataGridViewDatabase.RowHeadersVisible = false;
            this.tableLayoutPanelDatabase.SetRowSpan(this.dataGridViewDatabase, 5);
            this.dataGridViewDatabase.RowTemplate.Height = 23;
            this.dataGridViewDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(600, 77);
            this.dataGridViewDatabase.TabIndex = 0;
            this.dataGridViewDatabase.TabStop = false;
            // 
            // ColumnOfDbIndex
            // 
            this.ColumnOfDbIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDbIndex.FillWeight = 60F;
            this.ColumnOfDbIndex.HeaderText = "NO";
            this.ColumnOfDbIndex.Name = "ColumnOfDbIndex";
            this.ColumnOfDbIndex.ReadOnly = true;
            this.ColumnOfDbIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnOfDbServer
            // 
            this.ColumnOfDbServer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDbServer.FillWeight = 200F;
            this.ColumnOfDbServer.HeaderText = "SERVER";
            this.ColumnOfDbServer.Name = "ColumnOfDbServer";
            this.ColumnOfDbServer.ReadOnly = true;
            // 
            // ColumnOfDbName
            // 
            this.ColumnOfDbName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDbName.FillWeight = 140F;
            this.ColumnOfDbName.HeaderText = "DBNAME";
            this.ColumnOfDbName.Name = "ColumnOfDbName";
            this.ColumnOfDbName.ReadOnly = true;
            // 
            // ColumnOfDbFile
            // 
            this.ColumnOfDbFile.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfDbFile.FillWeight = 140F;
            this.ColumnOfDbFile.HeaderText = "DBFILE";
            this.ColumnOfDbFile.Name = "ColumnOfDbFile";
            this.ColumnOfDbFile.ReadOnly = true;
            // 
            // ColumnOfUser
            // 
            this.ColumnOfUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnOfUser.HeaderText = "USER";
            this.ColumnOfUser.Name = "ColumnOfUser";
            this.ColumnOfUser.ReadOnly = true;
            // 
            // tabPageLog
            // 
            this.tabPageLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPageLog.Controls.Add(this.tabControlLogPage);
            this.tabPageLog.Location = new System.Drawing.Point(4, 44);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(1906, 887);
            this.tabPageLog.TabIndex = 1;
            this.tabPageLog.Text = "     LOG      ";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // tabControlLogPage
            // 
            this.tabControlLogPage.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlLogPage.Controls.Add(this.tabPageReelTowerLog);
            this.tabControlLogPage.Controls.Add(this.tabPageRobotLog);
            this.tabControlLogPage.Controls.Add(this.tabPageProvideJobLog);
            this.tabControlLogPage.Controls.Add(this.tabPageAlarmHistory);
            this.tabControlLogPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLogPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlLogPage.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControlLogPage.Location = new System.Drawing.Point(0, 0);
            this.tabControlLogPage.Name = "tabControlLogPage";
            this.tabControlLogPage.SelectedIndex = 0;
            this.tabControlLogPage.Size = new System.Drawing.Size(1904, 885);
            this.tabControlLogPage.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlLogPage.TabIndex = 219;
            this.tabControlLogPage.TabStop = false;
            this.tabControlLogPage.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OnTabControlDrawItem);
            this.tabControlLogPage.SelectedIndexChanged += new System.EventHandler(this.OnLogTabIndexChanged);
            this.tabControlLogPage.TabIndexChanged += new System.EventHandler(this.OnLogTabIndexChanged);
            // 
            // tabPageReelTowerLog
            // 
            this.tabPageReelTowerLog.Controls.Add(this.listBoxReelTowerComm);
            this.tabPageReelTowerLog.Location = new System.Drawing.Point(4, 44);
            this.tabPageReelTowerLog.Name = "tabPageReelTowerLog";
            this.tabPageReelTowerLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReelTowerLog.Size = new System.Drawing.Size(1896, 837);
            this.tabPageReelTowerLog.TabIndex = 0;
            this.tabPageReelTowerLog.Text = "     REEL TOWER     ";
            this.tabPageReelTowerLog.UseVisualStyleBackColor = true;
            // 
            // listBoxReelTowerComm
            // 
            this.listBoxReelTowerComm.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxReelTowerComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReelTowerComm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReelTowerComm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxReelTowerComm.FormattingEnabled = true;
            this.listBoxReelTowerComm.HorizontalScrollbar = true;
            this.listBoxReelTowerComm.ItemHeight = 18;
            this.listBoxReelTowerComm.Location = new System.Drawing.Point(3, 3);
            this.listBoxReelTowerComm.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxReelTowerComm.Name = "listBoxReelTowerComm";
            this.listBoxReelTowerComm.Size = new System.Drawing.Size(1890, 831);
            this.listBoxReelTowerComm.TabIndex = 89;
            // 
            // tabPageRobotLog
            // 
            this.tabPageRobotLog.Controls.Add(this.listBoxReelHandlerComm);
            this.tabPageRobotLog.Location = new System.Drawing.Point(4, 44);
            this.tabPageRobotLog.Name = "tabPageRobotLog";
            this.tabPageRobotLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRobotLog.Size = new System.Drawing.Size(1896, 837);
            this.tabPageRobotLog.TabIndex = 1;
            this.tabPageRobotLog.Text = "   REEL HANDLER   ";
            this.tabPageRobotLog.UseVisualStyleBackColor = true;
            // 
            // listBoxReelHandlerComm
            // 
            this.listBoxReelHandlerComm.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxReelHandlerComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReelHandlerComm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxReelHandlerComm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxReelHandlerComm.FormattingEnabled = true;
            this.listBoxReelHandlerComm.HorizontalScrollbar = true;
            this.listBoxReelHandlerComm.ItemHeight = 18;
            this.listBoxReelHandlerComm.Location = new System.Drawing.Point(3, 3);
            this.listBoxReelHandlerComm.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxReelHandlerComm.Name = "listBoxReelHandlerComm";
            this.listBoxReelHandlerComm.Size = new System.Drawing.Size(1890, 831);
            this.listBoxReelHandlerComm.TabIndex = 90;
            // 
            // tabPageProvideJobLog
            // 
            this.tabPageProvideJobLog.Controls.Add(this.listBoxProvideJobLog);
            this.tabPageProvideJobLog.Location = new System.Drawing.Point(4, 44);
            this.tabPageProvideJobLog.Name = "tabPageProvideJobLog";
            this.tabPageProvideJobLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProvideJobLog.Size = new System.Drawing.Size(1896, 837);
            this.tabPageProvideJobLog.TabIndex = 3;
            this.tabPageProvideJobLog.Text = "   PROVIDE JOB   ";
            this.tabPageProvideJobLog.UseVisualStyleBackColor = true;
            // 
            // listBoxProvideJobLog
            // 
            this.listBoxProvideJobLog.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxProvideJobLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxProvideJobLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProvideJobLog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxProvideJobLog.FormattingEnabled = true;
            this.listBoxProvideJobLog.HorizontalScrollbar = true;
            this.listBoxProvideJobLog.ItemHeight = 18;
            this.listBoxProvideJobLog.Location = new System.Drawing.Point(3, 3);
            this.listBoxProvideJobLog.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxProvideJobLog.Name = "listBoxProvideJobLog";
            this.listBoxProvideJobLog.Size = new System.Drawing.Size(1890, 831);
            this.listBoxProvideJobLog.TabIndex = 91;
            // 
            // tabPageAlarmHistory
            // 
            this.tabPageAlarmHistory.Controls.Add(this.treeViewLog);
            this.tabPageAlarmHistory.Controls.Add(this.listBoxAlarmHistory);
            this.tabPageAlarmHistory.Location = new System.Drawing.Point(4, 44);
            this.tabPageAlarmHistory.Name = "tabPageAlarmHistory";
            this.tabPageAlarmHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlarmHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPageAlarmHistory.Size = new System.Drawing.Size(1896, 837);
            this.tabPageAlarmHistory.TabIndex = 2;
            this.tabPageAlarmHistory.Text = "   ALARM   ";
            this.tabPageAlarmHistory.UseVisualStyleBackColor = true;
            // 
            // treeViewLog
            // 
            this.treeViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewLog.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewLog.ImageIndex = 4;
            this.treeViewLog.ImageList = this.imageListFileSystem;
            this.treeViewLog.Location = new System.Drawing.Point(3, 3);
            this.treeViewLog.Name = "treeViewLog";
            treeNode1.ImageIndex = 4;
            treeNode1.Name = "Log";
            treeNode1.NodeFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.SelectedImageIndex = 5;
            treeNode1.Text = "Log";
            this.treeViewLog.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewLog.SelectedImageIndex = 5;
            this.treeViewLog.Size = new System.Drawing.Size(188, 831);
            this.treeViewLog.TabIndex = 92;
            this.treeViewLog.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnAfterSelectNode);
            // 
            // imageListFileSystem
            // 
            this.imageListFileSystem.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListFileSystem.ImageStream")));
            this.imageListFileSystem.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListFileSystem.Images.SetKeyName(0, "Icon_Internet.ico");
            this.imageListFileSystem.Images.SetKeyName(1, "Icon_Desktop.ico");
            this.imageListFileSystem.Images.SetKeyName(2, "Icon_Monitor_Off.ico");
            this.imageListFileSystem.Images.SetKeyName(3, "Icon_Monitor_On.ico");
            this.imageListFileSystem.Images.SetKeyName(4, "Icon_Folder.ico");
            this.imageListFileSystem.Images.SetKeyName(5, "Icon_Opened_Folder.ico");
            this.imageListFileSystem.Images.SetKeyName(6, "Icon_New_File.ico");
            this.imageListFileSystem.Images.SetKeyName(7, "Icon_Text_File.ico");
            // 
            // listBoxAlarmHistory
            // 
            this.listBoxAlarmHistory.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxAlarmHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBoxAlarmHistory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlarmHistory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listBoxAlarmHistory.FormattingEnabled = true;
            this.listBoxAlarmHistory.HorizontalScrollbar = true;
            this.listBoxAlarmHistory.ItemHeight = 18;
            this.listBoxAlarmHistory.Location = new System.Drawing.Point(191, 3);
            this.listBoxAlarmHistory.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxAlarmHistory.Name = "listBoxAlarmHistory";
            this.listBoxAlarmHistory.Size = new System.Drawing.Size(1702, 831);
            this.listBoxAlarmHistory.TabIndex = 91;
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.BackColor = System.Drawing.SystemColors.Control;
            this.buttonClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearLog.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearLog.Location = new System.Drawing.Point(1720, 0);
            this.buttonClearLog.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(200, 40);
            this.buttonClearLog.TabIndex = 0;
            this.buttonClearLog.TabStop = false;
            this.buttonClearLog.Text = "CLEAR";
            this.buttonClearLog.UseVisualStyleBackColor = false;
            this.buttonClearLog.Visible = false;
            this.buttonClearLog.Click += new System.EventHandler(this.OnClearLog);
            // 
            // tableLayoutPanelMainFrame
            // 
            this.tableLayoutPanelMainFrame.ColumnCount = 3;
            this.tableLayoutPanelMainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanelMainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanelMainFrame.Controls.Add(this.tabControlMain, 0, 1);
            this.tableLayoutPanelMainFrame.Controls.Add(this.tableLayoutPanelProvidePage, 0, 2);
            this.tableLayoutPanelMainFrame.Controls.Add(this.tableLayoutPanelTitle, 0, 0);
            this.tableLayoutPanelMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainFrame.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMainFrame.Name = "tableLayoutPanelMainFrame";
            this.tableLayoutPanelMainFrame.RowCount = 3;
            this.tableLayoutPanelMainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanelMainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMainFrame.Size = new System.Drawing.Size(1920, 1061);
            this.tableLayoutPanelMainFrame.TabIndex = 224;
            // 
            // tableLayoutPanelProvidePage
            // 
            this.tableLayoutPanelProvidePage.ColumnCount = 11;
            this.tableLayoutPanelMainFrame.SetColumnSpan(this.tableLayoutPanelProvidePage, 3);
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanelProvidePage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelProvidePage.Controls.Add(this.buttonClearLog, 10, 0);
            this.tableLayoutPanelProvidePage.Controls.Add(this.radioButtonLoginOperator, 0, 0);
            this.tableLayoutPanelProvidePage.Controls.Add(this.radioButtonSearchReel, 2, 0);
            this.tableLayoutPanelProvidePage.Controls.Add(this.radioButtonJobMonitor, 4, 0);
            this.tableLayoutPanelProvidePage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProvidePage.Location = new System.Drawing.Point(0, 1021);
            this.tableLayoutPanelProvidePage.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelProvidePage.Name = "tableLayoutPanelProvidePage";
            this.tableLayoutPanelProvidePage.RowCount = 1;
            this.tableLayoutPanelProvidePage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProvidePage.Size = new System.Drawing.Size(1920, 40);
            this.tableLayoutPanelProvidePage.TabIndex = 224;
            // 
            // radioButtonLoginOperator
            // 
            this.radioButtonLoginOperator.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLoginOperator.AutoSize = true;
            this.radioButtonLoginOperator.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonLoginOperator.Checked = true;
            this.radioButtonLoginOperator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonLoginOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonLoginOperator.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonLoginOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLoginOperator.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonLoginOperator.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonLoginOperator.Location = new System.Drawing.Point(0, 0);
            this.radioButtonLoginOperator.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonLoginOperator.Name = "radioButtonLoginOperator";
            this.radioButtonLoginOperator.Size = new System.Drawing.Size(200, 40);
            this.radioButtonLoginOperator.TabIndex = 1;
            this.radioButtonLoginOperator.TabStop = true;
            this.radioButtonLoginOperator.Text = "OPERATOR";
            this.radioButtonLoginOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonLoginOperator.UseVisualStyleBackColor = false;
            this.radioButtonLoginOperator.CheckedChanged += new System.EventHandler(this.OnCheckedChangedRadioButtonPages);
            // 
            // radioButtonSearchReel
            // 
            this.radioButtonSearchReel.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSearchReel.AutoSize = true;
            this.radioButtonSearchReel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonSearchReel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSearchReel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSearchReel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonSearchReel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSearchReel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonSearchReel.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonSearchReel.Location = new System.Drawing.Point(203, 0);
            this.radioButtonSearchReel.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonSearchReel.Name = "radioButtonSearchReel";
            this.radioButtonSearchReel.Size = new System.Drawing.Size(200, 40);
            this.radioButtonSearchReel.TabIndex = 2;
            this.radioButtonSearchReel.Text = "SEARCH";
            this.radioButtonSearchReel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSearchReel.UseVisualStyleBackColor = false;
            this.radioButtonSearchReel.CheckedChanged += new System.EventHandler(this.OnCheckedChangedRadioButtonPages);
            // 
            // radioButtonJobMonitor
            // 
            this.radioButtonJobMonitor.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonJobMonitor.AutoSize = true;
            this.radioButtonJobMonitor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radioButtonJobMonitor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonJobMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonJobMonitor.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HotTrack;
            this.radioButtonJobMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonJobMonitor.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonJobMonitor.ForeColor = System.Drawing.SystemColors.Window;
            this.radioButtonJobMonitor.Location = new System.Drawing.Point(406, 0);
            this.radioButtonJobMonitor.Margin = new System.Windows.Forms.Padding(0);
            this.radioButtonJobMonitor.Name = "radioButtonJobMonitor";
            this.radioButtonJobMonitor.Size = new System.Drawing.Size(200, 40);
            this.radioButtonJobMonitor.TabIndex = 3;
            this.radioButtonJobMonitor.Text = "MONITOR";
            this.radioButtonJobMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonJobMonitor.UseVisualStyleBackColor = false;
            this.radioButtonJobMonitor.CheckedChanged += new System.EventHandler(this.OnCheckedChangedRadioButtonPages);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnDoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnRunWorkerCompleted);
            // 
            // backgroundWorkerAMMAlive
            // 
            this.backgroundWorkerAMMAlive.WorkerReportsProgress = true;
            this.backgroundWorkerAMMAlive.WorkerSupportsCancellation = true;
            this.backgroundWorkerAMMAlive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAMMAlive_DoWork);
            this.backgroundWorkerAMMAlive.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerAMMAlive_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.tableLayoutPanelMainFrame);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormCloase);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Shown += new System.EventHandler(this.OnFormShown);
            this.tableLayoutPanelTitle.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageProvideOperation.ResumeLayout(false);
            this.tabControlOperation.ResumeLayout(false);
            this.tabPageProvideLoginOperator.ResumeLayout(false);
            this.tableLayoutPanelLoginOperator.ResumeLayout(false);
            this.tableLayoutPanelLoginOperator.PerformLayout();
            this.tabPageProvideSearchReel.ResumeLayout(false);
            this.tableLayoutPanelSearchReel.ResumeLayout(false);
            this.groupBoxAssignJob.ResumeLayout(false);
            this.tableLayoutPanelJobInformation.ResumeLayout(false);
            this.groupBoxAssignedReels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedReels)).EndInit();
            this.groupBoxSearchOptions.ResumeLayout(false);
            this.tableLayoutPanelReelInformation.ResumeLayout(false);
            this.groupBoxReelId.ResumeLayout(false);
            this.groupBoxReelId.PerformLayout();
            this.tableLayoutPanelReelId.ResumeLayout(false);
            this.tableLayoutPanelReelId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAssignReelsValue)).EndInit();
            this.splitContainerSearchReels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerSearchReels)).EndInit();
            this.splitContainerSearchReels.ResumeLayout(false);
            this.groupBoxSearchedReels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedReels)).EndInit();
            this.tabPageProvideJobMonitor.ResumeLayout(false);
            this.tableLayoutPanelMonitor.ResumeLayout(false);
            this.groupBoxQueuedUnloadJobs.ResumeLayout(false);
            this.tableLayoutPanelQueuedJobs.ResumeLayout(false);
            this.tableLayoutPanelQueuedJobs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueuedJobs)).EndInit();
            this.groupBoxUnloadingReel.ResumeLayout(false);
            this.tableLayoutPanelProcessingReel.ResumeLayout(false);
            this.groupBoxPendedReels.ResumeLayout(false);
            this.tabPageStoreOperation.ResumeLayout(false);
            this.tableLayoutPanelStoreReel.ResumeLayout(false);
            this.groupBoxStoreReel.ResumeLayout(false);
            this.tableLayoutPanelLoadReel.ResumeLayout(false);
            this.tableLayoutPanelLoadReel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoadReelQtyValue)).EndInit();
            this.groupBoxQueryReels.ResumeLayout(false);
            this.tableLayoutPanelQueryReels.ResumeLayout(false);
            this.tableLayoutPanelQueryReels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueryReelQtyValue)).EndInit();
            this.groupBoxQueryResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQueryResults)).EndInit();
            this.tabPageAccount.ResumeLayout(false);
            this.tableLayoutPanelAccountManager.ResumeLayout(false);
            this.groupBoxAccountManager.ResumeLayout(false);
            this.tableLayoutPanelAccountManagerLogin.ResumeLayout(false);
            this.tableLayoutPanelAccountManagerLogin.PerformLayout();
            this.groupBoxNewAccount.ResumeLayout(false);
            this.tableLayoutPanelAccount.ResumeLayout(false);
            this.tableLayoutPanelAccount.PerformLayout();
            this.tabPageReelTowerNotifier.ResumeLayout(false);
            this.tableLayoutPanelNotificationListener.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.groupBoxTower.ResumeLayout(false);
            this.tableLayoutPanelTower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTower)).EndInit();
            this.groupBoxMaterialInformation.ResumeLayout(false);
            this.tableLayoutPanelMaterialInformation.ResumeLayout(false);
            this.tableLayoutPanelMaterialInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaterialInformation)).EndInit();
            this.groupBoxConfig.ResumeLayout(false);
            this.tableLayoutPanelProperties.ResumeLayout(false);
            this.tableLayoutPanelProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJobSplitReelCountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeoutOfRejectValue)).EndInit();
            this.groupBoxCombineModules.ResumeLayout(false);
            this.tableLayoutPanelCombineModules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCombineModules)).EndInit();
            this.groupBoxDevices.ResumeLayout(false);
            this.tableLayoutPanelDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.groupBoxModel.ResumeLayout(false);
            this.groupBoxMaterialStorage.ResumeLayout(false);
            this.tableLayoutPanelModelVisionProperties.ResumeLayout(false);
            this.tableLayoutPanelModelVisionProperties.PerformLayout();
            this.groupBoxTimeoutProperties.ResumeLayout(false);
            this.tableLayoutPanelTimeout.ResumeLayout(false);
            this.tableLayoutPanelTimeout.PerformLayout();
            this.groupBoxNetworks.ResumeLayout(false);
            this.tableLayoutPanelNetwork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReelTowerNetworks)).EndInit();
            this.groupBoxGuiSettings.ResumeLayout(false);
            this.tableLayoutPanelDisplayLanguage.ResumeLayout(false);
            this.tableLayoutPanelDisplayLanguage.PerformLayout();
            this.groupBoxDatabases.ResumeLayout(false);
            this.tableLayoutPanelDatabase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            this.tabControlLogPage.ResumeLayout(false);
            this.tabPageReelTowerLog.ResumeLayout(false);
            this.tabPageRobotLog.ResumeLayout(false);
            this.tabPageProvideJobLog.ResumeLayout(false);
            this.tabPageAlarmHistory.ResumeLayout(false);
            this.tableLayoutPanelMainFrame.ResumeLayout(false);
            this.tableLayoutPanelProvidePage.ResumeLayout(false);
            this.tableLayoutPanelProvidePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button buttonExit;
        public System.Windows.Forms.Label labelRobotState;
        public System.Windows.Forms.Label labelRobotStatus;
        public System.Windows.Forms.Label labelTower1Status;
        public System.Windows.Forms.Button buttonAutoRun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTitle;
        private System.Windows.Forms.TabPage tabPageProvideOperation;
        public System.Windows.Forms.Label lblURClientConnectState;
        public System.Windows.Forms.Label labelTower1StatusValue;
        public System.Windows.Forms.Button btnClientConnect;
        // public System.Windows.Forms.Label label33;
        public System.Windows.Forms.Label labelWebServiceStatusValue;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.TabControl tabControlLogPage;
        private System.Windows.Forms.TabPage tabPageReelTowerLog;
        public System.Windows.Forms.ListBox listBoxReelTowerComm;
        private System.Windows.Forms.TabPage tabPageRobotLog;
        public System.Windows.Forms.ListBox listBoxReelHandlerComm;
        private System.Windows.Forms.TextBox textBoxReelHandlerCommunicationTimeoutValue;
        private System.Windows.Forms.TextBox textBoxReelTowerCommunicationTimeoutValue;
        private System.Windows.Forms.GroupBox groupBoxNetworks;
        public System.Windows.Forms.Label labelWerServiceStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTimeout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNetwork;
        private System.Windows.Forms.Button buttonSaveNetworks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainFrame;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.TabPage tabPageReelTowerManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelModelVisionProperties;
        private System.Windows.Forms.TextBox textBoxUnloadRejectMaterialValue;
        private System.Windows.Forms.TextBox textBoxNotifyRejectFullValue;
        private System.Windows.Forms.TextBox textBoxReelHandlerActionTimeoutValue;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonSaveModel;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox textBoxDelayLoadStartValue;
        private System.Windows.Forms.GroupBox groupBoxDatabases;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDatabase;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.Button buttonSaveGuiSettings;
        private System.Windows.Forms.GroupBox groupBoxGuiSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDisplayLanguage;
        private System.Windows.Forms.ComboBox comboBoxDisplayLanguage;
        private System.Windows.Forms.TabPage tabPageAlarmHistory;
        public System.Windows.Forms.ListBox listBoxAlarmHistory;
        private System.Windows.Forms.TreeView treeViewLog;
        private System.Windows.Forms.ImageList imageListFileSystem;
        public System.Windows.Forms.Label labelOperationState;
        // public System.Windows.Forms.Label btestst;
        public System.Windows.Forms.Label labelTower4Status;
        public System.Windows.Forms.Label labelTower3StatusValue;
        public System.Windows.Forms.Label labelTower3Status;
        public System.Windows.Forms.Label labelTower2Status;
        public System.Windows.Forms.Label labelTower2StatusValue;
        private System.Windows.Forms.TabPage tabPageReelTowerNotifier;
        private System.Windows.Forms.TabPage tabPageStoreOperation;
        protected System.Windows.Forms.TabControl tabControlOperation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoginOperator;
        private System.Windows.Forms.Label labelLoginOperator;
        private System.Windows.Forms.TextBox textBoxLoginOperatorValue;
        private System.Windows.Forms.TabPage tabPageProvideSearchReel;
        private System.Windows.Forms.GroupBox groupBoxAssignJob;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelJobInformation;
        public System.Windows.Forms.Label labelAssignJobUserValue;
        public System.Windows.Forms.Label labelAssignJobNameValue;
        public System.Windows.Forms.Label labelAssignJobName;
        public System.Windows.Forms.Label labelAssignJobUser;
        public System.Windows.Forms.Label labelAssignJobTotalReels;
        public System.Windows.Forms.Label labelAssignJobOutport;
        public System.Windows.Forms.Label labelAssignJobTotalReelsValue;
        private System.Windows.Forms.GroupBox groupBoxSearchOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelReelInformation;
        private System.Windows.Forms.GroupBox groupBoxReelId;
        public System.Windows.Forms.Label labelSearchReelIdType;
        public System.Windows.Forms.Label labelSearchReelId;
        public System.Windows.Forms.Label labelAssignReels;
        private System.Windows.Forms.Button buttonSearchReel;
        private System.Windows.Forms.Button buttonAssignReel;
        private System.Windows.Forms.CheckBox checkBoxSearchReelId;
        private System.Windows.Forms.SplitContainer splitContainerSearchReels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMonitor;
        private System.Windows.Forms.GroupBox groupBoxQueuedUnloadJobs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelQueuedJobs;
        private System.Windows.Forms.Button buttonRemoveJob;
        private System.Windows.Forms.GroupBox groupBoxUnloadingReel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProcessingReel;
        public System.Windows.Forms.Label labelProcessingReelQtyValue;
        public System.Windows.Forms.Label labelProcessingReelMfgValue;
        public System.Windows.Forms.Label labelProcessingReelSupplierValue;
        public System.Windows.Forms.Label labelProcessingReelLotIdValue;
        public System.Windows.Forms.Label labelProcessingReelCarrierValue;
        public System.Windows.Forms.Label labelProcessingReelArticleValue;
        public System.Windows.Forms.Label labelProcessingReelDstValue;
        public System.Windows.Forms.Label labelProcessingReelJobName;
        public System.Windows.Forms.Label labelProcessingReelUser;
        public System.Windows.Forms.Label labelProcessingReelTower;
        public System.Windows.Forms.Label labelProcessingReelTowerStatus;
        public System.Windows.Forms.Label labelProcessingReelSrc;
        public System.Windows.Forms.Label labelProcessingReelDst;
        public System.Windows.Forms.Label labelProcessingReelArticle;
        public System.Windows.Forms.Label labelProcessingReelCarrier;
        public System.Windows.Forms.Label labelProcessingReelLotId;
        public System.Windows.Forms.Label labelProcessingReelSupplier;
        public System.Windows.Forms.Label labelProcessingReelQty;
        public System.Windows.Forms.Label labelProcessingReelMfg;
        public System.Windows.Forms.Label labelProcessingReelJobNameValue;
        public System.Windows.Forms.Label labelProcessingReelUserValue;
        public System.Windows.Forms.Label labelProcessingReelTowerIdValud;
        public System.Windows.Forms.Label labelProcessingReelTowerStatusValue;
        public System.Windows.Forms.Label labelProcessingReelSrcValue;
        private System.Windows.Forms.GroupBox groupBoxPendedReels;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelProvidePage;
        protected System.Windows.Forms.RadioButton radioButtonLoginOperator;
        protected System.Windows.Forms.RadioButton radioButtonSearchReel;
        protected System.Windows.Forms.RadioButton radioButtonJobMonitor;
        protected System.Windows.Forms.TabPage tabPageProvideLoginOperator;
        protected System.Windows.Forms.TabPage tabPageProvideJobMonitor;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearchReel;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelReelId;
        protected System.Windows.Forms.GroupBox groupBoxSearchedReels;
        protected System.Windows.Forms.GroupBox groupBoxAssignedReels;
        protected System.Windows.Forms.Button buttonEnqueueJob;
        protected System.Windows.Forms.Button buttonRemoveReels;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStoreReel;
        protected System.Windows.Forms.GroupBox groupBoxStoreReel;
        protected System.Windows.Forms.Button buttonRequestLoadReel;
        protected System.Windows.Forms.Button buttonClearLoadReelRequest;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelLoadReel;
        public System.Windows.Forms.Label labelLoadReelTowerId;
        protected System.Windows.Forms.ComboBox comboBoxLoadReelTowerIdValue;
        protected System.Windows.Forms.TextBox textBoxLoadReelArticleValue;
        public System.Windows.Forms.Label labelLoadReelType;
        public System.Windows.Forms.Label labelLoadReelSize;
        public System.Windows.Forms.Label labelLoadReelThickness;
        public System.Windows.Forms.Label labelLoadReelArticle;
        public System.Windows.Forms.Label labelLoadReelCarrier;
        public System.Windows.Forms.Label labelLoadReelLotId;
        public System.Windows.Forms.Label labelLoadReelSupplier;
        public System.Windows.Forms.Label labelLoadReelMfg;
        public System.Windows.Forms.Label labelLoadReelQty;
        protected System.Windows.Forms.ComboBox comboBoxLoadReelThicknessValue;
        protected System.Windows.Forms.TextBox textBoxLoadReelCarrierValue;
        protected System.Windows.Forms.ComboBox comboBoxLoadReelSizeValue;
        protected System.Windows.Forms.TextBox textBoxLoadReelLotIdValue;
        protected System.Windows.Forms.TextBox textBoxLoadReelSupplierValue;
        protected System.Windows.Forms.TextBox textBoxLoadReelMfgValue;
        protected System.Windows.Forms.ComboBox comboBoxSearchReelIdTypeValue;
        protected System.Windows.Forms.TextBox textBoxSearchReelIdValue;
        protected System.Windows.Forms.NumericUpDown numericUpDownAssignReelsValue;
        protected System.Windows.Forms.ListView listViewPendedReels;
        protected System.Windows.Forms.GroupBox groupBoxQueryReels;
        protected System.Windows.Forms.Button buttonExecuteQueryReels;
        protected System.Windows.Forms.Button buttonClearQueryReels;
        protected System.Windows.Forms.NumericUpDown numericUpDownLoadReelQtyValue;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanelQueryReels;
        protected System.Windows.Forms.ComboBox comboBoxQueryReelTowerIdValue;
        protected System.Windows.Forms.ComboBox comboBoxQueryReelSizeValue;
        private System.Windows.Forms.CheckBox checkBoxQueryByTowerId;
        private System.Windows.Forms.CheckBox checkBoxQueryByReelSize;
        private System.Windows.Forms.CheckBox checkBoxQueryByLotID;
        private System.Windows.Forms.CheckBox checkBoxQueryByArticle;
        private System.Windows.Forms.CheckBox checkBoxQueryByCarrier;
        protected System.Windows.Forms.TextBox textBoxQueryReelArticleValue;
        protected System.Windows.Forms.TextBox textBoxQueryReelCarrierValue;
        public System.Windows.Forms.Label labelQueryReelCreateDateCondition;
        private System.Windows.Forms.CheckBox checkBox6QueryBySupplier;
        protected System.Windows.Forms.TextBox textBoxQueryReelSupplierValue;
        private System.Windows.Forms.CheckBox checkBoxQueryByDatetime;
        protected System.Windows.Forms.DateTimePicker dateTimePickerQueryReeCreateDateValue;
        private System.Windows.Forms.CheckBox checkBoxQueryByQty;
        protected System.Windows.Forms.NumericUpDown numericUpDownQueryReelQtyValue;
        protected System.Windows.Forms.ComboBox comboBoxQueryReelQtyOptionValue;
        public System.Windows.Forms.Label labelQueryReelQtyCondition;
        protected System.Windows.Forms.ComboBox comboBoxQueryDatetimeOptionValue;
        protected System.Windows.Forms.GroupBox groupBoxQueryResults;
        private System.Windows.Forms.DataGridView dataGridViewQueryResults;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccountManager;
        protected System.Windows.Forms.GroupBox groupBoxAccountManager;
        protected System.Windows.Forms.Button buttonAccountManagerLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccountManagerLogin;
        protected System.Windows.Forms.Label labelAccountManagerId;
        protected System.Windows.Forms.Label labelAccountManagerPassword;
        protected System.Windows.Forms.TextBox textBoxAccountManagerIdValue;
        protected System.Windows.Forms.TextBox textBoxAccountManagerPasswordValue;
        protected System.Windows.Forms.GroupBox groupBoxNewAccount;
        protected System.Windows.Forms.Button buttonQueryUser;
        protected System.Windows.Forms.Button buttonRemoveUser;
        protected System.Windows.Forms.Button buttonAddNewUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAccount;
        protected System.Windows.Forms.Label labelUserRemark;
        protected System.Windows.Forms.Label labelUserGroup;
        protected System.Windows.Forms.Label labelUserPassword;
        protected System.Windows.Forms.TextBox textBoxUserPasswordValue;
        protected System.Windows.Forms.Label labelUserFullname;
        protected System.Windows.Forms.TextBox textBoxUserFullnameValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNotificationListener;
        protected System.Windows.Forms.ListView listViewReelTowerGroupNotifications;
        private System.Windows.Forms.Button buttonSaveDatabase;
        private System.Windows.Forms.Button buttonSaveCombineModules;
        private System.Windows.Forms.Button buttonSaveDevices;
        private System.Windows.Forms.GroupBox groupBoxCombineModules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCombineModules;
        private System.Windows.Forms.GroupBox groupBoxDevices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDevices;
        private System.Windows.Forms.CheckBox checkBoxUnloadRejectMaterial;
        private System.Windows.Forms.CheckBox checkBoxNotifyRejectFull;
        private System.Windows.Forms.CheckBox checkBoxDelayLoadStart;
        private System.Windows.Forms.CheckBox checkBoxReelTowerCommunicationTimeout;
        private System.Windows.Forms.CheckBox checkBoxReelHandlerCommunicationTimeout;
        private System.Windows.Forms.CheckBox checkBoxReelHandlerActionTimeout;
        protected System.Windows.Forms.GroupBox groupBoxMaterialStorage;
        protected System.Windows.Forms.Label labelDisplayLanguage;
        protected System.Windows.Forms.GroupBox groupBoxTimeoutProperties;
        protected System.Windows.Forms.ComboBox comboBoxLoadReelTypeValue;
        public System.Windows.Forms.Label labelLoadReelComment;
        protected System.Windows.Forms.TextBox textBoxLoadReelCommentValue;
        protected System.Windows.Forms.Label labelElapsed;
        protected System.Windows.Forms.Label labelElapsedValue;
        protected System.Windows.Forms.ComboBox comboBoxAccountGroupIdValue;
        protected System.Windows.Forms.Label labelUserId;
        protected System.Windows.Forms.TextBox textBoxUserIdValue;
        protected System.Windows.Forms.TextBox textBoxUserRemarkValue;
        protected System.Windows.Forms.DataGridView dataGridViewSearchedReels;
        protected System.Windows.Forms.DataGridView dataGridViewAssignedReels;
        protected System.Windows.Forms.ComboBox comboBoxAssignJobOutportValue;
        protected System.Windows.Forms.DataGridView dataGridViewQueuedJobs;
        protected System.Windows.Forms.DataGridView dataGridViewReelTowerNetworks;
        protected System.Windows.Forms.DataGridView dataGridViewDatabase;
        protected System.Windows.Forms.DataGridView dataGridViewCombineModules;
        protected System.Windows.Forms.DataGridView dataGridViewDevices;
        protected System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfPort;
        protected System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProperties;
        private System.Windows.Forms.CheckBox checkBoxMaterialValidation;
        private System.Windows.Forms.CheckBox checkBoxMaterialArriveReport;
        private System.Windows.Forms.CheckBox checkBoxMaterialRemoveReport;
        protected System.Windows.Forms.GroupBox groupBoxModel;
        public System.Windows.Forms.Label labelTower4StatusValue;
        protected System.Windows.Forms.ComboBox comboBoxMaterialValidationValue;
        protected System.Windows.Forms.ComboBox comboBoxMaterialArriveReportValue;
        protected System.Windows.Forms.ComboBox comboBoxMaterialRemoveReportValue;
        private System.Windows.Forms.TabPage tabPageProvideJobLog;
        public System.Windows.Forms.ListBox listBoxProvideJobLog;
        private System.Windows.Forms.CheckBox checkBoxReelHandlerUsage;
        protected System.Windows.Forms.ComboBox comboBoxReelHandlerUsageValue;
        private System.Windows.Forms.Button buttonCleanUpMaterials;
        protected System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        protected System.Windows.Forms.CheckBox checkBoxTakeoutByRobot;
        private System.Windows.Forms.CheckBox checkBoxJobSplitReelCount;
        protected System.Windows.Forms.NumericUpDown numericUpDownJobSplitReelCountValue;
        private System.Windows.Forms.CheckBox checkBoxTimeoutOfReject;
        protected System.Windows.Forms.NumericUpDown numericUpDownTimeoutOfRejectValue;
        private System.Windows.Forms.Button buttonSaveMaterialInformation;
        private System.Windows.Forms.GroupBox groupBoxMaterialInformation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMaterialInformation;
        protected System.Windows.Forms.DataGridView dataGridViewMaterialInformation;
        protected System.Windows.Forms.Label labelMaterialName;
        protected System.Windows.Forms.TextBox textBoxMaterialNameValue;
        protected System.Windows.Forms.Label labelMaterialType;
        protected System.Windows.Forms.ComboBox comboBoxMaterialTypeValue;
        protected System.Windows.Forms.Button buttonDeleteMaterialInformation;
        protected System.Windows.Forms.Button buttonFindMaterialInformation;
        protected System.Windows.Forms.Button buttonAddMaterialInformation;
        protected System.Windows.Forms.ComboBox comboBoxProvideModeValue;
        protected System.Windows.Forms.ComboBox comboBoxRemapCreateTimeByMFGValue;
        private System.Windows.Forms.CheckBox checkBoxProvideMode;
        private System.Windows.Forms.CheckBox checkBoxRemapCreateTimeByMFG;
        private System.Windows.Forms.CheckBox checkBoxAssignedRejectPort;
        protected System.Windows.Forms.ComboBox comboBoxAssignedRejectPortValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnArticleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        protected System.Windows.Forms.ComboBox comboBoxAMMUsageValue;
        private System.Windows.Forms.CheckBox checkBoxAMMUsage;
        protected System.Windows.Forms.ComboBox comboBoxRejectAutoUsageValue;
        private System.Windows.Forms.CheckBox checkBoxRejectAutoUsage;
        public System.Windows.Forms.Label labelAMMStatusValue;
        public System.Windows.Forms.Label labelAMMStatus;
        protected System.Windows.Forms.Button buttonExecuteDBSync;
        private System.Windows.Forms.CheckBox checkBoxQueryByCustomerDB;
        private System.Windows.Forms.Button buttonSaveTower;
        private System.Windows.Forms.GroupBox groupBoxTower;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTower;
        protected System.Windows.Forms.DataGridView dataGridViewTower;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfCombineModuleIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfCombineModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfCombineModulePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfCombineModuleCaption;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDeviceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDeviceName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnOfDeviceHid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDeviceHardwareId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDeviceSerialSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDeviceEthernetSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDbIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDbServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfDbFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOfUser;
        protected System.Windows.Forms.Button buttonMissmathSearch;
        private System.Windows.Forms.RadioButton radioButtonSearchAll;
        private System.Windows.Forms.RadioButton radioButtonSerachMissmatch;
        protected System.Windows.Forms.TextBox textBoxQueryLotIDValue;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAMMAlive;
        protected System.Windows.Forms.ComboBox comboBoxAMMWebserviceUsageValue;
        private System.Windows.Forms.CheckBox checkBoxAMMWebserviceUsage;
        private System.Windows.Forms.TabPage tabPageAMM;
        public System.Windows.Forms.TabControl tabControlMain;
        protected System.Windows.Forms.Button buttonExecuteTowerSync;
        protected System.Windows.Forms.Label labelApplicationVersion;
        public System.Windows.Forms.Button buttonTakeoutByRobot;
    }
}

