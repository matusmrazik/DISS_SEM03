using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessLeaveCarPark : Process
    {
        public new AgentModel MyAgent => (AgentModel)base.MyAgent;

        public ProcessLeaveCarPark(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.LEAVE_CAR_PARK_FINISHED);
        }

        //meta! sender="AgentModel", id="52", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.LEAVE_CAR_PARK_FINISHED;
            Hold(SimConfig.RAMP_TO_CAR_PARK_TIME, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.LEAVE_CAR_PARK_FINISHED:
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
