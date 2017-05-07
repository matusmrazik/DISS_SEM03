using OSPABA;
using SEM03.Entities;

namespace SEM03.Simulation
{
    public class MsgCarService : MessageForm
    {
        public Customer Customer { get; set; }
        public WorkerWithCustomers WorkerWithCustomers { get; set; }
        public Mechanic Mechanic { get; set; }
        public ParkingPlace ParkingPlace { get; set; }

        public MsgCarService(OSPABA.Simulation sim)
            : base(sim)
        {
            Customer = null;
            WorkerWithCustomers = null;
            Mechanic = null;
            ParkingPlace = null;
        }

        public MsgCarService(MessageForm original)
            : base(original)
        {
            // copy() is called in superclass
        }

        public override MessageForm CreateCopy()
        {
            return new MsgCarService(this);
        }

        protected override void Copy(MessageForm message)
        {
            base.Copy(message);
            var original = (MsgCarService)message;

            Customer = original.Customer;
            WorkerWithCustomers = original.WorkerWithCustomers;
            Mechanic = original.Mechanic;
            ParkingPlace = original.ParkingPlace;
        }
    }
}
