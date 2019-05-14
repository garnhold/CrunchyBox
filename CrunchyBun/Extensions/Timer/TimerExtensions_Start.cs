using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class TimerExtensions_Start
    {
        static public bool StartWithRandomElapsedTimeInMilliseconds(this Timer item, long milliseconds)
        {
            return item.StartSetElapsedTimeInMilliseconds(RandInt.GetMagnitude((int)milliseconds));
        }

        static public bool StartWithRandomElapsedTime(this Timer item, Duration amount)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds((int)amount.GetMilliseconds());
        }

        static public bool StartWithRandomElapsedTimeInSeconds(this Timer item, float seconds)
        {
            return item.StartWithRandomElapsedTime(Duration.Seconds(seconds));
        }
    }
}