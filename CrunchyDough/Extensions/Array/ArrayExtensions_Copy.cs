using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Copy
    {
        static public void CopyFrom<T>(this T[] item, T[] array, int dst, int src, int length)
        {
            if (item.IsSubValid(dst, length) && array.IsSubValid(src, length))
                Array.Copy(array, src, item, dst, length);
        }
        static public void CopyFrom<T>(this T[] item, T[] array, int dst)
        {
            item.CopyFrom<T>(array, dst, 0, array.GetLength());
        }
        static public void CopyFrom<T>(this T[] item, T[] array)
        {
            item.CopyFrom<T>(array, 0);
        }

        static public T[] Copy<T>(this T[] item)
        {
            T[] copy = new T[item.GetLength()];

            copy.CopyFrom<T>(item);
            return copy;
        }
    }
}
