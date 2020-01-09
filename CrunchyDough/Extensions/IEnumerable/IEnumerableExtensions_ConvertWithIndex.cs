using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ConvertWithIndex
    {
        static public IEnumerable<OUTPUT_TYPE> ConvertWithIndex<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<OUTPUT_TYPE, int, INPUT_TYPE> operation)
        {
            int index = 0;

            foreach (INPUT_TYPE sub_item in item)
            {
                yield return operation(index, sub_item);

                index++;
            }
        }
    }
}