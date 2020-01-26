using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Convert
    {
        static public IList2D<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this IList2D<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                return new IList2DTransform<OUTPUT_TYPE>(
                    () => item.GetWidth(),
                    () => item.GetHeight(),
                    (x, y) => operation(item[x, y])
                );
            }

            return Empty.IList2D<OUTPUT_TYPE>();
        }
    }
}