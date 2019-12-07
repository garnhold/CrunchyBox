using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_Add
    {
        static public ELEMENT_TYPE AddAndGet<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, KEY_TYPE key, ELEMENT_TYPE element)
        {
            item.Add(key, element);

            return element;
        }
    }
}