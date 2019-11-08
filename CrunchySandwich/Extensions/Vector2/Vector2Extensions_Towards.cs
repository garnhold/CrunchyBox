using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Towards
    {
        static public Vector2 GetTowards(this Vector2 item, Vector2 target, Vector2 amount)
        {
            return new Vector2(
                item.x.GetTowards(target.x, amount.x),
                item.y.GetTowards(target.y, amount.y)
            );
        }
        static public Vector2 GetTowards(this Vector2 item, Vector2 target, float amount)
        {
            return item.GetTowards(
                target,
                item.GetDirection(target) * amount
            );
        }
    }
}