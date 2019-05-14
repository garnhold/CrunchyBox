using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Cells_Get_Looped
    {
        static public GridCell<T> GetCellLooped<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCell(x.GetLooped(item.GetWidth()), y.GetLooped(item.GetHeight()));
        }
    }
}