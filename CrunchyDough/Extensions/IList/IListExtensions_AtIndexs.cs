using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_AtIndexs
    {
        static public IEnumerable<T> AtIndexs<T>(this IList<T> item, IEnumerable<int> indexs)
        {
            return indexs.Convert(i => item.Get(i));
        }
        static public IEnumerable<T> AtIndexs<T>(this IList<T> item, params int[] indexs)
        {
            return item.AtIndexs((IEnumerable<int>)indexs);
        }
    }
}