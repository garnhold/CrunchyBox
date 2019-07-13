using System;

namespace CrunchyDough
{
    static public class TimeSourceExtensions_Duration
    {
        static public Duration GetCurrentTime(this TimeSource item)
        {
            return Duration.Milliseconds(item.GetCurrentTimeInMilliseconds());
        }
    }
}