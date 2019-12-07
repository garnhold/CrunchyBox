using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class FaceExtensions_Triangle
    {
        static public bool TryCreateTriangle(this Face item, Face face, out Triangle2 triangle)
        {
            if (item.v1 == face.v0)
            {
                if (item.IsInside(face.v1))
                {
                    triangle = new Triangle2(item.v0, face.v0, face.v1);
                    return true;
                }
            }

            triangle = default(Triangle2);
            return false;
        }

        static public bool TryCreateTriangle(this Face item, Face face, out Triangle2 triangle, out Face missing)
        {
            if (item.TryCreateTriangle(face, out triangle))
            {
                missing = FaceExtensions.CreatePoints(face.v1, item.v0);
                return true;
            }

            missing = default(Face);
            return false;
        }
    }
}