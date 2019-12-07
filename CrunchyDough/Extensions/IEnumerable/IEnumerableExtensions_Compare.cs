using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Compare
    {
        static public bool AreElements<T, J>(this IEnumerable<T> item, IEnumerable<J> to_check, Relation<T, J> relation)
        {
            if (item.PairPermissive<T, J>(to_check).AreAll(t => relation(t.item1, t.item2)))
                return true;

            return false;
        }

        static public bool AreElementsEqual<T>(this IEnumerable<T> item, IEnumerable<T> to_check)
        {
            return item.AreElements(to_check, (e1, e2) => e1.EqualsEX(e2));
        }

        static public int GetElementsHashCode<T>(this IEnumerable<T> item)
        {
            unchecked
            {
                return item.Apply(17, (h, i) => h * 23 + i.GetHashCodeEX());
            }
        }
    }
}