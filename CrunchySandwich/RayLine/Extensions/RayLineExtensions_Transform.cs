using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class RayLineExtensions_Transform
    {
        static public RayLine GetReverse(this RayLine item)
        {
            return new RayLine(item.terminus, item.origin);
        }
    }
}