using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Vector3Extensions_MinMax
    {
        static public Vector3 GetMin(this Vector3 item, Vector3 input)
        {
            return new Vector3(item.x.Min(input.x), item.y.Min(input.y), item.z.Min(input.z));
        }

        static public Vector3 GetMax(this Vector3 item, Vector3 input)
        {
            return new Vector3(item.x.Max(input.x), item.y.Max(input.y), item.z.Max(input.z));
        }

        static public void Order(this Vector3 item, Vector3 input, out Vector3 lower, out Vector3 upper)
        {
            float x_min;
            float x_max;
            item.x.Order(input.x, out x_min, out x_max);

            float y_min;
            float y_max;
            item.y.Order(input.y, out y_min, out y_max);

            float z_min;
            float z_max;
            item.z.Order(input.z, out z_min, out z_max);

            lower = new Vector3(x_min, y_min, z_min);
            upper = new Vector3(x_max, y_max, z_max);
        }
    }
}