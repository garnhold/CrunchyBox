using System;

namespace CrunchyDough
{
    static public class ArrayExtensions_Length
    {
        static public int GetLength<T>(this T[] item)
        {
            if (item != null)
                return item.Length;

            return 0;
        }
    }
}