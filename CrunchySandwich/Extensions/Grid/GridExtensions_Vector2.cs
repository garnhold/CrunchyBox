using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GridExtensions_Vector2
    {
        static public Vector2 GetSize<T>(this Grid<T> item)
        {
            return new Vector2(item.GetWidth(), item.GetHeight());
        }

        static public Vector2 GetExtents<T>(this Grid<T> item)
        {
            return item.GetSize() * 0.5f;
        }
    }
}