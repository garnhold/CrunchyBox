using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Intersect_Face
    {
        static public bool IsIntersecting(this Face item, Face face, out float distance, out Vector2 point)
        {
            return item.IsIntersecting(face.GetLineSegment(), out distance, out point);
        }

        static public bool IsIntersecting(this Face item, Face face, out float distance)
        {
            Vector2 point;

            return item.IsIntersecting(face, out distance, out point);
        }

        static public bool IsIntersecting(this Face item, Face face, out Vector2 point)
        {
            float distance;

            return item.IsIntersecting(face, out distance, out point);
        }
    }
}