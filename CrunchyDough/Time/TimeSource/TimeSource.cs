using System;

namespace Crunchy.Dough
{
    public abstract class TimeSource
    {
        public abstract long GetCurrentTimeInMilliseconds();
    }
}