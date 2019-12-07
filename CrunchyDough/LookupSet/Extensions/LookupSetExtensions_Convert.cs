using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupSetExtensions_Convert
    {
        static public T Convert<KEY_TYPE, VALUE_TYPE, T>(this LookupSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, Operation<T, VALUE_TYPE> operation)
        {
            return operation.Execute(item.Lookup(key));
        }
    }
}