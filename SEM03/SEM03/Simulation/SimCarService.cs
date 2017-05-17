using System;
using System.Collections.Generic;
using System.Threading;
using RandomLib;
using SEM03.Agents;
using SEM03.Entities;
using SEM03.Logging;
using SEM03.Statistics;

namespace SEM03.Simulation
{
    public class SimCarService : OSPABA.Simulation
    {
        public event Action OnRunFinished;
        public event Action<int, int, double> OnBestWorkerCountFound;

        private int _carParkServiceOccupied;

        public bool Stopped { get; private set; }

        public int Seed { get; private set; }

        public List<Customer> Customers { get; private set; }

        public int CarParkServiceOccupied
        {
            get => _carParkServiceOccupied;
            set
            {
                _carParkServiceOccupied = value;
                StatisticCarParkServiceOccupied.AddSample(_carParkServiceOccupied);
            }
        }

        public int Workers1Count => AgentService.Workers.Count;
        public int Workers2Count => AgentWorkshop.Workers.Count;
        public int CarPark1Capacity => AgentWorkshop.CarPark.Count;
        public int CarPark2Capacity => AgentService.CarPark.Count;

        public int Workers1Working => AgentService.WorkersWorking;
        public int Workers2Working => AgentWorkshop.WorkersWorking;
        public int CarPark1Occupied => AgentWorkshop.CarParkOccupied;
        public int CarPark2Occupied => AgentService.CarParkOccupied;
        public int CustomerQueueLength => AgentService.QueueLength;
        public int CarsForRepairQueueLength => AgentWorkshop.OrdersQueue.Count;
        public int RepairedCarsQueueLength => AgentService.RepairedQueue.Count;
        public int ReturnQueueLength => AgentService.ReturnQueue.Count;

        public AgentModel AgentModel { get; private set; }
        public AgentEnvironment AgentEnvironment { get; private set; }
        public AgentCarService AgentCarService { get; private set; }
        public AgentService AgentService { get; private set; }
        public AgentWorkshop AgentWorkshop { get; private set; }

        public Random GeneratorSeed { get; private set; }
        public ExponentialDistributionGenerator GeneratorCustomerArrivals { get; private set; }
        public EmpiricalIntDistributionGenerator GeneratorRepairCount { get; private set; }
        public EmpiricalIntDistributionGenerator GeneratorRepairType { get; private set; }
        public UniformIntDistributionGenerator GeneratorSimpleRepairDuration { get; private set; }
        public EmpiricalIntDistributionGenerator GeneratorModerateRepairDuration { get; private set; }
        public UniformIntDistributionGenerator GeneratorComplicatedRepairDuration { get; private set; }
        public UniformRealDistributionGenerator GeneratorOrderEntryDuration { get; private set; }
        public UniformRealDistributionGenerator GeneratorCarTakeoverDuration { get; private set; }
        public UniformRealDistributionGenerator GeneratorCarReturnDuration { get; private set; }

        public WStat StatisticCustomersInService { get; private set; }
        public WStat StatisticCarParkServiceOccupied { get; private set; }
        public Stat StatisticWaitForRepair => AgentService.StatisticWaitForRepair;
        public Stat StatisticWaitInQueue => AgentService.StatisticWaitInQueue;
        public WStat StatisticQueueLength => AgentService.StatisticQueueLength;
        public WStat StatisticCarsForRepairQueueLength => AgentWorkshop.StatisticCarsForRepairQueueLength;
        public WStat StatisticRepairedQueueLength => AgentService.StatisticRepairedQueueLength;
        public WStat StatisticReadyToReturnQueueLength => AgentService.StatisticReadyToReturnQueueLength;
        public Stat StatisticTimeInService => AgentEnvironment.StatisticTimeInService;
        public Stat StatisticIncomes => AgentService.StatisticIncomes;
        public WStat StatisticWorkers1Working => AgentService.StatisticWorkersWorking;
        public WStat StatisticWorkers2Working => AgentWorkshop.StatisticWorkersWorking;
        public WStat StatisticCarPark1Occupied => AgentWorkshop.StatisticCarParkOccupied;
        public WStat StatisticCarPark2Occupied => AgentService.StatisticCarParkOccupied;

        public Stat StatisticWaitForRepairTotal { get; private set; }
        public Stat StatisticWaitInQueueTotal { get; private set; }
        public Stat StatisticQueueLengthTotal { get; private set; }
        public Stat StatisticCarsForRepairQueueLengthTotal { get; private set; }
        public Stat StatisticRepairedQueueLengthTotal { get; private set; }
        public Stat StatisticReadyToReturnQueueLengthTotal { get; private set; }
        public Stat StatisticTimeInServiceTotal { get; private set; }
        public Stat StatisticServedPrecentageTotal { get; private set; }
        public Stat StatisticIncomesTotal { get; private set; }
        public Stat StatisticProfitTotal { get; private set; }
        public Stat StatisticCustomersInServiceTotal { get; private set; }
        public Stat StatisticWorkers1WorkingTotal { get; private set; }
        public Stat StatisticWorkers2WorkingTotal { get; private set; }
        public Stat StatisticCarPark1OccupiedTotal { get; private set; }
        public Stat StatisticCarPark2OccupiedTotal { get; private set; }
        public Stat StatisticCarParkServiceOccupiedTotal { get; private set; }

        public double ReplicationOperatingExpenses => SimTimeHelper.ToDays(SimConfig.ReplicationDuration) * SimConfig.OPERATING_EXPENSES_DAY;
        public double ReplicationWorkers1Expenses => Workers1Count * SimTimeHelper.ToDays(SimConfig.ReplicationDuration) * SimConfig.WORKER_1_COSTS_DAY;
        public double ReplicationWorkers2Expenses => Workers2Count * SimTimeHelper.ToDays(SimConfig.ReplicationDuration) * SimConfig.WORKER_2_COSTS_DAY;
        public double ReplicationAdvertisingExpenses => SimTimeHelper.ToDays(SimConfig.ReplicationDuration) * SimConfig.AdvertisingInvestmentDay;
        public double ReplicationTotalExpenses => ReplicationOperatingExpenses + ReplicationWorkers1Expenses + ReplicationWorkers2Expenses + ReplicationAdvertisingExpenses;

        public SimCarService()
        {
            Init();
        }

        public void Init(int group1Workers, int group2Workers, double advertisingInvestment, int? seed = null)
        {
            Stopped = false;

            Seed = seed ?? new Random().Next();

            SimConfig.AdvertisingInvestmentMonth = advertisingInvestment;

            AgentService.SetWorkersCount(group1Workers);
            AgentWorkshop.SetWorkersCount(group2Workers);
            AgentWorkshop.SetCarParkPlaces(SimConfig.CAR_PARK_1_PARKING_PLACES);
            AgentService.SetCarParkPlaces(SimConfig.CAR_PARK_2_PARKING_PLACES);

            GeneratorSeed = new Random(Seed);
            GeneratorCustomerArrivals = new ExponentialDistributionGenerator(SimConfig.TimeBetweenCustomers, GeneratorSeed.Next());
            GeneratorRepairCount.Seed(GeneratorSeed.Next());
            GeneratorRepairType.Seed(GeneratorSeed.Next());
            GeneratorSimpleRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorModerateRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorComplicatedRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorOrderEntryDuration.Seed(GeneratorSeed.Next());
            GeneratorCarTakeoverDuration.Seed(GeneratorSeed.Next());
            GeneratorCarReturnDuration.Seed(GeneratorSeed.Next());
        }

        public void SingleRun(int replicationCount, double simEndTime, int workers1Count, int workers2Count, double advertisingInvestment, int? seed = null)
        {
            Init(workers1Count, workers2Count, advertisingInvestment, seed);
            Simulate(replicationCount, simEndTime);

            if (Stopped) return;
            OnRunFinished?.Invoke();
        }

        public Thread SingleRunAsync(int replicationCount, double simEndTime, int workers1Count, int workers2Count, double advertisingInvestment, int? seed = null)
        {
            var thread = new Thread(() => SingleRun(replicationCount, simEndTime, workers1Count, workers2Count, advertisingInvestment, seed))
            {
                Name = "ABASim - simulation thread",
                IsBackground = true,
                Priority = ThreadPriority.Highest
            };
            thread.Start();
            return thread;
        }

        public void MultiRun(int replicationCount, double simEndTime, int workers1Min, int workers1Max, int workers2Min, int workers2Max, double advertisingInvestment, int? seed = null)
        {
            var seedGen = seed.HasValue ? new Random(seed.Value) : new Random();

            var bestResultValue = double.MinValue;

            for (var w1 = workers1Min; w1 <= workers1Max; ++w1)
            {
                for (var w2 = workers2Min; w2 <= workers2Max; ++w2)
                {
                    Init(w1, w2, advertisingInvestment, seedGen.Next());
                    Simulate(replicationCount, simEndTime);
                    if (Stopped) return;
                    var resultValue = ResultValue();
                    if (resultValue > bestResultValue)
                    {
                        bestResultValue = resultValue;
                        OnBestWorkerCountFound?.Invoke(w1, w2, resultValue);
                    }
                }
            }

            if (Stopped) return;
            OnRunFinished?.Invoke();
        }

        public Thread MultiRunAsync(int replicationCount, double simEndTime, int workers1Min, int workers1Max, int workers2Min, int workers2Max, double advertisingInvestment, int? seed = null)
        {
            var thread = new Thread(() => MultiRun(replicationCount, simEndTime, workers1Min, workers1Max, workers2Min, workers2Max, advertisingInvestment, seed))
            {
                Name = "ABASim - simulation thread",
                IsBackground = true,
                Priority = ThreadPriority.Highest
            };
            thread.Start();
            return thread;
        }

        public new void StopSimulation()
        {
            base.StopSimulation();
            Stopped = true;
        }

        protected override void PrepareSimulation()
        {
            base.PrepareSimulation();

            Stopped = false;

            StatisticWaitForRepair.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticWaitInQueue.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticQueueLength.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticCarsForRepairQueueLength.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticRepairedQueueLength.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticReadyToReturnQueueLength.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticTimeInService.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticIncomes.IgnoreBefore = SimConfig.HEAT_UP_TIME;
            StatisticWaitForRepair.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticWaitInQueue.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticQueueLength.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticCarsForRepairQueueLength.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticRepairedQueueLength.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticReadyToReturnQueueLength.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticTimeInService.IgnoreAfter = SimConfig.ReplicationEndTime;
            StatisticIncomes.IgnoreAfter = SimConfig.ReplicationEndTime;

            StatisticWaitForRepairTotal.Clear();
            StatisticWaitInQueueTotal.Clear();
            StatisticQueueLengthTotal.Clear();
            StatisticCarsForRepairQueueLengthTotal.Clear();
            StatisticRepairedQueueLengthTotal.Clear();
            StatisticReadyToReturnQueueLengthTotal.Clear();
            StatisticTimeInServiceTotal.Clear();
            StatisticServedPrecentageTotal.Clear();
            StatisticIncomesTotal.Clear();
            StatisticProfitTotal.Clear();
            StatisticCustomersInServiceTotal.Clear();
            StatisticWorkers1WorkingTotal.Clear();
            StatisticWorkers2WorkingTotal.Clear();
            StatisticCarPark1OccupiedTotal.Clear();
            StatisticCarPark2OccupiedTotal.Clear();
            StatisticCarParkServiceOccupiedTotal.Clear();
        }

        protected override void PrepareReplication()
        {
            base.PrepareReplication();

            Customers.Clear();
            StatisticCustomersInService.Clear();
            StatisticCarParkServiceOccupied.Clear();

            _carParkServiceOccupied = 0;

            //Logger.LogInfo($@"Beží replikácia {CurrentReplication + 1}");
        }

        protected override void ReplicationFinished()
        {
            StatisticWaitForRepairTotal.AddSample(StatisticWaitForRepair.Mean);
            StatisticWaitInQueueTotal.AddSample(StatisticWaitInQueue.Mean);
            StatisticQueueLengthTotal.AddSample(StatisticQueueLength.Mean);
            StatisticCarsForRepairQueueLengthTotal.AddSample(StatisticCarsForRepairQueueLength.Mean);
            StatisticRepairedQueueLengthTotal.AddSample(StatisticRepairedQueueLength.Mean);
            StatisticReadyToReturnQueueLengthTotal.AddSample(StatisticReadyToReturnQueueLength.Mean);
            StatisticTimeInServiceTotal.AddSample(StatisticTimeInService.Mean);
            StatisticServedPrecentageTotal.AddSample((double)AgentEnvironment.CustomersLeftServed.Count / AgentEnvironment.CustomersLeftTotal.Count);
            StatisticIncomesTotal.AddSample(StatisticIncomes.Sum);
            StatisticProfitTotal.AddSample(StatisticIncomes.Sum - ReplicationTotalExpenses);
            StatisticCustomersInServiceTotal.AddSample(StatisticCustomersInService.Mean);
            StatisticWorkers1WorkingTotal.AddSample(StatisticWorkers1Working.Mean);
            StatisticWorkers2WorkingTotal.AddSample(StatisticWorkers2Working.Mean);
            StatisticCarPark1OccupiedTotal.AddSample(StatisticCarPark1Occupied.Mean);
            StatisticCarPark2OccupiedTotal.AddSample(StatisticCarPark2Occupied.Mean);
            StatisticCarParkServiceOccupiedTotal.AddSample(StatisticCarParkServiceOccupied.Mean);

            base.ReplicationFinished();
        }

        protected override void SimulationFinished()
        {
            var days = (int)(SimConfig.ReplicationDuration / SimTimeHelper.DAY);
            var restOfTime = SimConfig.ReplicationDuration - days * SimTimeHelper.DAY;

            Logger.NewLine();
            Logger.LogInfo($@"Počet pracovníkov skupiny 1: {Workers1Count}");
            Logger.LogInfo($@"Počet pracovníkov skupiny 2: {Workers2Count}");
            Logger.LogInfo($@"Dĺžka jednej replikácie: {days} dní, {SimTimeHelper.DurationAsString(restOfTime)}");
            Logger.LogInfo($@"Priemerný počet zákazníkov za hodinu: {SimConfig.CustomersPerHour:0.000000}");
            Logger.LogInfo($@"Priemerný čas medzi zákazníkmi: {SimTimeHelper.DurationAsString(SimConfig.TimeBetweenCustomers)}");
            Logger.LogInfo($@"Priemerný čas čakania na opravu: {SimTimeHelper.DurationAsString(StatisticWaitForRepairTotal.Mean)}");
            Logger.LogInfo($@"Priemerný čas čakania vo fronte: {SimTimeHelper.DurationAsString(StatisticWaitInQueueTotal.Mean)}");
            Logger.LogInfo($@"Priemerná dĺžka frontu čakajúcich: {StatisticQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet áut na opravu: {StatisticCarsForRepairQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet opravených áut: {StatisticRepairedQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet áut na odovzdanie: {StatisticReadyToReturnQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný čas strávený v servise: {SimTimeHelper.DurationAsString(StatisticTimeInServiceTotal.Mean)}");
            Logger.LogInfo($@"Priemerný pomer obslúžených zákazníkov: {StatisticServedPrecentageTotal.Mean * 100.0:0.000000} %");
            Logger.LogInfo($@"Priemerný zisk: {StatisticIncomesTotal.Mean:0.00} EUR");
            Logger.LogInfo($@"Prevádzkové náklady: {ReplicationOperatingExpenses:0.00} EUR");
            Logger.LogInfo($@"Náklady na pracovníkov skupiny 1: {ReplicationWorkers1Expenses:0.00} EUR");
            Logger.LogInfo($@"Náklady na pracovníkov skupiny 2: {ReplicationWorkers2Expenses:0.00} EUR");
            Logger.LogInfo($@"Náklady na reklamu: {ReplicationAdvertisingExpenses:0.00} EUR");
            Logger.LogInfo($@"Celkové náklady: {ReplicationTotalExpenses:0.00} EUR");
            Logger.LogInfo($@"Priemerný hospodársky výsledok: {StatisticProfitTotal.Mean:0.00} EUR");

            base.SimulationFinished();
        }

        private void Init()
        {
            Seed = new Random().Next();

            Customers = new List<Customer>();

            AgentModel = new AgentModel(SimId.AGENT_MODEL, this, null);
            AgentEnvironment = new AgentEnvironment(SimId.AGENT_ENVIRONMENT, this, AgentModel);
            AgentCarService = new AgentCarService(SimId.AGENT_CAR_SERVICE, this, AgentModel);
            AgentService = new AgentService(SimId.AGENT_SERVICE, this, AgentCarService);
            AgentWorkshop = new AgentWorkshop(SimId.AGENT_WORKSHOP, this, AgentCarService);

            GeneratorSeed = new Random(Seed);
            GeneratorCustomerArrivals = new ExponentialDistributionGenerator(SimConfig.TimeBetweenCustomers, GeneratorSeed.Next());
            GeneratorRepairCount = new EmpiricalIntDistributionGenerator(new[]
            {
                new EmpiricalIntDistributionGenerator.IntervalDefinition(1, 2, 0.0544),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(2, 3, 0.3206),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(3, 4, 0.3061),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(4, 5, 0.2109),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(5, 6, 0.0986),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(6, 7, 0.0094)
            }, GeneratorSeed.Next());
            GeneratorRepairType = new EmpiricalIntDistributionGenerator(new[]
            {
                new EmpiricalIntDistributionGenerator.IntervalDefinition(0, 1, 0.7),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(1, 2, 0.2),
                new EmpiricalIntDistributionGenerator.IntervalDefinition(2, 3, 0.1)
            }, GeneratorSeed.Next());
            GeneratorSimpleRepairDuration = new UniformIntDistributionGenerator((int)SimTimeHelper.Minutes(2), (int)SimTimeHelper.Minutes(20), GeneratorSeed.Next());
            GeneratorModerateRepairDuration = new EmpiricalIntDistributionGenerator(new[]
            {
                new EmpiricalIntDistributionGenerator.IntervalDefinition((int)SimTimeHelper.Minutes(10), (int)SimTimeHelper.Minutes(40), 0.1),
                new EmpiricalIntDistributionGenerator.IntervalDefinition((int)SimTimeHelper.Minutes(41), (int)SimTimeHelper.Minutes(61), 0.6),
                new EmpiricalIntDistributionGenerator.IntervalDefinition((int)SimTimeHelper.Minutes(62), (int)SimTimeHelper.Minutes(100), 0.3)
            }, GeneratorSeed.Next());
            GeneratorComplicatedRepairDuration = new UniformIntDistributionGenerator((int)SimTimeHelper.Minutes(120), (int)SimTimeHelper.Minutes(260), GeneratorSeed.Next());
            GeneratorOrderEntryDuration = new UniformRealDistributionGenerator(70, 310, GeneratorSeed.Next());
            GeneratorCarTakeoverDuration = new UniformRealDistributionGenerator(80, 160, GeneratorSeed.Next());
            GeneratorCarReturnDuration = new UniformRealDistributionGenerator(123, 257, GeneratorSeed.Next());

            _carParkServiceOccupied = 0;

            StatisticCustomersInService = new WStat(this);
            StatisticCarParkServiceOccupied = new WStat(this);

            StatisticWaitForRepairTotal = new Stat(this);
            StatisticWaitInQueueTotal = new Stat(this);
            StatisticQueueLengthTotal = new Stat(this);
            StatisticCarsForRepairQueueLengthTotal = new Stat(this);
            StatisticRepairedQueueLengthTotal = new Stat(this);
            StatisticReadyToReturnQueueLengthTotal = new Stat(this);
            StatisticTimeInServiceTotal = new Stat(this);
            StatisticServedPrecentageTotal = new Stat(this);
            StatisticIncomesTotal = new Stat(this);
            StatisticProfitTotal = new Stat(this);
            StatisticCustomersInServiceTotal = new Stat(this);
            StatisticWorkers1WorkingTotal = new Stat(this);
            StatisticWorkers2WorkingTotal = new Stat(this);
            StatisticCarPark1OccupiedTotal = new Stat(this);
            StatisticCarPark2OccupiedTotal = new Stat(this);
            StatisticCarParkServiceOccupiedTotal = new Stat(this);
        }

        private double ResultValue()
        {
            return ResultValue(Workers1Count, Workers2Count, SimConfig.ReplicationDuration, StatisticWaitForRepairTotal.Mean, StatisticIncomesTotal.Mean, SimConfig.AdvertisingInvestmentTotal); // StatisticProfitTotal.Mean;
        }

        private static double ResultValue(int workers1, int workers2, double duration, double averageWaitForRepairTime, double totalIncomes, double advertisingInvestment)
        {
            if (averageWaitForRepairTime > SimConfig.MAX_WAIT_FOR_REPAIR_TIME)
            {
                return double.MinValue;
            }
            return MonthlyProfit(workers1, workers2, duration, totalIncomes, advertisingInvestment);
        }

        private static double MonthlyProfit(int workers1, int workers2, double duration, double totalIncomes, double advertisingInvestment)
        {
            return (totalIncomes - Expenses(workers1, workers2, duration, advertisingInvestment)) / (duration / SimTimeHelper.MONTH);
        }

        private static double Expenses(int workers1, int workers2, double duration, double advertisingInvestment)
        {
            var durationDays = SimTimeHelper.ToDays(duration);
            var operatingExpenses = durationDays * SimConfig.OPERATING_EXPENSES_DAY;
            var workersCosts = workers1 * durationDays * SimConfig.WORKER_1_COSTS_DAY + workers2 * durationDays * SimConfig.WORKER_2_COSTS_DAY;
            return operatingExpenses + workersCosts + advertisingInvestment;
        }
    }
}
