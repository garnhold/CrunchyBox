using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Interleave
    {
        static public IEnumerable<T> Interleave<T>(this IEnumerable<T> item, IEnumerable<T> other)
        {
            bool is_item_active = true;
            bool is_other_active = true;

            using (IEnumerator<T> item_iter = item.GetEnumerator())
            {
                using (IEnumerator<T> other_iter = other.GetEnumerator())
                {
                    while (is_item_active || is_other_active)
                    {
                        if (is_item_active)
                        {
                            if (item_iter.MoveNext())
                                yield return item_iter.Current;
                            else
                                is_item_active = false;
                        }

                        if (is_other_active)
                        {
                            if (other_iter.MoveNext())
                                yield return other_iter.Current;
                            else
                                is_other_active = false;
                        }
                    }
                    
                }
            }
        }

        static public IEnumerable<T> InterleaveCapEnd<T>(this IEnumerable<T> item, T value)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                while (iter.MoveNext())
                {
                    yield return iter.Current;
                    yield return value;
                }
            }
        }

        static public IEnumerable<T> Interleave<T>(this IEnumerable<T> item, T value)
        {
            using (IEnumerator<T> iter = item.GetEnumerator())
            {
                if (iter.MoveNext())
                {
                    yield return iter.Current;

                    while (iter.MoveNext())
                    {
                        yield return value;
                        yield return iter.Current;
                    }
                }
            }
        }
    }
}