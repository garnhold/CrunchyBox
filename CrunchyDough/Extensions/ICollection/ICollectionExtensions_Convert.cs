using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Convert
    {
        static public ICollection<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this ICollection<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new ICollectionTransform<OUTPUT_TYPE>(item.Count,
                    item.Convert(operation)
                );
            }

            return Empty.ICollection<OUTPUT_TYPE>();
        }
    }
}