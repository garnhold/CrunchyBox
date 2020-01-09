using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class LineSegment2Extensions_Ray
    {
        static public Ray2 GetRay(this LineSegment2 item)
        {
            return new Ray2(item.v0, item.v1 - item.v0);
        }
    }
}