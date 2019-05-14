using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class DateTimeExtensions_TimeZone
    {
        static public DateTime GetUTC(this DateTime item)
        {
            return TimeZoneInfo.ConvertTimeToUtc(item);
        }

        static public DateTime GetLocal(this DateTime item)
        {
            return item.GetLocal(TimeZoneInfo.Local);
        }
        static public DateTime GetLocal(this DateTime item, TimeZoneInfo time_zone)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(item, time_zone);
        }
    }
}