using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class TemporalSeriesExtensions_General
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