using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
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
                int hash_code = 17;

                item.Process(i => hash_code = hash_code * 23 + i.GetHashCodeEX());
                return hash_code;
            }
        }
    }
}