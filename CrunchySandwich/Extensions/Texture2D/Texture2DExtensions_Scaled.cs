using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_Scaled
    {
        static public Texture2D GetScaledByFactor(this Texture2D item, float width_scale, float height_scale)
        {
            return item.CreateColorGrid()
                .ConvertToScaledByFactor(width_scale, height_scale)
                .CreateTexture2D();
        }
        static public Texture2D GetScaledByFactor(this Texture2D item, float scale)
        {
            return item.GetScaledByFactor(scale, scale);
        }

        static public Texture2D GetScaledToDimensions(this Texture2D item, int width, int height)
        {
            return item.CreateColorGrid()
                .ConvertToDimensionsScaled(width, height)
                .CreateTexture2D();
        }
    }
}