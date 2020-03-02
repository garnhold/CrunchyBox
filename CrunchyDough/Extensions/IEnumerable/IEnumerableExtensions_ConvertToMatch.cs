using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ConvertToMatch
    {
        static public IEnumerable<OUTPUT_TYPE> ConvertToMatch<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, IEnumerable<OUTPUT_TYPE> other, Relation<INPUT_TYPE, OUTPUT_TYPE> relation)
        {
            List<OUTPUT_TYPE> other_list = other.ToList();

            return item.Convert(i => other_list.PopFirst(o => relation(i, o)));
        }
    }
}