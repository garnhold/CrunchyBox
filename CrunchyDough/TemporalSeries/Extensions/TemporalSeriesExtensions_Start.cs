using System;

namespace Crunchy.Dough
{
    static public class TemporalSeriesExtensions_Start
    {
        static public bool StartSetElapsedTime(this TemporalSeries item, Duration duration)
        {
            if (item.Start())
            {
                item.SetElapsedTime(duration);

                return true;
            }

            return false;
        }

        static public bool StartSetElapsedTimeInMilliseconds(this TemporalSeries item, long milliseconds)
        {
            return item.StartSetElapsedTime(Duration.Milliseconds(milliseconds));
        }

        static public bool StartSetElapsedTimeInSeconds(this TemporalSeries item, float seconds)
        {
            return item.StartSetElapsedTime(Duration.Seconds(seconds));
        }

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