using OSPABA;

namespace SEM03.Simulation
{
    public class Mc : IdList
    {
        public const int CUSTOMER_ARRIVED = 1001;
        public const int CUSTOMER_LEFT = 1002;
        public const int CUSTOMER_SERVICE = 1003;
        public const int PROCESS_ORDER_SERVICE = 1004;
        public const int RESERVE_PARKING_PLACE = 1005;
        public const int REPAIR_CAR = 1006;
        public const int RETURN_REPAIRED_CAR = 1007;
        public const int PARK_REPAIRED_CAR = 1008;
        public const int RESERVE_PARKING_PLACE_IN_WORKSHOP = 1009;
        public const int PARK_REPAIRED_CAR_TO_WORKSHOP = 1010;

        // 1..1000 range reserved for user
        public const int NEW_CUSTOMER = 1;
        public const int ARRIVAL_RAMP_CROSSED = 2;
        public const int PARK_CAR_FINISHED = 3;
        public const int WORKDAY_END = 4;
        public const int CUSTOMER_ORDER_ENTRY_FINISHED = 5;
        public const int CUSTOMER_CAR_TAKEOVER_FINISHED = 6;
        public const int CUSTOMER_PARK_TO_WORKSHOP_FINISHED = 7;
        public const int CAR_REPAIR_FINISHED = 8;
        public const int CUSTOMER_PARK_FROM_WORKSHOP_FINISHED = 9;
        public const int CAR_RETURN_FINISHED = 10;
        public const int LEAVE_CAR_PARK_FINISHED = 11;
        public const int DEPARTURE_RAMP_CROSSED = 12;
    }
}
