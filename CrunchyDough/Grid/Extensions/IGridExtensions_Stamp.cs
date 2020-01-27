using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Stamp
    {
        static public Stamp<T> CreateStamp<T>(this IGrid<T> item)
        {
            return new Stamp<T>(item);
        }

        static public Stamp<T> CreateStamp<T>(this IGrid<T> item, VectorF2 center)
        {
            return new Stamp<T>(center, item);
        }
    }
}