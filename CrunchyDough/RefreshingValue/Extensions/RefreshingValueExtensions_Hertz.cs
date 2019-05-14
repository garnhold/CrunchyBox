using System;

namespace CrunchyDough
{
    static public class RefreshingValueExtensions_Hertz
    {
        static public void SetRate<T>(this RefreshingValue<T> item, float hz)
        {
            item.SetInterval(Duration.Hertz(hz));
        }

        static public float GetRate<T>(this RefreshingValue<T> item)
        {
            return item.GetInterval().GetHertz();
        }
    }
}