using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Convert
    {
        static public IList<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this IList<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IListTransform<OUTPUT_TYPE>(item.Count,
                    i => operation(item[i])
                );
            }

            return Empty.IList<OUTPUT_TYPE>();
        }
    }
}