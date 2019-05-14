using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IDictionaryExtensions_FollowReferences
    {
        static public IEnumerable<VALUE_TYPE> FollowInferences<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, VALUE_TYPE value, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            return value.TraverseLoop(v => item.GetValue(operation(v)));
        }
        static public IEnumerable<VALUE_TYPE> FollowInferences<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, Operation<KEY_TYPE, VALUE_TYPE> operation)
        {
            VALUE_TYPE value;

            if (item.Values.TryGetFirst(out value))
                return item.FollowInferences(value, operation).Prepend(value);

            return Empty.IEnumerable<VALUE_TYPE>();
        }
    }
}