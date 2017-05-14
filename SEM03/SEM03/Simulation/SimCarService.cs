using System;
using System.Threading;
using RandomLib;
using SEM03.Agents;
using SEM03.Logging;
using SEM03.Statistics;

namespace SEM03.Simulation
{
    public class SimCarService : OSPABA.Simulation
    {
        public event Action OnRunFinished;
        public event Action<int, int, double> OnBestWorkerCountFound;

        public bool Stopped { get; private set; }

        public int Seed { get; private set; }

        public int Workers1Count => AgentService.Workers.Count;
        public int Workers2Count => AgentWorkshop.Workers.Count;

        public int Workers1Working => AgentService.WorkersWorking;
        public int Workers2Working => AgentWorkshop.WorkersWorking;
        public int CustomerQueueLength => AgentService.OrdersQueue.Count;
        public int CarsForRepairQueueLength => AgentWorkshop.OrdersQueue.Count;
        public int RepairedCarsQueueLength => AgentService.RepairedQueue.Count;

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

        public Stat StatisticWaitForRepair => AgentService.StatisticWaitForRepair;
        public Stat StatisticWaitInQueue => AgentService.StatisticWaitInQueue;
        public WStat StatisticQueueLength => AgentService.StatisticQueueLength;
        public WStat StatisticCarsForRepairQueueLength => AgentWorkshop.StatisticCarsForRepairQueueLength;
        public WStat StatisticRepairedQueueLength => AgentService.StatisticRepairedQueueLength;
        public WStat StatisticReadyToReturnQueueLength => AgentService.StatisticReadyToReturnQueueLength;
        public Stat StatisticTimeInService => AgentEnvironment.StatisticTimeInService;
        public Stat StatisticIncomes => AgentService.StatisticIncomes;

        public Stat StatisticWaitForRepairTotal { get; private set; }
        public Stat StatisticWaitInQueueTotal { get; private set; }
        public Stat StatisticQueueLengthTotal { get; private set; }
        public Stat StatisticCarsForRepairQueueLengthTotal { get; private set; }
        public Stat StatisticRepairedQueueLengthTotal { get; private set; }
        public Stat StatisticReadyToReturnQueueLengthTotal { get; private set; }
        public Stat StatisticTimeInServiceTotal { get; private set; }
        public Stat StatisticServedPrecentageTotal { get; private set; }
        public Stat StatisticIncomesTotal { get; private set; }

        public SimCarService()
        {
            Init();
        }

        public void Init(int group1Workers, int group2Workers, int? seed = null)
        {
            Stopped = false;

            Seed = seed ?? new Random().Next();

            AgentService.SetWorkersCount(group1Workers);
            AgentWorkshop.SetWorkersCount(group2Workers);
            AgentWorkshop.SetCarParkPlaces(SimConfig.CAR_PARK_1_PARKING_PLACES);
            AgentService.SetCarParkPlaces(SimConfig.CAR_PARK_2_PARKING_PLACES);

            GeneratorSeed = new Random(Seed);
            GeneratorCustomerArrivals.Seed(GeneratorSeed.Next());
            GeneratorRepairCount.Seed(GeneratorSeed.Next());
            GeneratorRepairType.Seed(GeneratorSeed.Next());
            GeneratorSimpleRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorModerateRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorComplicatedRepairDuration.Seed(GeneratorSeed.Next());
            GeneratorOrderEntryDuration.Seed(GeneratorSeed.Next());
            GeneratorCarTakeoverDuration.Seed(GeneratorSeed.Next());
            GeneratorCarReturnDuration.Seed(GeneratorSeed.Next());
        }

        public void SingleRun(int replicationCount, double simEndTime, int workers1Count, int workers2Count, int? seed = null)
        {
            Init(workers1Count, workers2Count, seed);
            Simulate(replicationCount, simEndTime);
            if (!Stopped)
            {
                OnRunFinished?.Invoke();
            }
        }

        public Thread SingleRunAsync(int replicationCount, double simEndTime, int workers1Count, int workers2Count, int? seed = null)
        {
            var thread = new Thread(() => SingleRun(replicationCount, simEndTime, workers1Count, workers2Count, seed))
            {
                Name = "ABASim - simulation thread",
                IsBackground = true,
                Priority = ThreadPriority.Highest
            };
            thread.Start();
            return thread;
        }

        public void MultiRun(int replicationCount, double simEndTime, int workers1Min, int workers1Max, int workers2Min, int workers2Max, int? seed = null)
        {
            var seedGen = seed.HasValue ? new Random(seed.Value) : new Random();

            var result = new[] { 0.0, 0.0 };
            var bestResult = new[] { long.MaxValue, 0.0 };
            var bestWorkers1 = 0;
            var bestWorkers2 = 0;

            for (var w1 = workers1Min; w1 <= workers1Max; ++w1)
            {
                for (var w2 = workers2Min; w2 <= workers2Max; ++w2)
                {
                    Init(w1, w2, seedGen.Next());
                    Simulate(replicationCount, simEndTime);
                    if (Stopped) return;
                    result[0] = StatisticWaitForRepairTotal.Mean;
                    result[1] = StatisticIncomesTotal.Mean;
                    if (ComputeProfit(w1, w2, result[0], result[1]) > ComputeProfit(bestWorkers1, bestWorkers2, bestResult[0], bestResult[1]))
                    {
                        bestResult[0] = result[0];
                        bestResult[1] = result[1];
                        bestWorkers1 = w1;
                        bestWorkers2 = w2;
                    }
                }
            }

            if (Stopped) return;
            OnBestWorkerCountFound?.Invoke(bestWorkers1, bestWorkers2, ComputeProfit(bestWorkers1, bestWorkers2, bestResult[0], bestResult[1]));
            OnRunFinished?.Invoke();
        }

        public Thread MultiRunAsync(int replicationCount, double simEndTime, int workers1Min, int workers1Max, int workers2Min, int workers2Max, int? seed = null)
        {
            var thread = new Thread(() => MultiRun(replicationCount, simEndTime, workers1Min, workers1Max, workers2Min, workers2Max, seed))
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
        }

        protected override void PrepareReplication()
        {
            base.PrepareReplication();

            Logger.LogInfo($@"Beží replikácia {CurrentReplication + 1}");
        }

        protected override void ReplicationFinished()
        {
            base.ReplicationFinished();

            StatisticWaitForRepairTotal.AddSample(StatisticWaitForRepair.Mean);
            StatisticWaitInQueueTotal.AddSample(StatisticWaitInQueue.Mean);
            StatisticQueueLengthTotal.AddSample(StatisticQueueLength.Mean);
            StatisticCarsForRepairQueueLengthTotal.AddSample(StatisticCarsForRepairQueueLength.Mean);
            StatisticRepairedQueueLengthTotal.AddSample(StatisticRepairedQueueLength.Mean);
            StatisticReadyToReturnQueueLengthTotal.AddSample(StatisticReadyToReturnQueueLength.Mean);
            StatisticTimeInServiceTotal.AddSample(StatisticTimeInService.Mean);
            StatisticServedPrecentageTotal.AddSample((double)AgentEnvironment.CustomersLeftServed.Count / AgentEnvironment.CustomersLeftTotal.Count);
            StatisticIncomesTotal.AddSample(StatisticIncomes.Sum);
        }

        protected override void SimulationFinished()
        {
            base.SimulationFinished();

            Logger.LogInfo($@"Počet pracovníkov skupiny 1: {Workers1Count}");
            Logger.LogInfo($@"Počet pracovníkov skupiny 2: {Workers2Count}");
            Logger.LogInfo($@"Priemerný čas čakania na opravu: {SimTimeHelper.DurationAsString(StatisticWaitForRepairTotal.Mean)}");
            Logger.LogInfo($@"Priemerný čas čakania vo fronte: {SimTimeHelper.DurationAsString(StatisticWaitInQueueTotal.Mean)}");
            Logger.LogInfo($@"Priemerná dĺžka frontu čakajúcich: {StatisticQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet áut na opravu: {StatisticCarsForRepairQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet opravených áut: {StatisticRepairedQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný počet áut na odovzdanie: {StatisticReadyToReturnQueueLengthTotal.Mean:0.000000}");
            Logger.LogInfo($@"Priemerný čas strávený v servise: {SimTimeHelper.DurationAsString(StatisticTimeInServiceTotal.Mean)}");
            Logger.LogInfo($@"Priemerný pomer obslúžených zákazníkov: {StatisticServedPrecentageTotal.Mean * 100.0:0.000000} %");
            Logger.LogInfo($@"Priemerný zisk: {StatisticIncomesTotal.Mean:0.00} EUR");
        }

        private void Init()
        {
            Seed = new Random().Next();

            AgentModel = new AgentModel(SimId.AGENT_MODEL, this, null);
            AgentEnvironment = new AgentEnvironment(SimId.AGENT_ENVIRONMENT, this, AgentModel);
            AgentCarService = new AgentCarService(SimId.AGENT_CAR_SERVICE, this, AgentModel);
            AgentService = new AgentService(SimId.AGENT_SERVICE, this, AgentCarService);
            AgentWorkshop = new AgentWorkshop(SimId.AGENT_WORKSHOP, this, AgentCarService);

            GeneratorSeed = new Random(Seed);
            GeneratorCustomerArrivals = new ExponentialDistributionGenerator(SimConfig.TIME_BETWEEN_CUSTOMERS, GeneratorSeed.Next());
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

            StatisticWaitForRepairTotal = new Stat(this);
            StatisticWaitInQueueTotal = new Stat(this);
            StatisticQueueLengthTotal = new Stat(this);
            StatisticCarsForRepairQueueLengthTotal = new Stat(this);
            StatisticRepairedQueueLengthTotal = new Stat(this);
            StatisticReadyToReturnQueueLengthTotal = new Stat(this);
            StatisticTimeInServiceTotal = new Stat(this);
            StatisticServedPrecentageTotal = new Stat(this);
            StatisticIncomesTotal = new Stat(this);
        }

        private static double ComputeProfit(int workers1, int workers2, double averageWaitForRepairTime, double totalIncomes)
        {
            if (averageWaitForRepairTime > SimTimeHelper.Hours(6)) return double.MinValue;

            var duration = SimTimeHelper.ToDays(SimConfig.ReplicationDuration);
            var operatingExpenses = duration * SimConfig.OPERATING_EXPENSES_DAY;
            var workersCosts = workers1 * duration * SimConfig.WORKER_1_COSTS_DAY + workers2 * duration * SimConfig.WORKER_2_COSTS_DAY;
            return totalIncomes - operatingExpenses - workersCosts;
        }
    }
}
