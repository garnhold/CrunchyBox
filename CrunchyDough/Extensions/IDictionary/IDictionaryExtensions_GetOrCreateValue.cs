using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_GetOrCreateValue
    {
        static public ELEMENT_TYPE GetOrCreateValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, Operation<ELEMENT_TYPE, KEY_TYPE> operation)
        {
            ELEMENT_TYPE value;

            if (item.TryGetValue(key, out value) == false)
                value = item.AddAndGet(key, operation(key));

            return value;
        }

        static public ELEMENT_TYPE GetOrCreateValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, Operation<ELEMENT_TYPE> operation)
        {
            return item.GetOrCreateValue(key, k => operation());
        }

        static public ELEMENT_TYPE GetOrCreateDefaultValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key)
        {
            return item.GetOrCreateValue(key, () => typeof(ELEMENT_TYPE).CreateInstance<ELEMENT_TYPE>());
        }

        static public ELEMENT_TYPE GetOrCreateKeyedValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key)
        {
            return item.GetOrCreateValue(key, () => typeof(ELEMENT_TYPE).CreateInstance<ELEMENT_TYPE>(key));
        }
    }
}