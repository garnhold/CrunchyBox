using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class TemporalSeriesExtensions_Milliseconds
    {
        static public void AddElapsedTimeInMilliseconds(this TemporalSeries item, long milliseconds)
        {
            item.SetElapsedTimeInMilliseconds(item.GetElapsedTimeInMilliseconds() + milliseconds);
        }

        static public long ResetGetMilliseconds(this TemporalSeries item)
        {
            long milliseconds = item.GetElapsedTimeInMilliseconds();

            item.Reset();
            return milliseconds;
        }

        static public long RestartGetMilliseconds(this TemporalSeries item)
        {
            long milliseconds = item.GetElapsedTimeInMilliseconds();

            item.Restart();
            return milliseconds;
        }
    }
}