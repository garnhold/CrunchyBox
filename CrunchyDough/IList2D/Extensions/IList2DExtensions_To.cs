using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_To
    {
        static public List2D<T> ToList2D<T>(this IList2D<T> item)
        {
            return new List2D<T>(item);
        }
    }
}