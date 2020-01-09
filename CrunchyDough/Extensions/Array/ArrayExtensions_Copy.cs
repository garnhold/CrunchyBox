using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Copy
    {
        static public int CopySub<T>(this T[] item, T[] array, int dst, int src, int length)
        {
            if (item.IsSubValid(dst, length) && array.IsSubValid(src, length))
            {
                Array.Copy(array, src, item, dst, length);

                return dst + length;
            }

            return dst;
        }

        static public int CopySubsection<T>(this T[] item, T[] array, int dst, int src_start, int src_end)
        {
            return item.CopySub(array, dst, src_start, src_end - src_start);
        }

        static public int CopyFrom<T>(this T[] item, T[] array, int dst, int src)
        {
            return item.CopySub(array, dst, src, array.Length - src);
        }
        static public int CopyFrom<T>(this T[] item, T[] array, int dst)
        {
            return item.CopyFrom(array, dst, 0);
        }
        static public int CopyFrom<T>(this T[] item, T[] array)
        {
            return item.CopyFrom(array, 0);
        }

        static public T[] Copy<T>(this T[] item)
        {
            T[] copy = new T[item.GetLength()];

            copy.CopyFrom(item);
            return copy;
        }
    }
}
