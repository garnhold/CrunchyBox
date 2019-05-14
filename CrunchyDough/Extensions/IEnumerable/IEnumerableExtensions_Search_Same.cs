using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Search_Same
    {
        static public bool AreAllSame<T>(this IEnumerable<T> item, out T value)
        {
            value = default(T);

            if (item != null)
            {
                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        value = iter.Current;

                        while (iter.MoveNext())
                        {
                            if (iter.Current.NotEqualsEX(value))
                                return false;
                        }
                    }
                }
            }

            return true;
        }
        static public bool AreAllSame<T>(this IEnumerable<T> item)
        {
            T value;

            return item.AreAllSame(out value);
        }
    }
}