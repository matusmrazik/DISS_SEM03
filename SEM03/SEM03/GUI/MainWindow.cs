using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using SEM03.Entities;
using SEM03.Simulation;

namespace SEM03.GUI
{
    public partial class MainWindow : Form
    {
        private const string RESUME_TEXT = "Pokračovať";
        private const string PAUSE_TEXT = "Pozastaviť";

        private static readonly object[] TimeUnitItems = { "sekúnd", "minút", "hodín", "dní" };
        private static readonly double[] TimeUnitCoefs = { 1.0, SimTimeHelper.MINUTE, SimTimeHelper.HOUR, SimTimeHelper.DAY };

        private readonly SimCarService _sim;
        private Thread _thr;

        public MainWindow()
        {
            InitializeComponent();
            _sim = new SimCarService();
            _thr = null;

            Init();
        }

        private void Init()
        {
            comboBoxTimeUnit.Items.AddRange(TimeUnitItems);
            comboBoxTimeUnit.SelectedIndex = 3;
            spinBoxCustomSeed.Maximum = int.MaxValue;
            labelSimSpeedValue.Text = $@"{horizontalSliderSimSpeed.Value}";
            labelSimRefreshRateValue.Text = $@"{horizontalSliderSimRefreshRate.Value} s";

            spinBoxQueueLenFixWorkers1.Minimum = spinBoxWorkers1.Value;
            spinBoxQueueLenFixWorkers1.Maximum = spinBoxWorkers1.Value;
            spinBoxQueueLenFixWorkers2.Minimum = spinBoxWorkers2.Value;
            spinBoxQueueLenFixWorkers2.Maximum = spinBoxWorkers2.Value;
            spinBoxTimeInServiceFixWorkers1.Minimum = spinBoxWorkers1.Value;
            spinBoxTimeInServiceFixWorkers1.Maximum = spinBoxWorkers1.Value;
            spinBoxTimeInServiceFixWorkers2.Minimum = spinBoxWorkers2.Value;
            spinBoxTimeInServiceFixWorkers2.Maximum = spinBoxWorkers2.Value;

            PrepareDataGrids();
            PrepareCharts();

            _sim.OnReplicationWillStart(ReplicationStarted);
            _sim.OnReplicationDidFinish(ReplicationFinished);
            _sim.OnSimulationWillStart(SimulationStarted);
            _sim.OnSimulationDidFinish(SimulationFinished);
            _sim.OnBestWorkerCountFound += BestWorkerCountFound;
            _sim.OnRunFinished += RunFinished;
            _sim.OnRefreshUI(RefreshTriggered);
        }

        private void PrepareDataGrids()
        {
            dataGridViewCustomers.AutoGenerateColumns = false;
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Sys. ID", "Id"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Stav", "State"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Čas čakania na zadanie objednávky", "WaitInQueueDurationStr"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Počet požadovaných opráv", "RequestedRepairCount"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Očakávané trvanie vykonania opráv", "TotalRepairDurationStr"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Čas čakania na opravu", "WaitForRepairDurationStr"));
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("Čas strávený v servise", "TimeInServiseStr"));

            dataGridViewWorkers1.AutoGenerateColumns = false;
            dataGridViewWorkers1.Columns.Add(CreateDataGridViewColumn("Stav", "State"));
            dataGridViewWorkers1.Columns.Add(CreateDataGridViewColumn("ID zákazníka", "CustomerId"));
            dataGridViewWorkers1.Columns.Add(CreateDataGridViewColumn("Celkový čas práce", "TotalWorkingTimeStr"));
            dataGridViewWorkers1.Columns.Add(CreateDataGridViewColumn("Celkový čas nečinnosti", "TotalIdleTimeStr"));
            dataGridViewWorkers1.Columns.Add(CreateDataGridViewColumn("Vyťaženie (percentá)", "TotalWorkingRatioStr"));

            dataGridViewWorkers2.AutoGenerateColumns = false;
            dataGridViewWorkers2.Columns.Add(CreateDataGridViewColumn("Stav", "State"));
            dataGridViewWorkers2.Columns.Add(CreateDataGridViewColumn("ID zákazníka", "CustomerId"));
            dataGridViewWorkers2.Columns.Add(CreateDataGridViewColumn("Celkový čas práce", "TotalWorkingTimeStr"));
            dataGridViewWorkers2.Columns.Add(CreateDataGridViewColumn("Celkový čas nečinnosti", "TotalIdleTimeStr"));
            dataGridViewWorkers2.Columns.Add(CreateDataGridViewColumn("Vyťaženie (percentá)", "TotalWorkingRatioStr"));
        }

        private DataGridViewTextBoxColumn CreateDataGridViewColumn(string columnName, string propertyName)
        {
            return new DataGridViewTextBoxColumn
            {
                DataPropertyName = propertyName,
                HeaderText = columnName
            };
        }

        private void PrepareCharts()
        {
            widgetPlotQueueLenWorkers1.Titles[0].Text = "Priemerný počet čakajúcich v rade podľa počtu pracovníkov skupiny 1";
            widgetPlotQueueLenWorkers1.ChartAreas[0].AxisX.Title = "Počet pracovníkov skupiny 1";
            widgetPlotQueueLenWorkers1.ChartAreas[0].AxisY.Title = "Priemerný počet čakajúcich v rade";

            widgetPlotQueueLenWorkers2.Titles[0].Text = "Priemerný počet čakajúcich v rade podľa počtu pracovníkov skupiny 2";
            widgetPlotQueueLenWorkers2.ChartAreas[0].AxisX.Title = "Počet pracovníkov skupiny 2";
            widgetPlotQueueLenWorkers2.ChartAreas[0].AxisY.Title = "Priemerný počet čakajúcich v rade";

            widgetPlotTimeInServiceWorkers1.Titles[0].Text = "Priemerný čas strávený zákazníkom v servise podľa počtu pracovníkov skupiny 1";
            widgetPlotTimeInServiceWorkers1.ChartAreas[0].AxisX.Title = "Počet pracovníkov skupiny 1";
            widgetPlotTimeInServiceWorkers1.ChartAreas[0].AxisY.Title = "Priemerný čas strávený zákazníkom v servise (hodiny)";

            widgetPlotTimeInServiceWorkers2.Titles[0].Text = "Priemerný čas strávený zákazníkom v servise podľa počtu pracovníkov skupiny 2";
            widgetPlotTimeInServiceWorkers2.ChartAreas[0].AxisX.Title = "Počet pracovníkov skupiny 2";
            widgetPlotTimeInServiceWorkers2.ChartAreas[0].AxisY.Title = "Priemerný čas strávený zákazníkom v servise (hodiny)";
        }

        private void ReplicationStarted(OSPABA.Simulation sim)
        {
            ExecuteOnGuiThread(labelReplicationValue, () => labelReplicationValue.Text = $@"{_sim.CurrentReplication + 1}");
        }

        private void ReplicationFinished(OSPABA.Simulation sim)
        {
            if (_sim.Stopped)
            {
                return;
            }

            var queueLengthMean = _sim.StatisticQueueLengthTotal.Mean;
            var carsForRepairQueueLengthMean = _sim.StatisticCarsForRepairQueueLengthTotal.Mean;
            var repairedQueueLengthMean = _sim.StatisticRepairedQueueLengthTotal.Mean;
            var waitInQueueMean = _sim.StatisticWaitInQueueTotal.Mean;
            var waitForRepairMean = _sim.StatisticWaitForRepairTotal.Mean;
            var timeInServiceMean = _sim.StatisticTimeInServiceTotal.Mean;
            var waitForRepair90Ci = _sim.StatisticWaitForRepairTotal.ConfidenceInterval90;
            var timeInService90Ci = _sim.StatisticTimeInServiceTotal.ConfidenceInterval90;
            var waitInQueue90Ci = _sim.StatisticWaitInQueueTotal.ConfidenceInterval90;

            ExecuteOnGuiThread(labelAVGCustomerQueueLenSimValue, () => labelAVGCustomerQueueLenSimValue.Text = $@"{queueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelAVGQueueForRepairLenSimValue, () => labelAVGQueueForRepairLenSimValue.Text = $@"{carsForRepairQueueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelAVGRepairedQueueLenSimValue, () => labelAVGRepairedQueueLenSimValue.Text = $@"{repairedQueueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelWaitInQueueDurSimValue, () => labelWaitInQueueDurSimValue.Text = SimTimeHelper.DurationAsString(waitInQueueMean));
            ExecuteOnGuiThread(labelWaitForRepairDurSimValue, () => labelWaitForRepairDurSimValue.Text = SimTimeHelper.DurationAsString(waitForRepairMean));
            ExecuteOnGuiThread(labelTimeInServiceDurSimValue, () => labelTimeInServiceDurSimValue.Text = SimTimeHelper.DurationAsString(timeInServiceMean));
            ExecuteOnGuiThread(labelWaitForRepairCIValue, () => labelWaitForRepairCIValue.Text = $@"<{SimTimeHelper.DurationAsString(waitForRepair90Ci[0])}, {SimTimeHelper.DurationAsString(waitForRepair90Ci[1])}>");
            ExecuteOnGuiThread(labelTimeInSystemCIValue, () => labelTimeInSystemCIValue.Text = $@"<{SimTimeHelper.DurationAsString(timeInService90Ci[0])}, {SimTimeHelper.DurationAsString(timeInService90Ci[1])}>");
            ExecuteOnGuiThread(labelWaitInQueueCIValue, () => labelWaitInQueueCIValue.Text = $@"<{SimTimeHelper.DurationAsString(waitInQueue90Ci[0])}, {SimTimeHelper.DurationAsString(waitInQueue90Ci[1])}>");
        }

        private void SimulationStarted(OSPABA.Simulation sim)
        {
            ExecuteOnGuiThread(labelWorkers1CurrentValue, () => labelWorkers1CurrentValue.Text = $@"{_sim.Workers1Count}");
            ExecuteOnGuiThread(labelWorkers2CurrentValue, () => labelWorkers2CurrentValue.Text = $@"{_sim.Workers2Count}");
            ExecuteOnGuiThread(labelUsedSeedValue, () => labelUsedSeedValue.Text = $@"{_sim.Seed}");
        }

        private void SimulationFinished(OSPABA.Simulation sim)
        {
            if (_sim.Stopped)
            {
                return;
            }

            var workers1 = _sim.Workers1Count;
            var workers2 = _sim.Workers2Count;
            var queueLengthMean = _sim.StatisticQueueLengthTotal.Mean;
            var timeInServiceMean = SimTimeHelper.ToHours(_sim.StatisticTimeInServiceTotal.Mean);

            if (workers1 == spinBoxQueueLenFixWorkers1.Value)
            {
                ExecuteOnGuiThread(widgetPlotQueueLenWorkers2, () =>
                {
                    widgetPlotQueueLenWorkers2.Series[0].Points.AddXY(workers2, queueLengthMean);
                    widgetPlotQueueLenWorkers2.Refresh();
                });
            }
            if (workers2 == spinBoxQueueLenFixWorkers2.Value)
            {
                ExecuteOnGuiThread(widgetPlotQueueLenWorkers1, () =>
                {
                    widgetPlotQueueLenWorkers1.Series[0].Points.AddXY(workers1, queueLengthMean);
                    widgetPlotQueueLenWorkers1.Refresh();
                });
            }
            if (workers1 == spinBoxTimeInServiceFixWorkers1.Value)
            {
                ExecuteOnGuiThread(widgetPlotTimeInServiceWorkers2, () =>
                {
                    widgetPlotTimeInServiceWorkers2.Series[0].Points.AddXY(workers2, timeInServiceMean);
                    widgetPlotTimeInServiceWorkers2.Refresh();
                });
            }
            if (workers2 == spinBoxTimeInServiceFixWorkers2.Value)
            {
                ExecuteOnGuiThread(widgetPlotTimeInServiceWorkers1, () =>
                {
                    widgetPlotTimeInServiceWorkers1.Series[0].Points.AddXY(workers1, timeInServiceMean);
                    widgetPlotTimeInServiceWorkers1.Refresh();
                });
            }
        }

        private void BestWorkerCountFound(int workers1Count, int workers2Count, double earnedMoney)
        {
            ExecuteOnGuiThread(labelIdealWorkers1CountValue, () => labelIdealWorkers1CountValue.Text = workers1Count == 0 ? "-" : $@"{workers1Count}");
            ExecuteOnGuiThread(labelIdealWorkers2CountValue, () => labelIdealWorkers2CountValue.Text = workers2Count == 0 ? "-" : $@"{workers2Count}");
            ExecuteOnGuiThread(labelProfitValue, () => labelProfitValue.Text = workers1Count == 0 ? "-" : $@"{earnedMoney:0.00} EUR");
        }

        private void RunFinished()
        {
            ExecuteOnGuiThread(this, () => SetUpControlsOnStartStop(false));
        }

        private void RefreshTriggered(OSPABA.Simulation sim)
        {
            var currentTime = SimTimeHelper.SimTimeAsString(_sim.CurrentTime);
            var workers1Working = _sim.Workers1Working;
            var workers2Working = _sim.Workers2Working;
            var customerQueueLength = _sim.CustomerQueueLength;
            var carsForRepairQueueLength = _sim.CarsForRepairQueueLength;
            var repairedCarsQueueLength = _sim.RepairedCarsQueueLength;
            var customerQueueLengthMean = _sim.StatisticQueueLength.Mean;
            var carsForRepairQueueLengthMean = _sim.StatisticCarsForRepairQueueLength.Mean;
            var repairedCarsQueueLengthMean = _sim.StatisticRepairedQueueLength.Mean;
            var waitInQueueMean = SimTimeHelper.DurationAsString(_sim.StatisticWaitInQueue.Mean);
            var waitForRepairMean = SimTimeHelper.DurationAsString(_sim.StatisticWaitForRepair.Mean);
            var timeInServiceMean = SimTimeHelper.DurationAsString(_sim.StatisticTimeInService.Mean);

            ExecuteOnGuiThread(labelTimeValue, () => labelTimeValue.Text = currentTime);
            ExecuteOnGuiThread(labelWorkers1WorkingValue, () => labelWorkers1WorkingValue.Text = $@"{workers1Working}");
            ExecuteOnGuiThread(labelWorkers2WorkingValue, () => labelWorkers2WorkingValue.Text = $@"{workers2Working}");
            ExecuteOnGuiThread(labelCustomerQueueLenValue, () => labelCustomerQueueLenValue.Text = $@"{customerQueueLength}");
            ExecuteOnGuiThread(labelQueueForRepairLenValue, () => labelQueueForRepairLenValue.Text = $@"{carsForRepairQueueLength}");
            ExecuteOnGuiThread(labelRepairedQueueLenValue, () => labelRepairedQueueLenValue.Text = $@"{repairedCarsQueueLength}");
            ExecuteOnGuiThread(labelAVGCustomerQueueLenValue, () => labelAVGCustomerQueueLenValue.Text = $@"{customerQueueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelAVGQueueForRepairLenValue, () => labelAVGQueueForRepairLenValue.Text = $@"{carsForRepairQueueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelAVGRepairedQueueLenValue, () => labelAVGRepairedQueueLenValue.Text = $@"{repairedCarsQueueLengthMean:0.000000}");
            ExecuteOnGuiThread(labelWaitInQueueDurValue, () => labelWaitInQueueDurValue.Text = waitInQueueMean);
            ExecuteOnGuiThread(labelWaitForRepairDurValue, () => labelWaitForRepairDurValue.Text = waitForRepairMean);
            ExecuteOnGuiThread(labelTimeInServiceDurValue, () => labelTimeInServiceDurValue.Text = timeInServiceMean);

            var customers = new List<Customer>(_sim.Customers.Count);
            customers.AddRange(_sim.Customers);
            ExecuteOnGuiThread(dataGridViewCustomers, () =>
            {
                dataGridViewCustomers.DataSource = customers;
                dataGridViewCustomers.Refresh();
            });

            var workers1 = new List<WorkerWithCustomers>(_sim.Workers1Count);
            workers1.AddRange(_sim.AgentService.Workers);
            ExecuteOnGuiThread(dataGridViewWorkers1, () =>
            {
                dataGridViewWorkers1.DataSource = workers1;
                dataGridViewWorkers1.Refresh();
            });

            var workers2 = new List<Mechanic>(_sim.Workers2Count);
            workers2.AddRange(_sim.AgentWorkshop.Workers);

            ExecuteOnGuiThread(dataGridViewWorkers2, () =>
            {
                dataGridViewWorkers2.DataSource = workers2;
                dataGridViewWorkers2.Refresh();
            });
        }

        private void RadioButtonCustomSeed_CheckedChanged(object sender, EventArgs e)
        {
            spinBoxCustomSeed.Enabled = radioButtonCustomSeed.Checked;
        }

        private void CheckBoxRangeWorkers1_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = checkBoxRangeWorkers1.Checked;
            spinBoxWorkers1.Enabled = !isChecked;
            spinBoxWorkers1Min.Enabled = isChecked;
            spinBoxWorkers1Max.Enabled = isChecked;
            if (isChecked)
            {
                spinBoxQueueLenFixWorkers1.Minimum = spinBoxWorkers1Min.Value;
                spinBoxQueueLenFixWorkers1.Maximum = spinBoxWorkers1Max.Value;
                spinBoxTimeInServiceFixWorkers1.Minimum = spinBoxWorkers1Min.Value;
                spinBoxTimeInServiceFixWorkers1.Maximum = spinBoxWorkers1Max.Value;
            }
            else
            {
                spinBoxQueueLenFixWorkers1.Minimum = spinBoxWorkers1.Value;
                spinBoxQueueLenFixWorkers1.Maximum = spinBoxWorkers1.Value;
                spinBoxTimeInServiceFixWorkers1.Minimum = spinBoxWorkers1.Value;
                spinBoxTimeInServiceFixWorkers1.Maximum = spinBoxWorkers1.Value;
            }
        }

        private void CheckBoxRangeWorkers2_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = checkBoxRangeWorkers2.Checked;
            spinBoxWorkers2.Enabled = !isChecked;
            spinBoxWorkers2Min.Enabled = isChecked;
            spinBoxWorkers2Max.Enabled = isChecked;
            if (isChecked)
            {
                spinBoxQueueLenFixWorkers2.Minimum = spinBoxWorkers2Min.Value;
                spinBoxQueueLenFixWorkers2.Maximum = spinBoxWorkers2Max.Value;
                spinBoxTimeInServiceFixWorkers2.Minimum = spinBoxWorkers2Min.Value;
                spinBoxTimeInServiceFixWorkers2.Maximum = spinBoxWorkers2Max.Value;
            }
            else
            {
                spinBoxQueueLenFixWorkers2.Minimum = spinBoxWorkers2.Value;
                spinBoxQueueLenFixWorkers2.Maximum = spinBoxWorkers2.Value;
                spinBoxTimeInServiceFixWorkers2.Minimum = spinBoxWorkers2.Value;
                spinBoxTimeInServiceFixWorkers2.Maximum = spinBoxWorkers2.Value;
            }
        }

        private void SpinBoxWorkers1_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers1.Value;
            spinBoxQueueLenFixWorkers1.Minimum = value;
            spinBoxQueueLenFixWorkers1.Maximum = value;
            spinBoxTimeInServiceFixWorkers1.Minimum = value;
            spinBoxTimeInServiceFixWorkers1.Maximum = value;
        }

        private void SpinBoxWorkers2_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers2.Value;
            spinBoxQueueLenFixWorkers2.Minimum = value;
            spinBoxQueueLenFixWorkers2.Maximum = value;
            spinBoxTimeInServiceFixWorkers2.Minimum = value;
            spinBoxTimeInServiceFixWorkers2.Maximum = value;
        }

        private void SpinBoxWorkers1Min_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers1Min.Value;
            spinBoxQueueLenFixWorkers1.Minimum = value;
            spinBoxTimeInServiceFixWorkers1.Minimum = value;
        }

        private void SpinBoxWorkers1Max_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers1Max.Value;
            spinBoxQueueLenFixWorkers1.Maximum = value;
            spinBoxTimeInServiceFixWorkers1.Maximum = value;
        }

        private void SpinBoxWorkers2Min_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers2Min.Value;
            spinBoxQueueLenFixWorkers2.Minimum = value;
            spinBoxTimeInServiceFixWorkers2.Minimum = value;
        }

        private void SpinBoxWorkers2Max_ValueChanged(object sender, EventArgs e)
        {
            var value = spinBoxWorkers2Max.Value;
            spinBoxQueueLenFixWorkers2.Maximum = value;
            spinBoxTimeInServiceFixWorkers2.Maximum = value;
        }

        private void PushButtonStartSimulation_Click(object sender, EventArgs e)
        {
            SetUpControlsOnStartStop(true);

            widgetPlotQueueLenWorkers1.Series[0].Points.Clear();
            widgetPlotQueueLenWorkers1.Refresh();
            widgetPlotQueueLenWorkers2.Series[0].Points.Clear();
            widgetPlotQueueLenWorkers2.Refresh();
            widgetPlotTimeInServiceWorkers1.Series[0].Points.Clear();
            widgetPlotTimeInServiceWorkers1.Refresh();
            widgetPlotTimeInServiceWorkers2.Series[0].Points.Clear();
            widgetPlotTimeInServiceWorkers2.Refresh();

            if (checkBoxWatchModeEnabled.Checked)
            {
                var interval = horizontalSliderSimRefreshRate.Value;
                var duration = (horizontalSliderSimSpeed.Maximum - horizontalSliderSimSpeed.Value) / 1000.0;
                _sim.SetSimSpeed(interval, duration);
            }
            else
            {
                _sim.SetMaxSimSpeed();
            }

            var replications = (int)spinBoxReplications.Value;
            var unitIndex = comboBoxTimeUnit.SelectedIndex;
            SimConfig.ReplicationDuration = (double)spinBoxReplicationDuration.Value * TimeUnitCoefs[unitIndex];

            var rangeWorkers1 = checkBoxRangeWorkers1.Checked;
            var rangeWorkers2 = checkBoxRangeWorkers2.Checked;

            int? seed = null;
            if (!rangeWorkers1 && !rangeWorkers2)
            {
                var w1 = (int)spinBoxWorkers1.Value;
                var w2 = (int)spinBoxWorkers2.Value;
                if (radioButtonCustomSeed.Checked) seed = (int)spinBoxCustomSeed.Value;
                _thr = _sim.SingleRunAsync(replications, SimConfig.TotalReplicationDuration, w1, w2, seed);
                return;
            }

            var w1Min = (int)spinBoxWorkers1.Value;
            var w1Max = (int)spinBoxWorkers1.Value;
            if (rangeWorkers1)
            {
                w1Min = (int)spinBoxWorkers1Min.Value;
                w1Max = (int)spinBoxWorkers1Max.Value;
            }
            var w2Min = (int)spinBoxWorkers2.Value;
            var w2Max = (int)spinBoxWorkers2.Value;
            if (rangeWorkers2)
            {
                w2Min = (int)spinBoxWorkers2Min.Value;
                w2Max = (int)spinBoxWorkers2Max.Value;
            }

            if (radioButtonCustomSeed.Checked) seed = (int)spinBoxCustomSeed.Value;
            _thr = _sim.MultiRunAsync(replications, SimConfig.TotalReplicationDuration, w1Min, w1Max, w2Min, w2Max, seed);
        }

        private void PushButtonPauseResumeSimulation_Click(object sender, EventArgs e)
        {
            if (!_sim.IsRunning())
            {
                return;
            }

            if (_sim.IsPaused())
            {
                _sim.ResumeSimulation();
                pushButtonPauseResumeSimulation.Text = PAUSE_TEXT;
            }
            else
            {
                _sim.PauseSimulation();
                pushButtonPauseResumeSimulation.Text = RESUME_TEXT;
            }
        }

        private void PushButtonStopSimulation_Click(object sender, EventArgs e)
        {
            _sim.StopSimulation();
            //_thr.Join();

            SetUpControlsOnStartStop(false);
        }

        private void CheckBoxWatchModeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = checkBoxWatchModeEnabled.Checked;
            horizontalSliderSimSpeed.Enabled = isChecked;
            horizontalSliderSimRefreshRate.Enabled = isChecked;
            if (isChecked)
            {
                var interval = horizontalSliderSimRefreshRate.Value;
                var duration = (horizontalSliderSimSpeed.Maximum - horizontalSliderSimSpeed.Value) / 1000.0;
                _sim.SetSimSpeed(interval, duration);
            }
            else
            {
                _sim.SetMaxSimSpeed();
            }
        }

        private void HorizontalSliderSimSpeed_ValueChanged(object sender, EventArgs e)
        {
            var value = horizontalSliderSimSpeed.Value;
            var interval = horizontalSliderSimRefreshRate.Value;
            var duration = (horizontalSliderSimSpeed.Maximum - value) / 1000.0;
            _sim.SetSimSpeed(interval, duration);
            labelSimSpeedValue.Text = $@"{value}";
        }

        private void HorizontalSliderSimRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            var interval = horizontalSliderSimRefreshRate.Value;
            var duration = (horizontalSliderSimSpeed.Maximum - horizontalSliderSimSpeed.Value) / 1000.0;
            _sim.SetSimSpeed(interval, duration);
            labelSimRefreshRateValue.Text = $@"{interval} s";
        }

        private void SetUpControlsOnStartStop(bool start)
        {
            pushButtonStartSimulation.Enabled = !start;
            pushButtonPauseResumeSimulation.Enabled = start;
            pushButtonPauseResumeSimulation.Text = PAUSE_TEXT;
            pushButtonStopSimulation.Enabled = start;
            groupBoxSeed.Enabled = !start;
            groupBoxParameters.Enabled = !start;
            spinBoxQueueLenFixWorkers1.Enabled = !start;
            spinBoxQueueLenFixWorkers2.Enabled = !start;
            spinBoxTimeInServiceFixWorkers1.Enabled = !start;
            spinBoxTimeInServiceFixWorkers2.Enabled = !start;
        }

        private static void ExecuteOnGuiThread(Control control, Action action)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(action);
            }
            else
            {
                action();
            }
        }
    }
}
