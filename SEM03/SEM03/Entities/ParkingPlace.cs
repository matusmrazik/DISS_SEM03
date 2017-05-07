using OSPABA;

namespace SEM03.Entities
{
    public class ParkingPlace : Entity
    {
        public State Availability { get; set; }

        public ParkingPlace(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Availability = State.Free;
        }

        public bool IsFree()
        {
            return Availability == State.Free;
        }

        public bool IsReserved()
        {
            return Availability == State.Reserved;
        }

        public bool IsOccupied()
        {
            return Availability == State.Occupied;
        }

        public void SetFree()
        {
            Availability = State.Free;
        }

        public void SetReserved()
        {
            Availability = State.Reserved;
        }

        public void SetOccupied()
        {
            Availability = State.Occupied;
        }

        public override string ToString()
        {
            return Availability.ToString();
        }

        public enum State
        {
            Free, Reserved, Occupied
        }
    }
}
