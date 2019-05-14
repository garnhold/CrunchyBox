using System;

namespace CrunchyDough
{
    public class RefreshingValue<T>
    {
        private RateLimiter rate_limiter;

        private T value;
        private Operation<T> operation;

        public RefreshingValue(RateLimiter r, Operation<T> o)
        {
            rate_limiter = r;

            operation = o;
        }

        public RefreshingValue(long d, Operation<T> o) : this(new RateLimiter(d), o) { }
        public RefreshingValue(Duration d, Operation<T> o) : this(new RateLimiter(d), o) { }

        public T GetValue()
        {
            rate_limiter.Process(delegate() {
                value = operation();
            });

            return value;
        }

        public void Prime()
        {
            rate_limiter.Prime();
        }

        public void Reset()
        {
            rate_limiter.Reset();
        }

        public void SetIntervalInMilliseconds(long milliseconds)
        {
            rate_limiter.SetIntervalInMilliseconds(milliseconds);
        }

        public long GetIntervalInMilliseconds()
        {
            return rate_limiter.GetIntervalInMilliseconds();
        }
    }
}