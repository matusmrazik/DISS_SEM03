using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessCarTakeover : Process
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public ProcessCarTakeover(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CUSTOMER_CAR_TAKEOVER_FINISHED);
        }

        //meta! sender="AgentService", id="76", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService) message;
            msg.Customer.State = "Odovzdáva auto";
            msg.WorkerWithCustomers.State = "Preberá auto";
            var time = MySim.GeneratorCarTakeoverDuration.Next();
            message.Code = Mc.CUSTOMER_CAR_TAKEOVER_FINISHED;
            Hold(time, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CUSTOMER_CAR_TAKEOVER_FINISHED:
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
