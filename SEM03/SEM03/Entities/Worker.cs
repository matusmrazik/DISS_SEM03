using OSPABA;

namespace SEM03.Entities
{
    public class Worker : Entity
    {
        public bool IsWorking { get; private set; }
        public double StartWorkingTime { get; private set; }
        public double TotalWorkingTime { get; private set; }

        public Worker(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Init();
        }

        public virtual void StartWork()
        {
            StartWorkingTime = MySim.CurrentTime;
            IsWorking = true;
        }

        public virtual void StopWork()
        {
            TotalWorkingTime += MySim.CurrentTime - StartWorkingTime;
            IsWorking = false;
        }

        public virtual void Reset()
        {
            Init();
        }

        private void Init()
        {
            IsWorking = false;
            StartWorkingTime = 0.0;
            TotalWorkingTime = 0.0;
        }
    }
}
