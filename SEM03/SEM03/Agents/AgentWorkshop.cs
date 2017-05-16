using System.Collections.Generic;
using System.Linq;
using OSPABA;
using SEM03.ContinualAssistants;
using SEM03.Entities;
using SEM03.InstantAssistants;
using SEM03.Managers;
using SEM03.Simulation;
using SEM03.Statistics;

namespace SEM03.Agents
{
    public class AgentWorkshop : Agent
    {
        public List<Mechanic> Workers { get; private set; }
        public List<ParkingPlace> CarPark { get; private set; }
        public CustomQueue<MsgCarService> OrdersQueue { get; private set; }

        public WStat StatisticCarsForRepairQueueLength { get; private set; }
        public WStat StatisticWorkersWorking { get; private set; }
        public WStat StatisticCarParkOccupied { get; private set; }

        public int WorkersWorking => Workers.Count(worker => worker.IsWorking);
        public int CarParkOccupied => CarPark.Count(place => place.IsOccupied());
        public double TotalWorkingTime => Workers.Sum(worker => worker.TotalWorkingTime);

        public AgentWorkshop(int id, OSPABA.Simulation mySim, Agent parent)
            : base(id, mySim, parent)
        {
            Init();
        }

        public override void PrepareReplication()
        {
            base.PrepareReplication();

            OrdersQueue.Clear();

            StatisticCarsForRepairQueueLength.Clear();
            StatisticWorkersWorking.Clear();
            StatisticCarParkOccupied.Clear();

            ResetWorkers();
            ResetCarPark();
        }

        public void SetWorkersCount(int count)
        {
            Workers.Clear();
            for (var i = 0; i < count; ++i)
            {
                var tmpWorker = new Mechanic(MySim);
                tmpWorker.StatisticWorkingDuration.IgnoreBefore = SimConfig.HEAT_UP_TIME;
                tmpWorker.StatisticWorkingDuration.IgnoreAfter = SimConfig.ReplicationEndTime;
                Workers.Add(tmpWorker);
            }
        }

        public void SetCarParkPlaces(int count)
        {
            CarPark.Clear();
            for (var i = 0; i < count; ++i)
            {
                var parkingPlace = new ParkingPlace(MySim);
                parkingPlace.OnAvailabilityChanged += () => StatisticCarParkOccupied.AddSample(CarParkOccupied);
                CarPark.Add(parkingPlace);
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
                parkingPlace.Reset();
            }
        }

        public Mechanic FindFreeWorker()
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
            new ManagerWorkshop(SimId.MANAGER_WORKSHOP, MySim, this);
            new ProcessCarRepair(SimId.PROCESS_CAR_REPAIR, MySim, this);
            new ActionAssignParkingPlace(SimId.ACTION_ASSIGN_PARKING_PLACE, MySim, this);
            new ActionAssignMechanic(SimId.ACTION_ASSIGN_MECHANIC, MySim, this);

            AddOwnMessage(Mc.RESERVE_PARKING_PLACE);
            AddOwnMessage(Mc.REPAIR_CAR);
            AddOwnMessage(Mc.PARK_REPAIRED_CAR_TO_WORKSHOP);

            Workers = new List<Mechanic>();
            CarPark = new List<ParkingPlace>();
            OrdersQueue = new CustomQueue<MsgCarService>();

            StatisticCarsForRepairQueueLength = new WStat(MySim);
            StatisticWorkersWorking = new WStat(MySim);
            StatisticCarParkOccupied = new WStat(MySim);
        }
    }
}
