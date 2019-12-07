using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class LookupBackedSetExtensions_Convert
    {
        static public T Convert<KEY_TYPE, VALUE_TYPE, T>(this LookupBackedSet<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, Operation<T> default_operation, Operation<T, VALUE_TYPE> operation)
        {
            if (item.IsAsBacked(key))
                return default_operation.Execute();

            return operation.Execute(item.Lookup(key));
        }
    }
}