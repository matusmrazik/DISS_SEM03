using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.InstantAssistants
{
    public class ActionAssignWorker : Action
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public ActionAssignWorker(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
        }

        public override void Execute(MessageForm message)
        {
            var msg = (MsgCarService) message;
            var worker = MyAgent.FindFreeWorker();
            if (worker == null)
            {
                msg.WorkerWithCustomers = null;
                return;
            }

            worker.StartWork(msg.Customer);
            msg.WorkerWithCustomers = worker;
        }
    }
}
