using System;

namespace CrunchyDough
{
    public class Timer : Stopwatch, TemporalDuration
    {
        private long duration_in_milliseconds;

        public Timer(long d, TimeSource t) : base(t)
        {
            SetDurationInMilliseconds(d);
        }

        public Timer(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }

        public Timer(long d) : this(d, TimeSource_System.INSTANCE) { }
        public Timer(Duration d) : this(d, TimeSource_System.INSTANCE) { }

        public Timer(TimeSource t) : this(0, t) { }

        public Timer() : this(0) { }

        public void SetDurationInMilliseconds(long d)
        {
            duration_in_milliseconds = d;
        }

        public long GetDurationInMilliseconds()
        {
            return duration_in_milliseconds;
        }
    }
}