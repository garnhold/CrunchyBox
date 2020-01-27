using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Convert
    {
        static public IGrid<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IGridTransform<OUTPUT_TYPE>(item.GetWidth(), item.GetHeight(),
                    (x, y) => operation(item[x, y])
                );
            }

            return Empty.IGrid<OUTPUT_TYPE>();
        }
    }
}