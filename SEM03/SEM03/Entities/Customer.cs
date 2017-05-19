using OSPABA;
using SEM03.Simulation;

namespace SEM03.Entities
{
    public class Customer : Entity
    {
        private bool _waitInQueueStarted;
        private bool _waitInQueueFinished;
        private bool _waitForRepairStarted;
        private bool _waitForRepairFinished;
        private bool _repairStarted;
        private bool _repairFinished;
        private bool _enteredService;
        private bool _leftService;

        public new SimCarService MySim => (SimCarService)base.MySim;

        public double ServiceEnterTime { get; private set; }
        public double RepairStart { get; private set; }
        public double TimeInServiceTotal { get; private set; }
        public double WaitForRepairStart { get; private set; }
        public double WaitForRepairTotal { get; private set; }
        public double WaitInQueueStart { get; private set; }
        public double WaitInQueueTotal { get; private set; }

        public int RequestedRepairCount { get; private set; }
        public double TotalRepairDuration { get; private set; }

        public bool Served { get; set; }
        public string State { get; set; }
        public string StateVehicle { get; set; }

        public string WaitInQueueDurationStr
        {
            get
            {
                if (_waitInQueueFinished) return SimTimeHelper.DurationAsString(WaitInQueueTotal);
                if (!_waitInQueueStarted) return SimTimeHelper.DurationAsString(0.0);
                return SimTimeHelper.DurationAsString(MySim.CurrentTime - WaitInQueueStart);
            }
        }

        public string WaitForRepairDurationStr
        {
            get
            {
                if (_waitForRepairFinished) return SimTimeHelper.DurationAsString(WaitForRepairTotal);
                if (!_waitForRepairStarted) return SimTimeHelper.DurationAsString(0.0);
                return SimTimeHelper.DurationAsString(MySim.CurrentTime - WaitForRepairStart);
            }
        }

        public string TimeInServiseStr
        {
            get
            {
                if (_leftService) return SimTimeHelper.DurationAsString(TimeInServiceTotal);
                if (!_enteredService) return SimTimeHelper.DurationAsString(0.0);
                return SimTimeHelper.DurationAsString(MySim.CurrentTime - ServiceEnterTime);
            }
        }

        public string RepairedPercent
        {
            get
            {
                if (_repairFinished) return "100.00 %";
                if (!_repairStarted) return "0.00 %";
                return $@"{100.0 * ((MySim.CurrentTime - RepairStart) / TotalRepairDuration):0.00} %";
            }
        }

        public string TotalRepairDurationStr => SimTimeHelper.DurationAsString(TotalRepairDuration);

        public Customer(OSPABA.Simulation mySim)
            : base(mySim)
        {
            _waitInQueueStarted = false;
            _waitInQueueFinished = false;
            _waitForRepairStarted = false;
            _waitForRepairFinished = false;
            _repairStarted = false;
            _repairFinished = false;
            _enteredService = false;
            _leftService = false;

            ServiceEnterTime = 0.0;
            RepairStart = 0.0;
            TimeInServiceTotal = 0.0;
            WaitForRepairStart = 0.0;
            WaitForRepairTotal = 0.0;
            WaitInQueueStart = 0.0;
            WaitInQueueTotal = 0.0;

            RequestedRepairCount = 0;
            TotalRepairDuration = 0.0;

            Served = false;
            State = "";
            StateVehicle = "";
        }

        public void EnteredService()
        {
            _enteredService = true;
            ServiceEnterTime = MySim.CurrentTime;
            State = "Parkuje pred servisom";
            StateVehicle = "Ide k parkovisku pred servisom";
        }

        public void LeftService()
        {
            _leftService = true;
            TimeInServiceTotal = MySim.CurrentTime - ServiceEnterTime;
        }

        public void WaitForRepairStarted()
        {
            _waitForRepairStarted = true;
            WaitForRepairStart = MySim.CurrentTime;
            State = "Čaká na opravu";
        }

        public void WaitForRepairFinished()
        {
            _waitForRepairFinished = true;
            WaitForRepairTotal = MySim.CurrentTime - WaitForRepairStart;
            State = "Odchádza";
        }

        public void WaitInQueueStarted()
        {
            _waitInQueueStarted = true;
            WaitInQueueStart = MySim.CurrentTime;
            State = "Čaká v rade na zadanie objednávky";
        }

        public void WaitInQueueFinished(bool served)
        {
            _waitInQueueFinished = true;
            Served = served;
            WaitInQueueTotal = MySim.CurrentTime - WaitInQueueStart;
            State = served ? "Zadáva objednávku" : "Odchádza neobslúžený";
        }

        public void VehicleRepairStarted()
        {
            // TODO
            _repairStarted = true;
            RepairStart = MySim.CurrentTime;
            StateVehicle = "Opravuje sa";
        }

        public void VehicleRepairFinished()
        {
            // TODO
            _repairFinished = true;
            StateVehicle = "Opravené, čaká na preparkovanie";
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
