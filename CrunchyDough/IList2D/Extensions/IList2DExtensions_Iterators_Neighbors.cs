using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Iterators_Neighbors
    {
        static public IEnumerable<T> GetCardinalNeighbors<T>(this IList2D<T> item, int x, int y, T default_value)
        {
            yield return item.Get(x - 1, y, default_value);
            yield return item.Get(x + 1, y, default_value);
            yield return item.Get(x, y - 1, default_value);
            yield return item.Get(x, y + 1, default_value);
        }
        static public IEnumerable<T> GetCardinalNeighbors<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetCardinalNeighbors<T>(x, y, default(T));
        }

        static public IEnumerable<T> GetOrdinalNeighbors<T>(this IList2D<T> item, int x, int y, T default_value)
        {
            yield return item.Get(x - 1, y - 1);
            yield return item.Get(x - 1, y + 1);
            yield return item.Get(x + 1, y - 1);
            yield return item.Get(x + 1, y + 1);
        }
        static public IEnumerable<T> GetOrdinalNeighbors<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetOrdinalNeighbors<T>(x, y, default(T));
        }

        static public IEnumerable<T> GetCardinalThenOrdinalNeighbors<T>(this IList2D<T> item, int x, int y, T default_value)
        {
            return item.GetCardinalNeighbors<T>(x, y, default_value).Append(item.GetOrdinalNeighbors<T>(x, y, default_value));
        }
        static public IEnumerable<T> GetCardinalThenOrdinalNeighbors<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetCardinalThenOrdinalNeighbors<T>(x, y, default(T));
        }

        static public IEnumerable<T> GetNeighbors<T>(this IList2D<T> item, int x, int y, T default_value)
        {
            return item.GetCardinalThenOrdinalNeighbors<T>(x, y, default_value);
        }
        static public IEnumerable<T> GetNeighbors<T>(this IList2D<T> item, int x, int y)
        {
            return item.GetNeighbors<T>(x, y, default(T));
        }
    }
}