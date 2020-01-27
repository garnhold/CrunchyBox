using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class IList2DExtensions_Vector2
    {
        static public Vector2 GetSize<T>(this IList2D<T> item)
        {
            return new Vector2(item.GetWidth(), item.GetHeight());
        }

        static public Vector2 GetExtents<T>(this IList2D<T> item)
        {
            return item.GetSize() * 0.5f;
        }
    }
}