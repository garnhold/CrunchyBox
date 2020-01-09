using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Iterators_Neighbors
    {
        static public IEnumerable<T> GetCardinalNeighborData<T>(this Grid<T> item, int x, int y)
        {
            yield return item.GetData(x - 1, y);
            yield return item.GetData(x + 1, y);
            yield return item.GetData(x, y - 1);
            yield return item.GetData(x, y + 1);
        }

        static public IEnumerable<T> GetOrdinalNeighborData<T>(this Grid<T> item, int x, int y)
        {
            yield return item.GetData(x - 1, y + 1);
            yield return item.GetData(x - 1, y - 1);
            yield return item.GetData(x + 1, y + 1);
            yield return item.GetData(x + 1, y - 1);
        }
    }
}