using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Extract
    {
        static public IEnumerable<T> SubSection<T>(this IEnumerable<T> item, int start_index, int end_index)
        {
            if (item != null)
            {
                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNextRepeatedly(start_index))
                    {
                        for (int i = start_index; i < end_index; i++)
                        {
                            if (iter.MoveNext() == false)
                                yield break;

                            yield return iter.Current;
                        }
                    }
                }
            }
        }

        static public IEnumerable<T> Sub<T>(this IEnumerable<T> item, int start_index, int length)
        {
            return item.SubSection<T>(start_index, start_index + length);
        }

        static public IEnumerable<T> Offset<T>(this IEnumerable<T> item, int start_index)
        {
            return item.SubSection<T>(start_index, int.MaxValue);
        }

        static public IEnumerable<T> Truncate<T>(this IEnumerable<T> item, int end_index)
        {
            return item.SubSection<T>(0, end_index);
        }
    }
}