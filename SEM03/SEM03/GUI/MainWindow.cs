using System;
using System.Threading;
using System.Windows.Forms;
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

            PrepareCharts();

            _sim.OnReplicationWillStart(ReplicationStarted);
            _sim.OnReplicationDidFinish(ReplicationFinished);
            _sim.OnSimulationWillStart(SimulationStarted);
            _sim.OnSimulationDidFinish(SimulationFinished);
            _sim.OnBestWorkerCountFound += BestWorkerCountFound;
            _sim.OnRunFinished += RunFinished;
            _sim.OnRefreshUI(RefreshTriggered);
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
            labelReplicationValue.Text = $@"{_sim.CurrentReplication + 1}";
        }

        private void ReplicationFinished(OSPABA.Simulation sim)
        {
            if (_sim.Stopped)
            {
                return;
            }

            var waitForRepair90Ci = _sim.StatisticWaitForRepairTotal.ConfidenceInterval90;
            var timeInService90Ci = _sim.StatisticTimeInServiceTotal.ConfidenceInterval90;
            var waitInQueue90Ci = _sim.StatisticWaitInQueueTotal.ConfidenceInterval90;

            labelAVGCustomerQueueLenSimValue.Text = $@"{_sim.StatisticQueueLengthTotal.Mean:0.000000}";
            labelAVGQueueForRepairLenSimValue.Text = $@"{_sim.StatisticCarsForRepairQueueLengthTotal.Mean:0.000000}";
            labelAVGRepairedQueueLenSimValue.Text = $@"{_sim.StatisticRepairedQueueLengthTotal.Mean:0.000000}";
            labelWaitInQueueDurSimValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticWaitInQueueTotal.Mean);
            labelWaitForRepairDurSimValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticWaitForRepairTotal.Mean);
            labelTimeInServiceDurSimValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticTimeInServiceTotal.Mean);
            labelWaitForRepairCIValue.Text = $@"<{SimTimeHelper.DurationAsString(waitForRepair90Ci[0])}, {SimTimeHelper.DurationAsString(waitForRepair90Ci[1])}>";
            labelTimeInSystemCIValue.Text = $@"<{SimTimeHelper.DurationAsString(timeInService90Ci[0])}, {SimTimeHelper.DurationAsString(timeInService90Ci[1])}>";
            labelWaitInQueueCIValue.Text = $@"<{SimTimeHelper.DurationAsString(waitInQueue90Ci[0])}, {SimTimeHelper.DurationAsString(waitInQueue90Ci[1])}>";
        }

        private void SimulationStarted(OSPABA.Simulation sim)
        {
            labelWorkers1CurrentValue.Text = $@"{_sim.Workers1Count}";
            labelWorkers2CurrentValue.Text = $@"{_sim.Workers2Count}";
            labelUsedSeedValue.Text = $@"{_sim.Seed}";
        }

        private void SimulationFinished(OSPABA.Simulation sim)
        {
            if (_sim.Stopped)
            {
                return;
            }

            /*if (workers1 == spinBoxQueueLenFixWorkers1.Value)
            {
                widgetPlotQueueLenWorkers2->graph(0)->addData(workers2, queue_len_total);
                widgetPlotQueueLenWorkers2->rescaleAxes();
                widgetPlotQueueLenWorkers2->replot();
            }
            if (workers2 == spinBoxQueueLenFixWorkers2.Value)
            {
                widgetPlotQueueLenWorkers1->graph(0)->addData(workers1, queue_len_total);
                widgetPlotQueueLenWorkers1->rescaleAxes();
                widgetPlotQueueLenWorkers1->replot();
            }
            if (workers1 == spinBoxTimeInServiceFixWorkers1.Value)
            {
                widgetPlotTimeInServiceWorkers2->graph(0)->addData(workers2, to_hours(time_in_service_total));
                widgetPlotTimeInServiceWorkers2->rescaleAxes();
                widgetPlotTimeInServiceWorkers2->replot();
            }
            if (workers2 == spinBoxTimeInServiceFixWorkers2.Value)
            {
                widgetPlotTimeInServiceWorkers1->graph(0)->addData(workers1, to_hours(time_in_service_total));
                widgetPlotTimeInServiceWorkers1->rescaleAxes();
                widgetPlotTimeInServiceWorkers1->replot();
            }*/

            if (_sim.Workers1Count == spinBoxQueueLenFixWorkers1.Value)
            {
                widgetPlotQueueLenWorkers2.Series[0].Points.AddXY(_sim.Workers2Count, _sim.StatisticQueueLengthTotal.Mean);
                widgetPlotQueueLenWorkers2.Refresh();
            }
            if (_sim.Workers2Count == spinBoxQueueLenFixWorkers2.Value)
            {
                widgetPlotQueueLenWorkers1.Series[0].Points.AddXY(_sim.Workers1Count, _sim.StatisticQueueLengthTotal.Mean);
                widgetPlotQueueLenWorkers1.Refresh();
            }
            if (_sim.Workers1Count == spinBoxTimeInServiceFixWorkers1.Value)
            {
                widgetPlotTimeInServiceWorkers2.Series[0].Points.AddXY(_sim.Workers2Count, SimTimeHelper.ToHours(_sim.StatisticTimeInServiceTotal.Mean));
                widgetPlotTimeInServiceWorkers2.Refresh();
            }
            if (_sim.Workers2Count == spinBoxTimeInServiceFixWorkers2.Value)
            {
                widgetPlotTimeInServiceWorkers1.Series[0].Points.AddXY(_sim.Workers1Count, SimTimeHelper.ToHours(_sim.StatisticTimeInServiceTotal.Mean));
                widgetPlotTimeInServiceWorkers1.Refresh();
            }
        }

        private void BestWorkerCountFound(int workers1Count, int workers2Count, double earnedMoney)
        {
            labelIdealWorkers1CountValue.Text = workers1Count == 0 ? "-" : $@"{workers1Count}";
            labelIdealWorkers2CountValue.Text = workers2Count == 0 ? "-" : $@"{workers2Count}";
            labelProfitValue.Text = workers1Count == 0 ? "-" : $@"{earnedMoney:0.00} EUR";
        }

        private void RunFinished()
        {
            //_thr.Join(); // TODO remove

            pushButtonStartSimulation.Enabled = true;
            pushButtonPauseResumeSimulation.Enabled = false;
            pushButtonPauseResumeSimulation.Text = PAUSE_TEXT;
            pushButtonStopSimulation.Enabled = false;
            groupBoxSeed.Enabled = true;
            groupBoxParameters.Enabled = true;
            spinBoxQueueLenFixWorkers1.Enabled = true;
            spinBoxQueueLenFixWorkers2.Enabled = true;
            spinBoxTimeInServiceFixWorkers1.Enabled = true;
            spinBoxTimeInServiceFixWorkers2.Enabled = true;
        }

        private void RefreshTriggered(OSPABA.Simulation sim)
        {
            labelTimeValue.Text = SimTimeHelper.SimTimeAsString(_sim.CurrentTime);
            labelWorkers1WorkingValue.Text = $@"{_sim.Workers1Working}";
            labelWorkers2WorkingValue.Text = $@"{_sim.Workers2Working}";
            labelCustomerQueueLenValue.Text = $@"{_sim.CustomerQueueLength}";
            labelQueueForRepairLenValue.Text = $@"{_sim.CarsForRepairQueueLength}";
            labelRepairedQueueLenValue.Text = $@"{_sim.RepairedCarsQueueLength}";
            labelAVGCustomerQueueLenValue.Text = $@"{_sim.StatisticQueueLength.Mean:0.000000}";
            labelAVGQueueForRepairLenValue.Text = $@"{_sim.StatisticCarsForRepairQueueLength.Mean:0.000000}";
            labelAVGRepairedQueueLenValue.Text = $@"{_sim.StatisticRepairedQueueLength.Mean:0.000000}";
            labelWaitInQueueDurValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticWaitInQueue.Mean);
            labelWaitForRepairDurValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticWaitForRepair.Mean);
            labelTimeInServiceDurValue.Text = SimTimeHelper.DurationAsString(_sim.StatisticTimeInService.Mean);
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
            pushButtonStartSimulation.Enabled = false;
            pushButtonPauseResumeSimulation.Enabled = true;
            pushButtonStopSimulation.Enabled = true;
            groupBoxSeed.Enabled = false;
            groupBoxParameters.Enabled = false;
            spinBoxQueueLenFixWorkers1.Enabled = false;
            spinBoxQueueLenFixWorkers2.Enabled = false;
            spinBoxTimeInServiceFixWorkers1.Enabled = false;
            spinBoxTimeInServiceFixWorkers2.Enabled = false;

            /*_ui->widgetPlotQueueLenWorkers1->graph(0)->clearData();
            _ui->widgetPlotQueueLenWorkers1->replot();
            _ui->widgetPlotQueueLenWorkers2->graph(0)->clearData();
            _ui->widgetPlotQueueLenWorkers2->replot();
            _ui->widgetPlotTimeInServiceWorkers1->graph(0)->clearData();
            _ui->widgetPlotTimeInServiceWorkers1->replot();
            _ui->widgetPlotTimeInServiceWorkers2->graph(0)->clearData();
            _ui->widgetPlotTimeInServiceWorkers2->replot();*/

            widgetPlotQueueLenWorkers1.Series[0].Points.Clear();
            widgetPlotQueueLenWorkers1.Refresh();
            widgetPlotQueueLenWorkers2.Series[0].Points.Clear();
            widgetPlotQueueLenWorkers2.Refresh();
            widgetPlotTimeInServiceWorkers1.Series[0].Points.Clear();
            widgetPlotTimeInServiceWorkers1.Refresh();
            widgetPlotTimeInServiceWorkers2.Series[0].Points.Clear();
            widgetPlotTimeInServiceWorkers2.Refresh();

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
            var running = _sim.IsRunning();
            _sim.PauseSimulation();
            pushButtonPauseResumeSimulation.Text = running ? RESUME_TEXT : PAUSE_TEXT;
        }

        private void PushButtonStopSimulation_Click(object sender, EventArgs e)
        {
            _sim.StopSimulation();
            _thr.Join();

            pushButtonStartSimulation.Enabled = true;
            pushButtonPauseResumeSimulation.Enabled = false;
            pushButtonPauseResumeSimulation.Text = PAUSE_TEXT;
            pushButtonStopSimulation.Enabled = false;
            groupBoxSeed.Enabled = true;
            groupBoxParameters.Enabled = true;
            spinBoxQueueLenFixWorkers1.Enabled = true;
            spinBoxQueueLenFixWorkers2.Enabled = true;
            spinBoxTimeInServiceFixWorkers1.Enabled = true;
            spinBoxTimeInServiceFixWorkers2.Enabled = true;
        }

        private void CheckBoxWatchModeEnabled_CheckedChanged(object sender, EventArgs e)
        {
            var isChecked = checkBoxWatchModeEnabled.Checked;
            //_sim->set_watch_mode_active(isChecked);
            horizontalSliderSimSpeed.Enabled = isChecked;
            horizontalSliderSimRefreshRate.Enabled = isChecked;
        }

        private void HorizontalSliderSimSpeed_ValueChanged(object sender, EventArgs e)
        {
            var value = horizontalSliderSimSpeed.Value;
            //_sim.SetSimSpeed(horizontalSliderSimSpeed.Maximum - value);
            labelSimSpeedValue.Text = $@"{value}";
        }

        private void HorizontalSliderSimRefreshRate_ValueChanged(object sender, EventArgs e)
        {
            var value = horizontalSliderSimRefreshRate.Value;
            //_sim.SetRefreshRate(value);
            labelSimRefreshRateValue.Text = $@"{value} s";
        }
    }
}
