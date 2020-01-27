using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Stamp
    {
        static public Stamp<T> CreateStamp<T>(this IList2D<T> item)
        {
            return new Stamp<T>(item);
        }

        static public Stamp<T> CreateStamp<T>(this IList2D<T> item, VectorF2 center)
        {
            return new Stamp<T>(center, item);
        }
    }
}