using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_Length
    {
        static public int GetLength(this string item)
        {
            if (item != null)
                return item.Length;

            return 0;
        }
    }
}