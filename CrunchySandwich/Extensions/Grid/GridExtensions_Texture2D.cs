using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class GridExtensions_Texture2D
    {
        static public Texture2D CreateTexture2D<T>(this Grid<T> item, Operation<Color, T> operation)
        {
            return Texture2DExtensions.Create(item.GetWidth(), item.GetHeight(), item.GetData().Convert(operation).ToArray());
        }

        static public Texture2D CreateTexture2D(this Grid<float> item)
        {
            return item.CreateTexture2D(f => new Color(f, f, f));
        }

        static public Texture2D CreateTexture2D(this Grid<bool> item, Color true_color, Color false_color)
        {
            return item.CreateTexture2D(b => b.ConvertBool(true_color, false_color));
        }
        static public Texture2D CreateTexture2D(this Grid<bool> item)
        {
            return item.CreateTexture2D(Color.black, Color.white);
        }
    }
}