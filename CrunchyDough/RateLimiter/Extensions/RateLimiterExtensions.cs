using System;

namespace CrunchyDough
{
    static public class RateLimiterExtensions
    {
        static public void SetInterval(this RateLimiter item, Duration duration)
        {
            item.SetIntervalInMilliseconds((long)duration.GetMilliseconds());
        }

        static public Duration GetInterval(this RateLimiter item)
        {
            return Duration.Milliseconds(item.GetIntervalInMilliseconds());
        }
    }
}