using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class IList2DExtensions_Texture2D
    {
        static public Texture2D CreateTexture2D<T>(this IList2D<T> item, Operation<Color, T> operation)
        {
            return Texture2DExtensions.Create(item.GetWidth(), item.GetHeight(), item.GetData().Convert(operation).ToArray());
        }

        static public Texture2D CreateTexture2D(this IList2D<Color> item)
        {
            return item.CreateTexture2D(c => c);
        }

        static public Texture2D CreateTexture2D(this IList2D<float> item)
        {
            return item.CreateTexture2D(f => new Color(f, f, f));
        }

        static public Texture2D CreateTexture2D(this IList2D<bool> item, Color true_color, Color false_color)
        {
            return item.CreateTexture2D(b => b.ConvertBool(true_color, false_color));
        }
        static public Texture2D CreateTexture2D(this IList2D<bool> item)
        {
            return item.CreateTexture2D(Color.black, Color.white);
        }
    }
}