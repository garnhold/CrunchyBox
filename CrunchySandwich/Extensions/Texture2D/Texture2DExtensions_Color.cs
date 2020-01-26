using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Texture2DExtensions_Color
    {
        static public readonly Color BLANK = new Color(0.0f, 0.0f, 0.0f, 0.0f);

        static public void SetPixelAt(this Texture2D item, int x, int y, Color color)
        {
            if (item.IsIndexValid(x, y))
                item.SetPixel(x, y, color);
        }

        static public Color GetPixelAt(this Texture2D item, int x, int y)
        {
            if (item.IsIndexValid(x, y))
                return item.GetPixel(x, y);

            return BLANK;
        }
    }
}