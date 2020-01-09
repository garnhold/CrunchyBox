using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_IsBound
    {
        static public bool IsBoundAbove(this Vector3 item, Vector3 value)
        {
            if (item.x >= value.x && item.y >= value.y && item.z >= value.z)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this Vector3 item, Vector3 value)
        {
            if (item.x <= value.x && item.y <= value.y && item.z <= value.z)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this Vector3 item, Vector3 value1, Vector3 value2)
        {
            Vector3 lower;
            Vector3 upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}