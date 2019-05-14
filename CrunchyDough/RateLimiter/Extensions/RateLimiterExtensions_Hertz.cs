using System;

namespace CrunchyDough
{
    static public class RateLimiterExtensions_Hertz
    {
        static public void SetRate(this RateLimiter item, float hz)
        {
            item.SetInterval(Duration.Hertz(hz));
        }

        static public float GetRate(this RateLimiter item)
        {
            return item.GetInterval().GetHertz();
        }
    }
}