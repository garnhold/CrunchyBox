using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Size
    {
        static public VectorI2 GetSize<T>(this IList2D<T> item)
        {
            return new VectorI2(item.GetWidth(), item.GetHeight());
        }
    }
}