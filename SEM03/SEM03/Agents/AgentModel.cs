using OSPABA;
using SEM03.ContinualAssistants;
using SEM03.Managers;
using SEM03.Simulation;

namespace SEM03.Agents
{
    public class AgentModel : Agent
    {
        public AgentModel(int id, OSPABA.Simulation mySim, Agent parent)
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
            new ManagerModel(SimId.MANAGER_MODEL, MySim, this);
            new ProcessLeaveCarPark(SimId.PROCESS_LEAVE_CAR_PARK, MySim, this);
            new ProcessParkCar(SimId.PROCESS_PARK_CAR, MySim, this);
            new ProcessCrossDepartureRamp(SimId.PROCESS_CROSS_DEPARTURE_RAMP, MySim, this);
            new ProcessCrossArrivalRamp(SimId.PROCESS_CROSS_ARRIVAL_RAMP, MySim, this);

            AddOwnMessage(Mc.CUSTOMER_ARRIVED);
            AddOwnMessage(Mc.CUSTOMER_SERVICE);
        }
    }
}
