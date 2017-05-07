﻿using System.Collections.Generic;
using OSPABA;
using SEM03.ContinualAssistants;
using SEM03.Entities;
using SEM03.InstantAssistants;
using SEM03.Managers;
using SEM03.Simulation;

namespace SEM03.Agents
{
    public class AgentService : Agent
    {
        public List<WorkerWithCustomers> Workers { get; private set; }
        public List<ParkingPlace> CarPark { get; private set; }
        public Queue<MsgCarService> OrdersQueue { get; private set; } // incoming orders
        public Queue<MsgCarService> RepairedQueue { get; private set; } // repaired cars waiting to be parked to car park
        public Queue<MsgCarService> ReturnQueue { get; private set; } // cars ready to be returned to their owners

        public AgentService(int id, OSPABA.Simulation mySim, Agent parent)
            : base(id, mySim, parent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();

            OrdersQueue.Clear();
            RepairedQueue.Clear();
            ReturnQueue.Clear();

            ResetWorkers();
            ResetCarPark();

            var message = new MsgCarService(MySim) { Addressee = FindAssistant(SimId.SCHEDULER_WORKDAY_END) };
            MyManager.StartContinualAssistant(message);
        }

        public void SetWorkersCount(int count)
        {
            Workers.Clear();
            for (var i = 0; i < count; ++i)
            {
                Workers.Add(new WorkerWithCustomers(MySim));
            }
        }

        public void SetCarParkPlaces(int count)
        {
            CarPark.Clear();
            for (var i = 0; i < count; ++i)
            {
                CarPark.Add(new ParkingPlace(MySim));
            }
        }

        public void ResetWorkers()
        {
            foreach (var worker in Workers)
            {
                worker.Reset();
            }
        }

        public void ResetCarPark()
        {
            foreach (var parkingPlace in CarPark)
            {
                parkingPlace.SetFree();
            }
        }

        public WorkerWithCustomers FindFreeWorker()
        {
            foreach (var worker in Workers)
            {
                if (!worker.IsWorking)
                {
                    return worker;
                }
            }
            return null;
        }

        public ParkingPlace FindFreeParkingPlace()
        {
            foreach (var parkingPlace in CarPark)
            {
                if (parkingPlace.IsFree())
                {
                    return parkingPlace;
                }
            }
            return null;
        }

        private void Init()
        {
            new ManagerService(SimId.MANAGER_SERVICE, MySim, this);
            new ProcessParkFromWorkshop(SimId.PROCESS_PARK_FROM_WORKSHOP, MySim, this);
            new ActionParkRepairedCar(SimId.ACTION_PARK_REPAIRED_CAR, MySim, this);
            new ProcessCarTakeover(SimId.PROCESS_CAR_TAKEOVER, MySim, this);
            new ProcessParkToWorkshop(SimId.PROCESS_PARK_TO_WORKSHOP, MySim, this);
            new ActionAssignWorker(SimId.ACTION_ASSIGN_WORKER, MySim, this);
            new ProcessCarReturn(SimId.PROCESS_CAR_RETURN, MySim, this);
            new ProcessOrderEntry(SimId.PROCESS_ORDER_ENTRY, MySim, this);
            new SchedulerWorkdayEnd(SimId.SCHEDULER_WORKDAY_END, MySim, this);

            AddOwnMessage(Mc.RETURN_REPAIRED_CAR);
            AddOwnMessage(Mc.PROCESS_ORDER_SERVICE);
            AddOwnMessage(Mc.PARK_REPAIRED_CAR);
            AddOwnMessage(Mc.RESERVE_PARKING_PLACE_IN_WORKSHOP);

            Workers = new List<WorkerWithCustomers>();
            CarPark = new List<ParkingPlace>();
            OrdersQueue = new Queue<MsgCarService>();
            RepairedQueue = new Queue<MsgCarService>();
            ReturnQueue = new Queue<MsgCarService>();
        }
    }
}
