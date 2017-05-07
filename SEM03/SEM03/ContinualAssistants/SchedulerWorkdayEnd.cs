using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class SchedulerWorkdayEnd : Scheduler
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public SchedulerWorkdayEnd(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.WORKDAY_END);
        }

        //meta! sender="AgentService", id="104", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.WORKDAY_END;
            Hold(SimTimeHelper.Days(1.0), message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.WORKDAY_END:
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
