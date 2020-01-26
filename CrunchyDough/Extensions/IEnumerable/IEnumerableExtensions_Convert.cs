using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Convert
    {
        static public IEnumerable<OUTPUT_TYPE> Convert<OUTPUT_TYPE>(this IEnumerable<object> item)
        {
            return item.Convert<object, OUTPUT_TYPE>();
        }

        static public IEnumerable<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item)
        {
            OUTPUT_TYPE cast;

            if (item != null)
            {
                foreach (INPUT_TYPE sub_item in item)
                {
                    if (sub_item.Convert<OUTPUT_TYPE>(out cast))
                        yield return cast;
                }
            }
        }

        static public IEnumerable<OUTPUT_TYPE> Convert<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            if (item != null)
            {
                foreach (INPUT_TYPE sub_item in item)
                    yield return operation.Execute(sub_item);
            }
        }
    }
}