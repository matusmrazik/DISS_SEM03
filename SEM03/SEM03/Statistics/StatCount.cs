namespace SEM03.Statistics
{
    public class StatCount
    {
        private readonly OSPABA.Simulation _mySim;

        public double IgnoreBefore { get; set; }
        public double IgnoreAfter { get; set; }

        public int Count { get; private set; }

        public StatCount(OSPABA.Simulation mySim)
        {
            _mySim = mySim;
            IgnoreBefore = 0.0;
            IgnoreAfter = double.MaxValue;
            Clear();
        }

        public StatCount(StatCount original)
        {
            _mySim = original._mySim;
            IgnoreBefore = original.IgnoreBefore;
            IgnoreAfter = original.IgnoreAfter;
            Count = original.Count;
        }

        public void Add(int count = 1)
        {
            if (_mySim.CurrentTime < IgnoreBefore || _mySim.CurrentTime > IgnoreAfter)
            {
                return;
            }

            Count += count;
        }

        public void Clear()
        {
            Count = 0;
        }
    }
}
