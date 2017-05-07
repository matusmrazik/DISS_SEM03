using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class SchedulerCustomerArrival : Scheduler
    {
        public new AgentEnvironment MyAgent => (AgentEnvironment)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public SchedulerCustomerArrival(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.NEW_CUSTOMER);
        }

        //meta! sender="AgentEnvironment", id="42", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.NEW_CUSTOMER;
            var time = MySim.GeneratorCustomerArrivals.Next();
            Hold(time, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.NEW_CUSTOMER:
                    AssistantFinished(message);
                    break;
            }
        }

        public override void ProcessMessage(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.Start:
                    ProcessStart(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }
    }
}
