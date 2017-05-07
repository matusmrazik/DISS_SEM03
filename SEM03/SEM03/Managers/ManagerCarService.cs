using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.Managers
{
    public class ManagerCarService : Manager
    {
        public new AgentCarService MyAgent => (AgentCarService)base.MyAgent;

        public ManagerCarService(int id, OSPABA.Simulation mySim, Agent myAgent)
            : base(id, mySim, myAgent)
        {
            Init();
        }

        //meta! sender="AgentModel", id="54", type="Request"
        public void ProcessCustomerService(MessageForm message)
        {
            message.Code = Mc.PROCESS_ORDER_SERVICE;
            message.Addressee = MySim.FindAgent(SimId.AGENT_SERVICE);
            Request(message);
        }

        //meta! sender="AgentWorkshop", id="62", type="Response"
        public void ProcessReserveParkingPlace(MessageForm message)
        {
            message.Code = Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP;
            Response(message);
        }

        //meta! sender="AgentService", id="66", type="Response"
        public void ProcessReturnRepairedCar(MessageForm message)
        {
            message.Code = Mc.CUSTOMER_SERVICE;
            Response(message);
        }

        //meta! sender="AgentService", id="60", type="Response"
        public void ProcessProcessOrderService(MessageForm message)
        {
            message.Code = Mc.REPAIR_CAR;
            message.Addressee = MySim.FindAgent(SimId.AGENT_WORKSHOP);
            Request(message);
        }

        //meta! sender="AgentWorkshop", id="65", type="Response"
        public void ProcessRepairCar(MessageForm message)
        {
            message.Code = Mc.RETURN_REPAIRED_CAR;
            message.Addressee = MySim.FindAgent(SimId.AGENT_SERVICE);
            Request(message);
        }

        //meta! sender="AgentWorkshop", id="85", type="Request"
        public void ProcessParkRepairedCarToWorkshop(MessageForm message)
        {
            message.Code = Mc.PARK_REPAIRED_CAR;
            message.Addressee = MySim.FindAgent(SimId.AGENT_SERVICE);
            Request(message);
        }

        //meta! sender="AgentService", id="80", type="Response"
        public void ProcessParkRepairedCar(MessageForm message)
        {
            message.Code = Mc.PARK_REPAIRED_CAR_TO_WORKSHOP;
            Response(message);
        }

        //meta! sender="AgentService", id="83", type="Request"
        public void ProcessReserveParkingPlaceInWorkshop(MessageForm message)
        {
            message.Code = Mc.RESERVE_PARKING_PLACE;
            message.Addressee = MySim.FindAgent(SimId.AGENT_WORKSHOP);
            Request(message);
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
                case Mc.PARK_REPAIRED_CAR:
                    ProcessParkRepairedCar(message);
                    break;
                case Mc.PROCESS_ORDER_SERVICE:
                    ProcessProcessOrderService(message);
                    break;
                case Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP:
                    ProcessReserveParkingPlaceInWorkshop(message);
                    break;
                case Mc.REPAIR_CAR:
                    ProcessRepairCar(message);
                    break;
                case Mc.RETURN_REPAIRED_CAR:
                    ProcessReturnRepairedCar(message);
                    break;
                case Mc.CUSTOMER_SERVICE:
                    ProcessCustomerService(message);
                    break;
                case Mc.RESERVE_PARKING_PLACE:
                    ProcessReserveParkingPlace(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }
    }
}
