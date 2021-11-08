using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_Set
    {
        static public void Set<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, ELEMENT_TYPE element)
        {
            item[key] = element;
        }

        static public ELEMENT_TYPE SetAndGet<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, ELEMENT_TYPE element)
        {
            item.Set(key, element);

            return element;
        }
    }
}