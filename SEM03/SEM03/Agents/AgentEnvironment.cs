using OSPABA;
using SEM03.ContinualAssistants;
using SEM03.Managers;
using SEM03.Simulation;
using SEM03.Statistics;

namespace SEM03.Agents
{
    public class AgentEnvironment : Agent
    {
        public StatCount CustomersArrivedTotal { get; private set; }
        public StatCount CustomersLeftTotal { get; private set; }
        public StatCount CustomersLeftServed { get; private set; }
        public StatCount CustomersLeftNotServed { get; private set; }

        public Stat StatisticTimeInService { get; private set; }

        public AgentEnvironment(int id, OSPABA.Simulation mySim, Agent parent)
            : base(id, mySim, parent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();

            StatisticTimeInService.Clear();

            CustomersArrivedTotal.Clear();
            CustomersLeftTotal.Clear();
            CustomersLeftServed.Clear();
            CustomersLeftNotServed.Clear();

            var message = new MsgCarService(MySim) { Addressee = FindAssistant(SimId.SCHEDULER_CUSTOMER_ARRIVAL) };
            MyManager.StartContinualAssistant(message);
        }

        private void Init()
        {
            new ManagerEnvironment(SimId.MANAGER_ENVIRONMENT, MySim, this);
            new SchedulerCustomerArrival(SimId.SCHEDULER_CUSTOMER_ARRIVAL, MySim, this);

            AddOwnMessage(Mc.CUSTOMER_LEFT);

            StatisticTimeInService = new Stat(MySim);

            CustomersArrivedTotal = new StatCount(MySim);
            CustomersLeftTotal = new StatCount(MySim);
            CustomersLeftServed = new StatCount(MySim);
            CustomersLeftNotServed = new StatCount(MySim);
        }
    }
}
