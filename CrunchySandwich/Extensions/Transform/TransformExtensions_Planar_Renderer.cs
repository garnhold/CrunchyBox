using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Planar_Bounds
    {
        static public Rect GetPlanarRendererBounds(this Transform item)
        {
            return item.GetComponent<Renderer>().bounds.GetPlanar();
        }
    }
}