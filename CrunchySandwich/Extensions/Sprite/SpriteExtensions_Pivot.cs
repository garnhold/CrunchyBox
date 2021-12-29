using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteExtensions_Pivot
    {
        static public Vector2 GetPixelPivot(this Sprite item)
        {
            return item.pivot;
        }

        static public Vector2 GetNormalizedPivot(this Sprite item)
        {
            return item.GetPixelPivot().GetComponentDivide(item.GetTextureSize());
        }

        static public Vector2 GetWorldPivot(this Sprite item)
        {
            return item.GetPixelPivot() * item.GetUnitsPerPixel();
        }
    }
}