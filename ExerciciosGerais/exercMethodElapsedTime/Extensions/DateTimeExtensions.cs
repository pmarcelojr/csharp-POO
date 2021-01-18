using System;
using System.Globalization;

namespace exercMethodElapsedTime.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("f1", CultureInfo.InvariantCulture) + " Hours";
            }
            else
            {
                return duration.TotalDays.ToString("f1", CultureInfo.InvariantCulture) + " Days";
            }
        }
    }
}