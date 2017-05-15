using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.ContinualAssistants
{
    public class ProcessCarReturn : Process
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public ProcessCarReturn(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
            MyAgent.AddOwnMessage(Mc.CAR_RETURN_FINISHED);
        }

        //meta! sender="AgentService", id="94", type="Start"
        public void ProcessStart(MessageForm message)
        {
            var msg = (MsgCarService) message;
            msg.WorkerWithCustomers.State = "Odovzdáva opravené auto";
            msg.Customer.State = "Preberá opravené auto";
            var time = MySim.GeneratorCarReturnDuration.Next();
            message.Code = Mc.CAR_RETURN_FINISHED;
            Hold(time, message);
        }

        public void ProcessDefault(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.CAR_RETURN_FINISHED:
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
