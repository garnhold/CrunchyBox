using System;
using System.Reflection;

namespace Crunchy.Dough
{
    public interface TemporalDuration : TemporalSeries
    {
        void SetDurationInMilliseconds(long d);
        long GetDurationInMilliseconds();
    }
}