using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Scaled
    {
        static public Texture2D GetScaled(this Texture2D item, float width_scale, float height_scale)
        {
            return Texture2DExtensions.Create(
                (int)(item.width * width_scale),
                (int)(item.height * height_scale),
                delegate(int x, int y) {
                    return item.GetPixelAt((int)(x / width_scale), (int)(y / height_scale));
                }
            );
        }
        static public Texture2D GetScaled(this Texture2D item, float scale)
        {
            return item.GetScaled(scale, scale);
        }

        static public Texture2D GetScaledToDimensions(this Texture2D item, int width, int height)
        {
            return item.GetScaled((float)width / (float)item.width, (float)height / (float)item.height);
        }
    }
}