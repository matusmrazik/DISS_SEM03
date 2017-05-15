using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessCarRepair : Process
    {
        public new AgentWorkshop MyAgent => (AgentWorkshop)base.MyAgent;

        public ProcessCarRepair(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CAR_REPAIR_FINISHED);
        }

        //meta! sender="AgentWorkshop", id="100", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Mechanic.State = "Opravuje auto";
            var time = msg.Customer.TotalRepairDuration;
            message.Code = Mc.CAR_REPAIR_FINISHED;
            Hold(time, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CAR_REPAIR_FINISHED:
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
