using System;

namespace CrunchyDough
{
    public abstract class TimeSource
    {
        public abstract long GetCurrentTimeInMilliseconds();
    }
}