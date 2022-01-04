using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_Solid
    {
        static public float GetSolidnessAt(this Texture2D item, int x, int y)
        {
            return item.GetPixelAt(x, y).a;
        }

        static public float GetSolidness(this Texture2D item, VectorI2 point)
        {
            return item.GetSolidnessAt(point.x, point.y);
        }
        static public float GetSolidness(this Texture2D item, RectI2 rect)
        {
            return rect.GetPoints()
                .Convert(p => item.GetSolidness(p))
                .Average();
        }

        static public bool IsSolidAt(this Texture2D item, int x, int y, float threshold=1e-3f)
        {
            if (item.GetSolidnessAt(x, y) >= threshold)
                return true;

            return false;
        }

        static public bool IsSolid(this Texture2D item, VectorI2 point, float threshold=1e-3f)
        {
            if (item.GetSolidness(point) >= threshold)
                return true;

            return false;
        }
        static public bool IsSolid(this Texture2D item, RectI2 rect, float threshold=1e-3f)
        {
            if (item.GetSolidness(rect) >= threshold)
                return true;

            return false;
        }
    }
}