using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_ConvertSet
    {
        static public LookupSet<KEY_TYPE, OUTPUT_TYPE> ConvertSet<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE>(this LookupSet<KEY_TYPE, INPUT_TYPE> item, Operation<OUTPUT_TYPE, INPUT_TYPE> operation)
        {
            return new LookupSetValueConverter<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE>(item, operation);
        }

        static public LookupSet<KEY_TYPE, OUTPUT_TYPE> ConvertSet<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE>(this LookupSet<KEY_TYPE, INPUT_TYPE> item)
        {
            return new LookupSetValueTypeConverter<KEY_TYPE, INPUT_TYPE, OUTPUT_TYPE>(item);
        }
    }
}