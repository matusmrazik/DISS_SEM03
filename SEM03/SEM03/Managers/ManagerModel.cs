using System.Collections.Generic;
using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.Managers
{
    public class ManagerModel : Manager
    {
        public new AgentModel MyAgent => (AgentModel)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

        public bool ArrivalRampOpen { get; private set; }
        public bool DepartureRampOpen { get; private set; }
        public Queue<MsgCarService> ArrivalRampQueue { get; private set; }
        public Queue<MsgCarService> DepartureRampQueue { get; private set; }

        public ManagerModel(int id, OSPABA.Simulation mySim, Agent myAgent)
            : base(id, mySim, myAgent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();

            ArrivalRampOpen = false;
            DepartureRampOpen = false;

            ArrivalRampQueue.Clear();
            DepartureRampQueue.Clear();
        }

        //meta! sender="AgentEnvironment", id="39", type="Notice"
        public void ProcessCustomerArrived(MessageForm message)
        {
            var msg = (MsgCarService)message;

            if (ArrivalRampQueue.Count == 0 && !ArrivalRampOpen)
            {
                ArrivalRampOpen = true;
                message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CROSS_ARRIVAL_RAMP);
                StartContinualAssistant(message);
            }
            else
            {
                msg.Customer.State = "Čaká pred vstupnou rampou";
                msg.Customer.StateVehicle = "Čaká pred vstupnou rampou";
                ArrivalRampQueue.Enqueue(msg);
            }
        }

        //meta! sender="AgentCarService", id="54", type="Response"
        public void ProcessCustomerService(MessageForm message)
        {
            MySim.CarParkServiceOccupied--;
            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_LEAVE_CAR_PARK);
            StartContinualAssistant(message);
        }

        //meta! sender="ProcessParkCar", id="50", type="Finish"
        public void ProcessFinishProcessParkCar(MessageForm message)
        {
            MySim.CarParkServiceOccupied++;
            ((MsgCarService)message).Customer.StateVehicle = "Zaparkované pred servisom";
            message.Code = Mc.CUSTOMER_SERVICE;
            message.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
            Request(message);
        }

        //meta! sender="ProcessCrossArrivalRamp", id="46", type="Finish"
        public void ProcessFinishProcessCrossArrivalRamp(MessageForm message)
        {
            ArrivalRampOpen = false;
            var msg = (MsgCarService)message;
            msg.Customer.EnteredService();

            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_CAR);
            StartContinualAssistant(message);

            if (ArrivalRampQueue.Count == 0)
            {
                return;
            }

            var msgNew = ArrivalRampQueue.Dequeue();
            ArrivalRampOpen = true;
            msgNew.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CROSS_ARRIVAL_RAMP);
            StartContinualAssistant(msgNew);
        }

        //meta! sender="ProcessLeaveCarPark", id="52", type="Finish"
        public void ProcessFinishProcessLeaveCarPark(MessageForm message)
        {
            if (DepartureRampQueue.Count == 0 && !DepartureRampOpen)
            {
                DepartureRampOpen = true;
                message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CROSS_DEPARTURE_RAMP);
                StartContinualAssistant(message);
            }
            else
            {
                var msg = (MsgCarService)message;
                msg.Customer.State = "Čaká pred výstupnou rampou";
                msg.Customer.StateVehicle = "Čaká pred výstupnou rampou";
                DepartureRampQueue.Enqueue(msg);
            }
        }

        //meta! sender="ProcessCrossDepartureRamp", id="48", type="Finish"
        public void ProcessFinishProcessCrossDepartureRamp(MessageForm message)
        {
            DepartureRampOpen = false;

            message.Code = Mc.CUSTOMER_LEFT;
            message.Addressee = MySim.FindAgent(SimId.AGENT_ENVIRONMENT);
            Notice(message);

            if (DepartureRampQueue.Count == 0)
            {
                return;
            }

            var msgNew = DepartureRampQueue.Dequeue();
            DepartureRampOpen = true;
            msgNew.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CROSS_DEPARTURE_RAMP);
            StartContinualAssistant(msgNew);
        }

        public void ProcessDefault(MessageForm message)
        {
        }

        public void Init()
        {
            ArrivalRampOpen = false;
            DepartureRampOpen = false;

            ArrivalRampQueue = new Queue<MsgCarService>();
            DepartureRampQueue = new Queue<MsgCarService>();
        }

        public override void ProcessMessage(MessageForm message)
        {
            switch (message.Code)
            {
                case Mc.Finish:
                    switch (message.Sender.Id)
                    {
                        case SimId.PROCESS_PARK_CAR:
                            ProcessFinishProcessParkCar(message);
                            break;
                        case SimId.PROCESS_CROSS_ARRIVAL_RAMP:
                            ProcessFinishProcessCrossArrivalRamp(message);
                            break;
                        case SimId.PROCESS_LEAVE_CAR_PARK:
                            ProcessFinishProcessLeaveCarPark(message);
                            break;
                        case SimId.PROCESS_CROSS_DEPARTURE_RAMP:
                            ProcessFinishProcessCrossDepartureRamp(message);
                            break;
                    }
                    break;
                case Mc.CUSTOMER_ARRIVED:
                    ProcessCustomerArrived(message);
                    break;
                case Mc.CUSTOMER_SERVICE:
                    ProcessCustomerService(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }
    }
}
