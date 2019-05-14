using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class FaceExtensions_Face
    {
        static public bool IntersectsFace(this Face item, Face face, out float distance, out Vector2 point)
        {
            return item.IntersectsRayLine(face.GetFaceRayLine(), out distance, out point);
        }

        static public bool IntersectsFace(this Face item, Face face, out float distance)
        {
            Vector2 point;

            return item.IntersectsFace(face, out distance, out point);
        }

        static public bool IntersectsFace(this Face item, Face face, out Vector2 point)
        {
            float distance;

            return item.IntersectsFace(face, out distance, out point);
        }
    }
}