using System;

namespace GdNet.Common
{
    /// <summary>
    /// Extension method for time types
    /// </summary>
    public static class TimeExtensions
    {
        /// <summary>
        /// Get integer representation of a timespan. Eg 012010 => 1 hour 20 minutes 10 seconds
        /// </summary>
        public static int ToNumber(this TimeSpan time)
        {
            var timeStr = string.Format("{0:00}{1:00}{2:00}{3:00}", time.Days, time.Hours, time.Minutes, time.Seconds);
            return int.Parse(timeStr);
        }
    }
}