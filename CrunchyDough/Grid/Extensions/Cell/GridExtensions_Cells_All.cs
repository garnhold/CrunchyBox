using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Cells_All
    {
        static public IEnumerable<GridCell<T>> GetCells<T>(this Grid<T> item)
        {
            return item;
        }
    }
}