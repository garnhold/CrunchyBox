using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Cells_Get_Array2D
    {
        static public GridCell<T>[,] GetCellArray2D<T>(this Grid<T> item)
        {
            return item.GetCells().ConvertTo2D(item.GetWidth(), item.GetHeight());
        }
    }
}