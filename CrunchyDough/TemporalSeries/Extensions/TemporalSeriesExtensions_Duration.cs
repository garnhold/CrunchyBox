using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TemporalSeriesExtensions_Duration
    {
        static public Duration ResetGetTime(this TemporalSeries item)
        {
            return Duration.Milliseconds(item.ResetGetMilliseconds());
        }

        static public Duration RestartGetTime(this TemporalSeries item)
        {
            return Duration.Milliseconds(item.RestartGetMilliseconds());
        }

        static public void AddElapsedTime(this TemporalSeries item, Duration duration)
        {
            item.AddElapsedTimeInMilliseconds(duration.GetWholeMilliseconds());
        }

        static public void SetElapsedTime(this TemporalSeries item, Duration duration)
        {
            item.SetElapsedTimeInMilliseconds(duration.GetWholeMilliseconds());
        }

        static public Duration GetElapsedTime(this TemporalSeries item)
        {
            return Duration.Milliseconds(item.GetElapsedTimeInMilliseconds());
        }
    }
}