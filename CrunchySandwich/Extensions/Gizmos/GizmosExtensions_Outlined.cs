using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class GizmosExtensions
    {
        static public void DrawOutlinedCube(Vector3 center, Vector3 size)
        {
            if(size.x > 0.0f && size.y > 0.0f && size.z > 0.0f)
                Gizmos.DrawCube(center, size);

            UseColor(Color.black, delegate() {
                Gizmos.DrawWireCube(center, size);
            });
        }
        static public void DrawOutlinedCube(Bounds bounds)
        {
            DrawOutlinedCube(bounds.center, bounds.size);
        }
        static public void DrawOutlinedCube(Rect bounds)
        {
            DrawOutlinedCube(bounds.center, bounds.size);
        }
    }
}