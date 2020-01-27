using System;

namespace Crunchy.Dough
{
    static public class Array2DExtensions_Adapt
    {
        static public IGrid<T> AdaptToIGrid<T>(this T[,] item)
        {
            return new Grid_Array2DAdapter<T>(item);
        }
    }
}