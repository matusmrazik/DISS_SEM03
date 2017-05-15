namespace SEM03.Entities
{
    public class WorkerWithCustomers : Worker
    {
        public Customer CustomerServed { get; private set; }

        public string CustomerId => CustomerServed == null ? "-" : $"{CustomerServed.Id}";

        public WorkerWithCustomers(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Init();
        }

        public void StartWork(Customer customer)
        {
            base.StartWork();
            CustomerServed = customer;
        }

        public override void StopWork()
        {
            base.StopWork();
            CustomerServed = null;
        }

        public override void Reset()
        {
            base.Reset();

            Init();
        }

        private void Init()
        {
            CustomerServed = null;
        }
    }
}
