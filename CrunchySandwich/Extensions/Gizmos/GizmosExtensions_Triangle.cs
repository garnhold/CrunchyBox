using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class GizmosExtensions
    {
        static public void DrawTriangle(Triangle3 triangle)
        {
            Gizmos.DrawLine(triangle.v0, triangle.v1);
            Gizmos.DrawLine(triangle.v1, triangle.v2);
            Gizmos.DrawLine(triangle.v2, triangle.v0);
        }

        static public void DrawTriangle(Triangle2 triangle)
        {
            Gizmos.DrawLine(triangle.v0, triangle.v1);
            Gizmos.DrawLine(triangle.v1, triangle.v2);
            Gizmos.DrawLine(triangle.v2, triangle.v0);
        }
    }
}