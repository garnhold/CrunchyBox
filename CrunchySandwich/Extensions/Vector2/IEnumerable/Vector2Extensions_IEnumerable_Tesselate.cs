using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Tesselate
    {
        static public IEnumerable<PolygonTriangle> TesselateLoop(this IEnumerable<Vector2> item)
        {
            return item.BuildFaceLoop().TesselateLoop();
        }
    }
}