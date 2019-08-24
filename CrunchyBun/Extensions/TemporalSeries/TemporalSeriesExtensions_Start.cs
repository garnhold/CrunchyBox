using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class TemporalSeriesExtensions_Start
    {
        static public bool StartWithRandomElapsedTimeInMilliseconds(this TemporalSeries item, long milliseconds)
        {
            return item.StartSetElapsedTimeInMilliseconds(RandInt.GetMagnitude((int)milliseconds));
        }

        static public bool StartWithRandomElapsedTime(this TemporalSeries item, Duration amount)
        {
            return item.StartWithRandomElapsedTimeInMilliseconds((int)amount.GetMilliseconds());
        }

        static public bool StartWithRandomElapsedTimeInSeconds(this TemporalSeries item, float seconds)
        {
            return item.StartWithRandomElapsedTime(Duration.Seconds(seconds));
        }
    }
}