using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Cells_Get
    {
        static public GridCell<T> GetCell<T>(this Grid<T> item, int x, int y)
        {
            GridCell<T> cell;

            item.TryGetCell(x, y, out cell);
            return cell;
        }
    }
}