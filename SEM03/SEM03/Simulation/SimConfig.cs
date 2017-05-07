namespace SEM03.Simulation
{
    public static class SimConfig
    {
        public const double WORKDAY_HOURS = SimTimeHelper.WORKDAY_HOURS;
        public const double WORKDAY_START_HOUR = SimTimeHelper.WORKDAY_START_HOUR;
        public const double HEAT_UP_TIME = 0.5 * SimTimeHelper.HOUR;
        public const double TIME_BETWEEN_CUSTOMERS = 20.0 * SimTimeHelper.MINUTE;

        public const double CAR_SPEED_KMH = 5.0;
        public const double CAR_SPEED_MS = CAR_SPEED_KMH / 3.6;
        public const double CROSS_RAMP_DURATION = 7.0;

        public const int CAR_PARK_1_PARKING_PLACES = 6;
        public const int CAR_PARK_2_PARKING_PLACES = 10;

        public const double RAMP_TO_CAR_PARK_DISTANCE_M = 18.5;
        public const double CAR_PARK_TO_WORKSHOP_DISTANCE_M = 117.0;
        public const double WORKSHOP_TO_CAR_PARK_DISTANCE_M = 153.0;

        public const double RAMP_TO_CAR_PARK_TIME = RAMP_TO_CAR_PARK_DISTANCE_M / CAR_SPEED_MS;
        public const double CAR_PARK_TO_WORKSHOP_TIME = CAR_PARK_TO_WORKSHOP_DISTANCE_M / CAR_SPEED_MS;
        public const double WORKSHOP_TO_CAR_PARK_TIME = WORKSHOP_TO_CAR_PARK_DISTANCE_M / CAR_SPEED_MS;
    }
}
