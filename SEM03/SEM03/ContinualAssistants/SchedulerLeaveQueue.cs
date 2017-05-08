using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class SchedulerLeaveQueue : Scheduler
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public SchedulerLeaveQueue(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.LEAVE_QUEUE);
        }

        //meta! sender="AgentService", id="118", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.LEAVE_QUEUE;
            Hold(SimConfig.MAX_WAIT_IN_QUEUE_TIME, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.LEAVE_QUEUE:
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
