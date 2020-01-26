using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Reverse
    {
        static public IList<T> GetReverse<T>(this IList<T> item)
        {
            return new IListTransform<T>(
                () => item.Count,
                i => item[item.GetFinalIndex() - i]
            );
        }
    }
}