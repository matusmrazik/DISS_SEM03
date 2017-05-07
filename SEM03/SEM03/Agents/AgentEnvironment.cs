using OSPABA;
using SEM03.ContinualAssistants;
using SEM03.Managers;
using SEM03.Simulation;

namespace SEM03.Agents
{
    public class AgentEnvironment : Agent
    {
        public AgentEnvironment(int id, OSPABA.Simulation mySim, Agent parent)
            : base(id, mySim, parent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();

            var message = new MsgCarService(MySim) { Addressee = FindAssistant(SimId.SCHEDULER_CUSTOMER_ARRIVAL) };
            MyManager.StartContinualAssistant(message);
        }

        private void Init()
        {
            new ManagerEnvironment(SimId.MANAGER_ENVIRONMENT, MySim, this);
            new SchedulerCustomerArrival(SimId.SCHEDULER_CUSTOMER_ARRIVAL, MySim, this);

            AddOwnMessage(Mc.CUSTOMER_LEFT);
        }
    }
}
