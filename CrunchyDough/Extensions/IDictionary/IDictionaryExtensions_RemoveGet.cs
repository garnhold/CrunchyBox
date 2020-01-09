using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_RemoveGet
    {
        static public bool TryRemoveAndGet<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, out VALUE_TYPE value)
        {
            if (item.TryGetValue(key, out value))
            {
                item.Remove(key);

                return true;
            }

            return false;
        }

        static public VALUE_TYPE RemoveAndGet<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key, VALUE_TYPE default_value)
        {
            VALUE_TYPE value;

            if (item.TryRemoveAndGet(key, out value))
                return value;

            return default_value;
        }
        static public VALUE_TYPE RemoveAndGet<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, KEY_TYPE key)
        {
            return item.RemoveAndGet(key, default(VALUE_TYPE));
        }
    }
}