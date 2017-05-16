using SEM03.Simulation;

namespace SEM03.Entities
{
    public class WorkerWithCustomers : Worker
    {
        public new SimCarService MySim => (SimCarService)base.MySim;

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
            MySim.StatisticWorkers1Working.AddSample(MySim.Workers1Working);
        }

        public override void StopWork()
        {
            base.StopWork();
            CustomerServed = null;
            MySim.StatisticWorkers1Working.AddSample(MySim.Workers1Working);
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
