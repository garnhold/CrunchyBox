using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Rotate
    {
        static public IEnumerable<T> RotateHalfway<T>(this ICollection<T> item)
        {
            return item.Rotate(item.Count / 2);
        }
    }
}