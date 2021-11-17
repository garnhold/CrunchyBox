using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IDictionaryExtensions_SetRange
    {
        static public void SetRangeOverwrite<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>> to_set)
        {
            to_set.Process(p => item[p.Key] = p.Value);
        }
        static public void SetRangeOverwrite<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, params KeyValuePair<KEY_TYPE, ELEMENT_TYPE>[] to_set)
        {
            item.SetRangeOverwrite((IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>>)to_set);
        }

        static public void SetRangeSkip<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>> to_set)
        {
            to_set.Process(p => {
                if (item.ContainsKey(p.Key) == false)
                    item[p.Key] = p.Value;
            });
        }
        static public void SetRangeSkip<KEY_TYPE, ELEMENT_TYPE>(this IDictionary<KEY_TYPE, ELEMENT_TYPE> item, params KeyValuePair<KEY_TYPE, ELEMENT_TYPE>[] to_set)
        {
            item.SetRangeSkip((IEnumerable<KeyValuePair<KEY_TYPE, ELEMENT_TYPE>>)to_set);
        }
    }
}