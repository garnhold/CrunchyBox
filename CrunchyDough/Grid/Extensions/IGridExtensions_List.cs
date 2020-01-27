using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_List
    {
        static public void Add<T>(this IGrid<List<T>> item, int x, int y, T value)
        {
            item.GetOrCreate(x, y, () => new List<T>()).Add(value);
        }
        static public void Add<T>(this IGrid<List<T>> item, VectorI2 index, T value)
        {
            item.Add(index.x, index.y, value);
        }
    }
}