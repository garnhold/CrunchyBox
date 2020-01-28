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

        static public IGrid<OUTPUT_TYPE> ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, int, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IGridTransform<OUTPUT_TYPE>(item.GetWidth(), item.GetHeight(),
                    (x, y) => operation(x, y, item[x, y])
                );
            }

            return Empty.IGrid<OUTPUT_TYPE>();
        }
        static public IGrid<OUTPUT_TYPE> ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>(this IGrid<INPUT_TYPE> item, Operation<OUTPUT_TYPE, VectorI2, INPUT_TYPE> operation)
        {
            return item.ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>((x, y, v) => operation(new VectorI2(x, y), v));
        }
    }
}