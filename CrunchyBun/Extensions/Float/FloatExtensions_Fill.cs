using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public class FloatExtensions_Fill
    {
        static public int GetPowerFillByMultiplier(this float item, float target, float multiplier)
        {
            return Mathq.FloorToInt(
                Mathq.Log(multiplier, target / item)
            );
        }
        static public float GetMultiplierFillByMultiplier(this float item, float target, float multiplier)
        {
            return Mathq.Pow(
                multiplier,
                item.GetPowerFillByMultiplier(target, multiplier)
            );
        }
        static public float GetFillByMultiplier(this float item, float target, float multiplier)
        {
            return item.GetMultiplierFillByMultiplier(target, multiplier) * item;
        }
    }
}