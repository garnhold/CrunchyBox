using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_Fill
    {
        static public int GetPowerFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            int x_power = item.x.GetPowerFillByMultiplier(target.x, multiplier);
            int y_power = item.y.GetPowerFillByMultiplier(target.y, multiplier);

            return x_power.Min(y_power);
        }

        static public float GetMultiplierFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            float x_multiplier = item.x.GetMultiplierFillByMultiplier(target.x, multiplier);
            float y_multiplier = item.y.GetMultiplierFillByMultiplier(target.y, multiplier);

            return x_multiplier.Min(y_multiplier);
        }

        static public Vector2 GetFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            return item.GetMultiplierFillByMultiplier(target, multiplier) * item;
        }
    }
}