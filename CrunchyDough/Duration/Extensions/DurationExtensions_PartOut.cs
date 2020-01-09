using System;

namespace Crunchy.Dough
{
    static public class DurationExtensions_PartOut
    {
        static public void GetDaysHoursMinutesSecondsMilliseconds(this Duration item, out int days, out int hours, out int minutes, out int seconds, out int milliseconds)
        {
            days = item.GetWholeDays(out item);
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
            milliseconds = (int)item.GetWholeMilliseconds();
        }
        static public void GetHoursMinutesSecondsMilliseconds(this Duration item, out int hours, out int minutes, out int seconds, out int milliseconds)
        {
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
            milliseconds = (int)item.GetWholeMilliseconds();
        }
        static public void GetMinutesSecondsMilliseconds(this Duration item, out int minutes, out int seconds, out int milliseconds)
        {
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
            milliseconds = (int)item.GetWholeMilliseconds();
        }
        static public void GetSecondsMilliseconds(this Duration item, out int seconds, out int milliseconds)
        {
            seconds = item.GetWholeSeconds(out item);
            milliseconds = (int)item.GetWholeMilliseconds();
        }

        static public void GetDaysHoursMinutesSeconds(this Duration item, out int days, out int hours, out int minutes, out int seconds)
        {
            days = item.GetWholeDays(out item);
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
        }
        static public void GetHoursMinutesSeconds(this Duration item, out int hours, out int minutes, out int seconds)
        {
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
        }
        static public void GetMinutesSeconds(this Duration item, out int minutes, out int seconds)
        {
            minutes = item.GetWholeMinutes(out item);
            seconds = item.GetWholeSeconds(out item);
        }

        static public void GetDaysHoursMinutes(this Duration item, out int days, out int hours, out int minutes)
        {
            days = item.GetWholeDays(out item);
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
        }
        static public void GetHoursMinutes(this Duration item, out int hours, out int minutes)
        {
            hours = item.GetWholeHours(out item);
            minutes = item.GetWholeMinutes(out item);
        }

        static public void GetDaysHours(this Duration item, out int days, out int hours)
        {
            days = item.GetWholeDays(out item);
            hours = item.GetWholeHours(out item);
        }
    }
}