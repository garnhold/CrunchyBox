using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_IGrid
    {
        static public IGrid<Color> CreateColorGrid(this Texture2D item)
        {
            return item.CreateGrid<Color>(c => c);
        }

        static public IGrid<float> CreateAlphaGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.a);
        }

        static public IGrid<float> CreateGrayscaleGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.grayscale);
        }

        static public IGrid<Vector2> CreateVector2Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector2());
        }

        static public IGrid<Vector3> CreateVector3Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector3());
        }

        static public IGrid<bool> CreateSolidGrid(this Texture2D item, float alpha_threshold)
        {
            return item.CreateGrid<bool>(c => c.a >= alpha_threshold);
        }

        static public IGrid<T> CreateGrid<T>(this Texture2D item, Operation<T, Color> operation)
        {
            return new Grid<T>(item.width, item.height, item.GetPixels().Convert(operation));
        }
    }
}