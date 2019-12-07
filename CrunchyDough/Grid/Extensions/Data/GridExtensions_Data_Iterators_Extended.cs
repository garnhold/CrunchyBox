using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class GridExtensions_Data_Iterators_Extended
    {
        static public IEnumerable<T> GetCardinalThenOrdinalNeighborData<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCardinalNeighborData(x, y).Append(item.GetOrdinalNeighborData(x, y));
        }

        static public IEnumerable<T> GetNeighborData<T>(this Grid<T> item, int x, int y)
        {
            return item.GetCardinalThenOrdinalNeighborData(x, y);
        }
    }
}