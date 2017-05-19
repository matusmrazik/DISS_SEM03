using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessCrossDepartureRamp : Process
    {
        public new AgentModel MyAgent => (AgentModel)base.MyAgent;

        public ProcessCrossDepartureRamp(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.DEPARTURE_RAMP_CROSSED);
        }

        //meta! sender="AgentModel", id="48", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.State = "Prechádza výstupnou rampou";
            msg.Customer.StateVehicle = "Prechádza výstupnou rampou";
            message.Code = Mc.DEPARTURE_RAMP_CROSSED;
            Hold(SimConfig.CROSS_RAMP_DURATION, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.DEPARTURE_RAMP_CROSSED:
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
