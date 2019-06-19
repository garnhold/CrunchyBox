using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class FluxTimerExtensions
    {
        static public void AdjustMultiplier(this FluxTimer item, float amount)
        {
            item.SetMultiplier(item.GetMultiplier() + amount);
        }
    }
}