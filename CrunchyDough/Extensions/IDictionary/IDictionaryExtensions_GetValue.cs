using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IDictionaryExtensions_GetValue
    {
        static public ELEMENT_TYPE GetValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, ELEMENT_TYPE default_value)
        {
            ELEMENT_TYPE value;

            if (item.TryGetValue(key, out value))
                return value;

            return default_value;
        }
        static public ELEMENT_TYPE GetValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key)
        {
            return item.GetValue(key, default(ELEMENT_TYPE));
        }
    }
}