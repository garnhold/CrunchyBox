using System;
using System.Reflection;

namespace CrunchyDough
{
    public interface TemporalSeries : Temporal
    {
        void SetElapsedTimeInMilliseconds(long m);
        long GetElapsedTimeInMilliseconds();
    }
}