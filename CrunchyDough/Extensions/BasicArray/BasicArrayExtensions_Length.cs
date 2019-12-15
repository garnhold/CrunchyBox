using System;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Length
    {
        static public int GetLength(this Array item)
        {
            if (item != null)
                return item.Length;

            return 0;
        }
    }
}