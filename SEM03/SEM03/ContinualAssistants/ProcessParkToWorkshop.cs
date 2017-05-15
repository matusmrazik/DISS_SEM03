using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessParkToWorkshop : Process
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public ProcessParkToWorkshop(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CUSTOMER_PARK_TO_WORKSHOP_FINISHED);
        }

        //meta! sender="AgentService", id="78", type="Start"
        public void ProcessStart(MessageForm message)
        {
            ((MsgCarService)message).WorkerWithCustomers.State = "Parkuje auto do dielne";
            message.Code = Mc.CUSTOMER_PARK_TO_WORKSHOP_FINISHED;
            Hold(SimConfig.CAR_PARK_TO_WORKSHOP_TIME, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CUSTOMER_PARK_TO_WORKSHOP_FINISHED:
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
