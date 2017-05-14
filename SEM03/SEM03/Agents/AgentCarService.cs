using OSPABA;
using SEM03.Managers;
using SEM03.Simulation;

namespace SEM03.Agents
{
    public class AgentCarService : Agent
    {
        public AgentCarService(int id, OSPABA.Simulation mySim, Agent parent)
            : base(id, mySim, parent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();
            // Setup component for the next replication
        }

        private void Init()
        {
            new ManagerCarService(SimId.MANAGER_CAR_SERVICE, MySim, this);

            AddOwnMessage(Mc.CUSTOMER_SERVICE);
            AddOwnMessage(Mc.RESERVE_PARKING_PLACE);
            AddOwnMessage(Mc.RETURN_REPAIRED_CAR);
            AddOwnMessage(Mc.PARKING_PLACE_FREE);
            AddOwnMessage(Mc.PROCESS_ORDER_SERVICE);
            AddOwnMessage(Mc.REPAIR_CAR);
            AddOwnMessage(Mc.PARK_REPAIRED_CAR_TO_WORKSHOP);
            AddOwnMessage(Mc.PARK_REPAIRED_CAR);
            AddOwnMessage(Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP);
        }
    }
}
