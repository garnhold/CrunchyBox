using System;

namespace CrunchyDough
{
    static public class TimeSourceExtensions
    {
        static public long TimeProcessInMilliseconds(this TimeSource item, Process process)
        {
            long start_time = item.GetCurrentTimeInMilliseconds();

            process();

            return item.GetCurrentTimeInMilliseconds() - start_time;
        }
    }
}