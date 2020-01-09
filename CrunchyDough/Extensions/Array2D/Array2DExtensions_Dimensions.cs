using System;

namespace Crunchy.Dough
{
    static public class Array2DExtensions_Dimensions
    {
        static public int GetWidth<T>(this T[,] item)
        {
            return item.GetLength(0);
        }

        static public int GetHeight<T>(this T[,] item)
        {
            return item.GetLength(1);
        }
    }
}