using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3Extensions_Towards
    {
        static public Vector3 GetTowards(this Vector3 item, Vector3 target, Vector3 amount)
        {
            return new Vector3(
                item.x.GetTowards(target.x, amount.x),
                item.y.GetTowards(target.y, amount.y),
                item.z.GetTowards(target.z, amount.z)
            );
        }
        static public Vector3 GetTowards(this Vector3 item, Vector3 target, float amount)
        {
            return item.GetTowards(
                target,
                item.GetDirection(target) * amount
            );
        }
    }
}