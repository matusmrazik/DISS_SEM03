using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.InstantAssistants
{
    public class ActionAssignMechanic : Action
    {
        public new AgentWorkshop MyAgent => (AgentWorkshop)base.MyAgent;

        public ActionAssignMechanic(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
        }

        public override void Execute(MessageForm message)
        {
            var msg = (MsgCarService)message;
            var mechanic = MyAgent.FindFreeWorker();
            if (mechanic == null)
            {
                msg.Mechanic = null;
                return;
            }

            mechanic.StartWork(msg.Customer);
            msg.Mechanic = mechanic;
        }
    }
}
