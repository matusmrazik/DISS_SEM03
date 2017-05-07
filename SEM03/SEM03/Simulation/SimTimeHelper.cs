namespace SEM03.Simulation
{
    public static class SimTimeHelper
    {
        public const int WORKDAY_HOURS = 8;
        public const int WORKDAY_START_HOUR = 7;

        public const double MINUTE = 60.0;
        public const double HOUR = 3600.0;
        public const double DAY = WORKDAY_HOURS * HOUR;

        public static double Seconds(double secs)
        {
            return secs;
        }

        public static double Minutes(double mins)
        {
            return mins * 60.0;
        }

        public static double Hours(double hrs)
        {
            return hrs * 3600.0;
        }

        public static double Days(double d)
        {
            return Hours(d * WORKDAY_HOURS);
        }

        public static double ToSeconds(double time)
        {
            return time;
        }

        public static double ToMinutes(double time)
        {
            return time / 60.0;
        }

        public static double ToHours(double time)
        {
            return time / 3600.0;
        }

        public static double ToDays(double time)
        {
            return ToHours(time) / WORKDAY_HOURS;
        }

        public static string DurationAsString(double time)
        {
            var s = (int)time;
            var seconds = time - s + s % 60;
            var minutes = s / 60 % 60;
            var hours = s / 3600;
            return $"{hours:00}:{minutes:00}:{seconds:00.00}";
        }

        public static string SimTimeAsString(double time)
        {
            if (time < 0.0)
                return "-" + DurationAsString(-time);

            var s = (int)time;
            var seconds = time - s + s % 60;
            var minutes = s / 60 % 60;
            var hours = WORKDAY_START_HOUR + s / 3600 % WORKDAY_HOURS;
            var days = (int)ToDays(time) + 1;
            return $"deň {days}, {hours:00}:{minutes:00}:{seconds:00.00}";
        }
    }
}
