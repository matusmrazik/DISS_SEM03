using OSPABA;
using SEM03.Simulation;

namespace SEM03.Entities
{
    public class Customer : Entity
    {
        public new SimCarService MySim => (SimCarService)base.MySim;

        public double ArrivedToRampTime { get; private set; }
        public double ServiceEnterTime { get; private set; }
        public double TimeInServiceTotal { get; private set; }
        public double WaitForRepairStart { get; private set; }
        public double WaitForRepairTotal { get; private set; }
        public double WaitInQueueStart { get; private set; }
        public double WaitInQueueTotal { get; private set; }

        public double WaitForCarTakeoverStart { get; private set; }
        public double WaitForCarTakeoverTotal { get; private set; }

        public int RequestedRepairCount { get; private set; }
        public double TotalRepairDuration { get; private set; }

        public bool Served { get; set; }

        public Customer(OSPABA.Simulation mySim)
            : base(mySim)
        {
            ArrivedToRampTime = 0.0;
            ServiceEnterTime = 0.0;
            TimeInServiceTotal = 0.0;
            WaitForRepairStart = 0.0;
            WaitForRepairTotal = 0.0;
            WaitInQueueStart = 0.0;
            WaitInQueueTotal = 0.0;

            WaitForCarTakeoverStart = 0.0;
            WaitForCarTakeoverTotal = 0.0;

            RequestedRepairCount = 0;
            TotalRepairDuration = 0.0;

            Served = false;
        }

        public void ArrivedToRamp()
        {
            ArrivedToRampTime = MySim.CurrentTime;
        }

        public void EnteredService()
        {
            ServiceEnterTime = MySim.CurrentTime;
        }

        public void LeftService()
        {
            TimeInServiceTotal = MySim.CurrentTime - ServiceEnterTime;
        }

        public void WaitForRepairStarted()
        {
            WaitForRepairStart = MySim.CurrentTime;
        }

        public void WaitForRepairFinished()
        {
            WaitForRepairTotal = MySim.CurrentTime - WaitForRepairStart;
        }

        public void WaitInQueueStarted()
        {
            WaitInQueueStart = MySim.CurrentTime;
        }

        public void WaitInQueueFinished()
        {
            WaitInQueueTotal = MySim.CurrentTime - WaitInQueueStart;
        }

        public void WaitForCarTakeoverStarted()
        {
            WaitForCarTakeoverStart = MySim.CurrentTime;
        }

        public void WaitForCarTakeoverFinished()
        {
            WaitForCarTakeoverTotal = MySim.CurrentTime - WaitForCarTakeoverStart;
        }

        public void GenerateRepairDuration()
        {
            TotalRepairDuration = 0.0;
            RequestedRepairCount = MySim.GeneratorRepairCount.Next();
            for (var i = 0; i < RequestedRepairCount; ++i)
            {
                var repairType = MySim.GeneratorRepairType.Next();
                switch (repairType)
                {
                    case 0: // simple
                        TotalRepairDuration += MySim.GeneratorSimpleRepairDuration.Next();
                        break;
                    case 1: // moderate
                        TotalRepairDuration += MySim.GeneratorModerateRepairDuration.Next();
                        break;
                    case 2: // complicated
                        TotalRepairDuration += MySim.GeneratorComplicatedRepairDuration.Next();
                        break;
                }
            }
        }
    }
}
