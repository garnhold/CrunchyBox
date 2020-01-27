using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Array2DExtensions_Convert
    {
        static public IGrid<T> ConvertToIGrid<T>(this T[,] item)
        {
            return new IGridTransform<T>(item.GetWidth(), item.GetHeight(),
                (x, y) => item[x, y],
                (x, y, v) => item[x, y] = v
            );
        }
    }
}