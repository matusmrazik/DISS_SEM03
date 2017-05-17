using OSPABA;
using SEM03.Agents;
using SEM03.Entities;
using SEM03.Simulation;

namespace SEM03.Managers
{
    public class ManagerService : Manager
    {
        public new AgentService MyAgent => (AgentService)base.MyAgent;
        public new SimCarService MySim => (SimCarService)base.MySim;

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
                return;
            }

            var parkingPlace = msg.ParkingPlace;
            msg.ParkingPlace = null;
            parkingPlace.SetFree();

            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_FROM_WORKSHOP);
            StartContinualAssistant(message);

            TryParkRepairedCar(parkingPlace);
        }

        //meta! sender="AgentCarService", id="60", type="Request"
        public void ProcessProcessOrderService(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.WaitInQueueStarted();

            var msgCopy = new MsgLeaveQueue(MySim)
            {
                Message = msg,
                Addressee = MyAgent.FindAssistant(SimId.SCHEDULER_LEAVE_QUEUE)
            };
            StartContinualAssistant(msgCopy);

            message.Code = Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP;
            message.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
            Request(message);
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

            Worker1ActionOnFinishWork(worker);
        }

        //meta! sender="ProcessParkFromWorkshop", id="92", type="Finish"
        public void ProcessFinishProcessParkFromWorkshop(MessageForm message)
        {
            MySim.CarParkServiceOccupied++;
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

            Worker1ActionOnFinishWork(worker);
        }

        //meta! sender="SchedulerLeaveQueue", id="118", type="Finish"
        public void ProcessFinishSchedulerLeaveQueue(MessageForm message)
        {
            var msg = ((MsgLeaveQueue)message).Message;

            if (MyAgent.ParkingPlaceQueue.Remove(msg))
            {
                MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
                msg.Customer.WaitInQueueFinished(false);
                msg.Code = Mc.PROCESS_ORDER_SERVICE;
                msg.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
                Response(msg);
            }

            if (MyAgent.OrdersQueue.Remove(msg))
            {
                MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
                msg.Customer.WaitInQueueFinished(false);
                msg.ParkingPlace.SetFree();
                msg.ParkingPlace = null;
                msg.Code = Mc.PROCESS_ORDER_SERVICE;
                msg.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
                Response(msg);
            }
        }

        //meta! sender="SchedulerWorkdayEnd", id="104", type="Finish"
        public void ProcessFinishSchedulerWorkdayEnd(MessageForm message)
        {
            foreach (var msg in MyAgent.ParkingPlaceQueue)
            {
                msg.Customer.WaitInQueueFinished(false);
                msg.Code = Mc.PROCESS_ORDER_SERVICE;
                msg.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
                Response(msg);
            }
            MyAgent.ParkingPlaceQueue.Clear();
            foreach (var msg in MyAgent.OrdersQueue)
            {
                msg.Customer.WaitInQueueFinished(false);
                msg.ParkingPlace.SetFree();
                msg.ParkingPlace = null;
                msg.Code = Mc.PROCESS_ORDER_SERVICE;
                msg.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
                Response(msg);
            }
            MyAgent.OrdersQueue.Clear();
            MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);

            message.Addressee = MyAgent.FindAssistant(SimId.SCHEDULER_WORKDAY_END);
            StartContinualAssistant(message);
        }

        //meta! sender="ProcessOrderEntry", id="73", type="Finish"
        public void ProcessFinishProcessOrderEntry(MessageForm message)
        {
            var msg = (MsgCarService)message;
            MyAgent.StatisticIncomes.AddSample(SimTimeHelper.ToHours(msg.Customer.TotalRepairDuration) * SimConfig.WORK_PRICE_HOUR);

            message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_CAR_TAKEOVER);
            StartContinualAssistant(message);
        }

        //meta! sender="ProcessCarTakeover", id="76", type="Finish"
        public void ProcessFinishProcessCarTakeover(MessageForm message)
        {
            var msg = (MsgCarService)message;
            msg.Customer.WaitForRepairStarted();
            MySim.CarParkServiceOccupied--;
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
                msg.Mechanic.State = "Čaká na voľné miesto na parkovisku";
                MyAgent.RepairedQueue.Enqueue(msg);
                MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
                return;
            }

            msg.Mechanic.State = "Parkuje opravené auto na parkovisko";
            Response(message);
        }

        //meta! sender="AgentCarService", id="83", type="Response"
        public void ProcessReserveParkingPlaceInWorkshop(MessageForm message)
        {
            var msg = (MsgCarService)message;
            if (msg.ParkingPlace == null)
            {
                MyAgent.ParkingPlaceQueue.Enqueue(msg);
                MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
                return;
            }

            ((Action)MyAgent.FindAssistant(SimId.ACTION_ASSIGN_WORKER)).Execute(message);

            if (msg.WorkerWithCustomers == null)
            {
                MyAgent.OrdersQueue.Enqueue(msg);
                MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
            }
            else
            {
                message.Addressee = MyAgent.FindAssistant(SimId.PROCESS_ORDER_ENTRY);
                StartContinualAssistant(message);
            }
        }

        //meta! sender="AgentCarService", id="122", type="Notice"
        public void ProcessParkingPlaceFreeInWorkshop(MessageForm message)
        {
            if (MyAgent.ParkingPlaceQueue.Count == 0)
            {
                return;
            }

            var msg = MyAgent.ParkingPlaceQueue.Dequeue();
            MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
            msg.Code = Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP;
            msg.Addressee = MySim.FindAgent(SimId.AGENT_CAR_SERVICE);
            Request(msg);
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
                        case SimId.SCHEDULER_LEAVE_QUEUE:
                            ProcessFinishSchedulerLeaveQueue(message);
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
                case Mc.PARKING_PLACE_FREE_IN_WORKSHOP:
                    ProcessParkingPlaceFreeInWorkshop(message);
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

        private void Worker1ActionOnFinishWork(WorkerWithCustomers worker)
        {
            /*if (!TryReturnRepairedCar(worker))
            {
                TryProcessNextOrder(worker);
            }*/

            if (MyAgent.OrdersQueue.Count == 0)
            {
                TryReturnRepairedCar(worker);
                return;
            }

            if (MyAgent.ReturnQueue.Count == 0)
            {
                TryProcessNextOrder(worker);
                return;
            }

            if (MyAgent.WorkersWorking > MyAgent.CarPark.Count - MyAgent.ReturnQueue.Count)
            {
                TryReturnRepairedCar(worker);
            }
            else
            {
                TryProcessNextOrder(worker);
            }
        }

        private bool TryParkRepairedCar(ParkingPlace parkingPlace)
        {
            if (MyAgent.RepairedQueue.Count == 0)
            {
                return false;
            }

            var msg = MyAgent.RepairedQueue.Dequeue();
            msg.Mechanic.State = "Parkuje opravené auto na parkovisko";
            MyAgent.StatisticRepairedQueueLength.AddSample(MyAgent.RepairedQueue.Count);
            parkingPlace.SetOccupied();
            msg.ParkingPlace = parkingPlace;
            Response(msg);

            return true;
        }

        private bool TryReturnRepairedCar(WorkerWithCustomers worker)
        {
            if (MyAgent.ReturnQueue.Count == 0)
            {
                return false;
            }

            var msg = MyAgent.ReturnQueue.Dequeue();
            MyAgent.StatisticReadyToReturnQueueLength.AddSample(MyAgent.ReturnQueue.Count);
            msg.WorkerWithCustomers = worker;
            worker.StartWork(msg.Customer);
            var parkingPlace = msg.ParkingPlace;
            msg.ParkingPlace = null;
            parkingPlace.SetFree();

            msg.Addressee = MyAgent.FindAssistant(SimId.PROCESS_PARK_FROM_WORKSHOP);
            StartContinualAssistant(msg);

            TryParkRepairedCar(parkingPlace);

            return true;
        }

        private bool TryProcessNextOrder(WorkerWithCustomers worker)
        {
            if (MyAgent.OrdersQueue.Count == 0)
            {
                return false;
            }

            var msg = MyAgent.OrdersQueue.Dequeue();
            MyAgent.StatisticQueueLength.AddSample(MyAgent.QueueLength);
            msg.WorkerWithCustomers = worker;
            worker.StartWork(msg.Customer);
            msg.Addressee = MyAgent.FindAssistant(SimId.PROCESS_ORDER_ENTRY);
            StartContinualAssistant(msg);

            return true;
        }
    }
}
