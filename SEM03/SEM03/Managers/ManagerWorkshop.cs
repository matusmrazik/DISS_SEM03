using OSPABA;
using SEM03.Agents;
using SEM03.Entities;
using SEM03.Simulation;
using Action = OSPABA.Action;

namespace SEM03.Managers
{
    public class ManagerWorkshop : Manager
    {
        public new AgentWorkshop MyAgent => (AgentWorkshop)base.MyAgent;

        public ManagerWorkshop(int id, OSPABA.Simulation mySim, Agent myAgent)
            : base(id, mySim, myAgent)
        {
            Init();
        }

        //meta! sender="AgentCarService", id="62", type="Request"
        public void ProcessReserveParkingPlace(MessageForm message)
        {
            ((Action)MyAgent.FindAssistant(SimId.ACTION_ASSIGN_PARKING_PLACE)).Execute(message);

            Response(message);
        }

        //meta! sender="AgentCarService", id="65", type="Request"
        public void ProcessRepairCar(MessageForm message)
        {
            ((Action)MyAgent.FindAssistant(SimId.ACTION_ASSIGN_MECHANIC)).Execute(message);

            var msg = (MsgCarService)message;
            if (msg.Mechanic == null)
            {
                MyAgent.OrdersQueue.Enqueue(msg);
                MyAgent.StatisticCarsForRepairQueueLength.AddSample(MyAgent.OrdersQueue.Count);
                return;
            }

            var parkingPlace = msg.ParkingPlace;
            msg.ParkingPlace = null;
            parkingPlace.SetFree();

            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CAR_REPAIR);
            StartContinualAssistant(message);

            var msgNew = new MsgCarService(MySim)
            {
                Code = Mc.PARKING_PLACE_FREE,
                Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE)
            };
            Notice(msgNew);
        }

        //meta! sender="ProcessCarRepair", id="100", type="Finish"
        public void ProcessFinish(MessageForm message)
        {
            message.Code = Mc.PARK_REPAIRED_CAR_TO_WORKSHOP;
            message.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
            Request(message);
        }

        //meta! sender="AgentCarService", id="85", type="Response"
        public void ProcessParkRepairedCarToWorkshop(MessageForm message)
        {
            var msg = (MsgCarService)message;
            var mechanic = msg.Mechanic;

            msg.Mechanic.StopWork();
            msg.Mechanic = null;

            message.Code = Mc.REPAIR_CAR;
            Response(message);

            TryRepairNextCar(mechanic);
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
                case Mc.PARK_REPAIRED_CAR_TO_WORKSHOP:
                    ProcessParkRepairedCarToWorkshop(message);
                    break;
                case Mc.Finish:
                    ProcessFinish(message);
                    break;
                case Mc.REPAIR_CAR:
                    ProcessRepairCar(message);
                    break;
                case Mc.RESERVE_PARKING_PLACE:
                    ProcessReserveParkingPlace(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }

        private bool TryRepairNextCar(Mechanic mechanic)
        {
            if (MyAgent.OrdersQueue.Count == 0)
            {
                return false;
            }

            var msg = MyAgent.OrdersQueue.Dequeue();
            MyAgent.StatisticCarsForRepairQueueLength.AddSample(MyAgent.OrdersQueue.Count);
            msg.Mechanic = mechanic;
            mechanic.StartWork(msg.Customer);
            var parkingPlace = msg.ParkingPlace;
            msg.ParkingPlace = null;
            parkingPlace.SetFree();
            msg.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CAR_REPAIR);
            StartContinualAssistant(msg);

            var msgNew = new MsgCarService(MySim)
            {
                Code = Mc.PARKING_PLACE_FREE,
                Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE)
            };
            Notice(msgNew);

            return true;
        }
    }
}
