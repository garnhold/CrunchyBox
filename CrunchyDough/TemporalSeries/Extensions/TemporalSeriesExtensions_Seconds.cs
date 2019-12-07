using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class TemporalSeriesExtensions_Seconds
    {
        static public float ResetGetSeconds(this TemporalSeries item)
        {
            return item.ResetGetTime().GetSeconds();
        }

        static public float RestartGetSeconds(this TemporalSeries item)
        {
            return item.RestartGetTime().GetSeconds();
        }

        static public void AddElapsedTimeInSeconds(this TemporalSeries item, float seconds)
        {
            item.AddElapsedTime(Duration.Seconds(seconds));
        }

        static public void SetElapsedTimeInSeconds(this TemporalSeries item, float seconds)
        {
            item.SetElapsedTime(Duration.Seconds(seconds));
        }

        static public float GetElapsedTimeInSeconds(this TemporalSeries item)
        {
            return item.GetElapsedTime().GetSeconds();
        }
    }
}