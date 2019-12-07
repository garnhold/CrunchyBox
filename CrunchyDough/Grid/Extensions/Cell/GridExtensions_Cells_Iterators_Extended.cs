using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Cells_Iterators_Extended
    {
        static public IEnumerable<GridCell<T>> GetCardinalThenOrdinalNeighborCells<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCardinalNeighborCells(x, y).Append(item.GetOrdinalNeighborCells(x, y));
        }

        static public IEnumerable<GridCell<T>> GetNeighborCells<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCardinalThenOrdinalNeighborCells(x, y);
        }
    }
}