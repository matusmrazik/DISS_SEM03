using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessCrossArrivalRamp : Process
    {
        public new AgentModel MyAgent => (AgentModel)base.MyAgent;

        public ProcessCrossArrivalRamp(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.ARRIVAL_RAMP_CROSSED);
        }

        //meta! sender="AgentModel", id="46", type="Start"
        public void ProcessStart(MessageForm message)
        {
            ((MsgCarService)message).Customer.State = "Prechádza vstupnou rampou";
            message.Code = Mc.ARRIVAL_RAMP_CROSSED;
            Hold(SimConfig.CROSS_RAMP_DURATION, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.ARRIVAL_RAMP_CROSSED:
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
