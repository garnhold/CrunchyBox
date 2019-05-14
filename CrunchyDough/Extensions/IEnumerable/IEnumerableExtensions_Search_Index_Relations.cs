using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Index_Relations
    {
        static public bool TryFindIndexOfFirstRelation<T>(this IEnumerable<T> item, out int index, IEnumerable<T> other, Relation<T, T> relation)
        {
            return item.PairPermissive(other).TryFindIndexOf(out index, p => relation(p.item1, p.item2));
        }
        static public int FindIndexOfFirstRelation<T>(this IEnumerable<T> item, IEnumerable<T> other, Relation<T, T> relation)
        {
            int index;

            item.TryFindIndexOfFirstRelation(out index, other, relation);
            return index;
        }
    }
}