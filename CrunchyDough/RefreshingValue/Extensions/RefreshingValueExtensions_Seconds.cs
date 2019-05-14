using System;

namespace CrunchyDough
{
    static public class RefreshingValueExtensions_Seconds
    {
        static public void SetIntervalInSeconds<T>(this RefreshingValue<T> item, float seconds)
        {
            item.SetInterval(Duration.Seconds(seconds));
        }

        static public float GetIntervalInSeconds<T>(this RefreshingValue<T> item)
        {
            return item.GetInterval().GetSeconds();
        }
    }
}