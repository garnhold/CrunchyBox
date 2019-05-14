using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Axis
    {
        static public float GetComponent(this Vector3 item, Axis axis)
        {
            switch (axis)
            {
                case Axis.X: return item.x;
                case Axis.Y: return item.y;
                case Axis.Z: return item.z;
            }

            return 0.0f;
        }
    }
}