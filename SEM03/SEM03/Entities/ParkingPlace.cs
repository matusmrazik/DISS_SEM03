using OSPABA;
using Action = System.Action;

namespace SEM03.Entities
{
    public class ParkingPlace : Entity
    {
        public event Action OnAvailabilityChanged;

        private State _availability;

        public double OccupiedStart { get; private set; }
        public double OccupiedSum { get; private set; }

        public double TotalOccupiedTime
        {
            get
            {
                if (!IsOccupied()) return OccupiedSum;
                return OccupiedSum + (MySim.CurrentTime - OccupiedStart);
            }
        }

        public string StateStr
        {
            get
            {
                if (IsFree()) return "Voľné";
                if (IsReserved()) return "Rezervované";
                return "Obsadené";
            }
        }

        public string OccupiedRatioStr => MySim.CurrentTime == 0.0 ? "-" : $"{100.0 * (TotalOccupiedTime / MySim.CurrentTime):0.00} %";

        public ParkingPlace(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Reset();
        }

        public bool IsFree()
        {
            return _availability == State.Free;
        }

        public bool IsReserved()
        {
            return _availability == State.Reserved;
        }

        public bool IsOccupied()
        {
            return _availability == State.Occupied;
        }

        public void SetFree()
        {
            if (IsFree()) return;
            if (IsOccupied()) OccupiedSum += MySim.CurrentTime - OccupiedStart;
            _availability = State.Free;
            OnAvailabilityChanged?.Invoke();
        }

        public void SetReserved()
        {
            if (IsReserved()) return;
            if (IsOccupied()) OccupiedSum += MySim.CurrentTime - OccupiedStart;
            _availability = State.Reserved;
            OnAvailabilityChanged?.Invoke();
        }

        public void SetOccupied()
        {
            if (IsOccupied()) return;
            OccupiedStart = MySim.CurrentTime;
            _availability = State.Occupied;
            OnAvailabilityChanged?.Invoke();
        }

        public void Reset()
        {
            _availability = State.Free;
            OccupiedStart = 0.0;
            OccupiedSum = 0.0;
        }

        private enum State
        {
            Free, Reserved, Occupied
        }
    }
}
