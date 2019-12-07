using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_CopyTo
    {
        static public int CopyTo<T>(this IEnumerable<T> item, T[] array, int index)
        {
            ICollection<T> collection;

            if (item != null)
            {
                if (item.Convert<ICollection<T>>(out collection))
                {
                    collection.CopyTo(array, index);
                    index += collection.Count;
                }
                else
                {
                    using (IEnumerator<T> iter = item.GetEnumerator())
                    {
                        while (iter.MoveNext() && index < array.Length)
                            array[index++] = iter.Current;
                    }
                }
            }

            return index;
        }
        static public int CopyTo<T>(this IEnumerable<T> dst_item, T[] dst_array)
        {
            return dst_item.CopyTo(dst_array, 0);
        }
    }
}