using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_Triangle
    {
        static public float CalculateTriangleArea(this VectorF2 point1, VectorF2 point2, VectorF2 point3)
        {
            float a;
            float b;
            float c;

            point1.GetDistanceTo(point2).Order(
                point2.GetDistanceTo(point3),
                point3.GetDistanceTo(point1),
                out c, out b, out a
            );

            float ab = a - b;

            float t1 = a + (b + c);
            float t2 = c - ab;
            float t3 = c + ab;
            float t4 = a + (b - c);

            return 0.25f * Mathq.Sqrt(t1 * t2 * t3 * t4);
        }

        static public float CalculateTriangleShortestToLongestSideRatio(this VectorF2 point1, VectorF2 point2, VectorF2 point3)
        {
            float a;
            float b;
            float c;

            point1.GetDistanceTo(point2).Order(
                point2.GetDistanceTo(point3),
                point3.GetDistanceTo(point1),
                out c, out b, out a
            );

            return c / a;
        }
    }
}