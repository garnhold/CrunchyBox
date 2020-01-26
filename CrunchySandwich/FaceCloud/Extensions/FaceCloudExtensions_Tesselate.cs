using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class FaceCloudExtensions_Tesselate
    {
        static public IEnumerable<PolygonTriangle> Tesselate(this FaceCloud item)
        {
            return item.GetVertexLoops().Convert(l => l.TesselateLoop()).Flatten();
        }
    }
}