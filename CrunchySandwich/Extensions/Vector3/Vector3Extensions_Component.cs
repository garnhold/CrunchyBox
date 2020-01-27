using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3Extensions_Component
    {
        static public Vector3 GetComponentMultiply(this Vector3 item, Vector3 other)
        {
            return new Vector3(item.x * other.x, item.y * other.y, item.z * other.z);
        }

        static public Vector3 GetComponentDivide(this Vector3 item, Vector3 other)
        {
            return new Vector3(item.x / other.x, item.y / other.y, item.z / other.z);
        }
    }
}