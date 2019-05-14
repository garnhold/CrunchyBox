using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class GridExtensions_Cells_Iterators_Neighbors
    {
        static public IEnumerable<GridCell<T>> GetCardinalNeighborCells<T>(this Grid<T> item, int x, int y)
        {
            GridCell<T> cell;

            if (item.TryGetCell(x - 1, y, out cell))
                yield return cell;

            if (item.TryGetCell(x + 1, y, out cell))
                yield return cell;

            if (item.TryGetCell(x, y - 1, out cell))
                yield return cell;

            if (item.TryGetCell(x, y + 1, out cell))
                yield return cell;
        }

        static public IEnumerable<GridCell<T>> GetOrdinalNeighborCells<T>(this Grid<T> item, int x, int y)
        {
            GridCell<T> cell;

            if (item.TryGetCell(x - 1, y - 1, out cell))
                yield return cell;

            if (item.TryGetCell(x - 1, y + 1, out cell))
                yield return cell;

            if (item.TryGetCell(x + 1, y - 1, out cell))
                yield return cell;

            if (item.TryGetCell(x + 1, y + 1, out cell))
                yield return cell;
        }
    }
}