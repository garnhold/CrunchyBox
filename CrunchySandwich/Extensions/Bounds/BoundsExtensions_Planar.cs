﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_Planar
    {
        static public Rect GetPlanar(this Bounds item)
        {
            return RectExtensions.CreateMinMaxRect(item.min.GetPlanar(), item.max.GetPlanar());
        }

        static public Vector2 GetPlanarSize(this Bounds item)
        {
            return item.size.GetPlanar();
        }

        static public Vector2 GetPlanarExtents(this Bounds item)
        {
            return item.extents.GetPlanar();
        }

        static public float GetPlanarArea(this Bounds item)
        {
            return item.size.x * item.size.y;
        }
    }
}