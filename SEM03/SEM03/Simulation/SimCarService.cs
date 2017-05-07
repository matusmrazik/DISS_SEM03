using System;
using RandomLib;
using SEM03.Agents;

namespace SEM03.Simulation
{
    public class SimCarService : OSPABA.Simulation
    {
        public int Seed { get; private set; }

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

        public SimCarService()
        {
            Init();
        }

        public void Init(int group1Workers, int group2Workers, int? seed = null)
        {
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

        protected override void PrepareSimulation()
        {
            base.PrepareSimulation();
            // Create global statistcis
        }

        protected override void PrepareReplication()
        {
            base.PrepareReplication();
            // Reset entities, queues, local statistics, etc...
        }

        protected override void ReplicationFinished()
        {
            base.ReplicationFinished();
            // Collect local statistics into global, update UI, etc...
        }

        protected override void SimulationFinished()
        {
            base.SimulationFinished();
            // Display simulation results
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
        }
    }
}
