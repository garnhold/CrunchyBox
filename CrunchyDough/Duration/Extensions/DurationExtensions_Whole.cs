using System;

namespace Crunchy.Dough
{
    static public class DurationExtensions_Whole
    {
        static public int GetWholeDays(this Duration item)
        {
            return (int)item.GetDays();
        }
        static public int GetWholeDays(this Duration item, out Duration remainder)
        {
            int whole_days = item.GetWholeDays();

            remainder = item - Duration.Days(whole_days);
            return whole_days;
        }

        static public int GetWholeHours(this Duration item)
        {
            return (int)item.GetHours();
        }
        static public int GetWholeHours(this Duration item, out Duration remainder)
        {
            int whole_hours = item.GetWholeHours();

            remainder = item - Duration.Hours(whole_hours);
            return whole_hours;
        }

        static public int GetWholeMinutes(this Duration item)
        {
            return (int)item.GetMinutes();
        }
        static public int GetWholeMinutes(this Duration item, out Duration remainder)
        {
            int whole_minutes = item.GetWholeMinutes();

            remainder = item - Duration.Minutes(whole_minutes);
            return whole_minutes;
        }

        static public int GetWholeSeconds(this Duration item)
        {
            return (int)item.GetSeconds();
        }
        static public int GetWholeSeconds(this Duration item, out Duration remainder)
        {
            int whole_seconds = item.GetWholeSeconds();

            remainder = item - Duration.Seconds(whole_seconds);
            return whole_seconds;
        }
    }
}