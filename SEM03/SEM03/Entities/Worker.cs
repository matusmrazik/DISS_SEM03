using OSPABA;
using SEM03.Statistics;

namespace SEM03.Entities
{
    public class Worker : Entity
    {
        public bool IsWorking { get; private set; }

        public WStat StatisticWorkingDuration { get; }

        public double TotalWorkingTime
        {
            get
            {
                if (IsWorking) StatisticWorkingDuration.AddSample(1.0);
                return StatisticWorkingDuration.Sum;
            }
        }

        public Worker(OSPABA.Simulation mySim)
            : base(mySim)
        {
            Init();
            StatisticWorkingDuration = new WStat(mySim);
        }

        public virtual void StartWork()
        {
            StatisticWorkingDuration.AddSample(1.0);
            IsWorking = true;
        }

        public virtual void StopWork()
        {
            StatisticWorkingDuration.AddSample(0.0);
            IsWorking = false;
        }

        public virtual void Reset()
        {
            Init();
            StatisticWorkingDuration.Clear();
        }

        private void Init()
        {
            IsWorking = false;
        }
    }
}
