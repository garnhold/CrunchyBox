using System;

namespace CrunchyDough
{
    public class RateLimiter
    {
        private Timer_Duration timer;

        public RateLimiter(long d, TimeSource t)
        {
            timer = new Timer_Duration(d, t).StartExpireAndGet();
        }

        public RateLimiter(long d) : this(d, TimeSource_Stopwatch.INSTANCE) { }

        public RateLimiter(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }
        public RateLimiter(Duration d) : this(d, TimeSource_Stopwatch.INSTANCE) { }

        public bool Process(Process process)
        {
            if (timer.Repeat())
            {
                process();
                return true;
            }

            return false;
        }

        public void Prime()
        {
            timer.Expire();
        }

        public void Reset()
        {
            timer.Reset();
        }

        public void SetIntervalInMilliseconds(long milliseconds)
        {
            timer.SetDurationInMilliseconds(milliseconds);
        }

        public long GetIntervalInMilliseconds()
        {
            return timer.GetDurationInMilliseconds();
        }
    }
}