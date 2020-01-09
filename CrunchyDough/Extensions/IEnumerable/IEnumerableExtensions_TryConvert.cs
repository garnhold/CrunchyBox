using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_TryConvert
    {
        static public IEnumerable<OUTPUT_TYPE> TryConvert<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, TryOperation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            foreach (INPUT_TYPE sub_item in item)
            {
                OUTPUT_TYPE cast;

                if (operation(sub_item, out cast))
                    yield return cast;
            }
        }
    }
}