using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_ConvertToKeyValuePairs
    {
        static public IEnumerable<KeyValuePair<VectorI2, T>> ConvertToKeyValuePairs<T>(this IGrid<T> item)
        {
            return item.ConvertWithIndexsToData((i, v) => KeyValuePair.New(i, v));
        }
    }
}