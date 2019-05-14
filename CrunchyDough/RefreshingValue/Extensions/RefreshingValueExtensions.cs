using System;

namespace CrunchyDough
{
    static public class RefreshingValueExtensions
    {
        static public void SetInterval<T>(this RefreshingValue<T> item, Duration duration)
        {
            item.SetIntervalInMilliseconds((long)duration.GetMilliseconds());
        }

        static public Duration GetInterval<T>(this RefreshingValue<T> item)
        {
            return Duration.Milliseconds(item.GetIntervalInMilliseconds());
        }
    }
}