using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_AtKeys
    {
        static public IEnumerable<VALUE_TYPE> GetAtKeys<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, IEnumerable<KEY_TYPE> keys)
        {
            return keys.Convert(k => item.GetValue(k));
        }
    }
}