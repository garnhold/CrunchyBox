using System;

namespace CrunchyDough
{
    static public class RateLimiterExtensions_Seconds
    {
        static public void SetIntervalInSeconds(this RateLimiter item, float seconds)
        {
            item.SetInterval(Duration.Seconds(seconds));
        }

        static public float GetIntervalInSeconds(this RateLimiter item)
        {
            return item.GetInterval().GetSeconds();
        }
    }
}