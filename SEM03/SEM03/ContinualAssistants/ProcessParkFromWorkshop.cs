using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessParkFromWorkshop : Process
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public ProcessParkFromWorkshop(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CUSTOMER_PARK_FROM_WORKSHOP_FINISHED);
        }

        //meta! sender="AgentService", id="92", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.StateVehicle = "Parkuje sa z dielne pred servis";
            msg.WorkerWithCustomers.State = "Parkuje opravené auto pred servis";
            message.Code = Mc.CUSTOMER_PARK_FROM_WORKSHOP_FINISHED;
            Hold(SimConfig.WORKSHOP_TO_CAR_PARK_TIME, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CUSTOMER_PARK_FROM_WORKSHOP_FINISHED:
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
