using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class RayLine2Extensions_Transform
    {
        static public RayLine2 GetReversed(this RayLine2 item)
        {
            return new RayLine2(item.terminus, item.origin);
        }
    }
}