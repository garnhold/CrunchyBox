using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GridCellExtensions_Vector2
    {
        static public Vector2 GetPosition<T>(this GridCell<T> item)
        {
            return new Vector2(item.GetX(), item.GetY());
        }
    }
}