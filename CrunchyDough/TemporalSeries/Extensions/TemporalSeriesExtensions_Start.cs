using System;

namespace CrunchyDough
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
    }
}