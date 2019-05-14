using System;

namespace CrunchyDough
{
    static public class TimerDurationExtensions
    {
        static public T StartExpireAndGet<T>(this T item) where T : Timer_Duration
        {
            item.Start();
            item.Expire();

            return item;
        }
    }
}