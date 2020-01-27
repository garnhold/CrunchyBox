using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_To
    {
        static public Grid_List<T> ToGrid<T>(this IGrid<T> item)
        {
            return new Grid_List<T>(item);
        }

        static public T[,] ToArray2D<T>(this IGrid<T> item)
        {
            T[,] array = new T[item.GetWidth(), item.GetHeight()];

            item.ProcessWithIndexs((x, y, v) => array[x, y] = v);
            return array;
        }
    }
}