using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_SetRange
    {
        static public void SetRange<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>> to_set)
        {
            to_set.Process(p => item[p.Key] = p.Value);
        }
        static public void SetRange<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, params KeyValuePair<KEY_TYPE, ELEMENT_TYPE>[] to_set)
        {
            item.SetRange((IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>>)to_set);
        }
    }
}