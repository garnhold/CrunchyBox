using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IDictionaryExtensions_CalculateKeyRelations
    {
        static public void CalculateKeyRelations<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, IEnumerable<KEY_TYPE> other, HashSet<KEY_TYPE> only_in_first, HashSet<KEY_TYPE> in_both, HashSet<KEY_TYPE> only_in_last)
        {
            only_in_first.Set(item.Keys);
            in_both.Clear();
            only_in_last.Clear();

            foreach (KEY_TYPE key in other)
            {
                if (item.ContainsKey(key))
                {
                    only_in_first.Remove(key);
                    in_both.Add(key);
                }
                else
                {
                    only_in_last.Add(key);
                }
            }
        }
        static public void CalculateKeyRelations<KEY_TYPE, VALUE_TYPE>(this IDictionary<KEY_TYPE, VALUE_TYPE> item, IEnumerable<KEY_TYPE> other, out HashSet<KEY_TYPE> only_in_first, out HashSet<KEY_TYPE> in_both, out HashSet<KEY_TYPE> only_in_last)
        {
            only_in_first = new HashSet<KEY_TYPE>();
            in_both = new HashSet<KEY_TYPE>();
            only_in_last = new HashSet<KEY_TYPE>();

            item.CalculateKeyRelations<KEY_TYPE, VALUE_TYPE>(other, only_in_first, in_both, only_in_last);
        }
    }
}