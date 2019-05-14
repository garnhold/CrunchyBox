using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Rotate
    {
        static public IEnumerable<T> Rotate<T>(this IEnumerable<T> item, int start)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.MoveNextRepeatedly(start))
                {
                    while (iter.MoveNext())
                        yield return iter.Current;

                    iter.Reset();
                    for (int i = 0; i < start; i++)
                    {
                        iter.MoveNext();
                        yield return iter.Current;
                    }
                }
            }
        }
    }
}