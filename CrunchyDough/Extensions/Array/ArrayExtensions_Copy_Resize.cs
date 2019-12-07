using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ArrayExtensions_Copy_Resize
    {
        static public T[] CopyResize<T>(this T[] item, int size)
        {
            T[] resized = new T[size];

            Array.Copy(item, 0, resized, 0, size.Min(item.Length));
            return resized;
        }

        static public T[] CopyGrow<T>(this T[] item)
        {
            return item.CopyResize(item.Length * 2);
        }
    }
}
