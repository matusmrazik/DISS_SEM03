using SEM03.Simulation;

namespace SEM03.Entities
{
    public class Mechanic : Worker
    {
        public new SimCarService MySim => (SimCarService)base.MySim;

        public Customer CustomerOfCar { get; private set; }

        public string CustomerId => CustomerOfCar == null ? "-" : $"{CustomerOfCar.Id}";

        public Mechanic(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Init();
        }

        public void StartWork(Customer customer)
        {
            base.StartWork();
            CustomerOfCar = customer;
            MySim.StatisticWorkers2Working.AddSample(MySim.Workers2Working);
        }

        public override void StopWork()
        {
            base.StopWork();
            CustomerOfCar = null;
            MySim.StatisticWorkers2Working.AddSample(MySim.Workers2Working);
        }

        public override void Reset()
        {
            base.Reset();

            Init();
        }

        private void Init()
        {
            CustomerOfCar = null;
        }
    }
}
