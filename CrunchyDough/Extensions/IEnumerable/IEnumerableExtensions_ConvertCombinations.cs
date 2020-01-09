using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ConvertCombinations
    {
        static public IEnumerable<OUTPUT_TYPE> ConvertCombinations<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2>(this IEnumerable<INPUT_TYPE1> item, IEnumerable<INPUT_TYPE2> other, Operation<OUTPUT_TYPE, INPUT_TYPE1, INPUT_TYPE2> operation)
        {
            foreach (INPUT_TYPE1 sub_item in item)
            {
                foreach (INPUT_TYPE2 sub_other in other)
                {
                    yield return operation(sub_item, sub_other);
                }
            }
        }
    }
}