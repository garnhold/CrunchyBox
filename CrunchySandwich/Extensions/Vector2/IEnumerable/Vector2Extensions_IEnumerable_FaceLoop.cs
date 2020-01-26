using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_IEnumerable_FaceLoop
    {
        static public IEnumerable<Face> BuildFaceLoop(this IEnumerable<Vector2> item)
        {
            return item.CloseLoop().ConvertConnections((v0, v1) => FaceExtensions.CreatePoints(v0, v1));
        }
    }
}