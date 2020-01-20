using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Same
    {
        static public bool AreAllSame<T>(this IEnumerable<T> item, out T value)
        {
            T first_value = default(T);
            
            value = default(T);

            if (item != null)
            {
                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        first_value = iter.Current;

                        while (iter.MoveNext())
                        {
                            if (iter.Current.NotEqualsEX(first_value))
                                return false;
                        }
                    }
                }
            }

            value = first_value;
            return true;
        }
        static public bool AreAllSame<T>(this IEnumerable<T> item)
        {
            T value;

            return item.AreAllSame(out value);
        }
        static public T GetIfAreAllSame<T>(this IEnumerable<T> item)
        {
            T value;

            item.AreAllSame(out value);
            return value;
        }
    }
}