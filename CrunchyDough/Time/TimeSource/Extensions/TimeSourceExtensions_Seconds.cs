using System;

namespace CrunchyDough
{
    static public class TimeSourceExtensions_Seconds
    {
        static public float GetCurrentTimeInSeconds(this TimeSource item)
        {
            return item.GetCurrentTime().GetSeconds();
        }
    }
}