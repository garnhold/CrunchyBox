using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_PopValue
    {
        static public bool TryPopValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, out ELEMENT_TYPE value)
        {
            if (item.TryGetValue(key, out value))
            {
                item.Remove(key);
                return true;
            }

            return false;
        }

        static public ELEMENT_TYPE PopValue<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, ELEMENT_TYPE default_value = default(ELEMENT_TYPE))
        {
            ELEMENT_TYPE value;

            if (item.TryPopValue(key, out value))
                return value;

            return default_value;
        }
    }
}