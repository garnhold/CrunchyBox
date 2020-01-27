using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Size
    {
        static public VectorI2 GetSize<T>(this IGrid<T> item)
        {
            return new VectorI2(item.GetWidth(), item.GetHeight());
        }
    }
}