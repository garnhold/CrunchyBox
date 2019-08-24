using System;
using System.Reflection;

namespace CrunchyDough
{
    public interface TemporalDuration : TemporalSeries
    {
        void SetDurationInMilliseconds(long d);
        long GetDurationInMilliseconds();
    }
}