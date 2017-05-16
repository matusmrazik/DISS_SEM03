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
            dataGridViewCustomers.Columns.Add(CreateDataGridViewColumn("ID", "Id"));
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

            dataGridViewCarPark1.AutoGenerateColumns = false;
            dataGridViewCarPark1.Columns.Add(CreateDataGridViewColumn("Stav", "StateStr"));
            dataGridViewCarPark1.Columns.Add(CreateDataGridViewColumn("Obsadenosť (percentá)", "OccupiedRatioStr"));

            dataGridViewCarPark2.AutoGenerateColumns = false;
            dataGridViewCarPark2.Columns.Add(CreateDataGridViewColumn("Stav", "StateStr"));
            dataGridViewCarPark2.Columns.Add(CreateDataGridViewColumn("Obsadenosť (percentá)", "OccupiedRatioStr"));
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
            var replication = _sim.CurrentReplication + 1;
            ExecuteOnGuiThread(labelReplicationValue, () => labelReplicationValue.Text = $@"{replication}");
        }

        private void ReplicationFinished(OSPABA.Simulation sim)
        {
            if (_sim.Stopped)
            {
                return;
            }

            var customersInServiceMean = _sim.StatisticCustomersInServiceTotal.Mean;
            var queueLengthMean = _sim.StatisticQueueLengthTotal.Mean;
            var toRepairQueueLengthMean = _sim.StatisticCarsForRepairQueueLengthTotal.Mean;
            var repairedQueueLengthMean = _sim.StatisticRepairedQueueLengthTotal.Mean;
            var returnQueueLengthMean = _sim.StatisticReadyToReturnQueueLengthTotal.Mean;
            var servedRatioMean = $"{100.0 * _sim.StatisticServedPrecentageTotal.Mean:0.0000} %";
            var waitInQueueMean = _sim.StatisticWaitInQueueTotal.Mean;
            var waitForRepairMean = _sim.StatisticWaitForRepairTotal.Mean;
            var timeInServiceMean = _sim.StatisticTimeInServiceTotal.Mean;
            var working1CountMean = _sim.StatisticWorkers1WorkingTotal.Mean;
            var working2CountMean = _sim.StatisticWorkers2WorkingTotal.Mean;
            var working1RatioMean = $"{100.0 * (working1CountMean / _sim.Workers1Count):0.0000} %";
            var working2RatioMean = $"{100.0 * (working2CountMean / _sim.Workers2Count):0.0000} %";
            var carPark1CountMean = _sim.StatisticCarPark1OccupiedTotal.Mean;
            var carPark2CountMean = _sim.StatisticCarPark2OccupiedTotal.Mean;
            var carParkServiceCountMean = _sim.StatisticCarParkServiceOccupiedTotal.Mean;
            var carPark1RatioMean = $"{100.0 * (carPark1CountMean / _sim.CarPark1Capacity):0.0000} %";
            var carPark2RatioMean = $"{100.0 * (carPark2CountMean / _sim.CarPark2Capacity):0.0000} %";

            var customersInServiceMeanCi = _sim.StatisticCustomersInServiceTotal.ConfidenceInterval90;
            var queueLengthMeanCi = _sim.StatisticQueueLengthTotal.ConfidenceInterval90;
            var toRepairQueueLengthMeanCi = _sim.StatisticCarsForRepairQueueLengthTotal.ConfidenceInterval90;
            var repairedQueueLengthMeanCi = _sim.StatisticRepairedQueueLengthTotal.ConfidenceInterval90;
            var returnQueueLengthMeanCi = _sim.StatisticReadyToReturnQueueLengthTotal.ConfidenceInterval90;
            var servedRatioMeanCi = _sim.StatisticServedPrecentageTotal.ConfidenceInterval90;
            var waitInQueueMeanCi = _sim.StatisticWaitInQueueTotal.ConfidenceInterval90;
            var waitForRepairMeanCi = _sim.StatisticWaitForRepairTotal.ConfidenceInterval90;
            var timeInServiceMeanCi = _sim.StatisticTimeInServiceTotal.ConfidenceInterval90;
            var working1CountMeanCi = _sim.StatisticWorkers1WorkingTotal.ConfidenceInterval90;
            var working2CountMeanCi = _sim.StatisticWorkers2WorkingTotal.ConfidenceInterval90;
            var working1RatioMeanCi = new[] { working1CountMeanCi[0] / _sim.Workers1Count, working1CountMeanCi[1] / _sim.Workers1Count };
            var working2RatioMeanCi = new[] { working2CountMeanCi[0] / _sim.Workers2Count, working2CountMeanCi[1] / _sim.Workers2Count };
            var carPark1CountMeanCi = _sim.StatisticCarPark1OccupiedTotal.ConfidenceInterval90;
            var carPark2CountMeanCi = _sim.StatisticCarPark2OccupiedTotal.ConfidenceInterval90;
            var carParkServiceCountMeanCi = _sim.StatisticCarParkServiceOccupiedTotal.ConfidenceInterval90;
            var carPark1RatioMeanCi = new[] { carPark1CountMeanCi[0] / _sim.CarPark1Capacity, carPark1CountMeanCi[1] / _sim.CarPark1Capacity };
            var carPark2RatioMeanCi = new[] { carPark2CountMeanCi[0] / _sim.CarPark2Capacity, carPark2CountMeanCi[1] / _sim.CarPark2Capacity };

            ExecuteOnGuiThread(groupBoxSimulationStats, () =>
            {
                labelSimCustomersInServiceValue.Text = $@"{customersInServiceMean:0.000000}";
                labelSimCustomerInQueueValue.Text = $@"{queueLengthMean:0.000000}";
                labelSimToRepairQueueLengthValue.Text = $@"{toRepairQueueLengthMean:0.000000}";
                labelSimRepairedQueueLengthValue.Text = $@"{repairedQueueLengthMean:0.000000}";
                labelSimReturnQueueLengthValue.Text = $@"{returnQueueLengthMean:0.000000}";
                labelSimCustomersServedRatioValue.Text = servedRatioMean;
                labelSimWaitInQueueValue.Text = SimTimeHelper.DurationAsString(waitInQueueMean);
                labelSimWaitForRepairValue.Text = SimTimeHelper.DurationAsString(waitForRepairMean);
                labelSimTimeInServiceValue.Text = SimTimeHelper.DurationAsString(timeInServiceMean);
                labelSimWorking1CountValue.Text = $@"{working1CountMean:0.000000}";
                labelSimWorking2CountValue.Text = $@"{working2CountMean:0.000000}";
                labelSimWorking1RatioValue.Text = working1RatioMean;
                labelSimWorking2RatioValue.Text = working2RatioMean;
                labelSimCarPark1CountValue.Text = $@"{carPark1CountMean:0.000000}";
                labelSimCarPark2CountValue.Text = $@"{carPark2CountMean:0.000000}";
                labelSimCarParkServiceCountValue.Text = $@"{carParkServiceCountMean:0.000000}";
                labelSimCarPark1RatioValue.Text = carPark1RatioMean;
                labelSimCarPark2RatioValue.Text = carPark2RatioMean;

                labelSimCustomersInServiceISValue.Text = $@"<{customersInServiceMeanCi[0]:0.000000}, {customersInServiceMeanCi[1]:0.000000}>";
                labelSimCustomerInQueueISValue.Text = $@"<{queueLengthMeanCi[0]:0.000000}, {queueLengthMeanCi[1]:0.000000}>";
                labelSimToRepairQueueLengthISValue.Text = $@"<{toRepairQueueLengthMeanCi[0]:0.000000}, {toRepairQueueLengthMeanCi[1]:0.000000}>";
                labelSimRepairedQueueLengthISValue.Text = $@"<{repairedQueueLengthMeanCi[0]:0.000000}, {repairedQueueLengthMeanCi[1]:0.000000}>";
                labelSimReturnQueueLengthISValue.Text = $@"<{returnQueueLengthMeanCi[0]:0.000000}, {returnQueueLengthMeanCi[1]:0.000000}>";
                labelSimCustomersServedRatioISValue.Text = $@"<{100.0 * servedRatioMeanCi[0]:0.0000} %, {100.0 * servedRatioMeanCi[1]:0.0000} %>";
                labelSimWaitInQueueISValue.Text = $@"<{SimTimeHelper.DurationAsString(waitInQueueMeanCi[0])}, {SimTimeHelper.DurationAsString(waitInQueueMeanCi[1])}>";
                labelSimWaitForRepairISValue.Text = $@"<{SimTimeHelper.DurationAsString(waitForRepairMeanCi[0])}, {SimTimeHelper.DurationAsString(waitForRepairMeanCi[1])}>";
                labelSimTimeInServiceISValue.Text = $@"<{SimTimeHelper.DurationAsString(timeInServiceMeanCi[0])}, {SimTimeHelper.DurationAsString(timeInServiceMeanCi[1])}>";
                labelSimWorking1CountISValue.Text = $@"<{working1CountMeanCi[0]:0.000000}, {working1CountMeanCi[1]:0.000000}>";
                labelSimWorking2CountISValue.Text = $@"<{working2CountMeanCi[0]:0.000000}, {working2CountMeanCi[1]:0.000000}>";
                labelSimWorking1RatioISValue.Text = $@"<{100.0 * working1RatioMeanCi[0]:0.0000} %, {100.0 * working1RatioMeanCi[1]:0.0000} %>";
                labelSimWorking2RatioISValue.Text = $@"<{100.0 * working2RatioMeanCi[0]:0.0000} %, {100.0 * working2RatioMeanCi[1]:0.0000} %>";
                labelSimCarPark1CountISValue.Text = $@"<{carPark1CountMeanCi[0]:0.000000}, {carPark1CountMeanCi[1]:0.000000}>";
                labelSimCarPark2CountISValue.Text = $@"<{carPark2CountMeanCi[0]:0.000000}, {carPark2CountMeanCi[1]:0.000000}>";
                labelSimCarParkServiceCountISValue.Text = $@"<{carParkServiceCountMeanCi[0]:0.000000}, {carParkServiceCountMeanCi[1]:0.000000}>";
                labelSimCarPark1RatioISValue.Text = $@"<{100.0 * carPark1RatioMeanCi[0]:0.0000} %, {100.0 * carPark1RatioMeanCi[1]:0.0000} %>";
                labelSimCarPark2RatioISValue.Text = $@"<{100.0 * carPark2RatioMeanCi[0]:0.0000} %, {100.0 * carPark2RatioMeanCi[1]:0.0000} %>";
            });
        }

        private void SimulationStarted(OSPABA.Simulation sim)
        {
            var w1 = _sim.Workers1Count;
            var w2 = _sim.Workers2Count;
            var seed = _sim.Seed;

            ExecuteOnGuiThread(frameResults, () =>
            {
                labelWorkers1CurrentValue.Text = $@"{w1}";
                labelWorkers2CurrentValue.Text = $@"{w2}";
                labelUsedSeedValue.Text = $@"{seed}";
            });
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
            ExecuteOnGuiThread(groupBoxIdealWorkersCount, () =>
            {
                labelIdealWorkers1CountValue.Text = workers1Count == 0 ? "-" : $@"{workers1Count}";
                labelIdealWorkers2CountValue.Text = workers2Count == 0 ? "-" : $@"{workers2Count}";
                labelProfitValue.Text = workers1Count == 0 ? "-" : $@"{earnedMoney:0.00} EUR";
            });
        }

        private void RunFinished()
        {
            ExecuteOnGuiThread(this, () => SetUpControlsOnStartStop(false));
        }

        private void RefreshTriggered(OSPABA.Simulation sim)
        {
            var currentTime = SimTimeHelper.SimTimeAsString(_sim.CurrentTime);
            ExecuteOnGuiThread(labelTimeValue, () => labelTimeValue.Text = currentTime);

            var customersInService = _sim.Customers.Count;
            var customersQueueLength = _sim.CustomerQueueLength;
            var customersInServiceTotal = _sim.AgentEnvironment.CustomersLeftTotal.Count;
            var customersServedTotal = _sim.AgentEnvironment.CustomersLeftServed.Count;
            var customersNotServedTotal = _sim.AgentEnvironment.CustomersLeftNotServed.Count;
            var customersServedRatio = customersInServiceTotal == 0 ? "-" : $"{100.0 * (customersServedTotal / (double)customersInServiceTotal):0.0000} %";
            var customersInServiceMean = _sim.StatisticCustomersInService.CurrentMean;
            var customersQueueLengthMean = _sim.StatisticQueueLength.CurrentMean;
            var waitInQueueMean = SimTimeHelper.DurationAsString(_sim.StatisticWaitInQueue.Mean);
            var waitForRepairMean = SimTimeHelper.DurationAsString(_sim.StatisticWaitForRepair.Mean);
            var timeInServiceMean = SimTimeHelper.DurationAsString(_sim.StatisticTimeInService.Mean);
            ExecuteOnGuiThread(groupBoxCustomersStats, () =>
            {
                labelCustomersInServiceValue.Text = $@"{customersInService}";
                labelCustomersInQueueValue.Text = $@"{customersQueueLength}";
                labelCustomersTotalValue.Text = $@"{customersInServiceTotal}";
                labelCustomersServedValue.Text = $@"{customersServedTotal}";
                labelCustomersNotServedValue.Text = $@"{customersNotServedTotal}";
                labelCustomersServedRatioValue.Text = customersServedRatio;
                labelCustomersInServiceAvgValue.Text = $@"{customersInServiceMean:0.000000}";
                labelCustomersInQueueAvgValue.Text = $@"{customersQueueLengthMean:0.000000}";
                labelCustomersWaitInQueueAvgValue.Text = waitInQueueMean;
                labelCustomersWaitForRepairAvgValue.Text = waitForRepairMean;
                labelCustomersTimeInServiceAvgValue.Text = timeInServiceMean;
            });

            var workers1Working = _sim.Workers1Working;
            var workers1WorkingRatio = $"{100.0 * (workers1Working / (double)_sim.Workers1Count):0.0000} %";
            var returnQueueLength = _sim.ReturnQueueLength;
            var workers1WorkingMean = _sim.StatisticWorkers1Working.CurrentMean;
            var workers1WorkingRatioMean = $"{100.0 * (workers1WorkingMean / _sim.Workers1Count):0.0000} %";
            var returnQueueLengthMean = _sim.StatisticReadyToReturnQueueLength.CurrentMean;
            ExecuteOnGuiThread(groupBoxWorkers1Stats, () =>
            {
                labelWorkers1WorkingCountValue.Text = $@"{workers1Working}";
                labelWorkers1WorkingRatioValue.Text = workers1WorkingRatio;
                labelWorkers1ReturnQueueLengthValue.Text = $@"{returnQueueLength}";
                labelWorkers1AvgWorkingCountValue.Text = $@"{workers1WorkingMean:0.000000}";
                labelWorkers1AvgWorkingRatioValue.Text = workers1WorkingRatioMean;
                labelWorkers1AvgReturnQueueLengthValue.Text = $@"{returnQueueLengthMean:0.000000}";
            });

            var workers2Working = _sim.Workers2Working;
            var workers2WorkingRatio = $"{100.0 * (workers2Working / (double)_sim.Workers2Count):0.0000} %";
            var toRepairQueueLength = _sim.CarsForRepairQueueLength;
            var repairedQueueLength = _sim.RepairedCarsQueueLength;
            var workers2WorkingMean = _sim.StatisticWorkers2Working.CurrentMean;
            var workers2WorkingRatioMean = $"{100.0 * (workers2WorkingMean / _sim.Workers2Count):0.0000} %";
            var toRepairQueueLengthMean = _sim.StatisticCarsForRepairQueueLength.CurrentMean;
            var repairedQueueLengthMean = _sim.StatisticRepairedQueueLength.CurrentMean;
            ExecuteOnGuiThread(groupBoxWorkers2Stats, () =>
            {
                labelWorkers2WorkingCountValue.Text = $@"{workers2Working}";
                labelWorkers2WorkingRatioValue.Text = workers2WorkingRatio;
                labelWorkers2ToRepairQueueLengthValue.Text = $@"{toRepairQueueLength}";
                labelWorkers2RepairedQueueLengthValue.Text = $@"{repairedQueueLength}";
                labelWorkers2AvgWorkingCountValue.Text = $@"{workers2WorkingMean:0.000000}";
                labelWorkers2AvgWorkingRatioValue.Text = workers2WorkingRatioMean;
                labelWorkers2AvgToRepairQueueLengthValue.Text = $@"{toRepairQueueLengthMean:0.000000}";
                labelWorkers2AvgRepairedQueueLengthValue.Text = $@"{repairedQueueLengthMean:0.000000}";
            });

            var carPark1OccupiedCount = _sim.CarPark1Occupied;
            var carPark1OccupiedRatio = $"{100.0 * (carPark1OccupiedCount / (double)_sim.CarPark1Capacity):0.0000} %";
            var carPark1OccupiedCountMean = _sim.StatisticCarPark1Occupied.CurrentMean;
            var carPark1OccupiedRatioMean = $"{100.0 * (carPark1OccupiedCountMean / _sim.CarPark1Capacity):0.0000} %";
            var carPark2OccupiedCount = _sim.CarPark2Occupied;
            var carPark2OccupiedRatio = $"{100.0 * (carPark2OccupiedCount / (double)_sim.CarPark2Capacity):0.0000} %";
            var carPark2OccupiedCountMean = _sim.StatisticCarPark2Occupied.CurrentMean;
            var carPark2OccupiedRatioMean = $"{100.0 * (carPark2OccupiedCountMean / _sim.CarPark2Capacity):0.0000} %";
            var carParkServiceCount = _sim.CarParkServiceOccupied;
            var carParkServiceCountMean = _sim.StatisticCarParkServiceOccupied.CurrentMean;
            ExecuteOnGuiThread(tabCarParks, () =>
            {
                labelCarPark1OccupiedCountValue.Text = $@"{carPark1OccupiedCount}";
                labelCarPark1OccupiedRatioValue.Text = carPark1OccupiedRatio;
                labelCarPark1AvgOccupiedCountValue.Text = $@"{carPark1OccupiedCountMean:0.000000}";
                labelCarPark1AvgOccupiedRatioValue.Text = carPark1OccupiedRatioMean;
                labelCarPark2OccupiedCountValue.Text = $@"{carPark2OccupiedCount}";
                labelCarPark2OccupiedRatioValue.Text = carPark2OccupiedRatio;
                labelCarPark2AvgOccupiedCountValue.Text = $@"{carPark2OccupiedCountMean:0.000000}";
                labelCarPark2AvgOccupiedRatioValue.Text = carPark2OccupiedRatioMean;
                labelCarParkServiceCountValue.Text = $@"{carParkServiceCount}";
                labelCarParkServiceAvgCountValue.Text = $@"{carParkServiceCountMean:0.000000}";
            });

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

            var carPark1 = new List<ParkingPlace>(_sim.AgentWorkshop.CarPark.Count);
            carPark1.AddRange(_sim.AgentWorkshop.CarPark);
            ExecuteOnGuiThread(dataGridViewCarPark1, () =>
            {
                dataGridViewCarPark1.DataSource = carPark1;
                dataGridViewCarPark1.Refresh();
            });

            var carPark2 = new List<ParkingPlace>(_sim.AgentService.CarPark.Count);
            carPark2.AddRange(_sim.AgentService.CarPark);
            ExecuteOnGuiThread(dataGridViewCarPark2, () =>
            {
                dataGridViewCarPark2.DataSource = carPark2;
                dataGridViewCarPark2.Refresh();
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

            var adInvestment = (double)spinBoxAdInvestment.Value;

            int? seed = null;
            if (!rangeWorkers1 && !rangeWorkers2)
            {
                var w1 = (int)spinBoxWorkers1.Value;
                var w2 = (int)spinBoxWorkers2.Value;
                if (radioButtonCustomSeed.Checked) seed = (int)spinBoxCustomSeed.Value;
                _thr = _sim.SingleRunAsync(replications, SimConfig.TotalReplicationDuration, w1, w2, adInvestment, seed);
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
            _thr = _sim.MultiRunAsync(replications, SimConfig.TotalReplicationDuration, w1Min, w1Max, w2Min, w2Max, adInvestment, seed);
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
            spinBoxAdInvestment.Enabled = !start;
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
