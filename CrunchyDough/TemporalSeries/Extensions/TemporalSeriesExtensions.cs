using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class TemporalSeriesExtensions
    {
        static public void Reset(this TemporalSeries item)
        {
            item.SetElapsedTimeInMilliseconds(0);
        }

        static public void Restart(this TemporalSeries item)
        {
            item.StopClear();
            item.Start();
        }

        static public void StopClear(this TemporalSeries item)
        {
            item.Pause();
            item.Reset();
        }
    }
}