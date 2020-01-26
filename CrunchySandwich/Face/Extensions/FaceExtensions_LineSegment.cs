using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class FaceExtensions_LineSegment
    {
        static public LineSegment2 GetLineSegment(this Face item)
        {
            return new LineSegment2(item.v0, item.v1);
        }
    }
}