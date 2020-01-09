using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public interface TemporalSeries : Temporal
    {
        void SetElapsedTimeInMilliseconds(long m);
        long GetElapsedTimeInMilliseconds();
    }
}