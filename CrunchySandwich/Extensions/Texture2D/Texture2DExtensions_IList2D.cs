using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Texture2DExtensions_IList2D
    {
        static public IList2D<Color> CreateColorGrid(this Texture2D item)
        {
            return item.CreateGrid<Color>(c => c);
        }

        static public IList2D<float> CreateAlphaGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.a);
        }

        static public IList2D<float> CreateGrayscaleGrid(this Texture2D item)
        {
            return item.CreateGrid<float>(c => c.grayscale);
        }

        static public IList2D<Vector2> CreateVector2Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector2());
        }

        static public IList2D<Vector3> CreateVector3Grid(this Texture2D item)
        {
            return item.CreateGrid(c => c.GetVector3());
        }

        static public IList2D<bool> CreateSolidGrid(this Texture2D item, float alpha_threshold)
        {
            return item.CreateGrid<bool>(c => c.a >= alpha_threshold);
        }

        static public IList2D<T> CreateGrid<T>(this Texture2D item, Operation<T, int, int> operation)
        {
            return new List2D_List<T>(item.width, item.height, operation);
        }

        static public IList2D<T> CreateGrid<T>(this Texture2D item, Operation<T, Color> operation)
        {
            return new List2D_List<T>(item.width, item.height, item.GetPixels().Convert(operation));
        }
    }
}