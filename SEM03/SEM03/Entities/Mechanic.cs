namespace SEM03.Entities
{
    public class Mechanic : Worker
    {
        public Customer CustomerOfCar { get; private set; }

        public Mechanic(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Init();
        }

        public void StartWork(Customer customer)
        {
            base.StartWork();
            CustomerOfCar = customer;
        }

        public override void StopWork()
        {
            base.StopWork();
            CustomerOfCar = null;
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
