using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Fill
    {
        static public int GetPowerFillByMultiplier(this VectorF2 item, VectorF2 target, float multiplier)
        {
            int x_power = item.x.GetPowerFillByMultiplier(target.x, multiplier);
            int y_power = item.y.GetPowerFillByMultiplier(target.y, multiplier);

            return x_power.Min(y_power);
        }

        static public float GetMultiplierFillByMultiplier(this VectorF2 item, VectorF2 target, float multiplier)
        {
            float x_multiplier = item.x.GetMultiplierFillByMultiplier(target.x, multiplier);
            float y_multiplier = item.y.GetMultiplierFillByMultiplier(target.y, multiplier);

            return x_multiplier.Min(y_multiplier);
        }

        static public VectorF2 GetFillByMultiplier(this VectorF2 item, VectorF2 target, float multiplier)
        {
            return item.GetMultiplierFillByMultiplier(target, multiplier) * item;
        }
    }
}