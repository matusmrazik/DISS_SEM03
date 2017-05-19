namespace SEM03.GUI
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.frameResults = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTimeValue = new System.Windows.Forms.Label();
            this.labelReplication = new System.Windows.Forms.Label();
            this.labelReplicationValue = new System.Windows.Forms.Label();
            this.labelWorkers1Current = new System.Windows.Forms.Label();
            this.labelWorkers1CurrentValue = new System.Windows.Forms.Label();
            this.labelWorkers2Current = new System.Windows.Forms.Label();
            this.labelWorkers2CurrentValue = new System.Windows.Forms.Label();
            this.groupBoxSimulationControl = new System.Windows.Forms.GroupBox();
            this.labelHigh = new System.Windows.Forms.Label();
            this.labelLow = new System.Windows.Forms.Label();
            this.labelFast = new System.Windows.Forms.Label();
            this.labelSlow = new System.Windows.Forms.Label();
            this.horizontalSliderSimRefreshRate = new System.Windows.Forms.TrackBar();
            this.horizontalSliderSimSpeed = new System.Windows.Forms.TrackBar();
            this.labelSimRefreshRateValue = new System.Windows.Forms.Label();
            this.labelSimRefreshRate = new System.Windows.Forms.Label();
            this.labelSimSpeedValue = new System.Windows.Forms.Label();
            this.labelSimSpeed = new System.Windows.Forms.Label();
            this.checkBoxWatchModeEnabled = new System.Windows.Forms.CheckBox();
            this.pushButtonStopSimulation = new System.Windows.Forms.Button();
            this.pushButtonPauseResumeSimulation = new System.Windows.Forms.Button();
            this.pushButtonStartSimulation = new System.Windows.Forms.Button();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.labelEuro = new System.Windows.Forms.Label();
            this.spinBoxAdInvestment = new System.Windows.Forms.NumericUpDown();
            this.labelAdInvestment = new System.Windows.Forms.Label();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.spinBoxReplicationDuration = new System.Windows.Forms.NumericUpDown();
            this.labelReplicationDuration = new System.Windows.Forms.Label();
            this.spinBoxReplications = new System.Windows.Forms.NumericUpDown();
            this.labelReplications = new System.Windows.Forms.Label();
            this.spinBoxWorkers2Max = new System.Windows.Forms.NumericUpDown();
            this.spinBoxWorkers2Min = new System.Windows.Forms.NumericUpDown();
            this.labelWorkers2Max = new System.Windows.Forms.Label();
            this.labelWorkers2Min = new System.Windows.Forms.Label();
            this.checkBoxRangeWorkers2 = new System.Windows.Forms.CheckBox();
            this.spinBoxWorkers2 = new System.Windows.Forms.NumericUpDown();
            this.labelWorkers2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Label();
            this.spinBoxWorkers1Max = new System.Windows.Forms.NumericUpDown();
            this.spinBoxWorkers1Min = new System.Windows.Forms.NumericUpDown();
            this.labelWorkers1Max = new System.Windows.Forms.Label();
            this.labelWorkers1Min = new System.Windows.Forms.Label();
            this.checkBoxRangeWorkers1 = new System.Windows.Forms.CheckBox();
            this.spinBoxWorkers1 = new System.Windows.Forms.NumericUpDown();
            this.labelWorkers1 = new System.Windows.Forms.Label();
            this.groupBoxSeed = new System.Windows.Forms.GroupBox();
            this.labelUsedSeedValue = new System.Windows.Forms.TextBox();
            this.labelUsedSeed = new System.Windows.Forms.Label();
            this.spinBoxCustomSeed = new System.Windows.Forms.NumericUpDown();
            this.radioButtonCustomSeed = new System.Windows.Forms.RadioButton();
            this.radioButtonRandomSeed = new System.Windows.Forms.RadioButton();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.tabWidgetOutput = new System.Windows.Forms.TabControl();
            this.tabSimulation = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelSimulation = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxIdealWorkersCount = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelIdealWorkersCount = new System.Windows.Forms.TableLayoutPanel();
            this.labelIdealWorkers1Count = new System.Windows.Forms.Label();
            this.labelIdealWorkers1CountValue = new System.Windows.Forms.Label();
            this.labelIdealWorkers2Count = new System.Windows.Forms.Label();
            this.labelIdealWorkers2CountValue = new System.Windows.Forms.Label();
            this.labelIdealMonthlyProfit = new System.Windows.Forms.Label();
            this.labelIdealMonthlyProfitValue = new System.Windows.Forms.Label();
            this.groupBoxSimulationStats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSimulationStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelSimCarPark2RatioISValue = new System.Windows.Forms.Label();
            this.labelSimCarPark2RatioIS = new System.Windows.Forms.Label();
            this.labelSimCarPark1RatioISValue = new System.Windows.Forms.Label();
            this.labelSimCarPark1RatioIS = new System.Windows.Forms.Label();
            this.labelSimCarParkServiceCountISValue = new System.Windows.Forms.Label();
            this.labelSimCarParkServiceCountIS = new System.Windows.Forms.Label();
            this.labelSimCarPark2CountISValue = new System.Windows.Forms.Label();
            this.labelSimCarPark2CountIS = new System.Windows.Forms.Label();
            this.labelSimCarPark1CountISValue = new System.Windows.Forms.Label();
            this.labelSimCarPark1CountIS = new System.Windows.Forms.Label();
            this.labelSimWorking2RatioISValue = new System.Windows.Forms.Label();
            this.labelSimWorking2RatioIS = new System.Windows.Forms.Label();
            this.labelSimWorking1RatioISValue = new System.Windows.Forms.Label();
            this.labelSimWorking1RatioIS = new System.Windows.Forms.Label();
            this.labelSimWorking2CountISValue = new System.Windows.Forms.Label();
            this.labelSimWorking2CountIS = new System.Windows.Forms.Label();
            this.labelSimWorking1CountISValue = new System.Windows.Forms.Label();
            this.labelSimWorking1CountIS = new System.Windows.Forms.Label();
            this.labelSimCustomersServedRatioISValue = new System.Windows.Forms.Label();
            this.labelSimCustomersServedRatioIS = new System.Windows.Forms.Label();
            this.labelSimReturnQueueLengthISValue = new System.Windows.Forms.Label();
            this.labelSimReturnQueueLengthIS = new System.Windows.Forms.Label();
            this.labelSimRepairedQueueLengthISValue = new System.Windows.Forms.Label();
            this.labelSimRepairedQueueLengthIS = new System.Windows.Forms.Label();
            this.labelSimToRepairQueueLengthISValue = new System.Windows.Forms.Label();
            this.labelSimToRepairQueueLengthIS = new System.Windows.Forms.Label();
            this.labelSimCustomerInQueueISValue = new System.Windows.Forms.Label();
            this.labelSimCustomerInQueueIS = new System.Windows.Forms.Label();
            this.labelSimCustomersInServiceISValue = new System.Windows.Forms.Label();
            this.labelSimCustomersInServiceIS = new System.Windows.Forms.Label();
            this.labelSimCustomerInQueue = new System.Windows.Forms.Label();
            this.labelSimCustomerInQueueValue = new System.Windows.Forms.Label();
            this.labelSimToRepairQueueLengthValue = new System.Windows.Forms.Label();
            this.labelSimReturnQueueLengthValue = new System.Windows.Forms.Label();
            this.labelSimWaitInQueueValue = new System.Windows.Forms.Label();
            this.labelSimWaitForRepairValue = new System.Windows.Forms.Label();
            this.labelSimTimeInServiceValue = new System.Windows.Forms.Label();
            this.labelSimWaitInQueueISValue = new System.Windows.Forms.Label();
            this.labelSimWaitForRepairISValue = new System.Windows.Forms.Label();
            this.labelSimTimeInServiceISValue = new System.Windows.Forms.Label();
            this.labelSimToRepairQueueLength = new System.Windows.Forms.Label();
            this.labelSimReturnQueueLength = new System.Windows.Forms.Label();
            this.labelSimWaitInQueue = new System.Windows.Forms.Label();
            this.labelSimWaitForRepair = new System.Windows.Forms.Label();
            this.labelSimTimeInService = new System.Windows.Forms.Label();
            this.labelSimWaitInQueueIS = new System.Windows.Forms.Label();
            this.labelSimWaitForRepairIS = new System.Windows.Forms.Label();
            this.labelSimTimeInServiceIS = new System.Windows.Forms.Label();
            this.labelSimCustomersInService = new System.Windows.Forms.Label();
            this.labelSimCustomersInServiceValue = new System.Windows.Forms.Label();
            this.labelSimRepairedQueueLength = new System.Windows.Forms.Label();
            this.labelSimCustomersServedRatio = new System.Windows.Forms.Label();
            this.labelSimRepairedQueueLengthValue = new System.Windows.Forms.Label();
            this.labelSimCustomersServedRatioValue = new System.Windows.Forms.Label();
            this.labelSimWorking1Count = new System.Windows.Forms.Label();
            this.labelSimWorking2Count = new System.Windows.Forms.Label();
            this.labelSimWorking1Ratio = new System.Windows.Forms.Label();
            this.labelSimWorking2Ratio = new System.Windows.Forms.Label();
            this.labelSimCarPark1Count = new System.Windows.Forms.Label();
            this.labelSimCarPark2Count = new System.Windows.Forms.Label();
            this.labelSimCarParkServiceCount = new System.Windows.Forms.Label();
            this.labelSimCarPark1Ratio = new System.Windows.Forms.Label();
            this.labelSimCarPark2Ratio = new System.Windows.Forms.Label();
            this.labelSimWorking1CountValue = new System.Windows.Forms.Label();
            this.labelSimWorking2CountValue = new System.Windows.Forms.Label();
            this.labelSimWorking1RatioValue = new System.Windows.Forms.Label();
            this.labelSimWorking2RatioValue = new System.Windows.Forms.Label();
            this.labelSimCarPark1CountValue = new System.Windows.Forms.Label();
            this.labelSimCarPark2CountValue = new System.Windows.Forms.Label();
            this.labelSimCarParkServiceCountValue = new System.Windows.Forms.Label();
            this.labelSimCarPark1RatioValue = new System.Windows.Forms.Label();
            this.labelSimCarPark2RatioValue = new System.Windows.Forms.Label();
            this.labelSimProfit = new System.Windows.Forms.Label();
            this.labelSimProfitValue = new System.Windows.Forms.Label();
            this.labelSimProfitIS = new System.Windows.Forms.Label();
            this.labelSimProfitISValue = new System.Windows.Forms.Label();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCustomers = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomersStats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCustomersStats = new System.Windows.Forms.TableLayoutPanel();
            this.labelCustomersInService = new System.Windows.Forms.Label();
            this.labelCustomersInQueue = new System.Windows.Forms.Label();
            this.labelCustomersTotal = new System.Windows.Forms.Label();
            this.labelCustomersServed = new System.Windows.Forms.Label();
            this.labelCustomersNotServed = new System.Windows.Forms.Label();
            this.labelCustomersServedRatio = new System.Windows.Forms.Label();
            this.labelCustomersInServiceValue = new System.Windows.Forms.Label();
            this.labelCustomersInQueueValue = new System.Windows.Forms.Label();
            this.labelCustomersTotalValue = new System.Windows.Forms.Label();
            this.labelCustomersServedValue = new System.Windows.Forms.Label();
            this.labelCustomersNotServedValue = new System.Windows.Forms.Label();
            this.labelCustomersServedRatioValue = new System.Windows.Forms.Label();
            this.labelCustomersAvgInService = new System.Windows.Forms.Label();
            this.labelCustomersAvgInQueue = new System.Windows.Forms.Label();
            this.labelCustomersAvgWaitInQueue = new System.Windows.Forms.Label();
            this.labelCustomersAvgWaitForRepair = new System.Windows.Forms.Label();
            this.labelCustomersAvgTimeInService = new System.Windows.Forms.Label();
            this.labelCustomersAvgInServiceValue = new System.Windows.Forms.Label();
            this.labelCustomersAvgInQueueValue = new System.Windows.Forms.Label();
            this.labelCustomersAvgWaitInQueueValue = new System.Windows.Forms.Label();
            this.labelCustomersAvgWaitForRepairValue = new System.Windows.Forms.Label();
            this.labelCustomersAvgTimeInServiceValue = new System.Windows.Forms.Label();
            this.tabWorkers1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelWorkers1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxWorkers1Stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWorkers1Stats = new System.Windows.Forms.TableLayoutPanel();
            this.labelWorkers1WorkingCount = new System.Windows.Forms.Label();
            this.labelWorkers1WorkingCountValue = new System.Windows.Forms.Label();
            this.labelWorkers1WorkingRatio = new System.Windows.Forms.Label();
            this.labelWorkers1WorkingRatioValue = new System.Windows.Forms.Label();
            this.labelWorkers1ReturnQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers1ReturnQueueLengthValue = new System.Windows.Forms.Label();
            this.labelWorkers1AvgWorkingCount = new System.Windows.Forms.Label();
            this.labelWorkers1AvgWorkingRatio = new System.Windows.Forms.Label();
            this.labelWorkers1AvgReturnQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers1AvgWorkingCountValue = new System.Windows.Forms.Label();
            this.labelWorkers1AvgWorkingRatioValue = new System.Windows.Forms.Label();
            this.labelWorkers1AvgReturnQueueLengthValue = new System.Windows.Forms.Label();
            this.dataGridViewWorkers1 = new System.Windows.Forms.DataGridView();
            this.tabWorkers2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelWorkers2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxWorkers2Stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWorkers2Stats = new System.Windows.Forms.TableLayoutPanel();
            this.labelWorkers2WorkingCount = new System.Windows.Forms.Label();
            this.labelWorkers2WorkingCountValue = new System.Windows.Forms.Label();
            this.labelWorkers2WorkingRatio = new System.Windows.Forms.Label();
            this.labelWorkers2WorkingRatioValue = new System.Windows.Forms.Label();
            this.labelWorkers2ToRepairQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers2ToRepairQueueLengthValue = new System.Windows.Forms.Label();
            this.labelWorkers2AvgWorkingCount = new System.Windows.Forms.Label();
            this.labelWorkers2AvgWorkingRatio = new System.Windows.Forms.Label();
            this.labelWorkers2AvgToRepairQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers2AvgWorkingCountValue = new System.Windows.Forms.Label();
            this.labelWorkers2AvgWorkingRatioValue = new System.Windows.Forms.Label();
            this.labelWorkers2AvgToRepairQueueLengthValue = new System.Windows.Forms.Label();
            this.labelWorkers2RepairedQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers2RepairedQueueLengthValue = new System.Windows.Forms.Label();
            this.labelWorkers2AvgRepairedQueueLength = new System.Windows.Forms.Label();
            this.labelWorkers2AvgRepairedQueueLengthValue = new System.Windows.Forms.Label();
            this.dataGridViewWorkers2 = new System.Windows.Forms.DataGridView();
            this.tabCarParks = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCarParks = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxCarPark1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarPark1 = new System.Windows.Forms.DataGridView();
            this.groupBoxCarPark2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCarPark2 = new System.Windows.Forms.DataGridView();
            this.groupBoxCarPark1Stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCarPark1Stats = new System.Windows.Forms.TableLayoutPanel();
            this.labelCarPark1OccupiedCount = new System.Windows.Forms.Label();
            this.labelCarPark1AvgOccupiedCount = new System.Windows.Forms.Label();
            this.labelCarPark1OccupiedRatio = new System.Windows.Forms.Label();
            this.labelCarPark1AvgOccupiedRatio = new System.Windows.Forms.Label();
            this.labelCarPark1OccupiedCountValue = new System.Windows.Forms.Label();
            this.labelCarPark1AvgOccupiedCountValue = new System.Windows.Forms.Label();
            this.labelCarPark1OccupiedRatioValue = new System.Windows.Forms.Label();
            this.labelCarPark1AvgOccupiedRatioValue = new System.Windows.Forms.Label();
            this.groupBoxCarPark2Stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCarPark2Stats = new System.Windows.Forms.TableLayoutPanel();
            this.labelCarPark2OccupiedCount = new System.Windows.Forms.Label();
            this.labelCarPark2AvgOccupiedCount = new System.Windows.Forms.Label();
            this.labelCarPark2OccupiedRatio = new System.Windows.Forms.Label();
            this.labelCarPark2AvgOccupiedRatio = new System.Windows.Forms.Label();
            this.labelCarPark2OccupiedCountValue = new System.Windows.Forms.Label();
            this.labelCarPark2AvgOccupiedCountValue = new System.Windows.Forms.Label();
            this.labelCarPark2OccupiedRatioValue = new System.Windows.Forms.Label();
            this.labelCarPark2AvgOccupiedRatioValue = new System.Windows.Forms.Label();
            this.groupBoxCarParkService = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelCarParkService = new System.Windows.Forms.TableLayoutPanel();
            this.labelCarParkServiceCount = new System.Windows.Forms.Label();
            this.labelCarParkServiceAvgCount = new System.Windows.Forms.Label();
            this.labelCarParkServiceCountValue = new System.Windows.Forms.Label();
            this.labelCarParkServiceAvgCountValue = new System.Windows.Forms.Label();
            this.tabQueueLenWorkers1 = new System.Windows.Forms.TabPage();
            this.widgetPlotQueueLenWorkers1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frameQueueLenWorkers1 = new System.Windows.Forms.Panel();
            this.spinBoxQueueLenFixWorkers2 = new System.Windows.Forms.NumericUpDown();
            this.labelQueueLenFixWorkers2 = new System.Windows.Forms.Label();
            this.tabQueueLenWorkers2 = new System.Windows.Forms.TabPage();
            this.widgetPlotQueueLenWorkers2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frameQueueLenWorkers2 = new System.Windows.Forms.Panel();
            this.spinBoxQueueLenFixWorkers1 = new System.Windows.Forms.NumericUpDown();
            this.labelQueueLenFixWorkers1 = new System.Windows.Forms.Label();
            this.tabTimeInServiceWorkers1 = new System.Windows.Forms.TabPage();
            this.widgetPlotTimeInServiceWorkers1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frameTimeInServiceWorkers1 = new System.Windows.Forms.Panel();
            this.spinBoxTimeInServiceFixWorkers2 = new System.Windows.Forms.NumericUpDown();
            this.labelTimeInServiceFixWorkers2 = new System.Windows.Forms.Label();
            this.tabTimeInServiceWorkers2 = new System.Windows.Forms.TabPage();
            this.widgetPlotTimeInServiceWorkers2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frameTimeInServiceWorkers2 = new System.Windows.Forms.Panel();
            this.spinBoxTimeInServiceFixWorkers1 = new System.Windows.Forms.NumericUpDown();
            this.labelTimeInServiceFixWorkers1 = new System.Windows.Forms.Label();
            this.centralWidget = new System.Windows.Forms.Panel();
            this.tabVehicles = new System.Windows.Forms.TabPage();
            this.dataGridViewVehicles = new System.Windows.Forms.DataGridView();
            this.groupBoxSimulation.SuspendLayout();
            this.frameResults.SuspendLayout();
            this.groupBoxSimulationControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimSpeed)).BeginInit();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxAdInvestment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxReplicationDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxReplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1)).BeginInit();
            this.groupBoxSeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxCustomSeed)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.tabWidgetOutput.SuspendLayout();
            this.tabSimulation.SuspendLayout();
            this.tableLayoutPanelSimulation.SuspendLayout();
            this.groupBoxIdealWorkersCount.SuspendLayout();
            this.tableLayoutPanelIdealWorkersCount.SuspendLayout();
            this.groupBoxSimulationStats.SuspendLayout();
            this.tableLayoutPanelSimulationStats.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            this.tableLayoutPanelCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.groupBoxCustomersStats.SuspendLayout();
            this.tableLayoutPanelCustomersStats.SuspendLayout();
            this.tabWorkers1.SuspendLayout();
            this.tableLayoutPanelWorkers1.SuspendLayout();
            this.groupBoxWorkers1Stats.SuspendLayout();
            this.tableLayoutPanelWorkers1Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers1)).BeginInit();
            this.tabWorkers2.SuspendLayout();
            this.tableLayoutPanelWorkers2.SuspendLayout();
            this.groupBoxWorkers2Stats.SuspendLayout();
            this.tableLayoutPanelWorkers2Stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers2)).BeginInit();
            this.tabCarParks.SuspendLayout();
            this.tableLayoutPanelCarParks.SuspendLayout();
            this.groupBoxCarPark1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPark1)).BeginInit();
            this.groupBoxCarPark2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPark2)).BeginInit();
            this.groupBoxCarPark1Stats.SuspendLayout();
            this.tableLayoutPanelCarPark1Stats.SuspendLayout();
            this.groupBoxCarPark2Stats.SuspendLayout();
            this.tableLayoutPanelCarPark2Stats.SuspendLayout();
            this.groupBoxCarParkService.SuspendLayout();
            this.tableLayoutPanelCarParkService.SuspendLayout();
            this.tabQueueLenWorkers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotQueueLenWorkers1)).BeginInit();
            this.frameQueueLenWorkers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueueLenFixWorkers2)).BeginInit();
            this.tabQueueLenWorkers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotQueueLenWorkers2)).BeginInit();
            this.frameQueueLenWorkers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueueLenFixWorkers1)).BeginInit();
            this.tabTimeInServiceWorkers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotTimeInServiceWorkers1)).BeginInit();
            this.frameTimeInServiceWorkers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxTimeInServiceFixWorkers2)).BeginInit();
            this.tabTimeInServiceWorkers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotTimeInServiceWorkers2)).BeginInit();
            this.frameTimeInServiceWorkers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxTimeInServiceFixWorkers1)).BeginInit();
            this.centralWidget.SuspendLayout();
            this.tabVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSimulation.Controls.Add(this.frameResults);
            this.groupBoxSimulation.Controls.Add(this.groupBoxSimulationControl);
            this.groupBoxSimulation.Controls.Add(this.groupBoxParameters);
            this.groupBoxSimulation.Controls.Add(this.groupBoxSeed);
            this.groupBoxSimulation.Location = new System.Drawing.Point(9, 9);
            this.groupBoxSimulation.Margin = new System.Windows.Forms.Padding(9);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(1239, 250);
            this.groupBoxSimulation.TabIndex = 0;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "Simulácia";
            // 
            // frameResults
            // 
            this.frameResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameResults.ColumnCount = 8;
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.frameResults.Controls.Add(this.labelTime, 0, 0);
            this.frameResults.Controls.Add(this.labelTimeValue, 1, 0);
            this.frameResults.Controls.Add(this.labelReplication, 2, 0);
            this.frameResults.Controls.Add(this.labelReplicationValue, 3, 0);
            this.frameResults.Controls.Add(this.labelWorkers1Current, 4, 0);
            this.frameResults.Controls.Add(this.labelWorkers1CurrentValue, 5, 0);
            this.frameResults.Controls.Add(this.labelWorkers2Current, 6, 0);
            this.frameResults.Controls.Add(this.labelWorkers2CurrentValue, 7, 0);
            this.frameResults.Location = new System.Drawing.Point(6, 214);
            this.frameResults.Name = "frameResults";
            this.frameResults.RowCount = 1;
            this.frameResults.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.frameResults.Size = new System.Drawing.Size(1227, 30);
            this.frameResults.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(20, 5);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(130, 20);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Simulačný čas:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeValue.Location = new System.Drawing.Point(156, 5);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(130, 20);
            this.labelTimeValue.TabIndex = 0;
            this.labelTimeValue.Text = "-";
            this.labelTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReplication
            // 
            this.labelReplication.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelReplication.Location = new System.Drawing.Point(326, 5);
            this.labelReplication.Name = "labelReplication";
            this.labelReplication.Size = new System.Drawing.Size(130, 20);
            this.labelReplication.TabIndex = 2;
            this.labelReplication.Text = "Replikácia:";
            this.labelReplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReplicationValue
            // 
            this.labelReplicationValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelReplicationValue.Location = new System.Drawing.Point(462, 5);
            this.labelReplicationValue.Name = "labelReplicationValue";
            this.labelReplicationValue.Size = new System.Drawing.Size(120, 20);
            this.labelReplicationValue.TabIndex = 3;
            this.labelReplicationValue.Text = "-";
            this.labelReplicationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1Current
            // 
            this.labelWorkers1Current.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1Current.Location = new System.Drawing.Point(632, 5);
            this.labelWorkers1Current.Name = "labelWorkers1Current";
            this.labelWorkers1Current.Size = new System.Drawing.Size(130, 20);
            this.labelWorkers1Current.TabIndex = 4;
            this.labelWorkers1Current.Text = "Počet pracovníkov 1:";
            this.labelWorkers1Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1CurrentValue
            // 
            this.labelWorkers1CurrentValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1CurrentValue.Location = new System.Drawing.Point(768, 5);
            this.labelWorkers1CurrentValue.Name = "labelWorkers1CurrentValue";
            this.labelWorkers1CurrentValue.Size = new System.Drawing.Size(120, 20);
            this.labelWorkers1CurrentValue.TabIndex = 5;
            this.labelWorkers1CurrentValue.Text = "-";
            this.labelWorkers1CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2Current
            // 
            this.labelWorkers2Current.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2Current.Location = new System.Drawing.Point(938, 5);
            this.labelWorkers2Current.Name = "labelWorkers2Current";
            this.labelWorkers2Current.Size = new System.Drawing.Size(130, 20);
            this.labelWorkers2Current.TabIndex = 6;
            this.labelWorkers2Current.Text = "Počet pracovníkov 2:";
            this.labelWorkers2Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2CurrentValue
            // 
            this.labelWorkers2CurrentValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2CurrentValue.Location = new System.Drawing.Point(1074, 5);
            this.labelWorkers2CurrentValue.Name = "labelWorkers2CurrentValue";
            this.labelWorkers2CurrentValue.Size = new System.Drawing.Size(120, 20);
            this.labelWorkers2CurrentValue.TabIndex = 7;
            this.labelWorkers2CurrentValue.Text = "-";
            this.labelWorkers2CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSimulationControl
            // 
            this.groupBoxSimulationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSimulationControl.Controls.Add(this.labelHigh);
            this.groupBoxSimulationControl.Controls.Add(this.labelLow);
            this.groupBoxSimulationControl.Controls.Add(this.labelFast);
            this.groupBoxSimulationControl.Controls.Add(this.labelSlow);
            this.groupBoxSimulationControl.Controls.Add(this.horizontalSliderSimRefreshRate);
            this.groupBoxSimulationControl.Controls.Add(this.horizontalSliderSimSpeed);
            this.groupBoxSimulationControl.Controls.Add(this.labelSimRefreshRateValue);
            this.groupBoxSimulationControl.Controls.Add(this.labelSimRefreshRate);
            this.groupBoxSimulationControl.Controls.Add(this.labelSimSpeedValue);
            this.groupBoxSimulationControl.Controls.Add(this.labelSimSpeed);
            this.groupBoxSimulationControl.Controls.Add(this.checkBoxWatchModeEnabled);
            this.groupBoxSimulationControl.Controls.Add(this.pushButtonStopSimulation);
            this.groupBoxSimulationControl.Controls.Add(this.pushButtonPauseResumeSimulation);
            this.groupBoxSimulationControl.Controls.Add(this.pushButtonStartSimulation);
            this.groupBoxSimulationControl.Location = new System.Drawing.Point(883, 19);
            this.groupBoxSimulationControl.MinimumSize = new System.Drawing.Size(350, 0);
            this.groupBoxSimulationControl.Name = "groupBoxSimulationControl";
            this.groupBoxSimulationControl.Size = new System.Drawing.Size(350, 190);
            this.groupBoxSimulationControl.TabIndex = 2;
            this.groupBoxSimulationControl.TabStop = false;
            this.groupBoxSimulationControl.Text = "Ovládanie simulácie";
            // 
            // labelHigh
            // 
            this.labelHigh.Location = new System.Drawing.Point(285, 170);
            this.labelHigh.Name = "labelHigh";
            this.labelHigh.Size = new System.Drawing.Size(55, 17);
            this.labelHigh.TabIndex = 13;
            this.labelHigh.Text = "Veľká";
            this.labelHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLow
            // 
            this.labelLow.Location = new System.Drawing.Point(130, 170);
            this.labelLow.Name = "labelLow";
            this.labelLow.Size = new System.Drawing.Size(55, 17);
            this.labelLow.TabIndex = 12;
            this.labelLow.Text = "Malá";
            this.labelLow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFast
            // 
            this.labelFast.Location = new System.Drawing.Point(285, 120);
            this.labelFast.Name = "labelFast";
            this.labelFast.Size = new System.Drawing.Size(55, 17);
            this.labelFast.TabIndex = 11;
            this.labelFast.Text = "Veľká";
            this.labelFast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSlow
            // 
            this.labelSlow.Location = new System.Drawing.Point(130, 120);
            this.labelSlow.Name = "labelSlow";
            this.labelSlow.Size = new System.Drawing.Size(55, 17);
            this.labelSlow.TabIndex = 10;
            this.labelSlow.Text = "Malá";
            this.labelSlow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // horizontalSliderSimRefreshRate
            // 
            this.horizontalSliderSimRefreshRate.AutoSize = false;
            this.horizontalSliderSimRefreshRate.Enabled = false;
            this.horizontalSliderSimRefreshRate.LargeChange = 10;
            this.horizontalSliderSimRefreshRate.Location = new System.Drawing.Point(140, 140);
            this.horizontalSliderSimRefreshRate.Maximum = 100;
            this.horizontalSliderSimRefreshRate.Minimum = 1;
            this.horizontalSliderSimRefreshRate.Name = "horizontalSliderSimRefreshRate";
            this.horizontalSliderSimRefreshRate.Size = new System.Drawing.Size(190, 30);
            this.horizontalSliderSimRefreshRate.TabIndex = 9;
            this.horizontalSliderSimRefreshRate.TickFrequency = 10;
            this.horizontalSliderSimRefreshRate.Value = 10;
            this.horizontalSliderSimRefreshRate.ValueChanged += new System.EventHandler(this.HorizontalSliderSimRefreshRate_ValueChanged);
            // 
            // horizontalSliderSimSpeed
            // 
            this.horizontalSliderSimSpeed.AutoSize = false;
            this.horizontalSliderSimSpeed.Enabled = false;
            this.horizontalSliderSimSpeed.LargeChange = 10;
            this.horizontalSliderSimSpeed.Location = new System.Drawing.Point(140, 90);
            this.horizontalSliderSimSpeed.Maximum = 1000;
            this.horizontalSliderSimSpeed.Name = "horizontalSliderSimSpeed";
            this.horizontalSliderSimSpeed.Size = new System.Drawing.Size(190, 30);
            this.horizontalSliderSimSpeed.TabIndex = 8;
            this.horizontalSliderSimSpeed.TickFrequency = 50;
            this.horizontalSliderSimSpeed.Value = 20;
            this.horizontalSliderSimSpeed.ValueChanged += new System.EventHandler(this.HorizontalSliderSimSpeed_ValueChanged);
            // 
            // labelSimRefreshRateValue
            // 
            this.labelSimRefreshRateValue.Location = new System.Drawing.Point(10, 160);
            this.labelSimRefreshRateValue.Name = "labelSimRefreshRateValue";
            this.labelSimRefreshRateValue.Size = new System.Drawing.Size(100, 17);
            this.labelSimRefreshRateValue.TabIndex = 7;
            this.labelSimRefreshRateValue.Text = "-";
            // 
            // labelSimRefreshRate
            // 
            this.labelSimRefreshRate.Location = new System.Drawing.Point(10, 140);
            this.labelSimRefreshRate.Name = "labelSimRefreshRate";
            this.labelSimRefreshRate.Size = new System.Drawing.Size(120, 17);
            this.labelSimRefreshRate.TabIndex = 6;
            this.labelSimRefreshRate.Text = "Rýchlosť obnovovania";
            // 
            // labelSimSpeedValue
            // 
            this.labelSimSpeedValue.Location = new System.Drawing.Point(10, 110);
            this.labelSimSpeedValue.Name = "labelSimSpeedValue";
            this.labelSimSpeedValue.Size = new System.Drawing.Size(100, 17);
            this.labelSimSpeedValue.TabIndex = 5;
            this.labelSimSpeedValue.Text = "-";
            // 
            // labelSimSpeed
            // 
            this.labelSimSpeed.Location = new System.Drawing.Point(10, 90);
            this.labelSimSpeed.Name = "labelSimSpeed";
            this.labelSimSpeed.Size = new System.Drawing.Size(120, 17);
            this.labelSimSpeed.TabIndex = 4;
            this.labelSimSpeed.Text = "Rýchlosť simulácie";
            this.labelSimSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxWatchModeEnabled
            // 
            this.checkBoxWatchModeEnabled.Location = new System.Drawing.Point(10, 63);
            this.checkBoxWatchModeEnabled.Name = "checkBoxWatchModeEnabled";
            this.checkBoxWatchModeEnabled.Size = new System.Drawing.Size(190, 20);
            this.checkBoxWatchModeEnabled.TabIndex = 3;
            this.checkBoxWatchModeEnabled.Text = "Sledovať priebeh simulácie";
            this.checkBoxWatchModeEnabled.UseVisualStyleBackColor = true;
            this.checkBoxWatchModeEnabled.CheckedChanged += new System.EventHandler(this.CheckBoxWatchModeEnabled_CheckedChanged);
            // 
            // pushButtonStopSimulation
            // 
            this.pushButtonStopSimulation.Enabled = false;
            this.pushButtonStopSimulation.Location = new System.Drawing.Point(240, 30);
            this.pushButtonStopSimulation.Name = "pushButtonStopSimulation";
            this.pushButtonStopSimulation.Size = new System.Drawing.Size(100, 25);
            this.pushButtonStopSimulation.TabIndex = 2;
            this.pushButtonStopSimulation.Text = "Zastaviť";
            this.pushButtonStopSimulation.UseVisualStyleBackColor = true;
            this.pushButtonStopSimulation.Click += new System.EventHandler(this.PushButtonStopSimulation_Click);
            // 
            // pushButtonPauseResumeSimulation
            // 
            this.pushButtonPauseResumeSimulation.Enabled = false;
            this.pushButtonPauseResumeSimulation.Location = new System.Drawing.Point(120, 30);
            this.pushButtonPauseResumeSimulation.Name = "pushButtonPauseResumeSimulation";
            this.pushButtonPauseResumeSimulation.Size = new System.Drawing.Size(110, 25);
            this.pushButtonPauseResumeSimulation.TabIndex = 1;
            this.pushButtonPauseResumeSimulation.Text = "Pozastaviť";
            this.pushButtonPauseResumeSimulation.UseVisualStyleBackColor = true;
            this.pushButtonPauseResumeSimulation.Click += new System.EventHandler(this.PushButtonPauseResumeSimulation_Click);
            // 
            // pushButtonStartSimulation
            // 
            this.pushButtonStartSimulation.Location = new System.Drawing.Point(10, 30);
            this.pushButtonStartSimulation.Name = "pushButtonStartSimulation";
            this.pushButtonStartSimulation.Size = new System.Drawing.Size(100, 25);
            this.pushButtonStartSimulation.TabIndex = 0;
            this.pushButtonStartSimulation.Text = "Spustiť";
            this.pushButtonStartSimulation.UseVisualStyleBackColor = true;
            this.pushButtonStartSimulation.Click += new System.EventHandler(this.PushButtonStartSimulation_Click);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParameters.Controls.Add(this.labelEuro);
            this.groupBoxParameters.Controls.Add(this.spinBoxAdInvestment);
            this.groupBoxParameters.Controls.Add(this.labelAdInvestment);
            this.groupBoxParameters.Controls.Add(this.comboBoxTimeUnit);
            this.groupBoxParameters.Controls.Add(this.spinBoxReplicationDuration);
            this.groupBoxParameters.Controls.Add(this.labelReplicationDuration);
            this.groupBoxParameters.Controls.Add(this.spinBoxReplications);
            this.groupBoxParameters.Controls.Add(this.labelReplications);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers2Max);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers2Min);
            this.groupBoxParameters.Controls.Add(this.labelWorkers2Max);
            this.groupBoxParameters.Controls.Add(this.labelWorkers2Min);
            this.groupBoxParameters.Controls.Add(this.checkBoxRangeWorkers2);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers2);
            this.groupBoxParameters.Controls.Add(this.labelWorkers2);
            this.groupBoxParameters.Controls.Add(this.line);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers1Max);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers1Min);
            this.groupBoxParameters.Controls.Add(this.labelWorkers1Max);
            this.groupBoxParameters.Controls.Add(this.labelWorkers1Min);
            this.groupBoxParameters.Controls.Add(this.checkBoxRangeWorkers1);
            this.groupBoxParameters.Controls.Add(this.spinBoxWorkers1);
            this.groupBoxParameters.Controls.Add(this.labelWorkers1);
            this.groupBoxParameters.Location = new System.Drawing.Point(251, 19);
            this.groupBoxParameters.MinimumSize = new System.Drawing.Size(520, 0);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(627, 190);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parametre simulácie";
            // 
            // labelEuro
            // 
            this.labelEuro.Location = new System.Drawing.Point(270, 123);
            this.labelEuro.Name = "labelEuro";
            this.labelEuro.Size = new System.Drawing.Size(31, 20);
            this.labelEuro.TabIndex = 23;
            this.labelEuro.Text = "EUR";
            this.labelEuro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spinBoxAdInvestment
            // 
            this.spinBoxAdInvestment.DecimalPlaces = 2;
            this.spinBoxAdInvestment.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinBoxAdInvestment.Location = new System.Drawing.Point(190, 123);
            this.spinBoxAdInvestment.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinBoxAdInvestment.Name = "spinBoxAdInvestment";
            this.spinBoxAdInvestment.Size = new System.Drawing.Size(71, 20);
            this.spinBoxAdInvestment.TabIndex = 22;
            this.spinBoxAdInvestment.Tag = "";
            // 
            // labelAdInvestment
            // 
            this.labelAdInvestment.Location = new System.Drawing.Point(10, 123);
            this.labelAdInvestment.Name = "labelAdInvestment";
            this.labelAdInvestment.Size = new System.Drawing.Size(170, 20);
            this.labelAdInvestment.TabIndex = 21;
            this.labelAdInvestment.Text = "Investovať mesačne do reklamy:";
            this.labelAdInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(430, 153);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(80, 21);
            this.comboBoxTimeUnit.TabIndex = 19;
            // 
            // spinBoxReplicationDuration
            // 
            this.spinBoxReplicationDuration.Location = new System.Drawing.Point(350, 153);
            this.spinBoxReplicationDuration.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinBoxReplicationDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxReplicationDuration.Name = "spinBoxReplicationDuration";
            this.spinBoxReplicationDuration.Size = new System.Drawing.Size(70, 20);
            this.spinBoxReplicationDuration.TabIndex = 18;
            this.spinBoxReplicationDuration.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // labelReplicationDuration
            // 
            this.labelReplicationDuration.Location = new System.Drawing.Point(250, 153);
            this.labelReplicationDuration.Name = "labelReplicationDuration";
            this.labelReplicationDuration.Size = new System.Drawing.Size(100, 20);
            this.labelReplicationDuration.TabIndex = 17;
            this.labelReplicationDuration.Text = "Dĺžka replikácie:";
            this.labelReplicationDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spinBoxReplications
            // 
            this.spinBoxReplications.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinBoxReplications.Location = new System.Drawing.Point(110, 153);
            this.spinBoxReplications.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.spinBoxReplications.Name = "spinBoxReplications";
            this.spinBoxReplications.Size = new System.Drawing.Size(110, 20);
            this.spinBoxReplications.TabIndex = 16;
            this.spinBoxReplications.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelReplications
            // 
            this.labelReplications.Location = new System.Drawing.Point(10, 153);
            this.labelReplications.Name = "labelReplications";
            this.labelReplications.Size = new System.Drawing.Size(100, 20);
            this.labelReplications.TabIndex = 15;
            this.labelReplications.Text = "Počet replikácií:";
            this.labelReplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spinBoxWorkers2Max
            // 
            this.spinBoxWorkers2Max.Enabled = false;
            this.spinBoxWorkers2Max.Location = new System.Drawing.Point(420, 93);
            this.spinBoxWorkers2Max.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers2Max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers2Max.Name = "spinBoxWorkers2Max";
            this.spinBoxWorkers2Max.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers2Max.TabIndex = 14;
            this.spinBoxWorkers2Max.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinBoxWorkers2Max.ValueChanged += new System.EventHandler(this.SpinBoxWorkers2Max_ValueChanged);
            // 
            // spinBoxWorkers2Min
            // 
            this.spinBoxWorkers2Min.Enabled = false;
            this.spinBoxWorkers2Min.Location = new System.Drawing.Point(300, 93);
            this.spinBoxWorkers2Min.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers2Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers2Min.Name = "spinBoxWorkers2Min";
            this.spinBoxWorkers2Min.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers2Min.TabIndex = 13;
            this.spinBoxWorkers2Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers2Min.ValueChanged += new System.EventHandler(this.SpinBoxWorkers2Min_ValueChanged);
            // 
            // labelWorkers2Max
            // 
            this.labelWorkers2Max.Location = new System.Drawing.Point(390, 93);
            this.labelWorkers2Max.Name = "labelWorkers2Max";
            this.labelWorkers2Max.Size = new System.Drawing.Size(31, 20);
            this.labelWorkers2Max.TabIndex = 12;
            this.labelWorkers2Max.Text = "max:";
            this.labelWorkers2Max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2Min
            // 
            this.labelWorkers2Min.Location = new System.Drawing.Point(270, 93);
            this.labelWorkers2Min.Name = "labelWorkers2Min";
            this.labelWorkers2Min.Size = new System.Drawing.Size(31, 20);
            this.labelWorkers2Min.TabIndex = 11;
            this.labelWorkers2Min.Text = "min:";
            this.labelWorkers2Min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxRangeWorkers2
            // 
            this.checkBoxRangeWorkers2.Location = new System.Drawing.Point(273, 63);
            this.checkBoxRangeWorkers2.Name = "checkBoxRangeWorkers2";
            this.checkBoxRangeWorkers2.Size = new System.Drawing.Size(85, 20);
            this.checkBoxRangeWorkers2.TabIndex = 10;
            this.checkBoxRangeWorkers2.Text = "Rozsah";
            this.checkBoxRangeWorkers2.UseVisualStyleBackColor = true;
            this.checkBoxRangeWorkers2.CheckedChanged += new System.EventHandler(this.CheckBoxRangeWorkers2_CheckedChanged);
            // 
            // spinBoxWorkers2
            // 
            this.spinBoxWorkers2.Location = new System.Drawing.Point(440, 33);
            this.spinBoxWorkers2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers2.Name = "spinBoxWorkers2";
            this.spinBoxWorkers2.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers2.TabIndex = 9;
            this.spinBoxWorkers2.Tag = "";
            this.spinBoxWorkers2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinBoxWorkers2.ValueChanged += new System.EventHandler(this.SpinBoxWorkers2_ValueChanged);
            // 
            // labelWorkers2
            // 
            this.labelWorkers2.Location = new System.Drawing.Point(270, 33);
            this.labelWorkers2.Name = "labelWorkers2";
            this.labelWorkers2.Size = new System.Drawing.Size(171, 20);
            this.labelWorkers2.TabIndex = 8;
            this.labelWorkers2.Text = "Počet pracovníkov skupiny 2:";
            this.labelWorkers2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // line
            // 
            this.line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.line.Location = new System.Drawing.Point(260, 30);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(2, 90);
            this.line.TabIndex = 7;
            // 
            // spinBoxWorkers1Max
            // 
            this.spinBoxWorkers1Max.Enabled = false;
            this.spinBoxWorkers1Max.Location = new System.Drawing.Point(160, 93);
            this.spinBoxWorkers1Max.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers1Max.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers1Max.Name = "spinBoxWorkers1Max";
            this.spinBoxWorkers1Max.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers1Max.TabIndex = 6;
            this.spinBoxWorkers1Max.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinBoxWorkers1Max.ValueChanged += new System.EventHandler(this.SpinBoxWorkers1Max_ValueChanged);
            // 
            // spinBoxWorkers1Min
            // 
            this.spinBoxWorkers1Min.Enabled = false;
            this.spinBoxWorkers1Min.Location = new System.Drawing.Point(40, 93);
            this.spinBoxWorkers1Min.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers1Min.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers1Min.Name = "spinBoxWorkers1Min";
            this.spinBoxWorkers1Min.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers1Min.TabIndex = 5;
            this.spinBoxWorkers1Min.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers1Min.ValueChanged += new System.EventHandler(this.SpinBoxWorkers1Min_ValueChanged);
            // 
            // labelWorkers1Max
            // 
            this.labelWorkers1Max.Location = new System.Drawing.Point(130, 93);
            this.labelWorkers1Max.Name = "labelWorkers1Max";
            this.labelWorkers1Max.Size = new System.Drawing.Size(31, 20);
            this.labelWorkers1Max.TabIndex = 4;
            this.labelWorkers1Max.Text = "max:";
            this.labelWorkers1Max.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1Min
            // 
            this.labelWorkers1Min.Location = new System.Drawing.Point(10, 93);
            this.labelWorkers1Min.Name = "labelWorkers1Min";
            this.labelWorkers1Min.Size = new System.Drawing.Size(31, 20);
            this.labelWorkers1Min.TabIndex = 3;
            this.labelWorkers1Min.Text = "min:";
            this.labelWorkers1Min.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxRangeWorkers1
            // 
            this.checkBoxRangeWorkers1.Location = new System.Drawing.Point(13, 63);
            this.checkBoxRangeWorkers1.Name = "checkBoxRangeWorkers1";
            this.checkBoxRangeWorkers1.Size = new System.Drawing.Size(85, 20);
            this.checkBoxRangeWorkers1.TabIndex = 2;
            this.checkBoxRangeWorkers1.Text = "Rozsah";
            this.checkBoxRangeWorkers1.UseVisualStyleBackColor = true;
            this.checkBoxRangeWorkers1.CheckedChanged += new System.EventHandler(this.CheckBoxRangeWorkers1_CheckedChanged);
            // 
            // spinBoxWorkers1
            // 
            this.spinBoxWorkers1.Location = new System.Drawing.Point(180, 33);
            this.spinBoxWorkers1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinBoxWorkers1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinBoxWorkers1.Name = "spinBoxWorkers1";
            this.spinBoxWorkers1.Size = new System.Drawing.Size(71, 20);
            this.spinBoxWorkers1.TabIndex = 1;
            this.spinBoxWorkers1.Tag = "";
            this.spinBoxWorkers1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.spinBoxWorkers1.ValueChanged += new System.EventHandler(this.SpinBoxWorkers1_ValueChanged);
            // 
            // labelWorkers1
            // 
            this.labelWorkers1.Location = new System.Drawing.Point(10, 33);
            this.labelWorkers1.Name = "labelWorkers1";
            this.labelWorkers1.Size = new System.Drawing.Size(171, 20);
            this.labelWorkers1.TabIndex = 0;
            this.labelWorkers1.Text = "Počet pracovníkov skupiny 1:";
            this.labelWorkers1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSeed
            // 
            this.groupBoxSeed.Controls.Add(this.labelUsedSeedValue);
            this.groupBoxSeed.Controls.Add(this.labelUsedSeed);
            this.groupBoxSeed.Controls.Add(this.spinBoxCustomSeed);
            this.groupBoxSeed.Controls.Add(this.radioButtonCustomSeed);
            this.groupBoxSeed.Controls.Add(this.radioButtonRandomSeed);
            this.groupBoxSeed.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSeed.MinimumSize = new System.Drawing.Size(240, 0);
            this.groupBoxSeed.Name = "groupBoxSeed";
            this.groupBoxSeed.Size = new System.Drawing.Size(240, 190);
            this.groupBoxSeed.TabIndex = 0;
            this.groupBoxSeed.TabStop = false;
            this.groupBoxSeed.Text = "Násada generátora";
            // 
            // labelUsedSeedValue
            // 
            this.labelUsedSeedValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.labelUsedSeedValue.Location = new System.Drawing.Point(110, 97);
            this.labelUsedSeedValue.Name = "labelUsedSeedValue";
            this.labelUsedSeedValue.ReadOnly = true;
            this.labelUsedSeedValue.Size = new System.Drawing.Size(120, 13);
            this.labelUsedSeedValue.TabIndex = 0;
            this.labelUsedSeedValue.TabStop = false;
            // 
            // labelUsedSeed
            // 
            this.labelUsedSeed.Location = new System.Drawing.Point(10, 93);
            this.labelUsedSeed.Name = "labelUsedSeed";
            this.labelUsedSeed.Size = new System.Drawing.Size(100, 20);
            this.labelUsedSeed.TabIndex = 0;
            this.labelUsedSeed.Text = "Použitá násada:";
            this.labelUsedSeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spinBoxCustomSeed
            // 
            this.spinBoxCustomSeed.Enabled = false;
            this.spinBoxCustomSeed.Location = new System.Drawing.Point(90, 63);
            this.spinBoxCustomSeed.Name = "spinBoxCustomSeed";
            this.spinBoxCustomSeed.Size = new System.Drawing.Size(141, 20);
            this.spinBoxCustomSeed.TabIndex = 0;
            // 
            // radioButtonCustomSeed
            // 
            this.radioButtonCustomSeed.Location = new System.Drawing.Point(13, 63);
            this.radioButtonCustomSeed.Name = "radioButtonCustomSeed";
            this.radioButtonCustomSeed.Size = new System.Drawing.Size(75, 20);
            this.radioButtonCustomSeed.TabIndex = 1;
            this.radioButtonCustomSeed.Text = "vlastná";
            this.radioButtonCustomSeed.UseVisualStyleBackColor = true;
            this.radioButtonCustomSeed.CheckedChanged += new System.EventHandler(this.RadioButtonCustomSeed_CheckedChanged);
            // 
            // radioButtonRandomSeed
            // 
            this.radioButtonRandomSeed.Checked = true;
            this.radioButtonRandomSeed.Location = new System.Drawing.Point(13, 33);
            this.radioButtonRandomSeed.Name = "radioButtonRandomSeed";
            this.radioButtonRandomSeed.Size = new System.Drawing.Size(75, 20);
            this.radioButtonRandomSeed.TabIndex = 0;
            this.radioButtonRandomSeed.TabStop = true;
            this.radioButtonRandomSeed.Text = "náhodná";
            this.radioButtonRandomSeed.UseVisualStyleBackColor = true;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.tabWidgetOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(9, 264);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxOutput.Size = new System.Drawing.Size(1239, 552);
            this.groupBoxOutput.TabIndex = 2;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Výstup";
            // 
            // tabWidgetOutput
            // 
            this.tabWidgetOutput.Controls.Add(this.tabSimulation);
            this.tabWidgetOutput.Controls.Add(this.tabCustomers);
            this.tabWidgetOutput.Controls.Add(this.tabVehicles);
            this.tabWidgetOutput.Controls.Add(this.tabWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabWorkers2);
            this.tabWidgetOutput.Controls.Add(this.tabCarParks);
            this.tabWidgetOutput.Controls.Add(this.tabQueueLenWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabQueueLenWorkers2);
            this.tabWidgetOutput.Controls.Add(this.tabTimeInServiceWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabTimeInServiceWorkers2);
            this.tabWidgetOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWidgetOutput.Location = new System.Drawing.Point(9, 22);
            this.tabWidgetOutput.Name = "tabWidgetOutput";
            this.tabWidgetOutput.SelectedIndex = 0;
            this.tabWidgetOutput.Size = new System.Drawing.Size(1221, 521);
            this.tabWidgetOutput.TabIndex = 0;
            // 
            // tabSimulation
            // 
            this.tabSimulation.Controls.Add(this.tableLayoutPanelSimulation);
            this.tabSimulation.Location = new System.Drawing.Point(4, 22);
            this.tabSimulation.Name = "tabSimulation";
            this.tabSimulation.Size = new System.Drawing.Size(1213, 495);
            this.tabSimulation.TabIndex = 8;
            this.tabSimulation.Text = "Simulácia";
            this.tabSimulation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelSimulation
            // 
            this.tableLayoutPanelSimulation.ColumnCount = 1;
            this.tableLayoutPanelSimulation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSimulation.Controls.Add(this.groupBoxIdealWorkersCount, 0, 1);
            this.tableLayoutPanelSimulation.Controls.Add(this.groupBoxSimulationStats, 0, 0);
            this.tableLayoutPanelSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSimulation.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSimulation.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelSimulation.Name = "tableLayoutPanelSimulation";
            this.tableLayoutPanelSimulation.RowCount = 2;
            this.tableLayoutPanelSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelSimulation.Size = new System.Drawing.Size(1213, 495);
            this.tableLayoutPanelSimulation.TabIndex = 4;
            // 
            // groupBoxIdealWorkersCount
            // 
            this.groupBoxIdealWorkersCount.Controls.Add(this.tableLayoutPanelIdealWorkersCount);
            this.groupBoxIdealWorkersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIdealWorkersCount.Location = new System.Drawing.Point(3, 433);
            this.groupBoxIdealWorkersCount.Name = "groupBoxIdealWorkersCount";
            this.groupBoxIdealWorkersCount.Size = new System.Drawing.Size(1207, 59);
            this.groupBoxIdealWorkersCount.TabIndex = 2;
            this.groupBoxIdealWorkersCount.TabStop = false;
            this.groupBoxIdealWorkersCount.Text = "Ideálny počet pracovníkov";
            // 
            // tableLayoutPanelIdealWorkersCount
            // 
            this.tableLayoutPanelIdealWorkersCount.ColumnCount = 4;
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers1Count, 0, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers1CountValue, 1, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers2Count, 2, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers2CountValue, 3, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealMonthlyProfit, 0, 1);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealMonthlyProfitValue, 2, 1);
            this.tableLayoutPanelIdealWorkersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIdealWorkersCount.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelIdealWorkersCount.Name = "tableLayoutPanelIdealWorkersCount";
            this.tableLayoutPanelIdealWorkersCount.RowCount = 2;
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.Size = new System.Drawing.Size(1201, 40);
            this.tableLayoutPanelIdealWorkersCount.TabIndex = 0;
            // 
            // labelIdealWorkers1Count
            // 
            this.labelIdealWorkers1Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIdealWorkers1Count.Location = new System.Drawing.Point(47, 2);
            this.labelIdealWorkers1Count.Name = "labelIdealWorkers1Count";
            this.labelIdealWorkers1Count.Size = new System.Drawing.Size(250, 15);
            this.labelIdealWorkers1Count.TabIndex = 3;
            this.labelIdealWorkers1Count.Text = "Počet pracovníkov skupiny 1:";
            this.labelIdealWorkers1Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdealWorkers1CountValue
            // 
            this.labelIdealWorkers1CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIdealWorkers1CountValue.Location = new System.Drawing.Point(303, 2);
            this.labelIdealWorkers1CountValue.Name = "labelIdealWorkers1CountValue";
            this.labelIdealWorkers1CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelIdealWorkers1CountValue.TabIndex = 5;
            this.labelIdealWorkers1CountValue.Text = "-";
            this.labelIdealWorkers1CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdealWorkers2Count
            // 
            this.labelIdealWorkers2Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIdealWorkers2Count.Location = new System.Drawing.Point(647, 2);
            this.labelIdealWorkers2Count.Name = "labelIdealWorkers2Count";
            this.labelIdealWorkers2Count.Size = new System.Drawing.Size(250, 15);
            this.labelIdealWorkers2Count.TabIndex = 4;
            this.labelIdealWorkers2Count.Text = "Počet pracovníkov skupiny 2:";
            this.labelIdealWorkers2Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdealWorkers2CountValue
            // 
            this.labelIdealWorkers2CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelIdealWorkers2CountValue.Location = new System.Drawing.Point(903, 2);
            this.labelIdealWorkers2CountValue.Name = "labelIdealWorkers2CountValue";
            this.labelIdealWorkers2CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelIdealWorkers2CountValue.TabIndex = 6;
            this.labelIdealWorkers2CountValue.Text = "-";
            this.labelIdealWorkers2CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdealMonthlyProfit
            // 
            this.labelIdealMonthlyProfit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanelIdealWorkersCount.SetColumnSpan(this.labelIdealMonthlyProfit, 2);
            this.labelIdealMonthlyProfit.Location = new System.Drawing.Point(197, 22);
            this.labelIdealMonthlyProfit.Name = "labelIdealMonthlyProfit";
            this.labelIdealMonthlyProfit.Size = new System.Drawing.Size(400, 15);
            this.labelIdealMonthlyProfit.TabIndex = 8;
            this.labelIdealMonthlyProfit.Text = "Mesačný hospodársky výsledok:";
            this.labelIdealMonthlyProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdealMonthlyProfitValue
            // 
            this.labelIdealMonthlyProfitValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanelIdealWorkersCount.SetColumnSpan(this.labelIdealMonthlyProfitValue, 2);
            this.labelIdealMonthlyProfitValue.Location = new System.Drawing.Point(603, 22);
            this.labelIdealMonthlyProfitValue.Name = "labelIdealMonthlyProfitValue";
            this.labelIdealMonthlyProfitValue.Size = new System.Drawing.Size(400, 15);
            this.labelIdealMonthlyProfitValue.TabIndex = 7;
            this.labelIdealMonthlyProfitValue.Text = "-";
            this.labelIdealMonthlyProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxSimulationStats
            // 
            this.groupBoxSimulationStats.Controls.Add(this.tableLayoutPanelSimulationStats);
            this.groupBoxSimulationStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSimulationStats.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSimulationStats.Name = "groupBoxSimulationStats";
            this.groupBoxSimulationStats.Size = new System.Drawing.Size(1207, 424);
            this.groupBoxSimulationStats.TabIndex = 1;
            this.groupBoxSimulationStats.TabStop = false;
            this.groupBoxSimulationStats.Text = "Štatistiky";
            // 
            // tableLayoutPanelSimulationStats
            // 
            this.tableLayoutPanelSimulationStats.ColumnCount = 4;
            this.tableLayoutPanelSimulationStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSimulationStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSimulationStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSimulationStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2RatioISValue, 3, 17);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2RatioIS, 2, 17);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1RatioISValue, 3, 16);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1RatioIS, 2, 16);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarParkServiceCountISValue, 3, 15);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarParkServiceCountIS, 2, 15);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2CountISValue, 3, 14);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2CountIS, 2, 14);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1CountISValue, 3, 13);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1CountIS, 2, 13);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2RatioISValue, 3, 12);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2RatioIS, 2, 12);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1RatioISValue, 3, 11);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1RatioIS, 2, 11);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2CountISValue, 3, 10);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2CountIS, 2, 10);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1CountISValue, 3, 9);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1CountIS, 2, 9);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersServedRatioISValue, 3, 5);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersServedRatioIS, 2, 5);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimReturnQueueLengthISValue, 3, 4);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimReturnQueueLengthIS, 2, 4);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimRepairedQueueLengthISValue, 3, 3);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimRepairedQueueLengthIS, 2, 3);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimToRepairQueueLengthISValue, 3, 2);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimToRepairQueueLengthIS, 2, 2);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomerInQueueISValue, 3, 1);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomerInQueueIS, 2, 1);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersInServiceISValue, 3, 0);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersInServiceIS, 2, 0);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomerInQueue, 0, 1);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomerInQueueValue, 1, 1);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimToRepairQueueLengthValue, 1, 2);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimReturnQueueLengthValue, 1, 4);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitInQueueValue, 1, 6);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitForRepairValue, 1, 7);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimTimeInServiceValue, 1, 8);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitInQueueISValue, 3, 6);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitForRepairISValue, 3, 7);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimTimeInServiceISValue, 3, 8);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimToRepairQueueLength, 0, 2);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimReturnQueueLength, 0, 4);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitInQueue, 0, 6);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitForRepair, 0, 7);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimTimeInService, 0, 8);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitInQueueIS, 2, 6);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWaitForRepairIS, 2, 7);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimTimeInServiceIS, 2, 8);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersInService, 0, 0);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersInServiceValue, 1, 0);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimRepairedQueueLength, 0, 3);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersServedRatio, 0, 5);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimRepairedQueueLengthValue, 1, 3);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCustomersServedRatioValue, 1, 5);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1Count, 0, 9);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2Count, 0, 10);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1Ratio, 0, 11);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2Ratio, 0, 12);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1Count, 0, 13);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2Count, 0, 14);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarParkServiceCount, 0, 15);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1Ratio, 0, 16);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2Ratio, 0, 17);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1CountValue, 1, 9);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2CountValue, 1, 10);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking1RatioValue, 1, 11);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimWorking2RatioValue, 1, 12);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1CountValue, 1, 13);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2CountValue, 1, 14);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarParkServiceCountValue, 1, 15);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark1RatioValue, 1, 16);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimCarPark2RatioValue, 1, 17);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimProfit, 0, 18);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimProfitValue, 1, 18);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimProfitIS, 2, 18);
            this.tableLayoutPanelSimulationStats.Controls.Add(this.labelSimProfitISValue, 3, 18);
            this.tableLayoutPanelSimulationStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSimulationStats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelSimulationStats.Name = "tableLayoutPanelSimulationStats";
            this.tableLayoutPanelSimulationStats.RowCount = 19;
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tableLayoutPanelSimulationStats.Size = new System.Drawing.Size(1201, 405);
            this.tableLayoutPanelSimulationStats.TabIndex = 0;
            // 
            // labelSimCarPark2RatioISValue
            // 
            this.labelSimCarPark2RatioISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark2RatioISValue.Location = new System.Drawing.Point(903, 360);
            this.labelSimCarPark2RatioISValue.Name = "labelSimCarPark2RatioISValue";
            this.labelSimCarPark2RatioISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2RatioISValue.TabIndex = 73;
            this.labelSimCarPark2RatioISValue.Text = "-";
            this.labelSimCarPark2RatioISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark2RatioIS
            // 
            this.labelSimCarPark2RatioIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark2RatioIS.Location = new System.Drawing.Point(647, 360);
            this.labelSimCarPark2RatioIS.Name = "labelSimCarPark2RatioIS";
            this.labelSimCarPark2RatioIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2RatioIS.TabIndex = 72;
            this.labelSimCarPark2RatioIS.Text = "90% IS vyťaženia parkoviska 2:";
            this.labelSimCarPark2RatioIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark1RatioISValue
            // 
            this.labelSimCarPark1RatioISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark1RatioISValue.Location = new System.Drawing.Point(903, 339);
            this.labelSimCarPark1RatioISValue.Name = "labelSimCarPark1RatioISValue";
            this.labelSimCarPark1RatioISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1RatioISValue.TabIndex = 71;
            this.labelSimCarPark1RatioISValue.Text = "-";
            this.labelSimCarPark1RatioISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark1RatioIS
            // 
            this.labelSimCarPark1RatioIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark1RatioIS.Location = new System.Drawing.Point(647, 339);
            this.labelSimCarPark1RatioIS.Name = "labelSimCarPark1RatioIS";
            this.labelSimCarPark1RatioIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1RatioIS.TabIndex = 70;
            this.labelSimCarPark1RatioIS.Text = "90% IS vyťaženia parkoviska 1:";
            this.labelSimCarPark1RatioIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarParkServiceCountISValue
            // 
            this.labelSimCarParkServiceCountISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarParkServiceCountISValue.Location = new System.Drawing.Point(903, 318);
            this.labelSimCarParkServiceCountISValue.Name = "labelSimCarParkServiceCountISValue";
            this.labelSimCarParkServiceCountISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarParkServiceCountISValue.TabIndex = 69;
            this.labelSimCarParkServiceCountISValue.Text = "-";
            this.labelSimCarParkServiceCountISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarParkServiceCountIS
            // 
            this.labelSimCarParkServiceCountIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarParkServiceCountIS.Location = new System.Drawing.Point(647, 318);
            this.labelSimCarParkServiceCountIS.Name = "labelSimCarParkServiceCountIS";
            this.labelSimCarParkServiceCountIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarParkServiceCountIS.TabIndex = 68;
            this.labelSimCarParkServiceCountIS.Text = "90% IS počtu áut na parkovisku pred servisom:";
            this.labelSimCarParkServiceCountIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark2CountISValue
            // 
            this.labelSimCarPark2CountISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark2CountISValue.Location = new System.Drawing.Point(903, 297);
            this.labelSimCarPark2CountISValue.Name = "labelSimCarPark2CountISValue";
            this.labelSimCarPark2CountISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2CountISValue.TabIndex = 67;
            this.labelSimCarPark2CountISValue.Text = "-";
            this.labelSimCarPark2CountISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark2CountIS
            // 
            this.labelSimCarPark2CountIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark2CountIS.Location = new System.Drawing.Point(647, 297);
            this.labelSimCarPark2CountIS.Name = "labelSimCarPark2CountIS";
            this.labelSimCarPark2CountIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2CountIS.TabIndex = 66;
            this.labelSimCarPark2CountIS.Text = "90% IS počtu áut na parkovisku 2:";
            this.labelSimCarPark2CountIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark1CountISValue
            // 
            this.labelSimCarPark1CountISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark1CountISValue.Location = new System.Drawing.Point(903, 276);
            this.labelSimCarPark1CountISValue.Name = "labelSimCarPark1CountISValue";
            this.labelSimCarPark1CountISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1CountISValue.TabIndex = 65;
            this.labelSimCarPark1CountISValue.Text = "-";
            this.labelSimCarPark1CountISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark1CountIS
            // 
            this.labelSimCarPark1CountIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark1CountIS.Location = new System.Drawing.Point(647, 276);
            this.labelSimCarPark1CountIS.Name = "labelSimCarPark1CountIS";
            this.labelSimCarPark1CountIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1CountIS.TabIndex = 64;
            this.labelSimCarPark1CountIS.Text = "90% IS počtu áut na parkovisku 1:";
            this.labelSimCarPark1CountIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking2RatioISValue
            // 
            this.labelSimWorking2RatioISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking2RatioISValue.Location = new System.Drawing.Point(903, 255);
            this.labelSimWorking2RatioISValue.Name = "labelSimWorking2RatioISValue";
            this.labelSimWorking2RatioISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2RatioISValue.TabIndex = 63;
            this.labelSimWorking2RatioISValue.Text = "-";
            this.labelSimWorking2RatioISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking2RatioIS
            // 
            this.labelSimWorking2RatioIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking2RatioIS.Location = new System.Drawing.Point(647, 255);
            this.labelSimWorking2RatioIS.Name = "labelSimWorking2RatioIS";
            this.labelSimWorking2RatioIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2RatioIS.TabIndex = 62;
            this.labelSimWorking2RatioIS.Text = "90% IS vyťaženia pracovníkov 2:";
            this.labelSimWorking2RatioIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking1RatioISValue
            // 
            this.labelSimWorking1RatioISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking1RatioISValue.Location = new System.Drawing.Point(903, 234);
            this.labelSimWorking1RatioISValue.Name = "labelSimWorking1RatioISValue";
            this.labelSimWorking1RatioISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1RatioISValue.TabIndex = 61;
            this.labelSimWorking1RatioISValue.Text = "-";
            this.labelSimWorking1RatioISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking1RatioIS
            // 
            this.labelSimWorking1RatioIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking1RatioIS.Location = new System.Drawing.Point(647, 234);
            this.labelSimWorking1RatioIS.Name = "labelSimWorking1RatioIS";
            this.labelSimWorking1RatioIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1RatioIS.TabIndex = 60;
            this.labelSimWorking1RatioIS.Text = "90% IS vyťaženia pracovníkov 1:";
            this.labelSimWorking1RatioIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking2CountISValue
            // 
            this.labelSimWorking2CountISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking2CountISValue.Location = new System.Drawing.Point(903, 213);
            this.labelSimWorking2CountISValue.Name = "labelSimWorking2CountISValue";
            this.labelSimWorking2CountISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2CountISValue.TabIndex = 59;
            this.labelSimWorking2CountISValue.Text = "-";
            this.labelSimWorking2CountISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking2CountIS
            // 
            this.labelSimWorking2CountIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking2CountIS.Location = new System.Drawing.Point(647, 213);
            this.labelSimWorking2CountIS.Name = "labelSimWorking2CountIS";
            this.labelSimWorking2CountIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2CountIS.TabIndex = 58;
            this.labelSimWorking2CountIS.Text = "90% IS počtu pracujúcich v skupine 2:";
            this.labelSimWorking2CountIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking1CountISValue
            // 
            this.labelSimWorking1CountISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking1CountISValue.Location = new System.Drawing.Point(903, 192);
            this.labelSimWorking1CountISValue.Name = "labelSimWorking1CountISValue";
            this.labelSimWorking1CountISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1CountISValue.TabIndex = 57;
            this.labelSimWorking1CountISValue.Text = "-";
            this.labelSimWorking1CountISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking1CountIS
            // 
            this.labelSimWorking1CountIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking1CountIS.Location = new System.Drawing.Point(647, 192);
            this.labelSimWorking1CountIS.Name = "labelSimWorking1CountIS";
            this.labelSimWorking1CountIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1CountIS.TabIndex = 56;
            this.labelSimWorking1CountIS.Text = "90% IS počtu pracujúcich v skupine 1:";
            this.labelSimWorking1CountIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomersServedRatioISValue
            // 
            this.labelSimCustomersServedRatioISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomersServedRatioISValue.Location = new System.Drawing.Point(903, 108);
            this.labelSimCustomersServedRatioISValue.Name = "labelSimCustomersServedRatioISValue";
            this.labelSimCustomersServedRatioISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersServedRatioISValue.TabIndex = 55;
            this.labelSimCustomersServedRatioISValue.Text = "-";
            this.labelSimCustomersServedRatioISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCustomersServedRatioIS
            // 
            this.labelSimCustomersServedRatioIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomersServedRatioIS.Location = new System.Drawing.Point(647, 108);
            this.labelSimCustomersServedRatioIS.Name = "labelSimCustomersServedRatioIS";
            this.labelSimCustomersServedRatioIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersServedRatioIS.TabIndex = 54;
            this.labelSimCustomersServedRatioIS.Text = "90% IS pomeru obslúžených zákazníkov:";
            this.labelSimCustomersServedRatioIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimReturnQueueLengthISValue
            // 
            this.labelSimReturnQueueLengthISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimReturnQueueLengthISValue.Location = new System.Drawing.Point(903, 87);
            this.labelSimReturnQueueLengthISValue.Name = "labelSimReturnQueueLengthISValue";
            this.labelSimReturnQueueLengthISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimReturnQueueLengthISValue.TabIndex = 53;
            this.labelSimReturnQueueLengthISValue.Text = "-";
            this.labelSimReturnQueueLengthISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimReturnQueueLengthIS
            // 
            this.labelSimReturnQueueLengthIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimReturnQueueLengthIS.Location = new System.Drawing.Point(647, 87);
            this.labelSimReturnQueueLengthIS.Name = "labelSimReturnQueueLengthIS";
            this.labelSimReturnQueueLengthIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimReturnQueueLengthIS.TabIndex = 52;
            this.labelSimReturnQueueLengthIS.Text = "90% IS dĺžky frontu áut na vrátenie:";
            this.labelSimReturnQueueLengthIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimRepairedQueueLengthISValue
            // 
            this.labelSimRepairedQueueLengthISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimRepairedQueueLengthISValue.Location = new System.Drawing.Point(903, 66);
            this.labelSimRepairedQueueLengthISValue.Name = "labelSimRepairedQueueLengthISValue";
            this.labelSimRepairedQueueLengthISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimRepairedQueueLengthISValue.TabIndex = 51;
            this.labelSimRepairedQueueLengthISValue.Text = "-";
            this.labelSimRepairedQueueLengthISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimRepairedQueueLengthIS
            // 
            this.labelSimRepairedQueueLengthIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimRepairedQueueLengthIS.Location = new System.Drawing.Point(647, 66);
            this.labelSimRepairedQueueLengthIS.Name = "labelSimRepairedQueueLengthIS";
            this.labelSimRepairedQueueLengthIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimRepairedQueueLengthIS.TabIndex = 50;
            this.labelSimRepairedQueueLengthIS.Text = "90% IS dĺžky frontu opravených áut:";
            this.labelSimRepairedQueueLengthIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimToRepairQueueLengthISValue
            // 
            this.labelSimToRepairQueueLengthISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimToRepairQueueLengthISValue.Location = new System.Drawing.Point(903, 45);
            this.labelSimToRepairQueueLengthISValue.Name = "labelSimToRepairQueueLengthISValue";
            this.labelSimToRepairQueueLengthISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimToRepairQueueLengthISValue.TabIndex = 49;
            this.labelSimToRepairQueueLengthISValue.Text = "-";
            this.labelSimToRepairQueueLengthISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimToRepairQueueLengthIS
            // 
            this.labelSimToRepairQueueLengthIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimToRepairQueueLengthIS.Location = new System.Drawing.Point(647, 45);
            this.labelSimToRepairQueueLengthIS.Name = "labelSimToRepairQueueLengthIS";
            this.labelSimToRepairQueueLengthIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimToRepairQueueLengthIS.TabIndex = 48;
            this.labelSimToRepairQueueLengthIS.Text = "90% IS dĺžky frontu áut na opravu:";
            this.labelSimToRepairQueueLengthIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomerInQueueISValue
            // 
            this.labelSimCustomerInQueueISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomerInQueueISValue.Location = new System.Drawing.Point(903, 24);
            this.labelSimCustomerInQueueISValue.Name = "labelSimCustomerInQueueISValue";
            this.labelSimCustomerInQueueISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomerInQueueISValue.TabIndex = 47;
            this.labelSimCustomerInQueueISValue.Text = "-";
            this.labelSimCustomerInQueueISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCustomerInQueueIS
            // 
            this.labelSimCustomerInQueueIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomerInQueueIS.Location = new System.Drawing.Point(647, 24);
            this.labelSimCustomerInQueueIS.Name = "labelSimCustomerInQueueIS";
            this.labelSimCustomerInQueueIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomerInQueueIS.TabIndex = 46;
            this.labelSimCustomerInQueueIS.Text = "90% IS dĺžky frontu čakajúcich:";
            this.labelSimCustomerInQueueIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomersInServiceISValue
            // 
            this.labelSimCustomersInServiceISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomersInServiceISValue.Location = new System.Drawing.Point(903, 3);
            this.labelSimCustomersInServiceISValue.Name = "labelSimCustomersInServiceISValue";
            this.labelSimCustomersInServiceISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersInServiceISValue.TabIndex = 45;
            this.labelSimCustomersInServiceISValue.Text = "-";
            this.labelSimCustomersInServiceISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCustomersInServiceIS
            // 
            this.labelSimCustomersInServiceIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomersInServiceIS.Location = new System.Drawing.Point(647, 3);
            this.labelSimCustomersInServiceIS.Name = "labelSimCustomersInServiceIS";
            this.labelSimCustomersInServiceIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersInServiceIS.TabIndex = 44;
            this.labelSimCustomersInServiceIS.Text = "90% IS počtu zákazníkov v servise:";
            this.labelSimCustomersInServiceIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomerInQueue
            // 
            this.labelSimCustomerInQueue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomerInQueue.Location = new System.Drawing.Point(47, 24);
            this.labelSimCustomerInQueue.Name = "labelSimCustomerInQueue";
            this.labelSimCustomerInQueue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomerInQueue.TabIndex = 2;
            this.labelSimCustomerInQueue.Text = "Priemerná dĺžka frontu čakajúcich:";
            this.labelSimCustomerInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomerInQueueValue
            // 
            this.labelSimCustomerInQueueValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomerInQueueValue.Location = new System.Drawing.Point(303, 24);
            this.labelSimCustomerInQueueValue.Name = "labelSimCustomerInQueueValue";
            this.labelSimCustomerInQueueValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomerInQueueValue.TabIndex = 3;
            this.labelSimCustomerInQueueValue.Text = "-";
            this.labelSimCustomerInQueueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimToRepairQueueLengthValue
            // 
            this.labelSimToRepairQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimToRepairQueueLengthValue.Location = new System.Drawing.Point(303, 45);
            this.labelSimToRepairQueueLengthValue.Name = "labelSimToRepairQueueLengthValue";
            this.labelSimToRepairQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimToRepairQueueLengthValue.TabIndex = 4;
            this.labelSimToRepairQueueLengthValue.Text = "-";
            this.labelSimToRepairQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimReturnQueueLengthValue
            // 
            this.labelSimReturnQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimReturnQueueLengthValue.Location = new System.Drawing.Point(303, 87);
            this.labelSimReturnQueueLengthValue.Name = "labelSimReturnQueueLengthValue";
            this.labelSimReturnQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimReturnQueueLengthValue.TabIndex = 5;
            this.labelSimReturnQueueLengthValue.Text = "-";
            this.labelSimReturnQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWaitInQueueValue
            // 
            this.labelSimWaitInQueueValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWaitInQueueValue.Location = new System.Drawing.Point(303, 129);
            this.labelSimWaitInQueueValue.Name = "labelSimWaitInQueueValue";
            this.labelSimWaitInQueueValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitInQueueValue.TabIndex = 6;
            this.labelSimWaitInQueueValue.Text = "-";
            this.labelSimWaitInQueueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWaitForRepairValue
            // 
            this.labelSimWaitForRepairValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWaitForRepairValue.Location = new System.Drawing.Point(303, 150);
            this.labelSimWaitForRepairValue.Name = "labelSimWaitForRepairValue";
            this.labelSimWaitForRepairValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitForRepairValue.TabIndex = 7;
            this.labelSimWaitForRepairValue.Text = "-";
            this.labelSimWaitForRepairValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimTimeInServiceValue
            // 
            this.labelSimTimeInServiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimTimeInServiceValue.Location = new System.Drawing.Point(303, 171);
            this.labelSimTimeInServiceValue.Name = "labelSimTimeInServiceValue";
            this.labelSimTimeInServiceValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimTimeInServiceValue.TabIndex = 8;
            this.labelSimTimeInServiceValue.Text = "-";
            this.labelSimTimeInServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWaitInQueueISValue
            // 
            this.labelSimWaitInQueueISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWaitInQueueISValue.Location = new System.Drawing.Point(903, 129);
            this.labelSimWaitInQueueISValue.Name = "labelSimWaitInQueueISValue";
            this.labelSimWaitInQueueISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitInQueueISValue.TabIndex = 9;
            this.labelSimWaitInQueueISValue.Text = "-";
            this.labelSimWaitInQueueISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWaitForRepairISValue
            // 
            this.labelSimWaitForRepairISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWaitForRepairISValue.Location = new System.Drawing.Point(903, 150);
            this.labelSimWaitForRepairISValue.Name = "labelSimWaitForRepairISValue";
            this.labelSimWaitForRepairISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitForRepairISValue.TabIndex = 10;
            this.labelSimWaitForRepairISValue.Text = "-";
            this.labelSimWaitForRepairISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimTimeInServiceISValue
            // 
            this.labelSimTimeInServiceISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimTimeInServiceISValue.Location = new System.Drawing.Point(903, 171);
            this.labelSimTimeInServiceISValue.Name = "labelSimTimeInServiceISValue";
            this.labelSimTimeInServiceISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimTimeInServiceISValue.TabIndex = 11;
            this.labelSimTimeInServiceISValue.Text = "-";
            this.labelSimTimeInServiceISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimToRepairQueueLength
            // 
            this.labelSimToRepairQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimToRepairQueueLength.Location = new System.Drawing.Point(47, 45);
            this.labelSimToRepairQueueLength.Name = "labelSimToRepairQueueLength";
            this.labelSimToRepairQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelSimToRepairQueueLength.TabIndex = 12;
            this.labelSimToRepairQueueLength.Text = "Priemerná dĺžka frontu áut na opravu:";
            this.labelSimToRepairQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimReturnQueueLength
            // 
            this.labelSimReturnQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimReturnQueueLength.Location = new System.Drawing.Point(47, 87);
            this.labelSimReturnQueueLength.Name = "labelSimReturnQueueLength";
            this.labelSimReturnQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelSimReturnQueueLength.TabIndex = 13;
            this.labelSimReturnQueueLength.Text = "Priemerná dĺžka frontu áut na vrátenie:";
            this.labelSimReturnQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWaitInQueue
            // 
            this.labelSimWaitInQueue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWaitInQueue.Location = new System.Drawing.Point(47, 129);
            this.labelSimWaitInQueue.Name = "labelSimWaitInQueue";
            this.labelSimWaitInQueue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitInQueue.TabIndex = 14;
            this.labelSimWaitInQueue.Text = "Priemerný čas čakania vo fronte:";
            this.labelSimWaitInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWaitForRepair
            // 
            this.labelSimWaitForRepair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWaitForRepair.Location = new System.Drawing.Point(47, 150);
            this.labelSimWaitForRepair.Name = "labelSimWaitForRepair";
            this.labelSimWaitForRepair.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitForRepair.TabIndex = 15;
            this.labelSimWaitForRepair.Text = "Priemerný čas čakania na opravu:";
            this.labelSimWaitForRepair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimTimeInService
            // 
            this.labelSimTimeInService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimTimeInService.Location = new System.Drawing.Point(47, 171);
            this.labelSimTimeInService.Name = "labelSimTimeInService";
            this.labelSimTimeInService.Size = new System.Drawing.Size(250, 15);
            this.labelSimTimeInService.TabIndex = 16;
            this.labelSimTimeInService.Text = "Priemerný čas strávený v servise:";
            this.labelSimTimeInService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWaitInQueueIS
            // 
            this.labelSimWaitInQueueIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWaitInQueueIS.Location = new System.Drawing.Point(647, 129);
            this.labelSimWaitInQueueIS.Name = "labelSimWaitInQueueIS";
            this.labelSimWaitInQueueIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitInQueueIS.TabIndex = 17;
            this.labelSimWaitInQueueIS.Text = "90% IS času čakania vo fronte:";
            this.labelSimWaitInQueueIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWaitForRepairIS
            // 
            this.labelSimWaitForRepairIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWaitForRepairIS.Location = new System.Drawing.Point(647, 150);
            this.labelSimWaitForRepairIS.Name = "labelSimWaitForRepairIS";
            this.labelSimWaitForRepairIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimWaitForRepairIS.TabIndex = 18;
            this.labelSimWaitForRepairIS.Text = "90% IS času čakania na opravu:";
            this.labelSimWaitForRepairIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimTimeInServiceIS
            // 
            this.labelSimTimeInServiceIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimTimeInServiceIS.Location = new System.Drawing.Point(647, 171);
            this.labelSimTimeInServiceIS.Name = "labelSimTimeInServiceIS";
            this.labelSimTimeInServiceIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimTimeInServiceIS.TabIndex = 19;
            this.labelSimTimeInServiceIS.Text = "90% IS času stráveného v servise:";
            this.labelSimTimeInServiceIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomersInService
            // 
            this.labelSimCustomersInService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomersInService.Location = new System.Drawing.Point(47, 3);
            this.labelSimCustomersInService.Name = "labelSimCustomersInService";
            this.labelSimCustomersInService.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersInService.TabIndex = 20;
            this.labelSimCustomersInService.Text = "Priemerný počet zákazníkov v servise:";
            this.labelSimCustomersInService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomersInServiceValue
            // 
            this.labelSimCustomersInServiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomersInServiceValue.Location = new System.Drawing.Point(303, 3);
            this.labelSimCustomersInServiceValue.Name = "labelSimCustomersInServiceValue";
            this.labelSimCustomersInServiceValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersInServiceValue.TabIndex = 21;
            this.labelSimCustomersInServiceValue.Text = "-";
            this.labelSimCustomersInServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimRepairedQueueLength
            // 
            this.labelSimRepairedQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimRepairedQueueLength.Location = new System.Drawing.Point(47, 66);
            this.labelSimRepairedQueueLength.Name = "labelSimRepairedQueueLength";
            this.labelSimRepairedQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelSimRepairedQueueLength.TabIndex = 22;
            this.labelSimRepairedQueueLength.Text = "Priemerná dĺžka frontu opravených áut:";
            this.labelSimRepairedQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCustomersServedRatio
            // 
            this.labelSimCustomersServedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCustomersServedRatio.Location = new System.Drawing.Point(47, 108);
            this.labelSimCustomersServedRatio.Name = "labelSimCustomersServedRatio";
            this.labelSimCustomersServedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersServedRatio.TabIndex = 23;
            this.labelSimCustomersServedRatio.Text = "Priemerný pomer obslúžených zákazníkov:";
            this.labelSimCustomersServedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimRepairedQueueLengthValue
            // 
            this.labelSimRepairedQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimRepairedQueueLengthValue.Location = new System.Drawing.Point(303, 66);
            this.labelSimRepairedQueueLengthValue.Name = "labelSimRepairedQueueLengthValue";
            this.labelSimRepairedQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimRepairedQueueLengthValue.TabIndex = 24;
            this.labelSimRepairedQueueLengthValue.Text = "-";
            this.labelSimRepairedQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCustomersServedRatioValue
            // 
            this.labelSimCustomersServedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCustomersServedRatioValue.Location = new System.Drawing.Point(303, 108);
            this.labelSimCustomersServedRatioValue.Name = "labelSimCustomersServedRatioValue";
            this.labelSimCustomersServedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCustomersServedRatioValue.TabIndex = 25;
            this.labelSimCustomersServedRatioValue.Text = "-";
            this.labelSimCustomersServedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking1Count
            // 
            this.labelSimWorking1Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking1Count.Location = new System.Drawing.Point(47, 192);
            this.labelSimWorking1Count.Name = "labelSimWorking1Count";
            this.labelSimWorking1Count.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1Count.TabIndex = 26;
            this.labelSimWorking1Count.Text = "Priemerný počet pracujúcich v skupine 1:";
            this.labelSimWorking1Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking2Count
            // 
            this.labelSimWorking2Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking2Count.Location = new System.Drawing.Point(47, 213);
            this.labelSimWorking2Count.Name = "labelSimWorking2Count";
            this.labelSimWorking2Count.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2Count.TabIndex = 27;
            this.labelSimWorking2Count.Text = "Priemerný počet pracujúcich v skupine 2:";
            this.labelSimWorking2Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking1Ratio
            // 
            this.labelSimWorking1Ratio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking1Ratio.Location = new System.Drawing.Point(47, 234);
            this.labelSimWorking1Ratio.Name = "labelSimWorking1Ratio";
            this.labelSimWorking1Ratio.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1Ratio.TabIndex = 28;
            this.labelSimWorking1Ratio.Text = "Priemerné vyťaženie pracovníkov 1:";
            this.labelSimWorking1Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking2Ratio
            // 
            this.labelSimWorking2Ratio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimWorking2Ratio.Location = new System.Drawing.Point(47, 255);
            this.labelSimWorking2Ratio.Name = "labelSimWorking2Ratio";
            this.labelSimWorking2Ratio.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2Ratio.TabIndex = 29;
            this.labelSimWorking2Ratio.Text = "Priemerné vyťaženie pracovníkov 2:";
            this.labelSimWorking2Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark1Count
            // 
            this.labelSimCarPark1Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark1Count.Location = new System.Drawing.Point(47, 276);
            this.labelSimCarPark1Count.Name = "labelSimCarPark1Count";
            this.labelSimCarPark1Count.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1Count.TabIndex = 30;
            this.labelSimCarPark1Count.Text = "Priemerný počet áut na parkovisku 1:";
            this.labelSimCarPark1Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark2Count
            // 
            this.labelSimCarPark2Count.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark2Count.Location = new System.Drawing.Point(47, 297);
            this.labelSimCarPark2Count.Name = "labelSimCarPark2Count";
            this.labelSimCarPark2Count.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2Count.TabIndex = 31;
            this.labelSimCarPark2Count.Text = "Priemerný počet áut na parkovisku 2:";
            this.labelSimCarPark2Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarParkServiceCount
            // 
            this.labelSimCarParkServiceCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarParkServiceCount.Location = new System.Drawing.Point(47, 318);
            this.labelSimCarParkServiceCount.Name = "labelSimCarParkServiceCount";
            this.labelSimCarParkServiceCount.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarParkServiceCount.TabIndex = 32;
            this.labelSimCarParkServiceCount.Text = "Priemerný počet áut na parkovisku pred servisom:";
            this.labelSimCarParkServiceCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark1Ratio
            // 
            this.labelSimCarPark1Ratio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark1Ratio.Location = new System.Drawing.Point(47, 339);
            this.labelSimCarPark1Ratio.Name = "labelSimCarPark1Ratio";
            this.labelSimCarPark1Ratio.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1Ratio.TabIndex = 33;
            this.labelSimCarPark1Ratio.Text = "Priemerné vyťaženie parkoviska 1:";
            this.labelSimCarPark1Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimCarPark2Ratio
            // 
            this.labelSimCarPark2Ratio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimCarPark2Ratio.Location = new System.Drawing.Point(47, 360);
            this.labelSimCarPark2Ratio.Name = "labelSimCarPark2Ratio";
            this.labelSimCarPark2Ratio.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2Ratio.TabIndex = 34;
            this.labelSimCarPark2Ratio.Text = "Priemerné vyťaženie parkoviska 2:";
            this.labelSimCarPark2Ratio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimWorking1CountValue
            // 
            this.labelSimWorking1CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking1CountValue.Location = new System.Drawing.Point(303, 192);
            this.labelSimWorking1CountValue.Name = "labelSimWorking1CountValue";
            this.labelSimWorking1CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1CountValue.TabIndex = 35;
            this.labelSimWorking1CountValue.Text = "-";
            this.labelSimWorking1CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking2CountValue
            // 
            this.labelSimWorking2CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking2CountValue.Location = new System.Drawing.Point(303, 213);
            this.labelSimWorking2CountValue.Name = "labelSimWorking2CountValue";
            this.labelSimWorking2CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2CountValue.TabIndex = 36;
            this.labelSimWorking2CountValue.Text = "-";
            this.labelSimWorking2CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking1RatioValue
            // 
            this.labelSimWorking1RatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking1RatioValue.Location = new System.Drawing.Point(303, 234);
            this.labelSimWorking1RatioValue.Name = "labelSimWorking1RatioValue";
            this.labelSimWorking1RatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking1RatioValue.TabIndex = 37;
            this.labelSimWorking1RatioValue.Text = "-";
            this.labelSimWorking1RatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimWorking2RatioValue
            // 
            this.labelSimWorking2RatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimWorking2RatioValue.Location = new System.Drawing.Point(303, 255);
            this.labelSimWorking2RatioValue.Name = "labelSimWorking2RatioValue";
            this.labelSimWorking2RatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimWorking2RatioValue.TabIndex = 38;
            this.labelSimWorking2RatioValue.Text = "-";
            this.labelSimWorking2RatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark1CountValue
            // 
            this.labelSimCarPark1CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark1CountValue.Location = new System.Drawing.Point(303, 276);
            this.labelSimCarPark1CountValue.Name = "labelSimCarPark1CountValue";
            this.labelSimCarPark1CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1CountValue.TabIndex = 39;
            this.labelSimCarPark1CountValue.Text = "-";
            this.labelSimCarPark1CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark2CountValue
            // 
            this.labelSimCarPark2CountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark2CountValue.Location = new System.Drawing.Point(303, 297);
            this.labelSimCarPark2CountValue.Name = "labelSimCarPark2CountValue";
            this.labelSimCarPark2CountValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2CountValue.TabIndex = 40;
            this.labelSimCarPark2CountValue.Text = "-";
            this.labelSimCarPark2CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarParkServiceCountValue
            // 
            this.labelSimCarParkServiceCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarParkServiceCountValue.Location = new System.Drawing.Point(303, 318);
            this.labelSimCarParkServiceCountValue.Name = "labelSimCarParkServiceCountValue";
            this.labelSimCarParkServiceCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarParkServiceCountValue.TabIndex = 41;
            this.labelSimCarParkServiceCountValue.Text = "-";
            this.labelSimCarParkServiceCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark1RatioValue
            // 
            this.labelSimCarPark1RatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark1RatioValue.Location = new System.Drawing.Point(303, 339);
            this.labelSimCarPark1RatioValue.Name = "labelSimCarPark1RatioValue";
            this.labelSimCarPark1RatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark1RatioValue.TabIndex = 42;
            this.labelSimCarPark1RatioValue.Text = "-";
            this.labelSimCarPark1RatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimCarPark2RatioValue
            // 
            this.labelSimCarPark2RatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimCarPark2RatioValue.Location = new System.Drawing.Point(303, 360);
            this.labelSimCarPark2RatioValue.Name = "labelSimCarPark2RatioValue";
            this.labelSimCarPark2RatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimCarPark2RatioValue.TabIndex = 43;
            this.labelSimCarPark2RatioValue.Text = "-";
            this.labelSimCarPark2RatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimProfit
            // 
            this.labelSimProfit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimProfit.Location = new System.Drawing.Point(47, 384);
            this.labelSimProfit.Name = "labelSimProfit";
            this.labelSimProfit.Size = new System.Drawing.Size(250, 15);
            this.labelSimProfit.TabIndex = 74;
            this.labelSimProfit.Text = "Hospodársky výsledok (zisky - náklady):";
            this.labelSimProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimProfitValue
            // 
            this.labelSimProfitValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimProfitValue.Location = new System.Drawing.Point(303, 384);
            this.labelSimProfitValue.Name = "labelSimProfitValue";
            this.labelSimProfitValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimProfitValue.TabIndex = 75;
            this.labelSimProfitValue.Text = "-";
            this.labelSimProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSimProfitIS
            // 
            this.labelSimProfitIS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSimProfitIS.Location = new System.Drawing.Point(647, 384);
            this.labelSimProfitIS.Name = "labelSimProfitIS";
            this.labelSimProfitIS.Size = new System.Drawing.Size(250, 15);
            this.labelSimProfitIS.TabIndex = 76;
            this.labelSimProfitIS.Text = "90% IS hospodárskeho výsledku:";
            this.labelSimProfitIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSimProfitISValue
            // 
            this.labelSimProfitISValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSimProfitISValue.Location = new System.Drawing.Point(903, 384);
            this.labelSimProfitISValue.Name = "labelSimProfitISValue";
            this.labelSimProfitISValue.Size = new System.Drawing.Size(250, 15);
            this.labelSimProfitISValue.TabIndex = 77;
            this.labelSimProfitISValue.Text = "-";
            this.labelSimProfitISValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tableLayoutPanelCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(1213, 495);
            this.tabCustomers.TabIndex = 4;
            this.tabCustomers.Text = "Zákazníci";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCustomers
            // 
            this.tableLayoutPanelCustomers.ColumnCount = 1;
            this.tableLayoutPanelCustomers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustomers.Controls.Add(this.dataGridViewCustomers, 0, 0);
            this.tableLayoutPanelCustomers.Controls.Add(this.groupBoxCustomersStats, 0, 1);
            this.tableLayoutPanelCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCustomers.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelCustomers.Name = "tableLayoutPanelCustomers";
            this.tableLayoutPanelCustomers.RowCount = 2;
            this.tableLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelCustomers.Size = new System.Drawing.Size(1207, 489);
            this.tableLayoutPanelCustomers.TabIndex = 0;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AllowUserToAddRows = false;
            this.dataGridViewCustomers.AllowUserToDeleteRows = false;
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.ReadOnly = true;
            this.dataGridViewCustomers.RowHeadersVisible = false;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1201, 333);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // groupBoxCustomersStats
            // 
            this.groupBoxCustomersStats.Controls.Add(this.tableLayoutPanelCustomersStats);
            this.groupBoxCustomersStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustomersStats.Location = new System.Drawing.Point(3, 342);
            this.groupBoxCustomersStats.Name = "groupBoxCustomersStats";
            this.groupBoxCustomersStats.Size = new System.Drawing.Size(1201, 144);
            this.groupBoxCustomersStats.TabIndex = 1;
            this.groupBoxCustomersStats.TabStop = false;
            this.groupBoxCustomersStats.Text = "Štatistiky";
            // 
            // tableLayoutPanelCustomersStats
            // 
            this.tableLayoutPanelCustomersStats.ColumnCount = 4;
            this.tableLayoutPanelCustomersStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCustomersStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCustomersStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCustomersStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersInService, 0, 0);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersInQueue, 0, 1);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersTotal, 0, 2);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersServed, 0, 3);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersNotServed, 0, 4);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersServedRatio, 0, 5);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersInServiceValue, 1, 0);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersInQueueValue, 1, 1);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersTotalValue, 1, 2);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersServedValue, 1, 3);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersNotServedValue, 1, 4);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersServedRatioValue, 1, 5);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgInService, 2, 0);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgInQueue, 2, 1);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgWaitInQueue, 2, 2);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgWaitForRepair, 2, 3);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgTimeInService, 2, 4);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgInServiceValue, 3, 0);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgInQueueValue, 3, 1);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgWaitInQueueValue, 3, 2);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgWaitForRepairValue, 3, 3);
            this.tableLayoutPanelCustomersStats.Controls.Add(this.labelCustomersAvgTimeInServiceValue, 3, 4);
            this.tableLayoutPanelCustomersStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCustomersStats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCustomersStats.Name = "tableLayoutPanelCustomersStats";
            this.tableLayoutPanelCustomersStats.RowCount = 6;
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanelCustomersStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCustomersStats.Size = new System.Drawing.Size(1195, 125);
            this.tableLayoutPanelCustomersStats.TabIndex = 0;
            // 
            // labelCustomersInService
            // 
            this.labelCustomersInService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersInService.Location = new System.Drawing.Point(45, 2);
            this.labelCustomersInService.Name = "labelCustomersInService";
            this.labelCustomersInService.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersInService.TabIndex = 0;
            this.labelCustomersInService.Text = "Počet zákazníkov v servise:";
            this.labelCustomersInService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersInQueue
            // 
            this.labelCustomersInQueue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersInQueue.Location = new System.Drawing.Point(45, 22);
            this.labelCustomersInQueue.Name = "labelCustomersInQueue";
            this.labelCustomersInQueue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersInQueue.TabIndex = 1;
            this.labelCustomersInQueue.Text = "Počet čakajúcich v rade:";
            this.labelCustomersInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersTotal
            // 
            this.labelCustomersTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersTotal.Location = new System.Drawing.Point(45, 42);
            this.labelCustomersTotal.Name = "labelCustomersTotal";
            this.labelCustomersTotal.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersTotal.TabIndex = 2;
            this.labelCustomersTotal.Text = "Celkový počet zákazníkov:";
            this.labelCustomersTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersServed
            // 
            this.labelCustomersServed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersServed.Location = new System.Drawing.Point(45, 62);
            this.labelCustomersServed.Name = "labelCustomersServed";
            this.labelCustomersServed.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersServed.TabIndex = 3;
            this.labelCustomersServed.Text = "Celkový počet obslúžených:";
            this.labelCustomersServed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersNotServed
            // 
            this.labelCustomersNotServed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersNotServed.Location = new System.Drawing.Point(45, 82);
            this.labelCustomersNotServed.Name = "labelCustomersNotServed";
            this.labelCustomersNotServed.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersNotServed.TabIndex = 4;
            this.labelCustomersNotServed.Text = "Celkový počet neobslúžených:";
            this.labelCustomersNotServed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersServedRatio
            // 
            this.labelCustomersServedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersServedRatio.Location = new System.Drawing.Point(45, 105);
            this.labelCustomersServedRatio.Name = "labelCustomersServedRatio";
            this.labelCustomersServedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersServedRatio.TabIndex = 5;
            this.labelCustomersServedRatio.Text = "Pomer obslúžených:";
            this.labelCustomersServedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersInServiceValue
            // 
            this.labelCustomersInServiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersInServiceValue.Location = new System.Drawing.Point(301, 2);
            this.labelCustomersInServiceValue.Name = "labelCustomersInServiceValue";
            this.labelCustomersInServiceValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersInServiceValue.TabIndex = 6;
            this.labelCustomersInServiceValue.Text = "-";
            this.labelCustomersInServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersInQueueValue
            // 
            this.labelCustomersInQueueValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersInQueueValue.Location = new System.Drawing.Point(301, 22);
            this.labelCustomersInQueueValue.Name = "labelCustomersInQueueValue";
            this.labelCustomersInQueueValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersInQueueValue.TabIndex = 7;
            this.labelCustomersInQueueValue.Text = "-";
            this.labelCustomersInQueueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersTotalValue
            // 
            this.labelCustomersTotalValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersTotalValue.Location = new System.Drawing.Point(301, 42);
            this.labelCustomersTotalValue.Name = "labelCustomersTotalValue";
            this.labelCustomersTotalValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersTotalValue.TabIndex = 8;
            this.labelCustomersTotalValue.Text = "-";
            this.labelCustomersTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersServedValue
            // 
            this.labelCustomersServedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersServedValue.Location = new System.Drawing.Point(301, 62);
            this.labelCustomersServedValue.Name = "labelCustomersServedValue";
            this.labelCustomersServedValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersServedValue.TabIndex = 9;
            this.labelCustomersServedValue.Text = "-";
            this.labelCustomersServedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersNotServedValue
            // 
            this.labelCustomersNotServedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersNotServedValue.Location = new System.Drawing.Point(301, 82);
            this.labelCustomersNotServedValue.Name = "labelCustomersNotServedValue";
            this.labelCustomersNotServedValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersNotServedValue.TabIndex = 10;
            this.labelCustomersNotServedValue.Text = "-";
            this.labelCustomersNotServedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersServedRatioValue
            // 
            this.labelCustomersServedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersServedRatioValue.Location = new System.Drawing.Point(301, 105);
            this.labelCustomersServedRatioValue.Name = "labelCustomersServedRatioValue";
            this.labelCustomersServedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersServedRatioValue.TabIndex = 11;
            this.labelCustomersServedRatioValue.Text = "-";
            this.labelCustomersServedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersAvgInService
            // 
            this.labelCustomersAvgInService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersAvgInService.Location = new System.Drawing.Point(641, 2);
            this.labelCustomersAvgInService.Name = "labelCustomersAvgInService";
            this.labelCustomersAvgInService.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgInService.TabIndex = 12;
            this.labelCustomersAvgInService.Text = "Priemerný počet zákazníkov v servise:";
            this.labelCustomersAvgInService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersAvgInQueue
            // 
            this.labelCustomersAvgInQueue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersAvgInQueue.Location = new System.Drawing.Point(641, 22);
            this.labelCustomersAvgInQueue.Name = "labelCustomersAvgInQueue";
            this.labelCustomersAvgInQueue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgInQueue.TabIndex = 13;
            this.labelCustomersAvgInQueue.Text = "Priemerný počet čakajúcich v rade:";
            this.labelCustomersAvgInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersAvgWaitInQueue
            // 
            this.labelCustomersAvgWaitInQueue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersAvgWaitInQueue.Location = new System.Drawing.Point(641, 42);
            this.labelCustomersAvgWaitInQueue.Name = "labelCustomersAvgWaitInQueue";
            this.labelCustomersAvgWaitInQueue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgWaitInQueue.TabIndex = 16;
            this.labelCustomersAvgWaitInQueue.Text = "Priemerný čas čakania vo fronte:";
            this.labelCustomersAvgWaitInQueue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersAvgWaitForRepair
            // 
            this.labelCustomersAvgWaitForRepair.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersAvgWaitForRepair.Location = new System.Drawing.Point(641, 62);
            this.labelCustomersAvgWaitForRepair.Name = "labelCustomersAvgWaitForRepair";
            this.labelCustomersAvgWaitForRepair.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgWaitForRepair.TabIndex = 17;
            this.labelCustomersAvgWaitForRepair.Text = "Priemerný čas čakania na opravu:";
            this.labelCustomersAvgWaitForRepair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersAvgTimeInService
            // 
            this.labelCustomersAvgTimeInService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCustomersAvgTimeInService.Location = new System.Drawing.Point(641, 82);
            this.labelCustomersAvgTimeInService.Name = "labelCustomersAvgTimeInService";
            this.labelCustomersAvgTimeInService.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgTimeInService.TabIndex = 18;
            this.labelCustomersAvgTimeInService.Text = "Priemerný čas strávený v servise:";
            this.labelCustomersAvgTimeInService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomersAvgInServiceValue
            // 
            this.labelCustomersAvgInServiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersAvgInServiceValue.Location = new System.Drawing.Point(897, 2);
            this.labelCustomersAvgInServiceValue.Name = "labelCustomersAvgInServiceValue";
            this.labelCustomersAvgInServiceValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgInServiceValue.TabIndex = 19;
            this.labelCustomersAvgInServiceValue.Text = "-";
            this.labelCustomersAvgInServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersAvgInQueueValue
            // 
            this.labelCustomersAvgInQueueValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersAvgInQueueValue.Location = new System.Drawing.Point(897, 22);
            this.labelCustomersAvgInQueueValue.Name = "labelCustomersAvgInQueueValue";
            this.labelCustomersAvgInQueueValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgInQueueValue.TabIndex = 20;
            this.labelCustomersAvgInQueueValue.Text = "-";
            this.labelCustomersAvgInQueueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersAvgWaitInQueueValue
            // 
            this.labelCustomersAvgWaitInQueueValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersAvgWaitInQueueValue.Location = new System.Drawing.Point(897, 42);
            this.labelCustomersAvgWaitInQueueValue.Name = "labelCustomersAvgWaitInQueueValue";
            this.labelCustomersAvgWaitInQueueValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgWaitInQueueValue.TabIndex = 23;
            this.labelCustomersAvgWaitInQueueValue.Text = "-";
            this.labelCustomersAvgWaitInQueueValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersAvgWaitForRepairValue
            // 
            this.labelCustomersAvgWaitForRepairValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersAvgWaitForRepairValue.Location = new System.Drawing.Point(897, 62);
            this.labelCustomersAvgWaitForRepairValue.Name = "labelCustomersAvgWaitForRepairValue";
            this.labelCustomersAvgWaitForRepairValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgWaitForRepairValue.TabIndex = 24;
            this.labelCustomersAvgWaitForRepairValue.Text = "-";
            this.labelCustomersAvgWaitForRepairValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomersAvgTimeInServiceValue
            // 
            this.labelCustomersAvgTimeInServiceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCustomersAvgTimeInServiceValue.Location = new System.Drawing.Point(897, 82);
            this.labelCustomersAvgTimeInServiceValue.Name = "labelCustomersAvgTimeInServiceValue";
            this.labelCustomersAvgTimeInServiceValue.Size = new System.Drawing.Size(250, 15);
            this.labelCustomersAvgTimeInServiceValue.TabIndex = 25;
            this.labelCustomersAvgTimeInServiceValue.Text = "-";
            this.labelCustomersAvgTimeInServiceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabWorkers1
            // 
            this.tabWorkers1.Controls.Add(this.tableLayoutPanelWorkers1);
            this.tabWorkers1.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers1.Name = "tabWorkers1";
            this.tabWorkers1.Size = new System.Drawing.Size(1213, 495);
            this.tabWorkers1.TabIndex = 5;
            this.tabWorkers1.Text = "Pracovníci skupiny 1";
            this.tabWorkers1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelWorkers1
            // 
            this.tableLayoutPanelWorkers1.ColumnCount = 1;
            this.tableLayoutPanelWorkers1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWorkers1.Controls.Add(this.groupBoxWorkers1Stats, 0, 1);
            this.tableLayoutPanelWorkers1.Controls.Add(this.dataGridViewWorkers1, 0, 0);
            this.tableLayoutPanelWorkers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWorkers1.Name = "tableLayoutPanelWorkers1";
            this.tableLayoutPanelWorkers1.RowCount = 2;
            this.tableLayoutPanelWorkers1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWorkers1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelWorkers1.Size = new System.Drawing.Size(1213, 495);
            this.tableLayoutPanelWorkers1.TabIndex = 0;
            // 
            // groupBoxWorkers1Stats
            // 
            this.groupBoxWorkers1Stats.Controls.Add(this.tableLayoutPanelWorkers1Stats);
            this.groupBoxWorkers1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkers1Stats.Location = new System.Drawing.Point(3, 393);
            this.groupBoxWorkers1Stats.Name = "groupBoxWorkers1Stats";
            this.groupBoxWorkers1Stats.Size = new System.Drawing.Size(1207, 99);
            this.groupBoxWorkers1Stats.TabIndex = 2;
            this.groupBoxWorkers1Stats.TabStop = false;
            this.groupBoxWorkers1Stats.Text = "Štatistiky";
            // 
            // tableLayoutPanelWorkers1Stats
            // 
            this.tableLayoutPanelWorkers1Stats.ColumnCount = 4;
            this.tableLayoutPanelWorkers1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1WorkingCount, 0, 0);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1WorkingCountValue, 1, 0);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1WorkingRatio, 0, 1);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1WorkingRatioValue, 1, 1);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1ReturnQueueLength, 0, 2);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1ReturnQueueLengthValue, 1, 2);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgWorkingCount, 2, 0);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgWorkingRatio, 2, 1);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgReturnQueueLength, 2, 2);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgWorkingCountValue, 3, 0);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgWorkingRatioValue, 3, 1);
            this.tableLayoutPanelWorkers1Stats.Controls.Add(this.labelWorkers1AvgReturnQueueLengthValue, 3, 2);
            this.tableLayoutPanelWorkers1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers1Stats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelWorkers1Stats.Name = "tableLayoutPanelWorkers1Stats";
            this.tableLayoutPanelWorkers1Stats.RowCount = 3;
            this.tableLayoutPanelWorkers1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelWorkers1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelWorkers1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelWorkers1Stats.Size = new System.Drawing.Size(1201, 80);
            this.tableLayoutPanelWorkers1Stats.TabIndex = 0;
            // 
            // labelWorkers1WorkingCount
            // 
            this.labelWorkers1WorkingCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1WorkingCount.Location = new System.Drawing.Point(47, 5);
            this.labelWorkers1WorkingCount.Name = "labelWorkers1WorkingCount";
            this.labelWorkers1WorkingCount.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1WorkingCount.TabIndex = 0;
            this.labelWorkers1WorkingCount.Text = "Počet pracujúcich:";
            this.labelWorkers1WorkingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1WorkingCountValue
            // 
            this.labelWorkers1WorkingCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1WorkingCountValue.Location = new System.Drawing.Point(303, 5);
            this.labelWorkers1WorkingCountValue.Name = "labelWorkers1WorkingCountValue";
            this.labelWorkers1WorkingCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1WorkingCountValue.TabIndex = 1;
            this.labelWorkers1WorkingCountValue.Text = "-";
            this.labelWorkers1WorkingCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1WorkingRatio
            // 
            this.labelWorkers1WorkingRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1WorkingRatio.Location = new System.Drawing.Point(47, 31);
            this.labelWorkers1WorkingRatio.Name = "labelWorkers1WorkingRatio";
            this.labelWorkers1WorkingRatio.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1WorkingRatio.TabIndex = 2;
            this.labelWorkers1WorkingRatio.Text = "Vyťaženie pracoviska:";
            this.labelWorkers1WorkingRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1WorkingRatioValue
            // 
            this.labelWorkers1WorkingRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1WorkingRatioValue.Location = new System.Drawing.Point(303, 31);
            this.labelWorkers1WorkingRatioValue.Name = "labelWorkers1WorkingRatioValue";
            this.labelWorkers1WorkingRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1WorkingRatioValue.TabIndex = 3;
            this.labelWorkers1WorkingRatioValue.Text = "-";
            this.labelWorkers1WorkingRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1ReturnQueueLength
            // 
            this.labelWorkers1ReturnQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1ReturnQueueLength.Location = new System.Drawing.Point(47, 58);
            this.labelWorkers1ReturnQueueLength.Name = "labelWorkers1ReturnQueueLength";
            this.labelWorkers1ReturnQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1ReturnQueueLength.TabIndex = 4;
            this.labelWorkers1ReturnQueueLength.Text = "Dĺžka frontu áut na vrátenie:";
            this.labelWorkers1ReturnQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1ReturnQueueLengthValue
            // 
            this.labelWorkers1ReturnQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1ReturnQueueLengthValue.Location = new System.Drawing.Point(303, 58);
            this.labelWorkers1ReturnQueueLengthValue.Name = "labelWorkers1ReturnQueueLengthValue";
            this.labelWorkers1ReturnQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1ReturnQueueLengthValue.TabIndex = 5;
            this.labelWorkers1ReturnQueueLengthValue.Text = "-";
            this.labelWorkers1ReturnQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1AvgWorkingCount
            // 
            this.labelWorkers1AvgWorkingCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1AvgWorkingCount.Location = new System.Drawing.Point(647, 5);
            this.labelWorkers1AvgWorkingCount.Name = "labelWorkers1AvgWorkingCount";
            this.labelWorkers1AvgWorkingCount.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgWorkingCount.TabIndex = 6;
            this.labelWorkers1AvgWorkingCount.Text = "Priemerný počet pracujúcich:";
            this.labelWorkers1AvgWorkingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1AvgWorkingRatio
            // 
            this.labelWorkers1AvgWorkingRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1AvgWorkingRatio.Location = new System.Drawing.Point(647, 31);
            this.labelWorkers1AvgWorkingRatio.Name = "labelWorkers1AvgWorkingRatio";
            this.labelWorkers1AvgWorkingRatio.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgWorkingRatio.TabIndex = 7;
            this.labelWorkers1AvgWorkingRatio.Text = "Priemerné vyťaženie pracoviska:";
            this.labelWorkers1AvgWorkingRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1AvgReturnQueueLength
            // 
            this.labelWorkers1AvgReturnQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers1AvgReturnQueueLength.Location = new System.Drawing.Point(647, 58);
            this.labelWorkers1AvgReturnQueueLength.Name = "labelWorkers1AvgReturnQueueLength";
            this.labelWorkers1AvgReturnQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgReturnQueueLength.TabIndex = 8;
            this.labelWorkers1AvgReturnQueueLength.Text = "Priemerná dĺžka frontu áut na vrátenie:";
            this.labelWorkers1AvgReturnQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1AvgWorkingCountValue
            // 
            this.labelWorkers1AvgWorkingCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1AvgWorkingCountValue.Location = new System.Drawing.Point(903, 5);
            this.labelWorkers1AvgWorkingCountValue.Name = "labelWorkers1AvgWorkingCountValue";
            this.labelWorkers1AvgWorkingCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgWorkingCountValue.TabIndex = 9;
            this.labelWorkers1AvgWorkingCountValue.Text = "-";
            this.labelWorkers1AvgWorkingCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1AvgWorkingRatioValue
            // 
            this.labelWorkers1AvgWorkingRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1AvgWorkingRatioValue.Location = new System.Drawing.Point(903, 31);
            this.labelWorkers1AvgWorkingRatioValue.Name = "labelWorkers1AvgWorkingRatioValue";
            this.labelWorkers1AvgWorkingRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgWorkingRatioValue.TabIndex = 10;
            this.labelWorkers1AvgWorkingRatioValue.Text = "-";
            this.labelWorkers1AvgWorkingRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1AvgReturnQueueLengthValue
            // 
            this.labelWorkers1AvgReturnQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers1AvgReturnQueueLengthValue.Location = new System.Drawing.Point(903, 58);
            this.labelWorkers1AvgReturnQueueLengthValue.Name = "labelWorkers1AvgReturnQueueLengthValue";
            this.labelWorkers1AvgReturnQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers1AvgReturnQueueLengthValue.TabIndex = 11;
            this.labelWorkers1AvgReturnQueueLengthValue.Text = "-";
            this.labelWorkers1AvgReturnQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewWorkers1
            // 
            this.dataGridViewWorkers1.AllowUserToAddRows = false;
            this.dataGridViewWorkers1.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkers1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWorkers1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWorkers1.Name = "dataGridViewWorkers1";
            this.dataGridViewWorkers1.ReadOnly = true;
            this.dataGridViewWorkers1.RowHeadersVisible = false;
            this.dataGridViewWorkers1.Size = new System.Drawing.Size(1207, 384);
            this.dataGridViewWorkers1.TabIndex = 1;
            // 
            // tabWorkers2
            // 
            this.tabWorkers2.Controls.Add(this.tableLayoutPanelWorkers2);
            this.tabWorkers2.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers2.Name = "tabWorkers2";
            this.tabWorkers2.Size = new System.Drawing.Size(1213, 495);
            this.tabWorkers2.TabIndex = 6;
            this.tabWorkers2.Text = "Pracovníci skupiny 2";
            this.tabWorkers2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelWorkers2
            // 
            this.tableLayoutPanelWorkers2.ColumnCount = 1;
            this.tableLayoutPanelWorkers2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWorkers2.Controls.Add(this.groupBoxWorkers2Stats, 0, 1);
            this.tableLayoutPanelWorkers2.Controls.Add(this.dataGridViewWorkers2, 0, 0);
            this.tableLayoutPanelWorkers2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWorkers2.Name = "tableLayoutPanelWorkers2";
            this.tableLayoutPanelWorkers2.RowCount = 2;
            this.tableLayoutPanelWorkers2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWorkers2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelWorkers2.Size = new System.Drawing.Size(1213, 495);
            this.tableLayoutPanelWorkers2.TabIndex = 0;
            // 
            // groupBoxWorkers2Stats
            // 
            this.groupBoxWorkers2Stats.Controls.Add(this.tableLayoutPanelWorkers2Stats);
            this.groupBoxWorkers2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkers2Stats.Location = new System.Drawing.Point(3, 393);
            this.groupBoxWorkers2Stats.Name = "groupBoxWorkers2Stats";
            this.groupBoxWorkers2Stats.Size = new System.Drawing.Size(1207, 99);
            this.groupBoxWorkers2Stats.TabIndex = 3;
            this.groupBoxWorkers2Stats.TabStop = false;
            this.groupBoxWorkers2Stats.Text = "Štatistiky";
            // 
            // tableLayoutPanelWorkers2Stats
            // 
            this.tableLayoutPanelWorkers2Stats.ColumnCount = 4;
            this.tableLayoutPanelWorkers2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2WorkingCount, 0, 0);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2WorkingCountValue, 1, 0);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2WorkingRatio, 0, 1);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2WorkingRatioValue, 1, 1);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2ToRepairQueueLength, 0, 2);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2ToRepairQueueLengthValue, 1, 2);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgWorkingCount, 2, 0);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgWorkingRatio, 2, 1);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgToRepairQueueLength, 2, 2);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgWorkingCountValue, 3, 0);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgWorkingRatioValue, 3, 1);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgToRepairQueueLengthValue, 3, 2);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2RepairedQueueLength, 0, 3);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2RepairedQueueLengthValue, 1, 3);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgRepairedQueueLength, 2, 3);
            this.tableLayoutPanelWorkers2Stats.Controls.Add(this.labelWorkers2AvgRepairedQueueLengthValue, 3, 3);
            this.tableLayoutPanelWorkers2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers2Stats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelWorkers2Stats.Name = "tableLayoutPanelWorkers2Stats";
            this.tableLayoutPanelWorkers2Stats.RowCount = 4;
            this.tableLayoutPanelWorkers2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelWorkers2Stats.Size = new System.Drawing.Size(1201, 80);
            this.tableLayoutPanelWorkers2Stats.TabIndex = 1;
            // 
            // labelWorkers2WorkingCount
            // 
            this.labelWorkers2WorkingCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2WorkingCount.Location = new System.Drawing.Point(47, 2);
            this.labelWorkers2WorkingCount.Name = "labelWorkers2WorkingCount";
            this.labelWorkers2WorkingCount.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2WorkingCount.TabIndex = 0;
            this.labelWorkers2WorkingCount.Text = "Počet pracujúcich:";
            this.labelWorkers2WorkingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2WorkingCountValue
            // 
            this.labelWorkers2WorkingCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2WorkingCountValue.Location = new System.Drawing.Point(303, 2);
            this.labelWorkers2WorkingCountValue.Name = "labelWorkers2WorkingCountValue";
            this.labelWorkers2WorkingCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2WorkingCountValue.TabIndex = 1;
            this.labelWorkers2WorkingCountValue.Text = "-";
            this.labelWorkers2WorkingCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2WorkingRatio
            // 
            this.labelWorkers2WorkingRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2WorkingRatio.Location = new System.Drawing.Point(47, 22);
            this.labelWorkers2WorkingRatio.Name = "labelWorkers2WorkingRatio";
            this.labelWorkers2WorkingRatio.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2WorkingRatio.TabIndex = 2;
            this.labelWorkers2WorkingRatio.Text = "Vyťaženie pracoviska:";
            this.labelWorkers2WorkingRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2WorkingRatioValue
            // 
            this.labelWorkers2WorkingRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2WorkingRatioValue.Location = new System.Drawing.Point(303, 22);
            this.labelWorkers2WorkingRatioValue.Name = "labelWorkers2WorkingRatioValue";
            this.labelWorkers2WorkingRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2WorkingRatioValue.TabIndex = 3;
            this.labelWorkers2WorkingRatioValue.Text = "-";
            this.labelWorkers2WorkingRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2ToRepairQueueLength
            // 
            this.labelWorkers2ToRepairQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2ToRepairQueueLength.Location = new System.Drawing.Point(47, 42);
            this.labelWorkers2ToRepairQueueLength.Name = "labelWorkers2ToRepairQueueLength";
            this.labelWorkers2ToRepairQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2ToRepairQueueLength.TabIndex = 4;
            this.labelWorkers2ToRepairQueueLength.Text = "Dĺžka frontu áut na opravu:";
            this.labelWorkers2ToRepairQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2ToRepairQueueLengthValue
            // 
            this.labelWorkers2ToRepairQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2ToRepairQueueLengthValue.Location = new System.Drawing.Point(303, 42);
            this.labelWorkers2ToRepairQueueLengthValue.Name = "labelWorkers2ToRepairQueueLengthValue";
            this.labelWorkers2ToRepairQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2ToRepairQueueLengthValue.TabIndex = 5;
            this.labelWorkers2ToRepairQueueLengthValue.Text = "-";
            this.labelWorkers2ToRepairQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2AvgWorkingCount
            // 
            this.labelWorkers2AvgWorkingCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2AvgWorkingCount.Location = new System.Drawing.Point(647, 2);
            this.labelWorkers2AvgWorkingCount.Name = "labelWorkers2AvgWorkingCount";
            this.labelWorkers2AvgWorkingCount.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgWorkingCount.TabIndex = 6;
            this.labelWorkers2AvgWorkingCount.Text = "Priemerný počet pracujúcich:";
            this.labelWorkers2AvgWorkingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2AvgWorkingRatio
            // 
            this.labelWorkers2AvgWorkingRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2AvgWorkingRatio.Location = new System.Drawing.Point(647, 22);
            this.labelWorkers2AvgWorkingRatio.Name = "labelWorkers2AvgWorkingRatio";
            this.labelWorkers2AvgWorkingRatio.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgWorkingRatio.TabIndex = 7;
            this.labelWorkers2AvgWorkingRatio.Text = "Priemerné vyťaženie pracoviska:";
            this.labelWorkers2AvgWorkingRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2AvgToRepairQueueLength
            // 
            this.labelWorkers2AvgToRepairQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2AvgToRepairQueueLength.Location = new System.Drawing.Point(647, 42);
            this.labelWorkers2AvgToRepairQueueLength.Name = "labelWorkers2AvgToRepairQueueLength";
            this.labelWorkers2AvgToRepairQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgToRepairQueueLength.TabIndex = 8;
            this.labelWorkers2AvgToRepairQueueLength.Text = "Priemerná dĺžka frontu áut na opravu:";
            this.labelWorkers2AvgToRepairQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2AvgWorkingCountValue
            // 
            this.labelWorkers2AvgWorkingCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2AvgWorkingCountValue.Location = new System.Drawing.Point(903, 2);
            this.labelWorkers2AvgWorkingCountValue.Name = "labelWorkers2AvgWorkingCountValue";
            this.labelWorkers2AvgWorkingCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgWorkingCountValue.TabIndex = 9;
            this.labelWorkers2AvgWorkingCountValue.Text = "-";
            this.labelWorkers2AvgWorkingCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2AvgWorkingRatioValue
            // 
            this.labelWorkers2AvgWorkingRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2AvgWorkingRatioValue.Location = new System.Drawing.Point(903, 22);
            this.labelWorkers2AvgWorkingRatioValue.Name = "labelWorkers2AvgWorkingRatioValue";
            this.labelWorkers2AvgWorkingRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgWorkingRatioValue.TabIndex = 10;
            this.labelWorkers2AvgWorkingRatioValue.Text = "-";
            this.labelWorkers2AvgWorkingRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2AvgToRepairQueueLengthValue
            // 
            this.labelWorkers2AvgToRepairQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2AvgToRepairQueueLengthValue.Location = new System.Drawing.Point(903, 42);
            this.labelWorkers2AvgToRepairQueueLengthValue.Name = "labelWorkers2AvgToRepairQueueLengthValue";
            this.labelWorkers2AvgToRepairQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgToRepairQueueLengthValue.TabIndex = 11;
            this.labelWorkers2AvgToRepairQueueLengthValue.Text = "-";
            this.labelWorkers2AvgToRepairQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2RepairedQueueLength
            // 
            this.labelWorkers2RepairedQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2RepairedQueueLength.Location = new System.Drawing.Point(47, 62);
            this.labelWorkers2RepairedQueueLength.Name = "labelWorkers2RepairedQueueLength";
            this.labelWorkers2RepairedQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2RepairedQueueLength.TabIndex = 12;
            this.labelWorkers2RepairedQueueLength.Text = "Dĺžka frontu opravených áut:";
            this.labelWorkers2RepairedQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2RepairedQueueLengthValue
            // 
            this.labelWorkers2RepairedQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2RepairedQueueLengthValue.Location = new System.Drawing.Point(303, 62);
            this.labelWorkers2RepairedQueueLengthValue.Name = "labelWorkers2RepairedQueueLengthValue";
            this.labelWorkers2RepairedQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2RepairedQueueLengthValue.TabIndex = 13;
            this.labelWorkers2RepairedQueueLengthValue.Text = "-";
            this.labelWorkers2RepairedQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2AvgRepairedQueueLength
            // 
            this.labelWorkers2AvgRepairedQueueLength.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelWorkers2AvgRepairedQueueLength.Location = new System.Drawing.Point(647, 62);
            this.labelWorkers2AvgRepairedQueueLength.Name = "labelWorkers2AvgRepairedQueueLength";
            this.labelWorkers2AvgRepairedQueueLength.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgRepairedQueueLength.TabIndex = 14;
            this.labelWorkers2AvgRepairedQueueLength.Text = "Priemerná dĺžka frontu opravených áut:";
            this.labelWorkers2AvgRepairedQueueLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2AvgRepairedQueueLengthValue
            // 
            this.labelWorkers2AvgRepairedQueueLengthValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelWorkers2AvgRepairedQueueLengthValue.Location = new System.Drawing.Point(903, 62);
            this.labelWorkers2AvgRepairedQueueLengthValue.Name = "labelWorkers2AvgRepairedQueueLengthValue";
            this.labelWorkers2AvgRepairedQueueLengthValue.Size = new System.Drawing.Size(250, 15);
            this.labelWorkers2AvgRepairedQueueLengthValue.TabIndex = 15;
            this.labelWorkers2AvgRepairedQueueLengthValue.Text = "-";
            this.labelWorkers2AvgRepairedQueueLengthValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewWorkers2
            // 
            this.dataGridViewWorkers2.AllowUserToAddRows = false;
            this.dataGridViewWorkers2.AllowUserToDeleteRows = false;
            this.dataGridViewWorkers2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWorkers2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWorkers2.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewWorkers2.Name = "dataGridViewWorkers2";
            this.dataGridViewWorkers2.ReadOnly = true;
            this.dataGridViewWorkers2.RowHeadersVisible = false;
            this.dataGridViewWorkers2.Size = new System.Drawing.Size(1207, 384);
            this.dataGridViewWorkers2.TabIndex = 2;
            // 
            // tabCarParks
            // 
            this.tabCarParks.Controls.Add(this.tableLayoutPanelCarParks);
            this.tabCarParks.Location = new System.Drawing.Point(4, 22);
            this.tabCarParks.Name = "tabCarParks";
            this.tabCarParks.Size = new System.Drawing.Size(1213, 495);
            this.tabCarParks.TabIndex = 7;
            this.tabCarParks.Text = "Parkoviská";
            this.tabCarParks.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelCarParks
            // 
            this.tableLayoutPanelCarParks.ColumnCount = 2;
            this.tableLayoutPanelCarParks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParks.Controls.Add(this.groupBoxCarPark1, 0, 0);
            this.tableLayoutPanelCarParks.Controls.Add(this.groupBoxCarPark2, 1, 0);
            this.tableLayoutPanelCarParks.Controls.Add(this.groupBoxCarPark1Stats, 0, 1);
            this.tableLayoutPanelCarParks.Controls.Add(this.groupBoxCarPark2Stats, 1, 1);
            this.tableLayoutPanelCarParks.Controls.Add(this.groupBoxCarParkService, 0, 2);
            this.tableLayoutPanelCarParks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCarParks.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelCarParks.Name = "tableLayoutPanelCarParks";
            this.tableLayoutPanelCarParks.RowCount = 3;
            this.tableLayoutPanelCarParks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCarParks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanelCarParks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelCarParks.Size = new System.Drawing.Size(1213, 495);
            this.tableLayoutPanelCarParks.TabIndex = 0;
            // 
            // groupBoxCarPark1
            // 
            this.groupBoxCarPark1.Controls.Add(this.dataGridViewCarPark1);
            this.groupBoxCarPark1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCarPark1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCarPark1.Name = "groupBoxCarPark1";
            this.groupBoxCarPark1.Size = new System.Drawing.Size(600, 319);
            this.groupBoxCarPark1.TabIndex = 0;
            this.groupBoxCarPark1.TabStop = false;
            this.groupBoxCarPark1.Text = "Parkovisko 1";
            // 
            // dataGridViewCarPark1
            // 
            this.dataGridViewCarPark1.AllowUserToAddRows = false;
            this.dataGridViewCarPark1.AllowUserToDeleteRows = false;
            this.dataGridViewCarPark1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarPark1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarPark1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarPark1.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCarPark1.Name = "dataGridViewCarPark1";
            this.dataGridViewCarPark1.ReadOnly = true;
            this.dataGridViewCarPark1.RowHeadersVisible = false;
            this.dataGridViewCarPark1.Size = new System.Drawing.Size(594, 300);
            this.dataGridViewCarPark1.TabIndex = 3;
            // 
            // groupBoxCarPark2
            // 
            this.groupBoxCarPark2.Controls.Add(this.dataGridViewCarPark2);
            this.groupBoxCarPark2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCarPark2.Location = new System.Drawing.Point(609, 3);
            this.groupBoxCarPark2.Name = "groupBoxCarPark2";
            this.groupBoxCarPark2.Size = new System.Drawing.Size(601, 319);
            this.groupBoxCarPark2.TabIndex = 1;
            this.groupBoxCarPark2.TabStop = false;
            this.groupBoxCarPark2.Text = "Parkovisko 2";
            // 
            // dataGridViewCarPark2
            // 
            this.dataGridViewCarPark2.AllowUserToAddRows = false;
            this.dataGridViewCarPark2.AllowUserToDeleteRows = false;
            this.dataGridViewCarPark2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarPark2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarPark2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarPark2.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewCarPark2.Name = "dataGridViewCarPark2";
            this.dataGridViewCarPark2.ReadOnly = true;
            this.dataGridViewCarPark2.RowHeadersVisible = false;
            this.dataGridViewCarPark2.Size = new System.Drawing.Size(595, 300);
            this.dataGridViewCarPark2.TabIndex = 3;
            // 
            // groupBoxCarPark1Stats
            // 
            this.groupBoxCarPark1Stats.Controls.Add(this.tableLayoutPanelCarPark1Stats);
            this.groupBoxCarPark1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCarPark1Stats.Location = new System.Drawing.Point(3, 328);
            this.groupBoxCarPark1Stats.Name = "groupBoxCarPark1Stats";
            this.groupBoxCarPark1Stats.Size = new System.Drawing.Size(600, 99);
            this.groupBoxCarPark1Stats.TabIndex = 2;
            this.groupBoxCarPark1Stats.TabStop = false;
            this.groupBoxCarPark1Stats.Text = "Štatistiky parkoviska 1";
            // 
            // tableLayoutPanelCarPark1Stats
            // 
            this.tableLayoutPanelCarPark1Stats.ColumnCount = 2;
            this.tableLayoutPanelCarPark1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarPark1Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1OccupiedCount, 0, 0);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1AvgOccupiedCount, 0, 1);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1OccupiedRatio, 0, 2);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1AvgOccupiedRatio, 0, 3);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1OccupiedCountValue, 1, 0);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1AvgOccupiedCountValue, 1, 1);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1OccupiedRatioValue, 1, 2);
            this.tableLayoutPanelCarPark1Stats.Controls.Add(this.labelCarPark1AvgOccupiedRatioValue, 1, 3);
            this.tableLayoutPanelCarPark1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCarPark1Stats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCarPark1Stats.Name = "tableLayoutPanelCarPark1Stats";
            this.tableLayoutPanelCarPark1Stats.RowCount = 4;
            this.tableLayoutPanelCarPark1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark1Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark1Stats.Size = new System.Drawing.Size(594, 80);
            this.tableLayoutPanelCarPark1Stats.TabIndex = 0;
            // 
            // labelCarPark1OccupiedCount
            // 
            this.labelCarPark1OccupiedCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark1OccupiedCount.Location = new System.Drawing.Point(44, 2);
            this.labelCarPark1OccupiedCount.Name = "labelCarPark1OccupiedCount";
            this.labelCarPark1OccupiedCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1OccupiedCount.TabIndex = 0;
            this.labelCarPark1OccupiedCount.Text = "Počet obsadených miest:";
            this.labelCarPark1OccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark1AvgOccupiedCount
            // 
            this.labelCarPark1AvgOccupiedCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark1AvgOccupiedCount.Location = new System.Drawing.Point(44, 22);
            this.labelCarPark1AvgOccupiedCount.Name = "labelCarPark1AvgOccupiedCount";
            this.labelCarPark1AvgOccupiedCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1AvgOccupiedCount.TabIndex = 1;
            this.labelCarPark1AvgOccupiedCount.Text = "Priemerný počet obsadených miest:";
            this.labelCarPark1AvgOccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark1OccupiedRatio
            // 
            this.labelCarPark1OccupiedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark1OccupiedRatio.Location = new System.Drawing.Point(44, 42);
            this.labelCarPark1OccupiedRatio.Name = "labelCarPark1OccupiedRatio";
            this.labelCarPark1OccupiedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1OccupiedRatio.TabIndex = 2;
            this.labelCarPark1OccupiedRatio.Text = "Vyťaženie:";
            this.labelCarPark1OccupiedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark1AvgOccupiedRatio
            // 
            this.labelCarPark1AvgOccupiedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark1AvgOccupiedRatio.Location = new System.Drawing.Point(44, 62);
            this.labelCarPark1AvgOccupiedRatio.Name = "labelCarPark1AvgOccupiedRatio";
            this.labelCarPark1AvgOccupiedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1AvgOccupiedRatio.TabIndex = 3;
            this.labelCarPark1AvgOccupiedRatio.Text = "Priemerné vyťaženie:";
            this.labelCarPark1AvgOccupiedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark1OccupiedCountValue
            // 
            this.labelCarPark1OccupiedCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark1OccupiedCountValue.Location = new System.Drawing.Point(300, 2);
            this.labelCarPark1OccupiedCountValue.Name = "labelCarPark1OccupiedCountValue";
            this.labelCarPark1OccupiedCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1OccupiedCountValue.TabIndex = 4;
            this.labelCarPark1OccupiedCountValue.Text = "-";
            this.labelCarPark1OccupiedCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark1AvgOccupiedCountValue
            // 
            this.labelCarPark1AvgOccupiedCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark1AvgOccupiedCountValue.Location = new System.Drawing.Point(300, 22);
            this.labelCarPark1AvgOccupiedCountValue.Name = "labelCarPark1AvgOccupiedCountValue";
            this.labelCarPark1AvgOccupiedCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1AvgOccupiedCountValue.TabIndex = 5;
            this.labelCarPark1AvgOccupiedCountValue.Text = "-";
            this.labelCarPark1AvgOccupiedCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark1OccupiedRatioValue
            // 
            this.labelCarPark1OccupiedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark1OccupiedRatioValue.Location = new System.Drawing.Point(300, 42);
            this.labelCarPark1OccupiedRatioValue.Name = "labelCarPark1OccupiedRatioValue";
            this.labelCarPark1OccupiedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1OccupiedRatioValue.TabIndex = 6;
            this.labelCarPark1OccupiedRatioValue.Text = "-";
            this.labelCarPark1OccupiedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark1AvgOccupiedRatioValue
            // 
            this.labelCarPark1AvgOccupiedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark1AvgOccupiedRatioValue.Location = new System.Drawing.Point(300, 62);
            this.labelCarPark1AvgOccupiedRatioValue.Name = "labelCarPark1AvgOccupiedRatioValue";
            this.labelCarPark1AvgOccupiedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark1AvgOccupiedRatioValue.TabIndex = 7;
            this.labelCarPark1AvgOccupiedRatioValue.Text = "-";
            this.labelCarPark1AvgOccupiedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxCarPark2Stats
            // 
            this.groupBoxCarPark2Stats.Controls.Add(this.tableLayoutPanelCarPark2Stats);
            this.groupBoxCarPark2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCarPark2Stats.Location = new System.Drawing.Point(609, 328);
            this.groupBoxCarPark2Stats.Name = "groupBoxCarPark2Stats";
            this.groupBoxCarPark2Stats.Size = new System.Drawing.Size(601, 99);
            this.groupBoxCarPark2Stats.TabIndex = 3;
            this.groupBoxCarPark2Stats.TabStop = false;
            this.groupBoxCarPark2Stats.Text = "Štatistiky parkoviska 2";
            // 
            // tableLayoutPanelCarPark2Stats
            // 
            this.tableLayoutPanelCarPark2Stats.ColumnCount = 2;
            this.tableLayoutPanelCarPark2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarPark2Stats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2OccupiedCount, 0, 0);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2AvgOccupiedCount, 0, 1);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2OccupiedRatio, 0, 2);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2AvgOccupiedRatio, 0, 3);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2OccupiedCountValue, 1, 0);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2AvgOccupiedCountValue, 1, 1);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2OccupiedRatioValue, 1, 2);
            this.tableLayoutPanelCarPark2Stats.Controls.Add(this.labelCarPark2AvgOccupiedRatioValue, 1, 3);
            this.tableLayoutPanelCarPark2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCarPark2Stats.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCarPark2Stats.Name = "tableLayoutPanelCarPark2Stats";
            this.tableLayoutPanelCarPark2Stats.RowCount = 4;
            this.tableLayoutPanelCarPark2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark2Stats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelCarPark2Stats.Size = new System.Drawing.Size(595, 80);
            this.tableLayoutPanelCarPark2Stats.TabIndex = 1;
            // 
            // labelCarPark2OccupiedCount
            // 
            this.labelCarPark2OccupiedCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark2OccupiedCount.Location = new System.Drawing.Point(44, 2);
            this.labelCarPark2OccupiedCount.Name = "labelCarPark2OccupiedCount";
            this.labelCarPark2OccupiedCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2OccupiedCount.TabIndex = 0;
            this.labelCarPark2OccupiedCount.Text = "Počet obsadených miest:";
            this.labelCarPark2OccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark2AvgOccupiedCount
            // 
            this.labelCarPark2AvgOccupiedCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark2AvgOccupiedCount.Location = new System.Drawing.Point(44, 22);
            this.labelCarPark2AvgOccupiedCount.Name = "labelCarPark2AvgOccupiedCount";
            this.labelCarPark2AvgOccupiedCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2AvgOccupiedCount.TabIndex = 1;
            this.labelCarPark2AvgOccupiedCount.Text = "Priemerný počet obsadených miest:";
            this.labelCarPark2AvgOccupiedCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark2OccupiedRatio
            // 
            this.labelCarPark2OccupiedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark2OccupiedRatio.Location = new System.Drawing.Point(44, 42);
            this.labelCarPark2OccupiedRatio.Name = "labelCarPark2OccupiedRatio";
            this.labelCarPark2OccupiedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2OccupiedRatio.TabIndex = 2;
            this.labelCarPark2OccupiedRatio.Text = "Vyťaženie:";
            this.labelCarPark2OccupiedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark2AvgOccupiedRatio
            // 
            this.labelCarPark2AvgOccupiedRatio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarPark2AvgOccupiedRatio.Location = new System.Drawing.Point(44, 62);
            this.labelCarPark2AvgOccupiedRatio.Name = "labelCarPark2AvgOccupiedRatio";
            this.labelCarPark2AvgOccupiedRatio.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2AvgOccupiedRatio.TabIndex = 3;
            this.labelCarPark2AvgOccupiedRatio.Text = "Priemerné vyťaženie:";
            this.labelCarPark2AvgOccupiedRatio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarPark2OccupiedCountValue
            // 
            this.labelCarPark2OccupiedCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark2OccupiedCountValue.Location = new System.Drawing.Point(300, 2);
            this.labelCarPark2OccupiedCountValue.Name = "labelCarPark2OccupiedCountValue";
            this.labelCarPark2OccupiedCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2OccupiedCountValue.TabIndex = 4;
            this.labelCarPark2OccupiedCountValue.Text = "-";
            this.labelCarPark2OccupiedCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark2AvgOccupiedCountValue
            // 
            this.labelCarPark2AvgOccupiedCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark2AvgOccupiedCountValue.Location = new System.Drawing.Point(300, 22);
            this.labelCarPark2AvgOccupiedCountValue.Name = "labelCarPark2AvgOccupiedCountValue";
            this.labelCarPark2AvgOccupiedCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2AvgOccupiedCountValue.TabIndex = 5;
            this.labelCarPark2AvgOccupiedCountValue.Text = "-";
            this.labelCarPark2AvgOccupiedCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark2OccupiedRatioValue
            // 
            this.labelCarPark2OccupiedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark2OccupiedRatioValue.Location = new System.Drawing.Point(300, 42);
            this.labelCarPark2OccupiedRatioValue.Name = "labelCarPark2OccupiedRatioValue";
            this.labelCarPark2OccupiedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2OccupiedRatioValue.TabIndex = 6;
            this.labelCarPark2OccupiedRatioValue.Text = "-";
            this.labelCarPark2OccupiedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarPark2AvgOccupiedRatioValue
            // 
            this.labelCarPark2AvgOccupiedRatioValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarPark2AvgOccupiedRatioValue.Location = new System.Drawing.Point(300, 62);
            this.labelCarPark2AvgOccupiedRatioValue.Name = "labelCarPark2AvgOccupiedRatioValue";
            this.labelCarPark2AvgOccupiedRatioValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarPark2AvgOccupiedRatioValue.TabIndex = 7;
            this.labelCarPark2AvgOccupiedRatioValue.Text = "-";
            this.labelCarPark2AvgOccupiedRatioValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxCarParkService
            // 
            this.tableLayoutPanelCarParks.SetColumnSpan(this.groupBoxCarParkService, 2);
            this.groupBoxCarParkService.Controls.Add(this.tableLayoutPanelCarParkService);
            this.groupBoxCarParkService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCarParkService.Location = new System.Drawing.Point(3, 433);
            this.groupBoxCarParkService.Name = "groupBoxCarParkService";
            this.groupBoxCarParkService.Size = new System.Drawing.Size(1207, 59);
            this.groupBoxCarParkService.TabIndex = 4;
            this.groupBoxCarParkService.TabStop = false;
            this.groupBoxCarParkService.Text = "Parkovisko pred servisom";
            // 
            // tableLayoutPanelCarParkService
            // 
            this.tableLayoutPanelCarParkService.ColumnCount = 2;
            this.tableLayoutPanelCarParkService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParkService.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParkService.Controls.Add(this.labelCarParkServiceCount, 0, 0);
            this.tableLayoutPanelCarParkService.Controls.Add(this.labelCarParkServiceAvgCount, 0, 1);
            this.tableLayoutPanelCarParkService.Controls.Add(this.labelCarParkServiceCountValue, 1, 0);
            this.tableLayoutPanelCarParkService.Controls.Add(this.labelCarParkServiceAvgCountValue, 1, 1);
            this.tableLayoutPanelCarParkService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelCarParkService.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelCarParkService.Name = "tableLayoutPanelCarParkService";
            this.tableLayoutPanelCarParkService.RowCount = 2;
            this.tableLayoutPanelCarParkService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParkService.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCarParkService.Size = new System.Drawing.Size(1201, 40);
            this.tableLayoutPanelCarParkService.TabIndex = 0;
            // 
            // labelCarParkServiceCount
            // 
            this.labelCarParkServiceCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarParkServiceCount.Location = new System.Drawing.Point(347, 2);
            this.labelCarParkServiceCount.Name = "labelCarParkServiceCount";
            this.labelCarParkServiceCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarParkServiceCount.TabIndex = 0;
            this.labelCarParkServiceCount.Text = "Počet áut na parkovisku:";
            this.labelCarParkServiceCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarParkServiceAvgCount
            // 
            this.labelCarParkServiceAvgCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCarParkServiceAvgCount.Location = new System.Drawing.Point(347, 22);
            this.labelCarParkServiceAvgCount.Name = "labelCarParkServiceAvgCount";
            this.labelCarParkServiceAvgCount.Size = new System.Drawing.Size(250, 15);
            this.labelCarParkServiceAvgCount.TabIndex = 1;
            this.labelCarParkServiceAvgCount.Text = "Priemerný počet áut na parkovisku:";
            this.labelCarParkServiceAvgCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCarParkServiceCountValue
            // 
            this.labelCarParkServiceCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarParkServiceCountValue.Location = new System.Drawing.Point(603, 2);
            this.labelCarParkServiceCountValue.Name = "labelCarParkServiceCountValue";
            this.labelCarParkServiceCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarParkServiceCountValue.TabIndex = 2;
            this.labelCarParkServiceCountValue.Text = "-";
            this.labelCarParkServiceCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCarParkServiceAvgCountValue
            // 
            this.labelCarParkServiceAvgCountValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelCarParkServiceAvgCountValue.Location = new System.Drawing.Point(603, 22);
            this.labelCarParkServiceAvgCountValue.Name = "labelCarParkServiceAvgCountValue";
            this.labelCarParkServiceAvgCountValue.Size = new System.Drawing.Size(250, 15);
            this.labelCarParkServiceAvgCountValue.TabIndex = 3;
            this.labelCarParkServiceAvgCountValue.Text = "-";
            this.labelCarParkServiceAvgCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabQueueLenWorkers1
            // 
            this.tabQueueLenWorkers1.Controls.Add(this.widgetPlotQueueLenWorkers1);
            this.tabQueueLenWorkers1.Controls.Add(this.frameQueueLenWorkers1);
            this.tabQueueLenWorkers1.Location = new System.Drawing.Point(4, 22);
            this.tabQueueLenWorkers1.Name = "tabQueueLenWorkers1";
            this.tabQueueLenWorkers1.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueueLenWorkers1.Size = new System.Drawing.Size(1213, 495);
            this.tabQueueLenWorkers1.TabIndex = 0;
            this.tabQueueLenWorkers1.Text = "Počet čakajúcich podľa počtu pracovníkov 1";
            this.tabQueueLenWorkers1.UseVisualStyleBackColor = true;
            // 
            // widgetPlotQueueLenWorkers1
            // 
            this.widgetPlotQueueLenWorkers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.widgetPlotQueueLenWorkers1.ChartAreas.Add(chartArea1);
            this.widgetPlotQueueLenWorkers1.Location = new System.Drawing.Point(5, 35);
            this.widgetPlotQueueLenWorkers1.Name = "widgetPlotQueueLenWorkers1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.widgetPlotQueueLenWorkers1.Series.Add(series1);
            this.widgetPlotQueueLenWorkers1.Size = new System.Drawing.Size(1052, 453);
            this.widgetPlotQueueLenWorkers1.TabIndex = 1;
            this.widgetPlotQueueLenWorkers1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            this.widgetPlotQueueLenWorkers1.Titles.Add(title1);
            // 
            // frameQueueLenWorkers1
            // 
            this.frameQueueLenWorkers1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameQueueLenWorkers1.Controls.Add(this.spinBoxQueueLenFixWorkers2);
            this.frameQueueLenWorkers1.Controls.Add(this.labelQueueLenFixWorkers2);
            this.frameQueueLenWorkers1.Location = new System.Drawing.Point(5, 5);
            this.frameQueueLenWorkers1.MinimumSize = new System.Drawing.Size(0, 25);
            this.frameQueueLenWorkers1.Name = "frameQueueLenWorkers1";
            this.frameQueueLenWorkers1.Size = new System.Drawing.Size(1052, 25);
            this.frameQueueLenWorkers1.TabIndex = 0;
            // 
            // spinBoxQueueLenFixWorkers2
            // 
            this.spinBoxQueueLenFixWorkers2.Location = new System.Drawing.Point(240, 3);
            this.spinBoxQueueLenFixWorkers2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinBoxQueueLenFixWorkers2.Name = "spinBoxQueueLenFixWorkers2";
            this.spinBoxQueueLenFixWorkers2.Size = new System.Drawing.Size(70, 20);
            this.spinBoxQueueLenFixWorkers2.TabIndex = 1;
            // 
            // labelQueueLenFixWorkers2
            // 
            this.labelQueueLenFixWorkers2.Location = new System.Drawing.Point(10, 2);
            this.labelQueueLenFixWorkers2.Name = "labelQueueLenFixWorkers2";
            this.labelQueueLenFixWorkers2.Size = new System.Drawing.Size(230, 21);
            this.labelQueueLenFixWorkers2.TabIndex = 0;
            this.labelQueueLenFixWorkers2.Text = "Sledovať pre počet pracovníkov 2:";
            this.labelQueueLenFixWorkers2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabQueueLenWorkers2
            // 
            this.tabQueueLenWorkers2.Controls.Add(this.widgetPlotQueueLenWorkers2);
            this.tabQueueLenWorkers2.Controls.Add(this.frameQueueLenWorkers2);
            this.tabQueueLenWorkers2.Location = new System.Drawing.Point(4, 22);
            this.tabQueueLenWorkers2.Name = "tabQueueLenWorkers2";
            this.tabQueueLenWorkers2.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueueLenWorkers2.Size = new System.Drawing.Size(1213, 495);
            this.tabQueueLenWorkers2.TabIndex = 1;
            this.tabQueueLenWorkers2.Text = "Počet čakajúcich podľa počtu pracovníkov 2";
            this.tabQueueLenWorkers2.UseVisualStyleBackColor = true;
            // 
            // widgetPlotQueueLenWorkers2
            // 
            this.widgetPlotQueueLenWorkers2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.widgetPlotQueueLenWorkers2.ChartAreas.Add(chartArea2);
            this.widgetPlotQueueLenWorkers2.Location = new System.Drawing.Point(5, 35);
            this.widgetPlotQueueLenWorkers2.Name = "widgetPlotQueueLenWorkers2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.widgetPlotQueueLenWorkers2.Series.Add(series2);
            this.widgetPlotQueueLenWorkers2.Size = new System.Drawing.Size(647, 444);
            this.widgetPlotQueueLenWorkers2.TabIndex = 2;
            this.widgetPlotQueueLenWorkers2.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            this.widgetPlotQueueLenWorkers2.Titles.Add(title2);
            // 
            // frameQueueLenWorkers2
            // 
            this.frameQueueLenWorkers2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameQueueLenWorkers2.Controls.Add(this.spinBoxQueueLenFixWorkers1);
            this.frameQueueLenWorkers2.Controls.Add(this.labelQueueLenFixWorkers1);
            this.frameQueueLenWorkers2.Location = new System.Drawing.Point(5, 5);
            this.frameQueueLenWorkers2.MinimumSize = new System.Drawing.Size(0, 25);
            this.frameQueueLenWorkers2.Name = "frameQueueLenWorkers2";
            this.frameQueueLenWorkers2.Size = new System.Drawing.Size(647, 25);
            this.frameQueueLenWorkers2.TabIndex = 1;
            // 
            // spinBoxQueueLenFixWorkers1
            // 
            this.spinBoxQueueLenFixWorkers1.Location = new System.Drawing.Point(240, 3);
            this.spinBoxQueueLenFixWorkers1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinBoxQueueLenFixWorkers1.Name = "spinBoxQueueLenFixWorkers1";
            this.spinBoxQueueLenFixWorkers1.Size = new System.Drawing.Size(70, 20);
            this.spinBoxQueueLenFixWorkers1.TabIndex = 3;
            // 
            // labelQueueLenFixWorkers1
            // 
            this.labelQueueLenFixWorkers1.Location = new System.Drawing.Point(10, 2);
            this.labelQueueLenFixWorkers1.Name = "labelQueueLenFixWorkers1";
            this.labelQueueLenFixWorkers1.Size = new System.Drawing.Size(230, 21);
            this.labelQueueLenFixWorkers1.TabIndex = 2;
            this.labelQueueLenFixWorkers1.Text = "Sledovať pre počet pracovníkov 1:";
            this.labelQueueLenFixWorkers1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTimeInServiceWorkers1
            // 
            this.tabTimeInServiceWorkers1.Controls.Add(this.widgetPlotTimeInServiceWorkers1);
            this.tabTimeInServiceWorkers1.Controls.Add(this.frameTimeInServiceWorkers1);
            this.tabTimeInServiceWorkers1.Location = new System.Drawing.Point(4, 22);
            this.tabTimeInServiceWorkers1.Name = "tabTimeInServiceWorkers1";
            this.tabTimeInServiceWorkers1.Size = new System.Drawing.Size(1213, 495);
            this.tabTimeInServiceWorkers1.TabIndex = 2;
            this.tabTimeInServiceWorkers1.Text = "Priemerný čas strávený v servise podľa počtu pracovníkov 1";
            this.tabTimeInServiceWorkers1.UseVisualStyleBackColor = true;
            // 
            // widgetPlotTimeInServiceWorkers1
            // 
            this.widgetPlotTimeInServiceWorkers1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.widgetPlotTimeInServiceWorkers1.ChartAreas.Add(chartArea3);
            this.widgetPlotTimeInServiceWorkers1.Location = new System.Drawing.Point(5, 35);
            this.widgetPlotTimeInServiceWorkers1.Name = "widgetPlotTimeInServiceWorkers1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.widgetPlotTimeInServiceWorkers1.Series.Add(series3);
            this.widgetPlotTimeInServiceWorkers1.Size = new System.Drawing.Size(647, 444);
            this.widgetPlotTimeInServiceWorkers1.TabIndex = 3;
            this.widgetPlotTimeInServiceWorkers1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            this.widgetPlotTimeInServiceWorkers1.Titles.Add(title3);
            // 
            // frameTimeInServiceWorkers1
            // 
            this.frameTimeInServiceWorkers1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameTimeInServiceWorkers1.Controls.Add(this.spinBoxTimeInServiceFixWorkers2);
            this.frameTimeInServiceWorkers1.Controls.Add(this.labelTimeInServiceFixWorkers2);
            this.frameTimeInServiceWorkers1.Location = new System.Drawing.Point(5, 5);
            this.frameTimeInServiceWorkers1.MinimumSize = new System.Drawing.Size(0, 25);
            this.frameTimeInServiceWorkers1.Name = "frameTimeInServiceWorkers1";
            this.frameTimeInServiceWorkers1.Size = new System.Drawing.Size(647, 25);
            this.frameTimeInServiceWorkers1.TabIndex = 2;
            // 
            // spinBoxTimeInServiceFixWorkers2
            // 
            this.spinBoxTimeInServiceFixWorkers2.Location = new System.Drawing.Point(240, 3);
            this.spinBoxTimeInServiceFixWorkers2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinBoxTimeInServiceFixWorkers2.Name = "spinBoxTimeInServiceFixWorkers2";
            this.spinBoxTimeInServiceFixWorkers2.Size = new System.Drawing.Size(70, 20);
            this.spinBoxTimeInServiceFixWorkers2.TabIndex = 3;
            // 
            // labelTimeInServiceFixWorkers2
            // 
            this.labelTimeInServiceFixWorkers2.Location = new System.Drawing.Point(10, 2);
            this.labelTimeInServiceFixWorkers2.Name = "labelTimeInServiceFixWorkers2";
            this.labelTimeInServiceFixWorkers2.Size = new System.Drawing.Size(230, 21);
            this.labelTimeInServiceFixWorkers2.TabIndex = 2;
            this.labelTimeInServiceFixWorkers2.Text = "Sledovať pre počet pracovníkov 2:";
            this.labelTimeInServiceFixWorkers2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabTimeInServiceWorkers2
            // 
            this.tabTimeInServiceWorkers2.Controls.Add(this.widgetPlotTimeInServiceWorkers2);
            this.tabTimeInServiceWorkers2.Controls.Add(this.frameTimeInServiceWorkers2);
            this.tabTimeInServiceWorkers2.Location = new System.Drawing.Point(4, 22);
            this.tabTimeInServiceWorkers2.Name = "tabTimeInServiceWorkers2";
            this.tabTimeInServiceWorkers2.Size = new System.Drawing.Size(1213, 495);
            this.tabTimeInServiceWorkers2.TabIndex = 3;
            this.tabTimeInServiceWorkers2.Text = "Priemerný čas strávený v servise podľa počtu pracovníkov 2";
            this.tabTimeInServiceWorkers2.UseVisualStyleBackColor = true;
            // 
            // widgetPlotTimeInServiceWorkers2
            // 
            this.widgetPlotTimeInServiceWorkers2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.widgetPlotTimeInServiceWorkers2.ChartAreas.Add(chartArea4);
            this.widgetPlotTimeInServiceWorkers2.Location = new System.Drawing.Point(5, 35);
            this.widgetPlotTimeInServiceWorkers2.Name = "widgetPlotTimeInServiceWorkers2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.widgetPlotTimeInServiceWorkers2.Series.Add(series4);
            this.widgetPlotTimeInServiceWorkers2.Size = new System.Drawing.Size(647, 444);
            this.widgetPlotTimeInServiceWorkers2.TabIndex = 4;
            this.widgetPlotTimeInServiceWorkers2.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            this.widgetPlotTimeInServiceWorkers2.Titles.Add(title4);
            // 
            // frameTimeInServiceWorkers2
            // 
            this.frameTimeInServiceWorkers2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frameTimeInServiceWorkers2.Controls.Add(this.spinBoxTimeInServiceFixWorkers1);
            this.frameTimeInServiceWorkers2.Controls.Add(this.labelTimeInServiceFixWorkers1);
            this.frameTimeInServiceWorkers2.Location = new System.Drawing.Point(5, 5);
            this.frameTimeInServiceWorkers2.MinimumSize = new System.Drawing.Size(0, 25);
            this.frameTimeInServiceWorkers2.Name = "frameTimeInServiceWorkers2";
            this.frameTimeInServiceWorkers2.Size = new System.Drawing.Size(647, 25);
            this.frameTimeInServiceWorkers2.TabIndex = 3;
            // 
            // spinBoxTimeInServiceFixWorkers1
            // 
            this.spinBoxTimeInServiceFixWorkers1.Location = new System.Drawing.Point(240, 3);
            this.spinBoxTimeInServiceFixWorkers1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinBoxTimeInServiceFixWorkers1.Name = "spinBoxTimeInServiceFixWorkers1";
            this.spinBoxTimeInServiceFixWorkers1.Size = new System.Drawing.Size(70, 20);
            this.spinBoxTimeInServiceFixWorkers1.TabIndex = 5;
            // 
            // labelTimeInServiceFixWorkers1
            // 
            this.labelTimeInServiceFixWorkers1.Location = new System.Drawing.Point(10, 2);
            this.labelTimeInServiceFixWorkers1.Name = "labelTimeInServiceFixWorkers1";
            this.labelTimeInServiceFixWorkers1.Size = new System.Drawing.Size(230, 21);
            this.labelTimeInServiceFixWorkers1.TabIndex = 4;
            this.labelTimeInServiceFixWorkers1.Text = "Sledovať pre počet pracovníkov 1:";
            this.labelTimeInServiceFixWorkers1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // centralWidget
            // 
            this.centralWidget.Controls.Add(this.groupBoxOutput);
            this.centralWidget.Controls.Add(this.groupBoxSimulation);
            this.centralWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralWidget.Location = new System.Drawing.Point(0, 0);
            this.centralWidget.Name = "centralWidget";
            this.centralWidget.Size = new System.Drawing.Size(1257, 825);
            this.centralWidget.TabIndex = 3;
            // 
            // tabVehicles
            // 
            this.tabVehicles.Controls.Add(this.dataGridViewVehicles);
            this.tabVehicles.Location = new System.Drawing.Point(4, 22);
            this.tabVehicles.Name = "tabVehicles";
            this.tabVehicles.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicles.Size = new System.Drawing.Size(1213, 495);
            this.tabVehicles.TabIndex = 9;
            this.tabVehicles.Text = "Vozidlá";
            this.tabVehicles.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVehicles
            // 
            this.dataGridViewVehicles.AllowUserToAddRows = false;
            this.dataGridViewVehicles.AllowUserToDeleteRows = false;
            this.dataGridViewVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewVehicles.Name = "dataGridViewVehicles";
            this.dataGridViewVehicles.ReadOnly = true;
            this.dataGridViewVehicles.RowHeadersVisible = false;
            this.dataGridViewVehicles.Size = new System.Drawing.Size(1207, 489);
            this.dataGridViewVehicles.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 825);
            this.Controls.Add(this.centralWidget);
            this.MinimumSize = new System.Drawing.Size(1172, 855);
            this.Name = "MainWindow";
            this.Text = "Semestrálna práca 3 - Diskrétna simulácia - Matúš Mrázik";
            this.groupBoxSimulation.ResumeLayout(false);
            this.frameResults.ResumeLayout(false);
            this.groupBoxSimulationControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimSpeed)).EndInit();
            this.groupBoxParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxAdInvestment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxReplicationDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxReplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxWorkers1)).EndInit();
            this.groupBoxSeed.ResumeLayout(false);
            this.groupBoxSeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxCustomSeed)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.tabWidgetOutput.ResumeLayout(false);
            this.tabSimulation.ResumeLayout(false);
            this.tableLayoutPanelSimulation.ResumeLayout(false);
            this.groupBoxIdealWorkersCount.ResumeLayout(false);
            this.tableLayoutPanelIdealWorkersCount.ResumeLayout(false);
            this.groupBoxSimulationStats.ResumeLayout(false);
            this.tableLayoutPanelSimulationStats.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.tableLayoutPanelCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.groupBoxCustomersStats.ResumeLayout(false);
            this.tableLayoutPanelCustomersStats.ResumeLayout(false);
            this.tabWorkers1.ResumeLayout(false);
            this.tableLayoutPanelWorkers1.ResumeLayout(false);
            this.groupBoxWorkers1Stats.ResumeLayout(false);
            this.tableLayoutPanelWorkers1Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers1)).EndInit();
            this.tabWorkers2.ResumeLayout(false);
            this.tableLayoutPanelWorkers2.ResumeLayout(false);
            this.groupBoxWorkers2Stats.ResumeLayout(false);
            this.tableLayoutPanelWorkers2Stats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers2)).EndInit();
            this.tabCarParks.ResumeLayout(false);
            this.tableLayoutPanelCarParks.ResumeLayout(false);
            this.groupBoxCarPark1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPark1)).EndInit();
            this.groupBoxCarPark2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarPark2)).EndInit();
            this.groupBoxCarPark1Stats.ResumeLayout(false);
            this.tableLayoutPanelCarPark1Stats.ResumeLayout(false);
            this.groupBoxCarPark2Stats.ResumeLayout(false);
            this.tableLayoutPanelCarPark2Stats.ResumeLayout(false);
            this.groupBoxCarParkService.ResumeLayout(false);
            this.tableLayoutPanelCarParkService.ResumeLayout(false);
            this.tabQueueLenWorkers1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotQueueLenWorkers1)).EndInit();
            this.frameQueueLenWorkers1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueueLenFixWorkers2)).EndInit();
            this.tabQueueLenWorkers2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotQueueLenWorkers2)).EndInit();
            this.frameQueueLenWorkers2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueueLenFixWorkers1)).EndInit();
            this.tabTimeInServiceWorkers1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotTimeInServiceWorkers1)).EndInit();
            this.frameTimeInServiceWorkers1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxTimeInServiceFixWorkers2)).EndInit();
            this.tabTimeInServiceWorkers2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.widgetPlotTimeInServiceWorkers2)).EndInit();
            this.frameTimeInServiceWorkers2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxTimeInServiceFixWorkers1)).EndInit();
            this.centralWidget.ResumeLayout(false);
            this.tabVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Panel centralWidget;
        private System.Windows.Forms.GroupBox groupBoxSeed;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.GroupBox groupBoxSimulationControl;
        private System.Windows.Forms.NumericUpDown spinBoxCustomSeed;
        private System.Windows.Forms.RadioButton radioButtonCustomSeed;
        private System.Windows.Forms.RadioButton radioButtonRandomSeed;
        private System.Windows.Forms.Label labelUsedSeed;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers1;
        private System.Windows.Forms.Label labelWorkers1;
        private System.Windows.Forms.CheckBox checkBoxRangeWorkers1;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers1Max;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers1Min;
        private System.Windows.Forms.Label labelWorkers1Max;
        private System.Windows.Forms.Label labelWorkers1Min;
        private System.Windows.Forms.Label line;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers2Max;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers2Min;
        private System.Windows.Forms.Label labelWorkers2Max;
        private System.Windows.Forms.Label labelWorkers2Min;
        private System.Windows.Forms.CheckBox checkBoxRangeWorkers2;
        private System.Windows.Forms.NumericUpDown spinBoxWorkers2;
        private System.Windows.Forms.Label labelWorkers2;
        private System.Windows.Forms.NumericUpDown spinBoxReplications;
        private System.Windows.Forms.Label labelReplications;
        private System.Windows.Forms.NumericUpDown spinBoxReplicationDuration;
        private System.Windows.Forms.Label labelReplicationDuration;
        private System.Windows.Forms.ComboBox comboBoxTimeUnit;
        private System.Windows.Forms.TextBox labelUsedSeedValue;
        private System.Windows.Forms.Button pushButtonStopSimulation;
        private System.Windows.Forms.Button pushButtonPauseResumeSimulation;
        private System.Windows.Forms.Button pushButtonStartSimulation;
        private System.Windows.Forms.CheckBox checkBoxWatchModeEnabled;
        private System.Windows.Forms.Label labelSimRefreshRateValue;
        private System.Windows.Forms.Label labelSimRefreshRate;
        private System.Windows.Forms.Label labelSimSpeedValue;
        private System.Windows.Forms.Label labelSimSpeed;
        private System.Windows.Forms.TrackBar horizontalSliderSimSpeed;
        private System.Windows.Forms.Label labelHigh;
        private System.Windows.Forms.Label labelLow;
        private System.Windows.Forms.Label labelFast;
        private System.Windows.Forms.Label labelSlow;
        private System.Windows.Forms.TrackBar horizontalSliderSimRefreshRate;
        private System.Windows.Forms.TableLayoutPanel frameResults;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTimeValue;
        private System.Windows.Forms.Label labelReplication;
        private System.Windows.Forms.Label labelReplicationValue;
        private System.Windows.Forms.Label labelWorkers1Current;
        private System.Windows.Forms.Label labelWorkers1CurrentValue;
        private System.Windows.Forms.Label labelWorkers2Current;
        private System.Windows.Forms.Label labelWorkers2CurrentValue;
        private System.Windows.Forms.TabControl tabWidgetOutput;
        private System.Windows.Forms.TabPage tabQueueLenWorkers1;
        private System.Windows.Forms.TabPage tabQueueLenWorkers2;
        private System.Windows.Forms.TabPage tabTimeInServiceWorkers1;
        private System.Windows.Forms.TabPage tabTimeInServiceWorkers2;
        private System.Windows.Forms.Panel frameQueueLenWorkers1;
        private System.Windows.Forms.DataVisualization.Charting.Chart widgetPlotQueueLenWorkers1;
        private System.Windows.Forms.Panel frameQueueLenWorkers2;
        private System.Windows.Forms.DataVisualization.Charting.Chart widgetPlotQueueLenWorkers2;
        private System.Windows.Forms.DataVisualization.Charting.Chart widgetPlotTimeInServiceWorkers1;
        private System.Windows.Forms.Panel frameTimeInServiceWorkers1;
        private System.Windows.Forms.Panel frameTimeInServiceWorkers2;
        private System.Windows.Forms.DataVisualization.Charting.Chart widgetPlotTimeInServiceWorkers2;
        private System.Windows.Forms.NumericUpDown spinBoxQueueLenFixWorkers2;
        private System.Windows.Forms.Label labelQueueLenFixWorkers2;
        private System.Windows.Forms.NumericUpDown spinBoxQueueLenFixWorkers1;
        private System.Windows.Forms.Label labelQueueLenFixWorkers1;
        private System.Windows.Forms.NumericUpDown spinBoxTimeInServiceFixWorkers2;
        private System.Windows.Forms.Label labelTimeInServiceFixWorkers2;
        private System.Windows.Forms.NumericUpDown spinBoxTimeInServiceFixWorkers1;
        private System.Windows.Forms.Label labelTimeInServiceFixWorkers1;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBoxCustomersStats;
        private System.Windows.Forms.TabPage tabWorkers1;
        private System.Windows.Forms.TabPage tabWorkers2;
        private System.Windows.Forms.TabPage tabCarParks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers1;
        private System.Windows.Forms.DataGridView dataGridViewWorkers1;
        private System.Windows.Forms.GroupBox groupBoxWorkers1Stats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers2;
        private System.Windows.Forms.GroupBox groupBoxWorkers2Stats;
        private System.Windows.Forms.DataGridView dataGridViewWorkers2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCarParks;
        private System.Windows.Forms.GroupBox groupBoxCarPark1;
        private System.Windows.Forms.GroupBox groupBoxCarPark2;
        private System.Windows.Forms.GroupBox groupBoxCarPark1Stats;
        private System.Windows.Forms.GroupBox groupBoxCarPark2Stats;
        private System.Windows.Forms.GroupBox groupBoxCarParkService;
        private System.Windows.Forms.DataGridView dataGridViewCarPark1;
        private System.Windows.Forms.DataGridView dataGridViewCarPark2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomersStats;
        private System.Windows.Forms.Label labelCustomersInService;
        private System.Windows.Forms.Label labelCustomersInQueue;
        private System.Windows.Forms.Label labelCustomersTotal;
        private System.Windows.Forms.Label labelCustomersServed;
        private System.Windows.Forms.Label labelCustomersNotServed;
        private System.Windows.Forms.Label labelCustomersServedRatio;
        private System.Windows.Forms.Label labelCustomersInServiceValue;
        private System.Windows.Forms.Label labelCustomersInQueueValue;
        private System.Windows.Forms.Label labelCustomersTotalValue;
        private System.Windows.Forms.Label labelCustomersServedValue;
        private System.Windows.Forms.Label labelCustomersNotServedValue;
        private System.Windows.Forms.Label labelCustomersServedRatioValue;
        private System.Windows.Forms.Label labelCustomersAvgInService;
        private System.Windows.Forms.Label labelCustomersAvgInQueue;
        private System.Windows.Forms.Label labelCustomersAvgWaitInQueue;
        private System.Windows.Forms.Label labelCustomersAvgWaitForRepair;
        private System.Windows.Forms.Label labelCustomersAvgTimeInService;
        private System.Windows.Forms.Label labelCustomersAvgInServiceValue;
        private System.Windows.Forms.Label labelCustomersAvgInQueueValue;
        private System.Windows.Forms.Label labelCustomersAvgWaitInQueueValue;
        private System.Windows.Forms.Label labelCustomersAvgWaitForRepairValue;
        private System.Windows.Forms.Label labelCustomersAvgTimeInServiceValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers1Stats;
        private System.Windows.Forms.Label labelWorkers1WorkingCount;
        private System.Windows.Forms.Label labelWorkers1WorkingCountValue;
        private System.Windows.Forms.Label labelWorkers1WorkingRatio;
        private System.Windows.Forms.Label labelWorkers1WorkingRatioValue;
        private System.Windows.Forms.Label labelWorkers1ReturnQueueLength;
        private System.Windows.Forms.Label labelWorkers1ReturnQueueLengthValue;
        private System.Windows.Forms.Label labelWorkers1AvgWorkingCount;
        private System.Windows.Forms.Label labelWorkers1AvgWorkingRatio;
        private System.Windows.Forms.Label labelWorkers1AvgReturnQueueLength;
        private System.Windows.Forms.Label labelWorkers1AvgWorkingCountValue;
        private System.Windows.Forms.Label labelWorkers1AvgWorkingRatioValue;
        private System.Windows.Forms.Label labelWorkers1AvgReturnQueueLengthValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers2Stats;
        private System.Windows.Forms.Label labelWorkers2WorkingCount;
        private System.Windows.Forms.Label labelWorkers2WorkingCountValue;
        private System.Windows.Forms.Label labelWorkers2WorkingRatio;
        private System.Windows.Forms.Label labelWorkers2WorkingRatioValue;
        private System.Windows.Forms.Label labelWorkers2ToRepairQueueLength;
        private System.Windows.Forms.Label labelWorkers2ToRepairQueueLengthValue;
        private System.Windows.Forms.Label labelWorkers2AvgWorkingCount;
        private System.Windows.Forms.Label labelWorkers2AvgWorkingRatio;
        private System.Windows.Forms.Label labelWorkers2AvgToRepairQueueLength;
        private System.Windows.Forms.Label labelWorkers2AvgWorkingCountValue;
        private System.Windows.Forms.Label labelWorkers2AvgWorkingRatioValue;
        private System.Windows.Forms.Label labelWorkers2AvgToRepairQueueLengthValue;
        private System.Windows.Forms.Label labelWorkers2RepairedQueueLength;
        private System.Windows.Forms.Label labelWorkers2RepairedQueueLengthValue;
        private System.Windows.Forms.Label labelWorkers2AvgRepairedQueueLength;
        private System.Windows.Forms.Label labelWorkers2AvgRepairedQueueLengthValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCarPark1Stats;
        private System.Windows.Forms.Label labelCarPark1OccupiedCount;
        private System.Windows.Forms.Label labelCarPark1AvgOccupiedCount;
        private System.Windows.Forms.Label labelCarPark1OccupiedRatio;
        private System.Windows.Forms.Label labelCarPark1AvgOccupiedRatio;
        private System.Windows.Forms.Label labelCarPark1OccupiedCountValue;
        private System.Windows.Forms.Label labelCarPark1AvgOccupiedCountValue;
        private System.Windows.Forms.Label labelCarPark1OccupiedRatioValue;
        private System.Windows.Forms.Label labelCarPark1AvgOccupiedRatioValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCarPark2Stats;
        private System.Windows.Forms.Label labelCarPark2OccupiedCount;
        private System.Windows.Forms.Label labelCarPark2AvgOccupiedCount;
        private System.Windows.Forms.Label labelCarPark2OccupiedRatio;
        private System.Windows.Forms.Label labelCarPark2AvgOccupiedRatio;
        private System.Windows.Forms.Label labelCarPark2OccupiedCountValue;
        private System.Windows.Forms.Label labelCarPark2AvgOccupiedCountValue;
        private System.Windows.Forms.Label labelCarPark2OccupiedRatioValue;
        private System.Windows.Forms.Label labelCarPark2AvgOccupiedRatioValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCarParkService;
        private System.Windows.Forms.Label labelCarParkServiceCount;
        private System.Windows.Forms.Label labelCarParkServiceAvgCount;
        private System.Windows.Forms.Label labelCarParkServiceCountValue;
        private System.Windows.Forms.Label labelCarParkServiceAvgCountValue;
        private System.Windows.Forms.TabPage tabSimulation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSimulation;
        private System.Windows.Forms.GroupBox groupBoxIdealWorkersCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIdealWorkersCount;
        private System.Windows.Forms.Label labelIdealWorkers2Count;
        private System.Windows.Forms.Label labelIdealWorkers1Count;
        private System.Windows.Forms.Label labelIdealWorkers1CountValue;
        private System.Windows.Forms.Label labelIdealWorkers2CountValue;
        private System.Windows.Forms.Label labelIdealMonthlyProfitValue;
        private System.Windows.Forms.Label labelIdealMonthlyProfit;
        private System.Windows.Forms.GroupBox groupBoxSimulationStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSimulationStats;
        private System.Windows.Forms.Label labelSimCustomerInQueue;
        private System.Windows.Forms.Label labelSimCustomerInQueueValue;
        private System.Windows.Forms.Label labelSimToRepairQueueLengthValue;
        private System.Windows.Forms.Label labelSimReturnQueueLengthValue;
        private System.Windows.Forms.Label labelSimWaitInQueueValue;
        private System.Windows.Forms.Label labelSimWaitForRepairValue;
        private System.Windows.Forms.Label labelSimTimeInServiceValue;
        private System.Windows.Forms.Label labelSimWaitInQueueISValue;
        private System.Windows.Forms.Label labelSimWaitForRepairISValue;
        private System.Windows.Forms.Label labelSimTimeInServiceISValue;
        private System.Windows.Forms.Label labelSimToRepairQueueLength;
        private System.Windows.Forms.Label labelSimReturnQueueLength;
        private System.Windows.Forms.Label labelSimWaitInQueue;
        private System.Windows.Forms.Label labelSimWaitForRepair;
        private System.Windows.Forms.Label labelSimTimeInService;
        private System.Windows.Forms.Label labelSimWaitInQueueIS;
        private System.Windows.Forms.Label labelSimWaitForRepairIS;
        private System.Windows.Forms.Label labelSimTimeInServiceIS;
        private System.Windows.Forms.Label labelSimCustomersInService;
        private System.Windows.Forms.Label labelSimCustomersInServiceValue;
        private System.Windows.Forms.Label labelSimRepairedQueueLength;
        private System.Windows.Forms.Label labelSimCustomersServedRatio;
        private System.Windows.Forms.Label labelSimRepairedQueueLengthValue;
        private System.Windows.Forms.Label labelSimCustomersServedRatioValue;
        private System.Windows.Forms.Label labelSimWorking1Count;
        private System.Windows.Forms.Label labelSimWorking2Count;
        private System.Windows.Forms.Label labelSimWorking1Ratio;
        private System.Windows.Forms.Label labelSimWorking2Ratio;
        private System.Windows.Forms.Label labelSimCarPark1Count;
        private System.Windows.Forms.Label labelSimCarPark2Count;
        private System.Windows.Forms.Label labelSimCarParkServiceCount;
        private System.Windows.Forms.Label labelSimCarPark1Ratio;
        private System.Windows.Forms.Label labelSimCarPark2Ratio;
        private System.Windows.Forms.Label labelSimWorking1CountValue;
        private System.Windows.Forms.Label labelSimWorking2CountValue;
        private System.Windows.Forms.Label labelSimWorking1RatioValue;
        private System.Windows.Forms.Label labelSimWorking2RatioValue;
        private System.Windows.Forms.Label labelSimCarPark1CountValue;
        private System.Windows.Forms.Label labelSimCarPark2CountValue;
        private System.Windows.Forms.Label labelSimCarParkServiceCountValue;
        private System.Windows.Forms.Label labelSimCarPark1RatioValue;
        private System.Windows.Forms.Label labelSimCarPark2RatioValue;
        private System.Windows.Forms.Label labelSimCarPark2RatioISValue;
        private System.Windows.Forms.Label labelSimCarPark2RatioIS;
        private System.Windows.Forms.Label labelSimCarPark1RatioISValue;
        private System.Windows.Forms.Label labelSimCarPark1RatioIS;
        private System.Windows.Forms.Label labelSimCarParkServiceCountISValue;
        private System.Windows.Forms.Label labelSimCarParkServiceCountIS;
        private System.Windows.Forms.Label labelSimCarPark2CountISValue;
        private System.Windows.Forms.Label labelSimCarPark2CountIS;
        private System.Windows.Forms.Label labelSimCarPark1CountISValue;
        private System.Windows.Forms.Label labelSimCarPark1CountIS;
        private System.Windows.Forms.Label labelSimWorking2RatioISValue;
        private System.Windows.Forms.Label labelSimWorking2RatioIS;
        private System.Windows.Forms.Label labelSimWorking1RatioISValue;
        private System.Windows.Forms.Label labelSimWorking1RatioIS;
        private System.Windows.Forms.Label labelSimWorking2CountISValue;
        private System.Windows.Forms.Label labelSimWorking2CountIS;
        private System.Windows.Forms.Label labelSimWorking1CountISValue;
        private System.Windows.Forms.Label labelSimWorking1CountIS;
        private System.Windows.Forms.Label labelSimCustomersServedRatioISValue;
        private System.Windows.Forms.Label labelSimCustomersServedRatioIS;
        private System.Windows.Forms.Label labelSimReturnQueueLengthISValue;
        private System.Windows.Forms.Label labelSimReturnQueueLengthIS;
        private System.Windows.Forms.Label labelSimRepairedQueueLengthISValue;
        private System.Windows.Forms.Label labelSimRepairedQueueLengthIS;
        private System.Windows.Forms.Label labelSimToRepairQueueLengthISValue;
        private System.Windows.Forms.Label labelSimToRepairQueueLengthIS;
        private System.Windows.Forms.Label labelSimCustomerInQueueISValue;
        private System.Windows.Forms.Label labelSimCustomerInQueueIS;
        private System.Windows.Forms.Label labelSimCustomersInServiceISValue;
        private System.Windows.Forms.Label labelSimCustomersInServiceIS;
        private System.Windows.Forms.Label labelEuro;
        private System.Windows.Forms.NumericUpDown spinBoxAdInvestment;
        private System.Windows.Forms.Label labelAdInvestment;
        private System.Windows.Forms.Label labelSimProfit;
        private System.Windows.Forms.Label labelSimProfitValue;
        private System.Windows.Forms.Label labelSimProfitIS;
        private System.Windows.Forms.Label labelSimProfitISValue;
        private System.Windows.Forms.TabPage tabVehicles;
        private System.Windows.Forms.DataGridView dataGridViewVehicles;
    }
}