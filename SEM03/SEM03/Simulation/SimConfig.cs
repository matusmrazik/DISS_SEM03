using System;

namespace SEM03.Simulation
{
    public static class SimConfig
    {
        public const double DAYS_IN_MONTH = SimTimeHelper.DAYS_IN_MONTH;
        public const double WORKDAY_HOURS = SimTimeHelper.WORKDAY_HOURS;
        public const double WORKDAY_START_HOUR = SimTimeHelper.WORKDAY_START_HOUR;
        public const double CUSTOMERS_PER_HOUR = 3.0;
        public const double MAX_WAIT_IN_QUEUE_TIME = 10.0 * SimTimeHelper.MINUTE;
        public const double MAX_WAIT_FOR_REPAIR_TIME = 6.0 * SimTimeHelper.HOUR;

        public const double HEAT_UP_TIME = 0.0;
        public const double COOL_DOWN_TIME = 0.0;
        public const double REPLICATION_START_TIME = HEAT_UP_TIME;
        public static double ReplicationDuration { get; set; } = 21.0 * SimTimeHelper.DAY;
        public static double ReplicationEndTime => REPLICATION_START_TIME + ReplicationDuration;
        public static double TotalReplicationDuration => HEAT_UP_TIME + ReplicationDuration + COOL_DOWN_TIME;

        public const double CUSTOMERS_RAISE_MAX = 0.78;
        public const double CUSTOMERS_RAISE_FOR_1000_EUR = 0.16;
        public const double CUSTOMERS_RAISE_FOR_1_EUR = CUSTOMERS_RAISE_FOR_1000_EUR / 1000.0;
        public static double AdvertisingInvestmentMonth { get; set; } = 0.0;
        public static double AdvertisingInvestmentDay => AdvertisingInvestmentMonth / DAYS_IN_MONTH;
        public static double AdvertisingInvestmentTotal => AdvertisingInvestmentDay * SimTimeHelper.ToDays(ReplicationDuration);
        public static double CustomersRaise => 1.0 + Math.Min(CUSTOMERS_RAISE_MAX, AdvertisingInvestmentMonth * CUSTOMERS_RAISE_FOR_1_EUR);

        public static double CustomersPerHour => CUSTOMERS_PER_HOUR * CustomersRaise;
        public static double TimeBetweenCustomers => SimTimeHelper.HOUR / CustomersPerHour;

        public const double WORKER_1_COSTS_MONTH = 1150.0;
        public const double WORKER_2_COSTS_MONTH = 1600.0;
        public const double OPERATING_EXPENSES_MONTH = 7000.0;
        public const double WORK_PRICE_HOUR = 25.0;

        public const double WORKER_1_COSTS_DAY = WORKER_1_COSTS_MONTH / DAYS_IN_MONTH;
        public const double WORKER_2_COSTS_DAY = WORKER_2_COSTS_MONTH / DAYS_IN_MONTH;
        public const double OPERATING_EXPENSES_DAY = OPERATING_EXPENSES_MONTH / DAYS_IN_MONTH;
        public const double WORK_PRICE_DAY = WORK_PRICE_HOUR * WORKDAY_HOURS;
        public const double WORKER_1_COSTS_HOUR = WORKER_1_COSTS_DAY / WORKDAY_HOURS;
        public const double WORKER_2_COSTS_HOUR = WORKER_2_COSTS_DAY / WORKDAY_HOURS;
        public const double OPERATING_EXPENSES_HOUR = OPERATING_EXPENSES_DAY / WORKDAY_HOURS;
        public const double WORK_PRICE_MONTH = WORK_PRICE_DAY * DAYS_IN_MONTH;
        public const double WORKER_1_COSTS_MINUTE = WORKER_1_COSTS_HOUR / 60;
        public const double WORKER_2_COSTS_MINUTE = WORKER_2_COSTS_HOUR / 60;
        public const double OPERATING_EXPENSES_MINUTE = OPERATING_EXPENSES_HOUR / 60;
        public const double WORK_PRICE_MINUTE = WORK_PRICE_HOUR / 60;
        public const double WORKER_1_COSTS_SECOND = WORKER_1_COSTS_MINUTE / 60;
        public const double WORKER_2_COSTS_SECOND = WORKER_2_COSTS_MINUTE / 60;
        public const double OPERATING_EXPENSES_SECOND = OPERATING_EXPENSES_MINUTE / 60;
        public const double WORK_PRICE_SECOND = WORK_PRICE_MINUTE / 60;

        public const int CAR_PARK_1_PARKING_PLACES = 6;
        public const int CAR_PARK_2_PARKING_PLACES = 10;

        public const double CAR_SPEED_KMH = 5.0;
        public const double CAR_SPEED_MS = CAR_SPEED_KMH / 3.6;
        public const double CROSS_RAMP_DURATION = 7.0;

        public const double RAMP_TO_CAR_PARK_DISTANCE_M = 18.5;
        public const double CAR_PARK_TO_WORKSHOP_DISTANCE_M = 117.0;
        public const double WORKSHOP_TO_CAR_PARK_DISTANCE_M = 153.0;

        public const double RAMP_TO_CAR_PARK_TIME = RAMP_TO_CAR_PARK_DISTANCE_M / CAR_SPEED_MS;
        public const double CAR_PARK_TO_WORKSHOP_TIME = CAR_PARK_TO_WORKSHOP_DISTANCE_M / CAR_SPEED_MS;
        public const double WORKSHOP_TO_CAR_PARK_TIME = WORKSHOP_TO_CAR_PARK_DISTANCE_M / CAR_SPEED_MS;
    }
}
