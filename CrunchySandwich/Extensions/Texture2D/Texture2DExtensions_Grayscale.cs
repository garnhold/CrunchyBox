using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Texture2DExtensions_Grayscale
    {
        static public void SetGrayscaleAt(this Texture2D item, int x, int y, float g)
        {
            item.SetPixelAt(x, y, ColorExtensions.CreateGrayscale(g));
        }

        static public float GetGrayscaleAt(this Texture2D item, int x, int y)
        {
            return item.GetPixelAt(x, y).GetGrayscale();
        }
    }
}