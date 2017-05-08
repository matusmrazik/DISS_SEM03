using OSPABA;
using SEM03.Agents;
using SEM03.Simulation;

namespace SEM03.Managers
{
    public class ManagerService : Manager
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;

        public ManagerService(int id, OSPABA.Simulation mySim, Agent myAgent)
            : base(id, mySim, myAgent)
        {
            Init();
        }

        //meta! sender="AgentCarService", id="66", type="Request"
        public void ProcessReturnRepairedCar(MessageForm message)
        {
            ((Action)MyAgent.FindAssistant(SimId.ACTION_ASSIGN_WORKER)).Execute(message);

            var msg = (MsgCarService)message;
            if (msg.WorkerWithCustomers == null)
            {
                MyAgent.ReturnQueue.Enqueue(msg);
                MyAgent.StatisticReadyToReturnQueueLength.AddSample(MyAgent.ReturnQueue.Count);
            }
            else
            {
                var parkingPlace = msg.ParkingPlace;
                msg.ParkingPlace = null;
                parkingPlace.SetFree();

                message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_FROM_WORKSHOP);
                StartContinualAssistant(message);

                if (MyAgent.RepairedQueue.Count == 0)
                {
                    return;
                }

                var msgNew = MyAgent.RepairedQueue.Dequeue();
                MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
                parkingPlace.SetOccupied();
                msgNew.ParkingPlace = parkingPlace;
                Response(msgNew);
            }
        }

        //meta! sender="AgentCarService", id="60", type="Request"
        public void ProcessProcessOrderService(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.WaitInQueueStarted();
            ((Action)MyAgent.FindAssistant(SimId.ACTION_ASSIGN_WORKER)).Execute(message);

            if (msg.WorkerWithCustomers == null)
            {
                MyAgent.OrdersQueue.Enqueue(msg);
                MyAgent.StatisticQueueLength.AddSample(MyAgent.OrdersQueue.Count);
            }
            else
            {
                message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_ORDER_ENTRY);
                StartContinualAssistant(message);
            }
        }

        //meta! sender="ProcessParkToWorkshop", id="78", type="Finish"
        public void ProcessFinishProcessParkToWorkshop(MessageForm message)
        {
            var msg = (MsgCarService)message;
            var worker = msg.WorkerWithCustomers;

            msg.WorkerWithCustomers.StopWork();
            msg.WorkerWithCustomers = null;
            msg.ParkingPlace.SetOccupied();

            message.Code = Mc.PROCESS_ORDER_SERVICE;
            Response(message);

            if (MyAgent.ReturnQueue.Count == 0)
            {
                if (MyAgent.OrdersQueue.Count == 0)
                {
                    return;
                }

                var msgNew = MyAgent.OrdersQueue.Dequeue();
                MyAgent.StatisticQueueLength.AddSample(MyAgent.OrdersQueue.Count);
                msgNew.WorkerWithCustomers = worker;
                worker.StartWork(msgNew.Customer);
                msgNew.Addressee = MyAgent.FindAssistant(SimId.PROCESS_ORDER_ENTRY);
                StartContinualAssistant(msgNew);
                return;
            }

            var msgNew2 = MyAgent.ReturnQueue.Dequeue();
            MyAgent.StatisticReadyToReturnQueueLength.AddSample(MyAgent.ReturnQueue.Count);
            msgNew2.WorkerWithCustomers = worker;
            worker.StartWork(msgNew2.Customer);
            var parkingPlace = msgNew2.ParkingPlace;
            msgNew2.ParkingPlace = null;
            parkingPlace.SetFree();

            msgNew2.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_FROM_WORKSHOP);
            StartContinualAssistant(msgNew2);

            if (MyAgent.RepairedQueue.Count == 0)
            {
                return;
            }

            var msgNew3 = MyAgent.RepairedQueue.Dequeue();
            MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
            parkingPlace.SetOccupied();
            msgNew3.ParkingPlace = parkingPlace;
            Response(msgNew3);
        }

        //meta! sender="ProcessParkFromWorkshop", id="92", type="Finish"
        public void ProcessFinishProcessParkFromWorkshop(MessageForm message)
        {
            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CAR_RETURN);
            StartContinualAssistant(message);
        }

        //meta! sender="ProcessCarReturn", id="94", type="Finish"
        public void ProcessFinishProcessCarReturn(MessageForm message)
        {
            var msg = (MsgCarService)message;
            var worker = msg.WorkerWithCustomers;

            msg.Customer.WaitForRepairFinished();
            MyAgent.StatisticWaitForRepair.AddSample(msg.Customer.WaitForRepairTotal);
            msg.WorkerWithCustomers.StopWork();
            msg.WorkerWithCustomers = null;

            message.Code = Mc.RETURN_REPAIRED_CAR;
            Response(message);

            if (MyAgent.ReturnQueue.Count == 0)
            {
                if (MyAgent.OrdersQueue.Count == 0)
                {
                    return;
                }

                var msgNew = MyAgent.OrdersQueue.Dequeue();
                MyAgent.StatisticQueueLength.AddSample(MyAgent.OrdersQueue.Count);
                msgNew.WorkerWithCustomers = worker;
                worker.StartWork(msgNew.Customer);
                msgNew.Addressee = MyAgent.FindAssistant(SimId.PROCESS_ORDER_ENTRY);
                StartContinualAssistant(msgNew);
                return;
            }

            var msgNew2 = MyAgent.ReturnQueue.Dequeue();
            MyAgent.StatisticReadyToReturnQueueLength.AddSample(MyAgent.ReturnQueue.Count);
            msgNew2.WorkerWithCustomers = worker;
            worker.StartWork(msgNew2.Customer);
            var parkingPlace = msgNew2.ParkingPlace;
            msgNew2.ParkingPlace = null;
            parkingPlace.SetFree();

            msgNew2.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_FROM_WORKSHOP);
            StartContinualAssistant(msgNew2);

            if (MyAgent.RepairedQueue.Count == 0)
            {
                return;
            }

            var msgNew3 = MyAgent.RepairedQueue.Dequeue();
            MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
            parkingPlace.SetOccupied();
            msgNew3.ParkingPlace = parkingPlace;
            Response(msgNew3);
        }

        //meta! sender="SchedulerWorkdayEnd", id="104", type="Finish"
        public void ProcessFinishSchedulerWorkdayEnd(MessageForm message)
        {
            MyAgent.OrdersQueue.Clear();
            MyAgent.StatisticQueueLength.AddSample(MyAgent.OrdersQueue.Count);

            message.Addressee = MyAgent.FindAssistant(SimId.SCHEDULER_WORKDAY_END);
            StartContinualAssistant(message);
        }

        //meta! sender="ProcessOrderEntry", id="73", type="Finish"
        public void ProcessFinishProcessOrderEntry(MessageForm message)
        {
            message.Code = Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP;
            message.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
            Request(message);
        }

        //meta! sender="ProcessCarTakeover", id="76", type="Finish"
        public void ProcessFinishProcessCarTakeover(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.WaitForRepairStarted();
            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_TO_WORKSHOP);
            StartContinualAssistant(message);
        }

        //meta! sender="AgentCarService", id="80", type="Request"
        public void ProcessParkRepairedCar(MessageForm message)
        {
            ((Action)MyAgent.FindAssistant(SimId.ACTION_PARK_REPAIRED_CAR)).Execute(message);

            var msg = (MsgCarService)message;
            if (msg.ParkingPlace == null)
            {
                MyAgent.RepairedQueue.Enqueue(msg);
                MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
                return;
            }

            Response(message);
        }

        //meta! sender="AgentCarService", id="83", type="Response"
        public void ProcessReserveParkingPlaceInWorkshop(MessageForm message)
        {
            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CAR_TAKEOVER);
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
                    switch (message.Sender.Id)
                    {
                        case SimId.PROCESS_PARK_TO_WORKSHOP:
                            ProcessFinishProcessParkToWorkshop(message);
                            break;
                        case SimId.PROCESS_PARK_FROM_WORKSHOP:
                            ProcessFinishProcessParkFromWorkshop(message);
                            break;
                        case SimId.PROCESS_CAR_RETURN:
                            ProcessFinishProcessCarReturn(message);
                            break;
                        case SimId.SCHEDULER_WORKDAY_END:
                            ProcessFinishSchedulerWorkdayEnd(message);
                            break;
                        case SimId.PROCESS_ORDER_ENTRY:
                            ProcessFinishProcessOrderEntry(message);
                            break;
                        case SimId.PROCESS_CAR_TAKEOVER:
                            ProcessFinishProcessCarTakeover(message);
                            break;
                    }
                    break;
                case Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP:
                    ProcessReserveParkingPlaceInWorkshop(message);
                    break;
                case Mc.RETURN_REPAIRED_CAR:
                    ProcessReturnRepairedCar(message);
                    break;
                case Mc.PARK_REPAIRED_CAR:
                    ProcessParkRepairedCar(message);
                    break;
                case Mc.PROCESS_ORDER_SERVICE:
                    ProcessProcessOrderService(message);
                    break;
                default:
                    ProcessDefault(message);
                    break;
            }
        }
    }
}
