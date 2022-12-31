using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Triangle
    {
        static public Triangle2 GetTriangle012(this Quad2 item)
        {
            return new Triangle2(item.v0, item.v1, item.v2);
        }

        static public Triangle2 GetTriangle230(this Quad2 item)
        {
            return new Triangle2(item.v2, item.v3, item.v0);
        }

        static public IEnumerable<Triangle2> GetTriangles(this Quad2 item)
        {
            yield return item.GetTriangle012();
            yield return item.GetTriangle230();
        }
    }
}