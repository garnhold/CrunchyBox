using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Validate
    {
        static public IEnumerable<T> ValidateFirst<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.MoveNext())
                {
                    if (predicate(iter.Current))
                    {
                        yield return iter.Current;
                        while (iter.MoveNext())
                            yield return iter.Current;
                    }
                }
            }
        }
    }
}