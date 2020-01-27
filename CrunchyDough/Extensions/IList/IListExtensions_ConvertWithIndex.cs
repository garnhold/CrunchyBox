using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_ConvertWithIndex
    {
        static public IList<OUTPUT_TYPE> ConvertWithIndex<INPUT_TYPE, OUTPUT_TYPE>(this IList<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IListTransform<OUTPUT_TYPE>(item.Count,
                    i => operation(i, item[i])
                );
            }

            return Empty.IList<OUTPUT_TYPE>();
        }
    }
}