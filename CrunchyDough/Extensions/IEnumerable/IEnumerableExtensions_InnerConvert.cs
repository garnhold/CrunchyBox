using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_InnerConvert
    {
        static public IEnumerable<IEnumerable<OUTPUT_TYPE>> InnerConvert<OUTPUT_TYPE>(this IEnumerable<IEnumerable<object>> item)
        {
            return item.Convert(e => e.Convert<OUTPUT_TYPE>());
        }

        static public IEnumerable<IEnumerable<OUTPUT_TYPE>> InnerConvert<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<IEnumerable<INPUT_TYPE>> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            return item.Convert(e => e.Convert<INPUT_TYPE, OUTPUT_TYPE>(operation));
        }

        static public IEnumerable<IEnumerable<OUTPUT_TYPE>> InnerConvert<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<IEnumerable<INPUT_TYPE>> item)
        {
            return item.Convert(e => e.Convert<INPUT_TYPE, OUTPUT_TYPE>());
        }
    }
}