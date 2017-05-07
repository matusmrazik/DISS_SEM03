using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessParkCar : Process
    {
        public new AgentModel MyAgent => (AgentModel)base.MyAgent;

        public ProcessParkCar(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.PARK_CAR_FINISHED);
        }

        //meta! sender="AgentModel", id="50", type="Start"
        public void ProcessStart(MessageForm message)
        {
            message.Code = Mc.PARK_CAR_FINISHED;
            Hold(SimConfig.RAMP_TO_CAR_PARK_TIME, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.PARK_CAR_FINISHED:
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
