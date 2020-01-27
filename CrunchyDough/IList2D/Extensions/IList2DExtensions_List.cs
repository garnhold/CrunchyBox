using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_List
    {
        static public void Add<T>(this IList2D<List<T>> item, int x, int y, T value)
        {
            item.GetOrCreate(x, y, () => new List<T>()).Add(value);
        }
        static public void Add<T>(this IList2D<List<T>> item, VectorI2 index, T value)
        {
            item.Add(index.x, index.y, value);
        }
    }
}