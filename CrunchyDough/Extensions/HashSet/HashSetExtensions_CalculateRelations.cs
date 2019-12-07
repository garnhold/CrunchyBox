using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class HashSetExtensions_CalculateRelations
    {
        static public void CalculateKeyRelations<T>(this HashSet<T> item, IEnumerable<T> other, HashSet<T> only_in_first, HashSet<T> in_both, HashSet<T> only_in_last)
        {
            only_in_first.Set(item);
            in_both.Clear();
            only_in_last.Clear();

            foreach (T key in other)
            {
                if (item.Contains(key))
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
        static public void CalculateKeyRelations<T>(this HashSet<T> item, IEnumerable<T> other, out HashSet<T> only_in_first, out HashSet<T> in_both, out HashSet<T> only_in_last)
        {
            only_in_first = new HashSet<T>();
            in_both = new HashSet<T>();
            only_in_last = new HashSet<T>();

            item.CalculateKeyRelations<T>(other, only_in_first, in_both, only_in_last);
        }

        static public void CalculateKeyRelations<T>(this HashSet<T> item, IEnumerable<T> other, HashSet<T> only_in_first, HashSet<T> in_both)
        {
            only_in_first.Set(item);
            in_both.Clear();

            foreach (T key in other)
            {
                if (item.Contains(key))
                {
                    only_in_first.Remove(key);
                    in_both.Add(key);
                }
            }
        }
        static public void CalculateKeyRelations<T>(this HashSet<T> item, IEnumerable<T> other, out HashSet<T> only_in_first, out HashSet<T> in_both)
        {
            only_in_first = new HashSet<T>();
            in_both = new HashSet<T>();

            item.CalculateKeyRelations<T>(other, only_in_first, in_both);
        }
    }
}