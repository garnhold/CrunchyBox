using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class FaceCloudExtensions_Polygon
    {
        static public Polygon BuildPolygon(this FaceCloud item)
        {
            return new Polygon(item.Tesselate());
        }
    }
}