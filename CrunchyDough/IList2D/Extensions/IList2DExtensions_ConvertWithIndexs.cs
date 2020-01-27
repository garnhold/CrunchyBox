using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_ConvertWithIndexs
    {
        static public IList2D<OUTPUT_TYPE> ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>(this IList2D<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, int, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IList2DTransform<OUTPUT_TYPE>(
                    () => item.GetWidth(),
                    () => item.GetHeight(),
                    (x, y) => operation(x, y, item[x, y])
                );
            }

            return Empty.IList2D<OUTPUT_TYPE>();
        }
        static public IList2D<OUTPUT_TYPE> ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>(this IList2D<INPUT_TYPE> item, Operation<OUTPUT_TYPE, VectorI2, INPUT_TYPE> operation)
        {
            return item.ConvertWithIndexs<INPUT_TYPE, OUTPUT_TYPE>((x, y, v) => operation(new VectorI2(x, y), v));
        }
    }
}