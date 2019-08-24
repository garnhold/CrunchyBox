using System;

namespace CrunchyDough
{
    public class RateLimiter
    {
        private Timer timer;

        public RateLimiter(long d, TimeSource t)
        {
            timer = new Timer(d, t).StartExpireAndGet();
        }

        public RateLimiter(long d) : this(d, TimeSource_System.INSTANCE) { }

        public RateLimiter(Duration d, TimeSource t) : this(d.GetWholeMilliseconds(), t) { }
        public RateLimiter(Duration d) : this(d, TimeSource_System.INSTANCE) { }

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