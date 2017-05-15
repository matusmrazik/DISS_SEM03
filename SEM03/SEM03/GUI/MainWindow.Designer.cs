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
            this.tableLayoutPanelOutput = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxOutputReplication = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelOutputReplication = new System.Windows.Forms.TableLayoutPanel();
            this.labelTimeInServiceDur = new System.Windows.Forms.Label();
            this.labelWaitForRepairDurValue = new System.Windows.Forms.Label();
            this.labelWaitForRepairDur = new System.Windows.Forms.Label();
            this.labelWaitInQueueDurValue = new System.Windows.Forms.Label();
            this.labelWaitInQueueDur = new System.Windows.Forms.Label();
            this.labelAVGRepairedQueueLenValue = new System.Windows.Forms.Label();
            this.labelAVGRepairedQueueLen = new System.Windows.Forms.Label();
            this.labelAVGQueueForRepairLenValue = new System.Windows.Forms.Label();
            this.labelAVGQueueForRepairLen = new System.Windows.Forms.Label();
            this.labelAVGCustomerQueueLenValue = new System.Windows.Forms.Label();
            this.labelAVGCustomerQueueLen = new System.Windows.Forms.Label();
            this.labelRepairedQueueLenValue = new System.Windows.Forms.Label();
            this.labelRepairedQueueLen = new System.Windows.Forms.Label();
            this.labelQueueForRepairLenValue = new System.Windows.Forms.Label();
            this.labelQueueForRepairLen = new System.Windows.Forms.Label();
            this.labelCustomerQueueLenValue = new System.Windows.Forms.Label();
            this.labelCustomerQueueLen = new System.Windows.Forms.Label();
            this.labelWorkers2WorkingValue = new System.Windows.Forms.Label();
            this.labelWorkers2Working = new System.Windows.Forms.Label();
            this.labelWorkers1WorkingValue = new System.Windows.Forms.Label();
            this.labelWorkers1Working = new System.Windows.Forms.Label();
            this.labelTimeInServiceDurValue = new System.Windows.Forms.Label();
            this.groupBoxIdealWorkersCount = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelIdealWorkersCount = new System.Windows.Forms.TableLayoutPanel();
            this.labelIdealWorkers2Count = new System.Windows.Forms.Label();
            this.labelIdealWorkers1Count = new System.Windows.Forms.Label();
            this.labelIdealWorkers1CountValue = new System.Windows.Forms.Label();
            this.labelIdealWorkers2CountValue = new System.Windows.Forms.Label();
            this.labelProfitValue = new System.Windows.Forms.Label();
            this.labelProfit = new System.Windows.Forms.Label();
            this.groupBoxOutputSimulation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelOutputSimulation = new System.Windows.Forms.TableLayoutPanel();
            this.labelAVGCustomerQueueLenSim = new System.Windows.Forms.Label();
            this.labelAVGCustomerQueueLenSimValue = new System.Windows.Forms.Label();
            this.labelAVGQueueForRepairLenSimValue = new System.Windows.Forms.Label();
            this.labelAVGRepairedQueueLenSimValue = new System.Windows.Forms.Label();
            this.labelWaitInQueueDurSimValue = new System.Windows.Forms.Label();
            this.labelWaitForRepairDurSimValue = new System.Windows.Forms.Label();
            this.labelTimeInServiceDurSimValue = new System.Windows.Forms.Label();
            this.labelWaitInQueueCIValue = new System.Windows.Forms.Label();
            this.labelWaitForRepairCIValue = new System.Windows.Forms.Label();
            this.labelTimeInSystemCIValue = new System.Windows.Forms.Label();
            this.labelAVGQueueForRepairLenSim = new System.Windows.Forms.Label();
            this.labelAVGRepairedQueueLenSim = new System.Windows.Forms.Label();
            this.labelWaitInQueueDurSim = new System.Windows.Forms.Label();
            this.labelWaitForRepairDurSim = new System.Windows.Forms.Label();
            this.labelTimeInServiceDurSim = new System.Windows.Forms.Label();
            this.labelWaitInQueueCI = new System.Windows.Forms.Label();
            this.labelWaitForRepairCI = new System.Windows.Forms.Label();
            this.labelTimeInSystemCI = new System.Windows.Forms.Label();
            this.groupBoxVisualization = new System.Windows.Forms.GroupBox();
            this.tabWidgetOutput = new System.Windows.Forms.TabControl();
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
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.tabWorkers1 = new System.Windows.Forms.TabPage();
            this.tabWorkers2 = new System.Windows.Forms.TabPage();
            this.tabCarParks = new System.Windows.Forms.TabPage();
            this.tabCarParkService = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelCustomers = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.groupBoxCustomersStats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWorkers1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewWorkers1 = new System.Windows.Forms.DataGridView();
            this.groupBoxWorkers1Stats = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelWorkers2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewWorkers2 = new System.Windows.Forms.DataGridView();
            this.groupBoxWorkers2Stats = new System.Windows.Forms.GroupBox();
            this.groupBoxSimulation.SuspendLayout();
            this.frameResults.SuspendLayout();
            this.groupBoxSimulationControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimRefreshRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimSpeed)).BeginInit();
            this.groupBoxParameters.SuspendLayout();
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
            this.tableLayoutPanelOutput.SuspendLayout();
            this.groupBoxOutputReplication.SuspendLayout();
            this.tableLayoutPanelOutputReplication.SuspendLayout();
            this.groupBoxIdealWorkersCount.SuspendLayout();
            this.tableLayoutPanelIdealWorkersCount.SuspendLayout();
            this.groupBoxOutputSimulation.SuspendLayout();
            this.tableLayoutPanelOutputSimulation.SuspendLayout();
            this.groupBoxVisualization.SuspendLayout();
            this.tabWidgetOutput.SuspendLayout();
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
            this.tabCustomers.SuspendLayout();
            this.tabWorkers1.SuspendLayout();
            this.tabWorkers2.SuspendLayout();
            this.tableLayoutPanelCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.tableLayoutPanelWorkers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers1)).BeginInit();
            this.tableLayoutPanelWorkers2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers2)).BeginInit();
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
            this.groupBoxSimulation.Size = new System.Drawing.Size(1138, 250);
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
            this.frameResults.Size = new System.Drawing.Size(1126, 30);
            this.frameResults.TabIndex = 3;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTime.Location = new System.Drawing.Point(3, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(134, 30);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "Simulačný čas:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeValue
            // 
            this.labelTimeValue.AutoSize = true;
            this.labelTimeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimeValue.Location = new System.Drawing.Point(143, 0);
            this.labelTimeValue.Name = "labelTimeValue";
            this.labelTimeValue.Size = new System.Drawing.Size(134, 30);
            this.labelTimeValue.TabIndex = 0;
            this.labelTimeValue.Text = "-";
            this.labelTimeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelReplication
            // 
            this.labelReplication.AutoSize = true;
            this.labelReplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReplication.Location = new System.Drawing.Point(283, 0);
            this.labelReplication.Name = "labelReplication";
            this.labelReplication.Size = new System.Drawing.Size(134, 30);
            this.labelReplication.TabIndex = 2;
            this.labelReplication.Text = "Replikácia:";
            this.labelReplication.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelReplicationValue
            // 
            this.labelReplicationValue.AutoSize = true;
            this.labelReplicationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReplicationValue.Location = new System.Drawing.Point(423, 0);
            this.labelReplicationValue.Name = "labelReplicationValue";
            this.labelReplicationValue.Size = new System.Drawing.Size(134, 30);
            this.labelReplicationValue.TabIndex = 3;
            this.labelReplicationValue.Text = "-";
            this.labelReplicationValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1Current
            // 
            this.labelWorkers1Current.AutoSize = true;
            this.labelWorkers1Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers1Current.Location = new System.Drawing.Point(563, 0);
            this.labelWorkers1Current.Name = "labelWorkers1Current";
            this.labelWorkers1Current.Size = new System.Drawing.Size(134, 30);
            this.labelWorkers1Current.TabIndex = 4;
            this.labelWorkers1Current.Text = "Počet pracovníkov 1:";
            this.labelWorkers1Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1CurrentValue
            // 
            this.labelWorkers1CurrentValue.AutoSize = true;
            this.labelWorkers1CurrentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers1CurrentValue.Location = new System.Drawing.Point(703, 0);
            this.labelWorkers1CurrentValue.Name = "labelWorkers1CurrentValue";
            this.labelWorkers1CurrentValue.Size = new System.Drawing.Size(134, 30);
            this.labelWorkers1CurrentValue.TabIndex = 5;
            this.labelWorkers1CurrentValue.Text = "-";
            this.labelWorkers1CurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2Current
            // 
            this.labelWorkers2Current.AutoSize = true;
            this.labelWorkers2Current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers2Current.Location = new System.Drawing.Point(843, 0);
            this.labelWorkers2Current.Name = "labelWorkers2Current";
            this.labelWorkers2Current.Size = new System.Drawing.Size(134, 30);
            this.labelWorkers2Current.TabIndex = 6;
            this.labelWorkers2Current.Text = "Počet pracovníkov 2:";
            this.labelWorkers2Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2CurrentValue
            // 
            this.labelWorkers2CurrentValue.AutoSize = true;
            this.labelWorkers2CurrentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers2CurrentValue.Location = new System.Drawing.Point(983, 0);
            this.labelWorkers2CurrentValue.Name = "labelWorkers2CurrentValue";
            this.labelWorkers2CurrentValue.Size = new System.Drawing.Size(140, 30);
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
            this.groupBoxSimulationControl.Location = new System.Drawing.Point(782, 19);
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
            this.groupBoxParameters.Size = new System.Drawing.Size(526, 190);
            this.groupBoxParameters.TabIndex = 1;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Parametre simulácie";
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
            26,
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
            16,
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
            this.line.Text = "label1";
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
            this.radioButtonCustomSeed.TabStop = true;
            this.radioButtonCustomSeed.Text = "vlastná";
            this.radioButtonCustomSeed.UseVisualStyleBackColor = true;
            this.radioButtonCustomSeed.CheckedChanged += new System.EventHandler(this.RadioButtonCustomSeed_CheckedChanged);
            // 
            // radioButtonRandomSeed
            // 
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
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutput.Controls.Add(this.tableLayoutPanelOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(9, 264);
            this.groupBoxOutput.MinimumSize = new System.Drawing.Size(450, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxOutput.Size = new System.Drawing.Size(450, 543);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Výstup";
            // 
            // tableLayoutPanelOutput
            // 
            this.tableLayoutPanelOutput.ColumnCount = 1;
            this.tableLayoutPanelOutput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOutput.Controls.Add(this.groupBoxOutputReplication, 0, 0);
            this.tableLayoutPanelOutput.Controls.Add(this.groupBoxIdealWorkersCount, 0, 2);
            this.tableLayoutPanelOutput.Controls.Add(this.groupBoxOutputSimulation, 0, 1);
            this.tableLayoutPanelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOutput.Location = new System.Drawing.Point(9, 22);
            this.tableLayoutPanelOutput.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelOutput.Name = "tableLayoutPanelOutput";
            this.tableLayoutPanelOutput.RowCount = 3;
            this.tableLayoutPanelOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.7F));
            this.tableLayoutPanelOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.28F));
            this.tableLayoutPanelOutput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.02F));
            this.tableLayoutPanelOutput.Size = new System.Drawing.Size(432, 512);
            this.tableLayoutPanelOutput.TabIndex = 3;
            // 
            // groupBoxOutputReplication
            // 
            this.groupBoxOutputReplication.Controls.Add(this.tableLayoutPanelOutputReplication);
            this.groupBoxOutputReplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputReplication.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutputReplication.Name = "groupBoxOutputReplication";
            this.groupBoxOutputReplication.Size = new System.Drawing.Size(426, 227);
            this.groupBoxOutputReplication.TabIndex = 0;
            this.groupBoxOutputReplication.TabStop = false;
            this.groupBoxOutputReplication.Text = "Aktuálna replikácia";
            // 
            // tableLayoutPanelOutputReplication
            // 
            this.tableLayoutPanelOutputReplication.ColumnCount = 2;
            this.tableLayoutPanelOutputReplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOutputReplication.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelTimeInServiceDur, 0, 10);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWaitForRepairDurValue, 1, 9);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWaitForRepairDur, 0, 9);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWaitInQueueDurValue, 1, 8);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWaitInQueueDur, 0, 8);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGRepairedQueueLenValue, 1, 7);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGRepairedQueueLen, 0, 7);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGQueueForRepairLenValue, 1, 6);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGQueueForRepairLen, 0, 6);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGCustomerQueueLenValue, 1, 5);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelAVGCustomerQueueLen, 0, 5);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelRepairedQueueLenValue, 1, 4);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelRepairedQueueLen, 0, 4);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelQueueForRepairLenValue, 1, 3);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelQueueForRepairLen, 0, 3);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelCustomerQueueLenValue, 1, 2);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelCustomerQueueLen, 0, 2);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWorkers2WorkingValue, 1, 1);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWorkers2Working, 0, 1);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWorkers1WorkingValue, 1, 0);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelWorkers1Working, 0, 0);
            this.tableLayoutPanelOutputReplication.Controls.Add(this.labelTimeInServiceDurValue, 1, 10);
            this.tableLayoutPanelOutputReplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOutputReplication.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelOutputReplication.Name = "tableLayoutPanelOutputReplication";
            this.tableLayoutPanelOutputReplication.RowCount = 11;
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanelOutputReplication.Size = new System.Drawing.Size(420, 208);
            this.tableLayoutPanelOutputReplication.TabIndex = 0;
            // 
            // labelTimeInServiceDur
            // 
            this.labelTimeInServiceDur.AutoSize = true;
            this.labelTimeInServiceDur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInServiceDur.Location = new System.Drawing.Point(3, 180);
            this.labelTimeInServiceDur.Name = "labelTimeInServiceDur";
            this.labelTimeInServiceDur.Size = new System.Drawing.Size(204, 28);
            this.labelTimeInServiceDur.TabIndex = 21;
            this.labelTimeInServiceDur.Text = "Priemerný čas strávený v servise:";
            this.labelTimeInServiceDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitForRepairDurValue
            // 
            this.labelWaitForRepairDurValue.AutoSize = true;
            this.labelWaitForRepairDurValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairDurValue.Location = new System.Drawing.Point(213, 162);
            this.labelWaitForRepairDurValue.Name = "labelWaitForRepairDurValue";
            this.labelWaitForRepairDurValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairDurValue.TabIndex = 20;
            this.labelWaitForRepairDurValue.Text = "-";
            this.labelWaitForRepairDurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitForRepairDur
            // 
            this.labelWaitForRepairDur.AutoSize = true;
            this.labelWaitForRepairDur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairDur.Location = new System.Drawing.Point(3, 162);
            this.labelWaitForRepairDur.Name = "labelWaitForRepairDur";
            this.labelWaitForRepairDur.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairDur.TabIndex = 19;
            this.labelWaitForRepairDur.Text = "Priemerný čas čakania na opravu:";
            this.labelWaitForRepairDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitInQueueDurValue
            // 
            this.labelWaitInQueueDurValue.AutoSize = true;
            this.labelWaitInQueueDurValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueDurValue.Location = new System.Drawing.Point(213, 144);
            this.labelWaitInQueueDurValue.Name = "labelWaitInQueueDurValue";
            this.labelWaitInQueueDurValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueDurValue.TabIndex = 18;
            this.labelWaitInQueueDurValue.Text = "-";
            this.labelWaitInQueueDurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitInQueueDur
            // 
            this.labelWaitInQueueDur.AutoSize = true;
            this.labelWaitInQueueDur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueDur.Location = new System.Drawing.Point(3, 144);
            this.labelWaitInQueueDur.Name = "labelWaitInQueueDur";
            this.labelWaitInQueueDur.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueDur.TabIndex = 17;
            this.labelWaitInQueueDur.Text = "Priemerný čas čakania vo fronte:";
            this.labelWaitInQueueDur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVGRepairedQueueLenValue
            // 
            this.labelAVGRepairedQueueLenValue.AutoSize = true;
            this.labelAVGRepairedQueueLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGRepairedQueueLenValue.Location = new System.Drawing.Point(213, 126);
            this.labelAVGRepairedQueueLenValue.Name = "labelAVGRepairedQueueLenValue";
            this.labelAVGRepairedQueueLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGRepairedQueueLenValue.TabIndex = 16;
            this.labelAVGRepairedQueueLenValue.Text = "-";
            this.labelAVGRepairedQueueLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGRepairedQueueLen
            // 
            this.labelAVGRepairedQueueLen.AutoSize = true;
            this.labelAVGRepairedQueueLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGRepairedQueueLen.Location = new System.Drawing.Point(3, 126);
            this.labelAVGRepairedQueueLen.Name = "labelAVGRepairedQueueLen";
            this.labelAVGRepairedQueueLen.Size = new System.Drawing.Size(204, 18);
            this.labelAVGRepairedQueueLen.TabIndex = 15;
            this.labelAVGRepairedQueueLen.Text = "Priemerný počet áut na odovzdanie:";
            this.labelAVGRepairedQueueLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVGQueueForRepairLenValue
            // 
            this.labelAVGQueueForRepairLenValue.AutoSize = true;
            this.labelAVGQueueForRepairLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGQueueForRepairLenValue.Location = new System.Drawing.Point(213, 108);
            this.labelAVGQueueForRepairLenValue.Name = "labelAVGQueueForRepairLenValue";
            this.labelAVGQueueForRepairLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGQueueForRepairLenValue.TabIndex = 14;
            this.labelAVGQueueForRepairLenValue.Text = "-";
            this.labelAVGQueueForRepairLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGQueueForRepairLen
            // 
            this.labelAVGQueueForRepairLen.AutoSize = true;
            this.labelAVGQueueForRepairLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGQueueForRepairLen.Location = new System.Drawing.Point(3, 108);
            this.labelAVGQueueForRepairLen.Name = "labelAVGQueueForRepairLen";
            this.labelAVGQueueForRepairLen.Size = new System.Drawing.Size(204, 18);
            this.labelAVGQueueForRepairLen.TabIndex = 13;
            this.labelAVGQueueForRepairLen.Text = "Priemerný počet áut na opravu:";
            this.labelAVGQueueForRepairLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVGCustomerQueueLenValue
            // 
            this.labelAVGCustomerQueueLenValue.AutoSize = true;
            this.labelAVGCustomerQueueLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGCustomerQueueLenValue.Location = new System.Drawing.Point(213, 90);
            this.labelAVGCustomerQueueLenValue.Name = "labelAVGCustomerQueueLenValue";
            this.labelAVGCustomerQueueLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGCustomerQueueLenValue.TabIndex = 12;
            this.labelAVGCustomerQueueLenValue.Text = "-";
            this.labelAVGCustomerQueueLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGCustomerQueueLen
            // 
            this.labelAVGCustomerQueueLen.AutoSize = true;
            this.labelAVGCustomerQueueLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGCustomerQueueLen.Location = new System.Drawing.Point(3, 90);
            this.labelAVGCustomerQueueLen.Name = "labelAVGCustomerQueueLen";
            this.labelAVGCustomerQueueLen.Size = new System.Drawing.Size(204, 18);
            this.labelAVGCustomerQueueLen.TabIndex = 11;
            this.labelAVGCustomerQueueLen.Text = "Priemerná dĺžka frontu čakajúcich:";
            this.labelAVGCustomerQueueLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelRepairedQueueLenValue
            // 
            this.labelRepairedQueueLenValue.AutoSize = true;
            this.labelRepairedQueueLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRepairedQueueLenValue.Location = new System.Drawing.Point(213, 72);
            this.labelRepairedQueueLenValue.Name = "labelRepairedQueueLenValue";
            this.labelRepairedQueueLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelRepairedQueueLenValue.TabIndex = 10;
            this.labelRepairedQueueLenValue.Text = "-";
            this.labelRepairedQueueLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRepairedQueueLen
            // 
            this.labelRepairedQueueLen.AutoSize = true;
            this.labelRepairedQueueLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRepairedQueueLen.Location = new System.Drawing.Point(3, 72);
            this.labelRepairedQueueLen.Name = "labelRepairedQueueLen";
            this.labelRepairedQueueLen.Size = new System.Drawing.Size(204, 18);
            this.labelRepairedQueueLen.TabIndex = 9;
            this.labelRepairedQueueLen.Text = "Počet opravených áut na odovzdanie:";
            this.labelRepairedQueueLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelQueueForRepairLenValue
            // 
            this.labelQueueForRepairLenValue.AutoSize = true;
            this.labelQueueForRepairLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQueueForRepairLenValue.Location = new System.Drawing.Point(213, 54);
            this.labelQueueForRepairLenValue.Name = "labelQueueForRepairLenValue";
            this.labelQueueForRepairLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelQueueForRepairLenValue.TabIndex = 8;
            this.labelQueueForRepairLenValue.Text = "-";
            this.labelQueueForRepairLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQueueForRepairLen
            // 
            this.labelQueueForRepairLen.AutoSize = true;
            this.labelQueueForRepairLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQueueForRepairLen.Location = new System.Drawing.Point(3, 54);
            this.labelQueueForRepairLen.Name = "labelQueueForRepairLen";
            this.labelQueueForRepairLen.Size = new System.Drawing.Size(204, 18);
            this.labelQueueForRepairLen.TabIndex = 7;
            this.labelQueueForRepairLen.Text = "Počet áut čakajúcich na opravu:";
            this.labelQueueForRepairLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCustomerQueueLenValue
            // 
            this.labelCustomerQueueLenValue.AutoSize = true;
            this.labelCustomerQueueLenValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomerQueueLenValue.Location = new System.Drawing.Point(213, 36);
            this.labelCustomerQueueLenValue.Name = "labelCustomerQueueLenValue";
            this.labelCustomerQueueLenValue.Size = new System.Drawing.Size(204, 18);
            this.labelCustomerQueueLenValue.TabIndex = 6;
            this.labelCustomerQueueLenValue.Text = "-";
            this.labelCustomerQueueLenValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCustomerQueueLen
            // 
            this.labelCustomerQueueLen.AutoSize = true;
            this.labelCustomerQueueLen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCustomerQueueLen.Location = new System.Drawing.Point(3, 36);
            this.labelCustomerQueueLen.Name = "labelCustomerQueueLen";
            this.labelCustomerQueueLen.Size = new System.Drawing.Size(204, 18);
            this.labelCustomerQueueLen.TabIndex = 5;
            this.labelCustomerQueueLen.Text = "Dĺžka frontu čakajúcich:";
            this.labelCustomerQueueLen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers2WorkingValue
            // 
            this.labelWorkers2WorkingValue.AutoSize = true;
            this.labelWorkers2WorkingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers2WorkingValue.Location = new System.Drawing.Point(213, 18);
            this.labelWorkers2WorkingValue.Name = "labelWorkers2WorkingValue";
            this.labelWorkers2WorkingValue.Size = new System.Drawing.Size(204, 18);
            this.labelWorkers2WorkingValue.TabIndex = 4;
            this.labelWorkers2WorkingValue.Text = "-";
            this.labelWorkers2WorkingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers2Working
            // 
            this.labelWorkers2Working.AutoSize = true;
            this.labelWorkers2Working.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers2Working.Location = new System.Drawing.Point(3, 18);
            this.labelWorkers2Working.Name = "labelWorkers2Working";
            this.labelWorkers2Working.Size = new System.Drawing.Size(204, 18);
            this.labelWorkers2Working.TabIndex = 3;
            this.labelWorkers2Working.Text = "Aktívni pracovníci v skupine 2:";
            this.labelWorkers2Working.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWorkers1WorkingValue
            // 
            this.labelWorkers1WorkingValue.AutoSize = true;
            this.labelWorkers1WorkingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers1WorkingValue.Location = new System.Drawing.Point(213, 0);
            this.labelWorkers1WorkingValue.Name = "labelWorkers1WorkingValue";
            this.labelWorkers1WorkingValue.Size = new System.Drawing.Size(204, 18);
            this.labelWorkers1WorkingValue.TabIndex = 2;
            this.labelWorkers1WorkingValue.Text = "-";
            this.labelWorkers1WorkingValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWorkers1Working
            // 
            this.labelWorkers1Working.AutoSize = true;
            this.labelWorkers1Working.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWorkers1Working.Location = new System.Drawing.Point(3, 0);
            this.labelWorkers1Working.Name = "labelWorkers1Working";
            this.labelWorkers1Working.Size = new System.Drawing.Size(204, 18);
            this.labelWorkers1Working.TabIndex = 1;
            this.labelWorkers1Working.Text = "Aktívni pracovníci v skupine 1:";
            this.labelWorkers1Working.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeInServiceDurValue
            // 
            this.labelTimeInServiceDurValue.AutoSize = true;
            this.labelTimeInServiceDurValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInServiceDurValue.Location = new System.Drawing.Point(213, 180);
            this.labelTimeInServiceDurValue.Name = "labelTimeInServiceDurValue";
            this.labelTimeInServiceDurValue.Size = new System.Drawing.Size(204, 28);
            this.labelTimeInServiceDurValue.TabIndex = 0;
            this.labelTimeInServiceDurValue.Text = "-";
            this.labelTimeInServiceDurValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxIdealWorkersCount
            // 
            this.groupBoxIdealWorkersCount.Controls.Add(this.tableLayoutPanelIdealWorkersCount);
            this.groupBoxIdealWorkersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxIdealWorkersCount.Location = new System.Drawing.Point(3, 431);
            this.groupBoxIdealWorkersCount.Name = "groupBoxIdealWorkersCount";
            this.groupBoxIdealWorkersCount.Size = new System.Drawing.Size(426, 78);
            this.groupBoxIdealWorkersCount.TabIndex = 2;
            this.groupBoxIdealWorkersCount.TabStop = false;
            this.groupBoxIdealWorkersCount.Text = "Ideálny počet pracovníkov";
            // 
            // tableLayoutPanelIdealWorkersCount
            // 
            this.tableLayoutPanelIdealWorkersCount.ColumnCount = 2;
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIdealWorkersCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers2Count, 0, 1);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers1Count, 0, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers1CountValue, 1, 0);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelIdealWorkers2CountValue, 1, 1);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelProfitValue, 1, 2);
            this.tableLayoutPanelIdealWorkersCount.Controls.Add(this.labelProfit, 0, 2);
            this.tableLayoutPanelIdealWorkersCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelIdealWorkersCount.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelIdealWorkersCount.Name = "tableLayoutPanelIdealWorkersCount";
            this.tableLayoutPanelIdealWorkersCount.RowCount = 3;
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelIdealWorkersCount.Size = new System.Drawing.Size(420, 59);
            this.tableLayoutPanelIdealWorkersCount.TabIndex = 0;
            // 
            // labelIdealWorkers2Count
            // 
            this.labelIdealWorkers2Count.AutoSize = true;
            this.labelIdealWorkers2Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIdealWorkers2Count.Location = new System.Drawing.Point(3, 19);
            this.labelIdealWorkers2Count.Name = "labelIdealWorkers2Count";
            this.labelIdealWorkers2Count.Size = new System.Drawing.Size(204, 19);
            this.labelIdealWorkers2Count.TabIndex = 4;
            this.labelIdealWorkers2Count.Text = "Počet pracovníkov skupiny 2:";
            this.labelIdealWorkers2Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdealWorkers1Count
            // 
            this.labelIdealWorkers1Count.AutoSize = true;
            this.labelIdealWorkers1Count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIdealWorkers1Count.Location = new System.Drawing.Point(3, 0);
            this.labelIdealWorkers1Count.Name = "labelIdealWorkers1Count";
            this.labelIdealWorkers1Count.Size = new System.Drawing.Size(204, 19);
            this.labelIdealWorkers1Count.TabIndex = 3;
            this.labelIdealWorkers1Count.Text = "Počet pracovníkov skupiny 1:";
            this.labelIdealWorkers1Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelIdealWorkers1CountValue
            // 
            this.labelIdealWorkers1CountValue.AutoSize = true;
            this.labelIdealWorkers1CountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIdealWorkers1CountValue.Location = new System.Drawing.Point(213, 0);
            this.labelIdealWorkers1CountValue.Name = "labelIdealWorkers1CountValue";
            this.labelIdealWorkers1CountValue.Size = new System.Drawing.Size(204, 19);
            this.labelIdealWorkers1CountValue.TabIndex = 5;
            this.labelIdealWorkers1CountValue.Text = "-";
            this.labelIdealWorkers1CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelIdealWorkers2CountValue
            // 
            this.labelIdealWorkers2CountValue.AutoSize = true;
            this.labelIdealWorkers2CountValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelIdealWorkers2CountValue.Location = new System.Drawing.Point(213, 19);
            this.labelIdealWorkers2CountValue.Name = "labelIdealWorkers2CountValue";
            this.labelIdealWorkers2CountValue.Size = new System.Drawing.Size(204, 19);
            this.labelIdealWorkers2CountValue.TabIndex = 6;
            this.labelIdealWorkers2CountValue.Text = "-";
            this.labelIdealWorkers2CountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProfitValue
            // 
            this.labelProfitValue.AutoSize = true;
            this.labelProfitValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProfitValue.Location = new System.Drawing.Point(213, 38);
            this.labelProfitValue.Name = "labelProfitValue";
            this.labelProfitValue.Size = new System.Drawing.Size(204, 21);
            this.labelProfitValue.TabIndex = 7;
            this.labelProfitValue.Text = "-";
            this.labelProfitValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProfit.Location = new System.Drawing.Point(3, 38);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(204, 21);
            this.labelProfit.TabIndex = 8;
            this.labelProfit.Text = "Hospodársky výsledok:";
            this.labelProfit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxOutputSimulation
            // 
            this.groupBoxOutputSimulation.Controls.Add(this.tableLayoutPanelOutputSimulation);
            this.groupBoxOutputSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputSimulation.Location = new System.Drawing.Point(3, 236);
            this.groupBoxOutputSimulation.Name = "groupBoxOutputSimulation";
            this.groupBoxOutputSimulation.Size = new System.Drawing.Size(426, 189);
            this.groupBoxOutputSimulation.TabIndex = 1;
            this.groupBoxOutputSimulation.TabStop = false;
            this.groupBoxOutputSimulation.Text = "Simulácia";
            // 
            // tableLayoutPanelOutputSimulation
            // 
            this.tableLayoutPanelOutputSimulation.ColumnCount = 2;
            this.tableLayoutPanelOutputSimulation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOutputSimulation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGCustomerQueueLenSim, 0, 0);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGCustomerQueueLenSimValue, 1, 0);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGQueueForRepairLenSimValue, 1, 1);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGRepairedQueueLenSimValue, 1, 2);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitInQueueDurSimValue, 1, 3);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitForRepairDurSimValue, 1, 4);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelTimeInServiceDurSimValue, 1, 5);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitInQueueCIValue, 1, 6);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitForRepairCIValue, 1, 7);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelTimeInSystemCIValue, 1, 8);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGQueueForRepairLenSim, 0, 1);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelAVGRepairedQueueLenSim, 0, 2);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitInQueueDurSim, 0, 3);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitForRepairDurSim, 0, 4);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelTimeInServiceDurSim, 0, 5);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitInQueueCI, 0, 6);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelWaitForRepairCI, 0, 7);
            this.tableLayoutPanelOutputSimulation.Controls.Add(this.labelTimeInSystemCI, 0, 8);
            this.tableLayoutPanelOutputSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOutputSimulation.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanelOutputSimulation.Name = "tableLayoutPanelOutputSimulation";
            this.tableLayoutPanelOutputSimulation.RowCount = 9;
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOutputSimulation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelOutputSimulation.Size = new System.Drawing.Size(420, 170);
            this.tableLayoutPanelOutputSimulation.TabIndex = 0;
            // 
            // labelAVGCustomerQueueLenSim
            // 
            this.labelAVGCustomerQueueLenSim.AutoSize = true;
            this.labelAVGCustomerQueueLenSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGCustomerQueueLenSim.Location = new System.Drawing.Point(3, 0);
            this.labelAVGCustomerQueueLenSim.Name = "labelAVGCustomerQueueLenSim";
            this.labelAVGCustomerQueueLenSim.Size = new System.Drawing.Size(204, 18);
            this.labelAVGCustomerQueueLenSim.TabIndex = 2;
            this.labelAVGCustomerQueueLenSim.Text = "Priemerná dĺžka frontu čakajúcich:";
            this.labelAVGCustomerQueueLenSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVGCustomerQueueLenSimValue
            // 
            this.labelAVGCustomerQueueLenSimValue.AutoSize = true;
            this.labelAVGCustomerQueueLenSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGCustomerQueueLenSimValue.Location = new System.Drawing.Point(213, 0);
            this.labelAVGCustomerQueueLenSimValue.Name = "labelAVGCustomerQueueLenSimValue";
            this.labelAVGCustomerQueueLenSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGCustomerQueueLenSimValue.TabIndex = 3;
            this.labelAVGCustomerQueueLenSimValue.Text = "-";
            this.labelAVGCustomerQueueLenSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGQueueForRepairLenSimValue
            // 
            this.labelAVGQueueForRepairLenSimValue.AutoSize = true;
            this.labelAVGQueueForRepairLenSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGQueueForRepairLenSimValue.Location = new System.Drawing.Point(213, 18);
            this.labelAVGQueueForRepairLenSimValue.Name = "labelAVGQueueForRepairLenSimValue";
            this.labelAVGQueueForRepairLenSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGQueueForRepairLenSimValue.TabIndex = 4;
            this.labelAVGQueueForRepairLenSimValue.Text = "-";
            this.labelAVGQueueForRepairLenSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGRepairedQueueLenSimValue
            // 
            this.labelAVGRepairedQueueLenSimValue.AutoSize = true;
            this.labelAVGRepairedQueueLenSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGRepairedQueueLenSimValue.Location = new System.Drawing.Point(213, 36);
            this.labelAVGRepairedQueueLenSimValue.Name = "labelAVGRepairedQueueLenSimValue";
            this.labelAVGRepairedQueueLenSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelAVGRepairedQueueLenSimValue.TabIndex = 5;
            this.labelAVGRepairedQueueLenSimValue.Text = "-";
            this.labelAVGRepairedQueueLenSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitInQueueDurSimValue
            // 
            this.labelWaitInQueueDurSimValue.AutoSize = true;
            this.labelWaitInQueueDurSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueDurSimValue.Location = new System.Drawing.Point(213, 54);
            this.labelWaitInQueueDurSimValue.Name = "labelWaitInQueueDurSimValue";
            this.labelWaitInQueueDurSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueDurSimValue.TabIndex = 6;
            this.labelWaitInQueueDurSimValue.Text = "-";
            this.labelWaitInQueueDurSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitForRepairDurSimValue
            // 
            this.labelWaitForRepairDurSimValue.AutoSize = true;
            this.labelWaitForRepairDurSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairDurSimValue.Location = new System.Drawing.Point(213, 72);
            this.labelWaitForRepairDurSimValue.Name = "labelWaitForRepairDurSimValue";
            this.labelWaitForRepairDurSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairDurSimValue.TabIndex = 7;
            this.labelWaitForRepairDurSimValue.Text = "-";
            this.labelWaitForRepairDurSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTimeInServiceDurSimValue
            // 
            this.labelTimeInServiceDurSimValue.AutoSize = true;
            this.labelTimeInServiceDurSimValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInServiceDurSimValue.Location = new System.Drawing.Point(213, 90);
            this.labelTimeInServiceDurSimValue.Name = "labelTimeInServiceDurSimValue";
            this.labelTimeInServiceDurSimValue.Size = new System.Drawing.Size(204, 18);
            this.labelTimeInServiceDurSimValue.TabIndex = 8;
            this.labelTimeInServiceDurSimValue.Text = "-";
            this.labelTimeInServiceDurSimValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitInQueueCIValue
            // 
            this.labelWaitInQueueCIValue.AutoSize = true;
            this.labelWaitInQueueCIValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueCIValue.Location = new System.Drawing.Point(213, 108);
            this.labelWaitInQueueCIValue.Name = "labelWaitInQueueCIValue";
            this.labelWaitInQueueCIValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueCIValue.TabIndex = 9;
            this.labelWaitInQueueCIValue.Text = "-";
            this.labelWaitInQueueCIValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWaitForRepairCIValue
            // 
            this.labelWaitForRepairCIValue.AutoSize = true;
            this.labelWaitForRepairCIValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairCIValue.Location = new System.Drawing.Point(213, 126);
            this.labelWaitForRepairCIValue.Name = "labelWaitForRepairCIValue";
            this.labelWaitForRepairCIValue.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairCIValue.TabIndex = 10;
            this.labelWaitForRepairCIValue.Text = "-";
            this.labelWaitForRepairCIValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTimeInSystemCIValue
            // 
            this.labelTimeInSystemCIValue.AutoSize = true;
            this.labelTimeInSystemCIValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInSystemCIValue.Location = new System.Drawing.Point(213, 144);
            this.labelTimeInSystemCIValue.Name = "labelTimeInSystemCIValue";
            this.labelTimeInSystemCIValue.Size = new System.Drawing.Size(204, 26);
            this.labelTimeInSystemCIValue.TabIndex = 11;
            this.labelTimeInSystemCIValue.Text = "-";
            this.labelTimeInSystemCIValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelAVGQueueForRepairLenSim
            // 
            this.labelAVGQueueForRepairLenSim.AutoSize = true;
            this.labelAVGQueueForRepairLenSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGQueueForRepairLenSim.Location = new System.Drawing.Point(3, 18);
            this.labelAVGQueueForRepairLenSim.Name = "labelAVGQueueForRepairLenSim";
            this.labelAVGQueueForRepairLenSim.Size = new System.Drawing.Size(204, 18);
            this.labelAVGQueueForRepairLenSim.TabIndex = 12;
            this.labelAVGQueueForRepairLenSim.Text = "Priemerný počet áut na opravu:";
            this.labelAVGQueueForRepairLenSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVGRepairedQueueLenSim
            // 
            this.labelAVGRepairedQueueLenSim.AutoSize = true;
            this.labelAVGRepairedQueueLenSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAVGRepairedQueueLenSim.Location = new System.Drawing.Point(3, 36);
            this.labelAVGRepairedQueueLenSim.Name = "labelAVGRepairedQueueLenSim";
            this.labelAVGRepairedQueueLenSim.Size = new System.Drawing.Size(204, 18);
            this.labelAVGRepairedQueueLenSim.TabIndex = 13;
            this.labelAVGRepairedQueueLenSim.Text = "Priemerný počet áut na odovzdanie:";
            this.labelAVGRepairedQueueLenSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitInQueueDurSim
            // 
            this.labelWaitInQueueDurSim.AutoSize = true;
            this.labelWaitInQueueDurSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueDurSim.Location = new System.Drawing.Point(3, 54);
            this.labelWaitInQueueDurSim.Name = "labelWaitInQueueDurSim";
            this.labelWaitInQueueDurSim.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueDurSim.TabIndex = 14;
            this.labelWaitInQueueDurSim.Text = "Priemerný čas čakania vo fronte:";
            this.labelWaitInQueueDurSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitForRepairDurSim
            // 
            this.labelWaitForRepairDurSim.AutoSize = true;
            this.labelWaitForRepairDurSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairDurSim.Location = new System.Drawing.Point(3, 72);
            this.labelWaitForRepairDurSim.Name = "labelWaitForRepairDurSim";
            this.labelWaitForRepairDurSim.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairDurSim.TabIndex = 15;
            this.labelWaitForRepairDurSim.Text = "Priemerný čas čakania na opravu:";
            this.labelWaitForRepairDurSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeInServiceDurSim
            // 
            this.labelTimeInServiceDurSim.AutoSize = true;
            this.labelTimeInServiceDurSim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInServiceDurSim.Location = new System.Drawing.Point(3, 90);
            this.labelTimeInServiceDurSim.Name = "labelTimeInServiceDurSim";
            this.labelTimeInServiceDurSim.Size = new System.Drawing.Size(204, 18);
            this.labelTimeInServiceDurSim.TabIndex = 16;
            this.labelTimeInServiceDurSim.Text = "Priemerný čas strávený v servise:";
            this.labelTimeInServiceDurSim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitInQueueCI
            // 
            this.labelWaitInQueueCI.AutoSize = true;
            this.labelWaitInQueueCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitInQueueCI.Location = new System.Drawing.Point(3, 108);
            this.labelWaitInQueueCI.Name = "labelWaitInQueueCI";
            this.labelWaitInQueueCI.Size = new System.Drawing.Size(204, 18);
            this.labelWaitInQueueCI.TabIndex = 17;
            this.labelWaitInQueueCI.Text = "90% IS času čakania vo fronte:";
            this.labelWaitInQueueCI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelWaitForRepairCI
            // 
            this.labelWaitForRepairCI.AutoSize = true;
            this.labelWaitForRepairCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWaitForRepairCI.Location = new System.Drawing.Point(3, 126);
            this.labelWaitForRepairCI.Name = "labelWaitForRepairCI";
            this.labelWaitForRepairCI.Size = new System.Drawing.Size(204, 18);
            this.labelWaitForRepairCI.TabIndex = 18;
            this.labelWaitForRepairCI.Text = "90% IS času čakania na opravu:";
            this.labelWaitForRepairCI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimeInSystemCI
            // 
            this.labelTimeInSystemCI.AutoSize = true;
            this.labelTimeInSystemCI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimeInSystemCI.Location = new System.Drawing.Point(3, 144);
            this.labelTimeInSystemCI.Name = "labelTimeInSystemCI";
            this.labelTimeInSystemCI.Size = new System.Drawing.Size(204, 26);
            this.labelTimeInSystemCI.TabIndex = 19;
            this.labelTimeInSystemCI.Text = "90% IS času stráveného v servise:";
            this.labelTimeInSystemCI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxVisualization
            // 
            this.groupBoxVisualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVisualization.Controls.Add(this.tabWidgetOutput);
            this.groupBoxVisualization.Location = new System.Drawing.Point(464, 264);
            this.groupBoxVisualization.Name = "groupBoxVisualization";
            this.groupBoxVisualization.Padding = new System.Windows.Forms.Padding(9);
            this.groupBoxVisualization.Size = new System.Drawing.Size(683, 543);
            this.groupBoxVisualization.TabIndex = 2;
            this.groupBoxVisualization.TabStop = false;
            this.groupBoxVisualization.Text = "Grafický výstup";
            // 
            // tabWidgetOutput
            // 
            this.tabWidgetOutput.Controls.Add(this.tabCustomers);
            this.tabWidgetOutput.Controls.Add(this.tabWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabWorkers2);
            this.tabWidgetOutput.Controls.Add(this.tabCarParkService);
            this.tabWidgetOutput.Controls.Add(this.tabCarParks);
            this.tabWidgetOutput.Controls.Add(this.tabQueueLenWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabQueueLenWorkers2);
            this.tabWidgetOutput.Controls.Add(this.tabTimeInServiceWorkers1);
            this.tabWidgetOutput.Controls.Add(this.tabTimeInServiceWorkers2);
            this.tabWidgetOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWidgetOutput.Location = new System.Drawing.Point(9, 22);
            this.tabWidgetOutput.Name = "tabWidgetOutput";
            this.tabWidgetOutput.SelectedIndex = 0;
            this.tabWidgetOutput.Size = new System.Drawing.Size(665, 512);
            this.tabWidgetOutput.TabIndex = 0;
            // 
            // tabQueueLenWorkers1
            // 
            this.tabQueueLenWorkers1.Controls.Add(this.widgetPlotQueueLenWorkers1);
            this.tabQueueLenWorkers1.Controls.Add(this.frameQueueLenWorkers1);
            this.tabQueueLenWorkers1.Location = new System.Drawing.Point(4, 22);
            this.tabQueueLenWorkers1.Name = "tabQueueLenWorkers1";
            this.tabQueueLenWorkers1.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueueLenWorkers1.Size = new System.Drawing.Size(657, 486);
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
            this.widgetPlotQueueLenWorkers1.Size = new System.Drawing.Size(647, 444);
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
            this.frameQueueLenWorkers1.Size = new System.Drawing.Size(647, 25);
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
            this.tabQueueLenWorkers2.Size = new System.Drawing.Size(657, 486);
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
            this.tabTimeInServiceWorkers1.Size = new System.Drawing.Size(657, 486);
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
            this.tabTimeInServiceWorkers2.Size = new System.Drawing.Size(657, 486);
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
            this.centralWidget.Controls.Add(this.groupBoxVisualization);
            this.centralWidget.Controls.Add(this.groupBoxSimulation);
            this.centralWidget.Controls.Add(this.groupBoxOutput);
            this.centralWidget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralWidget.Location = new System.Drawing.Point(0, 0);
            this.centralWidget.Name = "centralWidget";
            this.centralWidget.Size = new System.Drawing.Size(1156, 816);
            this.centralWidget.TabIndex = 3;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tableLayoutPanelCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomers.Size = new System.Drawing.Size(657, 486);
            this.tabCustomers.TabIndex = 4;
            this.tabCustomers.Text = "Zákazníci";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // tabWorkers1
            // 
            this.tabWorkers1.Controls.Add(this.tableLayoutPanelWorkers1);
            this.tabWorkers1.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers1.Name = "tabWorkers1";
            this.tabWorkers1.Size = new System.Drawing.Size(657, 486);
            this.tabWorkers1.TabIndex = 5;
            this.tabWorkers1.Text = "Pracovníci skupiny 1";
            this.tabWorkers1.UseVisualStyleBackColor = true;
            // 
            // tabWorkers2
            // 
            this.tabWorkers2.Controls.Add(this.tableLayoutPanelWorkers2);
            this.tabWorkers2.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers2.Name = "tabWorkers2";
            this.tabWorkers2.Size = new System.Drawing.Size(657, 486);
            this.tabWorkers2.TabIndex = 6;
            this.tabWorkers2.Text = "Pracovníci skupiny 2";
            this.tabWorkers2.UseVisualStyleBackColor = true;
            // 
            // tabCarParks
            // 
            this.tabCarParks.Location = new System.Drawing.Point(4, 22);
            this.tabCarParks.Name = "tabCarParks";
            this.tabCarParks.Size = new System.Drawing.Size(657, 486);
            this.tabCarParks.TabIndex = 7;
            this.tabCarParks.Text = "Parkoviská";
            this.tabCarParks.UseVisualStyleBackColor = true;
            // 
            // tabCarParkService
            // 
            this.tabCarParkService.Location = new System.Drawing.Point(4, 22);
            this.tabCarParkService.Name = "tabCarParkService";
            this.tabCarParkService.Size = new System.Drawing.Size(657, 486);
            this.tabCarParkService.TabIndex = 8;
            this.tabCarParkService.Text = "Parkovisko pred servisom";
            this.tabCarParkService.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelCustomers.Size = new System.Drawing.Size(651, 480);
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
            this.dataGridViewCustomers.Size = new System.Drawing.Size(645, 234);
            this.dataGridViewCustomers.TabIndex = 0;
            // 
            // groupBoxCustomersStats
            // 
            this.groupBoxCustomersStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCustomersStats.Location = new System.Drawing.Point(3, 243);
            this.groupBoxCustomersStats.Name = "groupBoxCustomersStats";
            this.groupBoxCustomersStats.Size = new System.Drawing.Size(645, 234);
            this.groupBoxCustomersStats.TabIndex = 1;
            this.groupBoxCustomersStats.TabStop = false;
            this.groupBoxCustomersStats.Text = "Štatistiky";
            // 
            // tableLayoutPanelWorkers1
            // 
            this.tableLayoutPanelWorkers1.ColumnCount = 1;
            this.tableLayoutPanelWorkers1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers1.Controls.Add(this.groupBoxWorkers1Stats, 0, 1);
            this.tableLayoutPanelWorkers1.Controls.Add(this.dataGridViewWorkers1, 0, 0);
            this.tableLayoutPanelWorkers1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWorkers1.Name = "tableLayoutPanelWorkers1";
            this.tableLayoutPanelWorkers1.RowCount = 2;
            this.tableLayoutPanelWorkers1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers1.Size = new System.Drawing.Size(657, 486);
            this.tableLayoutPanelWorkers1.TabIndex = 0;
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
            this.dataGridViewWorkers1.Size = new System.Drawing.Size(651, 237);
            this.dataGridViewWorkers1.TabIndex = 1;
            // 
            // groupBoxWorkers1Stats
            // 
            this.groupBoxWorkers1Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkers1Stats.Location = new System.Drawing.Point(3, 246);
            this.groupBoxWorkers1Stats.Name = "groupBoxWorkers1Stats";
            this.groupBoxWorkers1Stats.Size = new System.Drawing.Size(651, 237);
            this.groupBoxWorkers1Stats.TabIndex = 2;
            this.groupBoxWorkers1Stats.TabStop = false;
            this.groupBoxWorkers1Stats.Text = "Štatistiky";
            // 
            // tableLayoutPanelWorkers2
            // 
            this.tableLayoutPanelWorkers2.ColumnCount = 1;
            this.tableLayoutPanelWorkers2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers2.Controls.Add(this.groupBoxWorkers2Stats, 0, 1);
            this.tableLayoutPanelWorkers2.Controls.Add(this.dataGridViewWorkers2, 0, 0);
            this.tableLayoutPanelWorkers2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWorkers2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWorkers2.Name = "tableLayoutPanelWorkers2";
            this.tableLayoutPanelWorkers2.RowCount = 2;
            this.tableLayoutPanelWorkers2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelWorkers2.Size = new System.Drawing.Size(657, 486);
            this.tableLayoutPanelWorkers2.TabIndex = 0;
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
            this.dataGridViewWorkers2.Size = new System.Drawing.Size(651, 237);
            this.dataGridViewWorkers2.TabIndex = 2;
            // 
            // groupBoxWorkers2Stats
            // 
            this.groupBoxWorkers2Stats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxWorkers2Stats.Location = new System.Drawing.Point(3, 246);
            this.groupBoxWorkers2Stats.Name = "groupBoxWorkers2Stats";
            this.groupBoxWorkers2Stats.Size = new System.Drawing.Size(651, 237);
            this.groupBoxWorkers2Stats.TabIndex = 3;
            this.groupBoxWorkers2Stats.TabStop = false;
            this.groupBoxWorkers2Stats.Text = "Štatistiky";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 816);
            this.Controls.Add(this.centralWidget);
            this.MinimumSize = new System.Drawing.Size(1172, 855);
            this.Name = "MainWindow";
            this.Text = "Semestrálna práca 3 - Diskrétna simulácia - Matúš Mrázik";
            this.groupBoxSimulation.ResumeLayout(false);
            this.frameResults.ResumeLayout(false);
            this.frameResults.PerformLayout();
            this.groupBoxSimulationControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimRefreshRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSliderSimSpeed)).EndInit();
            this.groupBoxParameters.ResumeLayout(false);
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
            this.tableLayoutPanelOutput.ResumeLayout(false);
            this.groupBoxOutputReplication.ResumeLayout(false);
            this.tableLayoutPanelOutputReplication.ResumeLayout(false);
            this.tableLayoutPanelOutputReplication.PerformLayout();
            this.groupBoxIdealWorkersCount.ResumeLayout(false);
            this.tableLayoutPanelIdealWorkersCount.ResumeLayout(false);
            this.tableLayoutPanelIdealWorkersCount.PerformLayout();
            this.groupBoxOutputSimulation.ResumeLayout(false);
            this.tableLayoutPanelOutputSimulation.ResumeLayout(false);
            this.tableLayoutPanelOutputSimulation.PerformLayout();
            this.groupBoxVisualization.ResumeLayout(false);
            this.tabWidgetOutput.ResumeLayout(false);
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
            this.tabCustomers.ResumeLayout(false);
            this.tabWorkers1.ResumeLayout(false);
            this.tabWorkers2.ResumeLayout(false);
            this.tableLayoutPanelCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.tableLayoutPanelWorkers1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers1)).EndInit();
            this.tableLayoutPanelWorkers2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxVisualization;
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
        private System.Windows.Forms.GroupBox groupBoxOutputReplication;
        private System.Windows.Forms.GroupBox groupBoxOutputSimulation;
        private System.Windows.Forms.GroupBox groupBoxIdealWorkersCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOutputReplication;
        private System.Windows.Forms.Label labelTimeInServiceDur;
        private System.Windows.Forms.Label labelWaitForRepairDurValue;
        private System.Windows.Forms.Label labelWaitForRepairDur;
        private System.Windows.Forms.Label labelWaitInQueueDurValue;
        private System.Windows.Forms.Label labelWaitInQueueDur;
        private System.Windows.Forms.Label labelAVGRepairedQueueLenValue;
        private System.Windows.Forms.Label labelAVGRepairedQueueLen;
        private System.Windows.Forms.Label labelAVGQueueForRepairLenValue;
        private System.Windows.Forms.Label labelAVGQueueForRepairLen;
        private System.Windows.Forms.Label labelAVGCustomerQueueLenValue;
        private System.Windows.Forms.Label labelAVGCustomerQueueLen;
        private System.Windows.Forms.Label labelRepairedQueueLenValue;
        private System.Windows.Forms.Label labelRepairedQueueLen;
        private System.Windows.Forms.Label labelQueueForRepairLenValue;
        private System.Windows.Forms.Label labelQueueForRepairLen;
        private System.Windows.Forms.Label labelCustomerQueueLenValue;
        private System.Windows.Forms.Label labelCustomerQueueLen;
        private System.Windows.Forms.Label labelWorkers2WorkingValue;
        private System.Windows.Forms.Label labelWorkers2Working;
        private System.Windows.Forms.Label labelWorkers1WorkingValue;
        private System.Windows.Forms.Label labelWorkers1Working;
        private System.Windows.Forms.Label labelTimeInServiceDurValue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelIdealWorkersCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOutputSimulation;
        private System.Windows.Forms.Label labelAVGCustomerQueueLenSim;
        private System.Windows.Forms.Label labelAVGCustomerQueueLenSimValue;
        private System.Windows.Forms.Label labelAVGQueueForRepairLenSimValue;
        private System.Windows.Forms.Label labelAVGRepairedQueueLenSimValue;
        private System.Windows.Forms.Label labelWaitInQueueDurSimValue;
        private System.Windows.Forms.Label labelWaitForRepairDurSimValue;
        private System.Windows.Forms.Label labelTimeInServiceDurSimValue;
        private System.Windows.Forms.Label labelWaitInQueueCIValue;
        private System.Windows.Forms.Label labelWaitForRepairCIValue;
        private System.Windows.Forms.Label labelTimeInSystemCIValue;
        private System.Windows.Forms.Label labelAVGQueueForRepairLenSim;
        private System.Windows.Forms.Label labelAVGRepairedQueueLenSim;
        private System.Windows.Forms.Label labelWaitInQueueDurSim;
        private System.Windows.Forms.Label labelWaitForRepairDurSim;
        private System.Windows.Forms.Label labelTimeInServiceDurSim;
        private System.Windows.Forms.Label labelWaitInQueueCI;
        private System.Windows.Forms.Label labelWaitForRepairCI;
        private System.Windows.Forms.Label labelTimeInSystemCI;
        private System.Windows.Forms.Label labelIdealWorkers2Count;
        private System.Windows.Forms.Label labelIdealWorkers1Count;
        private System.Windows.Forms.Label labelIdealWorkers1CountValue;
        private System.Windows.Forms.Label labelIdealWorkers2CountValue;
        private System.Windows.Forms.Label labelProfitValue;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.GroupBox groupBoxCustomersStats;
        private System.Windows.Forms.TabPage tabWorkers1;
        private System.Windows.Forms.TabPage tabWorkers2;
        private System.Windows.Forms.TabPage tabCarParkService;
        private System.Windows.Forms.TabPage tabCarParks;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers1;
        private System.Windows.Forms.DataGridView dataGridViewWorkers1;
        private System.Windows.Forms.GroupBox groupBoxWorkers1Stats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWorkers2;
        private System.Windows.Forms.GroupBox groupBoxWorkers2Stats;
        private System.Windows.Forms.DataGridView dataGridViewWorkers2;
    }
}