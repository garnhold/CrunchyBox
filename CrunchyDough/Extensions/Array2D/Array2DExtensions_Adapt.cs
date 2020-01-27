using System;

namespace Crunchy.Dough
{
    static public class Array2DExtensions_Adapt
    {
        static public IList2D<T> AdaptToIList2D<T>(this T[,] item)
        {
            return new List2D_Array2DAdapter<T>(item);
        }
    }
}