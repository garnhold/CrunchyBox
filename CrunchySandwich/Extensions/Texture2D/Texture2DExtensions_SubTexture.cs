using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_SubTexture
    {
        static public Texture2D GetSubTexture(this Texture2D item, int x, int y, int width, int height)
        {
            return Texture2DExtensions.Create(width, height, item.GetPixels(x, y, width, height));
        }

        static public Texture2D GetSubTexture(this Texture2D item, Rect rect)
        {
            return item.GetSubTexture((int)rect.xMin, (int)rect.yMin, (int)rect.width, (int)rect.height);
        }

        static public void SetSubTexture(this Texture2D item, int dst_x, int dst_y, int src_x, int src_y, int width, int height, Texture2D src)
        {
            item.SetPixels(dst_x, dst_y, width, height, src.GetPixels(src_x, src_y, width, height));
        }

        static public void SetSubTexture(this Texture2D item, int x, int y, Texture2D src)
        {
            item.SetSubTexture(x, y, 0, 0, src.width, src.height, src);
        }
    }
}