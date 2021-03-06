using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawRay(Ray ray, float size)
        {
            DrawVectorArrow(ray.origin, ray.direction, size);
        }
        static public void DrawRay(Ray ray)
        {
            DrawRay(ray, 0.3f);
        }

        static public void DrawRay(Ray2 ray, float size)
        {
            DrawVectorArrow(ray.origin, ray.direction, size);
        }
        static public void DrawRay(Ray2 ray)
        {
            DrawRay(ray, 0.3f);
        }
    }
}