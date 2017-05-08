using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessOrderEntry : Process
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public ProcessOrderEntry(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CUSTOMER_ORDER_ENTRY_FINISHED);
        }

        //meta! sender="AgentService", id="73", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.GenerateRepairDuration();
            msg.Customer.WaitInQueueFinished();
            MyAgent.StatisticWaitInQueue.AddSample(msg.Customer.WaitInQueueTotal);
            var time = MySim.GeneratorOrderEntryDuration.Next();
            message.Code = Mc.CUSTOMER_ORDER_ENTRY_FINISHED;
            Hold(time, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CUSTOMER_ORDER_ENTRY_FINISHED:
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
