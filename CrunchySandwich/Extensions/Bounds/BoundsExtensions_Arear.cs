using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class BoundsExtensions_Arear
    {
        static public Rect GetArear(this Bounds item)
        {
            return RectExtensions.CreateMinMaxRect(item.min.GetArear(), item.max.GetArear());
        }

        static public Vector2 GetArearSize(this Bounds item)
        {
            return item.size.GetArear();
        }

        static public Vector2 GetArearExtents(this Bounds item)
        {
            return item.extents.GetArear();
        }

        static public float GetArearArea(this Bounds item)
        {
            return item.size.x * item.size.z;
        }
    }
}