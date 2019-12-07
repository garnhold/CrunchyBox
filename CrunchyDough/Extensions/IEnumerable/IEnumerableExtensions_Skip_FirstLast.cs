using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Skip_FirstLast
    {
        static public IEnumerable<T> SkipFirst<T>(this IEnumerable<T> item)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.MoveNext())
                {
                    while (iter.MoveNext())
                        yield return iter.Current;
                }
            }
        }

        static public IEnumerable<T> SkipLast<T>(this IEnumerable<T> item)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if(iter.MoveNext())
                {
                    T previous = iter.Current;

                    while (iter.MoveNext())
                    {
                        yield return previous;

                        previous = iter.Current;
                    }
                }
            }
        }
    }
}