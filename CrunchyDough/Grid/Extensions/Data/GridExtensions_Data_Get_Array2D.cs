using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Get_Array2D
    {
        static public T[,] GetDataArray2D<T>(this Grid<T> item)
        {
            return item.GetData().ConvertTo2D(item.GetWidth(), item.GetHeight());
        }
    }
}