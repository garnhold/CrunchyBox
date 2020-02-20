using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_ConvertWithIndex
    {
        static public ICollection<OUTPUT_TYPE> ConvertWithIndex<INPUT_TYPE, OUTPUT_TYPE>(this ICollection<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new ICollectionTransform<OUTPUT_TYPE>(item.Count,
                    item.ConvertWithIndex(operation)
                );
            }

            return Empty.ICollection<OUTPUT_TYPE>();
        }
    }
}