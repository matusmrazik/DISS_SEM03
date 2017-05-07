using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.InstantAssistants
{
    public class ActionParkRepairedCar : Action
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public ActionParkRepairedCar(int id, OSPABA.Simulation mySim, CommonAgent myAgent)
            : base(id, mySim, myAgent)
        {
        }

        public override void Execute(MessageForm message)
        {
            var msg = (MsgCarService)message;
            var parkingPlace = MyAgent.FindFreeParkingPlace();
            if (parkingPlace == null)
            {
                msg.ParkingPlace = null;
                return;
            }

            parkingPlace.SetOccupied();
            msg.ParkingPlace = parkingPlace;
        }
    }
}
