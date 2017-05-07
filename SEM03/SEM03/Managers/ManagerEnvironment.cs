using System;
using OSPABA;
using SEM03.Agents;
using SEM03.Entities;
using SEM03.Simulation;

namespace SEM03.Managers
{
    public class ManagerEnvironment : Manager
    {
        public new AgentEnvironment MyAgent => (AgentEnvironment)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public ManagerEnvironment(int id, OSPABA.Simulation mySim, Agent myAgent)
            : base(id, mySim, myAgent)
        {
            Init();
        }

        //meta! sender="AgentModel", id="40", type="Notice"
        public void ProcessCustomerLeft(MessageForm message)
        {
        }

        //meta! sender="SchedulerCustomerArrival", id="42", type="Finish"
        public void ProcessFinish(MessageForm message)
        {
            var messageCopy = new MsgCarService(message);
            messageCopy.Addressee = MySim.FindAgent(SimId.AGENT_MODEL);
            messageCopy.Code = Mc.CUSTOMER_ARRIVED;
            messageCopy.Customer = new Customer(MySim);
            Notice(messageCopy);

            message.Addressee = MyAgent.FindAssistant(SimId.SCHEDULER_CUSTOMER_ARRIVAL);
            StartContinualAssistant(message);
        }

        public void ProcessDefault(MessageForm message)
        {
        }

        public void Init()
        {
        }

        public override void ProcessMessage(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.Finish:
                    ProcessFinish(message);
                    break;
                case Mc.CUSTOMER_LEFT:
                    ProcessCustomerLeft(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }
    }
}
