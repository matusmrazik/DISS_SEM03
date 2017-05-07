using OSPABA;

namespace SEM03.Simulation
{
    public class SimId : IdList
    {
        public const int AGENT_MODEL = 1;
        public const int AGENT_ENVIRONMENT = 2;
        public const int AGENT_CAR_SERVICE = 3;
        public const int AGENT_SERVICE = 4;
        public const int AGENT_WORKSHOP = 5;
        public const int MANAGER_MODEL = 101;
        public const int MANAGER_ENVIRONMENT = 102;
        public const int MANAGER_CAR_SERVICE = 103;
        public const int MANAGER_SERVICE = 104;
        public const int MANAGER_WORKSHOP = 105;
        public const int ACTION_ASSIGN_PARKING_PLACE = 1001;
        public const int ACTION_ASSIGN_WORKER = 1002;
        public const int ACTION_ASSIGN_MECHANIC = 1003;
        public const int ACTION_PARK_REPAIRED_CAR = 1004;
        public const int SCHEDULER_CUSTOMER_ARRIVAL = 1011;
        public const int SCHEDULER_WORKDAY_END = 1012;
        public const int PROCESS_CAR_REPAIR = 1021;
        public const int PROCESS_ORDER_ENTRY = 1022;
        public const int PROCESS_CAR_TAKEOVER = 1023;
        public const int PROCESS_PARK_TO_WORKSHOP = 1024;
        public const int PROCESS_CROSS_ARRIVAL_RAMP = 1025;
        public const int PROCESS_CROSS_DEPARTURE_RAMP = 1026;
        public const int PROCESS_PARK_CAR = 1027;
        public const int PROCESS_LEAVE_CAR_PARK = 1028;
        public const int PROCESS_PARK_FROM_WORKSHOP = 1029;
        public const int PROCESS_CAR_RETURN = 1030;
    }
}
