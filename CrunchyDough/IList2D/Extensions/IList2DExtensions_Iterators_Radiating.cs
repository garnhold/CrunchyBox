using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Iterators_Radiating
    {
        static public IEnumerable<T> GetRadiating<T>(this IList2D<T> item, int radius)
        {
            return RadiatingWalker.Iterator(radius)
                .Convert(p => item.Get(p.item1, p.item2));
        }
    }
}