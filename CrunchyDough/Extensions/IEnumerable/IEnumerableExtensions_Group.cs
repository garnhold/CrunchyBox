using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Group
    {
        static public IEnumerable<OUTPUT_TYPE> Group<OUTPUT_TYPE, INPUT_TYPE, KEY_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<KEY_TYPE, INPUT_TYPE> key_operation, Operation<OUTPUT_TYPE, KEY_TYPE, IEnumerable<INPUT_TYPE>> operation)
        {
            return item.ToMultiDictionary(key_operation)
                .Convert(p => operation(p.Key, p.Value));
        }
    }
}