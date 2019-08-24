using System;

namespace CrunchyDough
{
    static public class TemporalSeriesExtensions_Restart
    {
        static public void RestartSetElapsedTime(this TemporalSeries item, Duration duration)
        {
            item.Restart();
            item.SetElapsedTime(duration);
        }

        static public void RestartSetElapsedTimeInMilliseconds(this TemporalSeries item, long milliseconds)
        {
            item.RestartSetElapsedTime(Duration.Milliseconds(milliseconds));
        }

        static public void RestartSetElapsedTimeInSeconds(this TemporalSeries item, float seconds)
        {
            item.RestartSetElapsedTime(Duration.Seconds(seconds));
        }
    }
}