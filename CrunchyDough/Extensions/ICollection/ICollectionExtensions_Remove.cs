using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_Remove
    {
        static public bool RemoveFirst<T>(this ICollection<T> item, Predicate<T> predicate)
        {
            return item.Remove(item.FindFirst(predicate));
        }
        
        static public int RemoveAll<T>(this ICollection<T> item, IEnumerable<T> to_remove)
        {
            return to_remove.Count(i => item.Remove(i));
        }

        static public int RemoveAll<T>(this ICollection<T> item, Predicate<T> predicate)
        {
            return item.RemoveAll(item.Narrow(predicate).ToList());
        }

        static public int RemoveAll<T>(this ICollection<T> item, T to_remove)
        {
            return item.RemoveAll(i => i.EqualsEX(to_remove));
        }

        static public int RemoveAllNulls<T>(this ICollection<T> item) where T : class
        {
            return item.RemoveAll((T)null);
        }

        static public int RemoveAllUntil<T>(this ICollection<T> item, Predicate<T> predicate, bool should_remove_last)
        {
            bool has_reached = false;

            return item.RemoveAll(delegate(T sub_item) {
                if (has_reached)
                    return false;

                if (predicate.DoesDescribe(sub_item))
                {
                    has_reached = true;
                    if (should_remove_last == false)
                        return false;
                }

                return true;
            });
        }
        static public int RemoveAllUntil<T>(this ICollection<T> item, T to_remove, bool should_remove_last)
        {
            return item.RemoveAllUntil(i => i.EqualsEX(to_remove), should_remove_last);
        }

        static public int RemoveAllWhile<T>(this ICollection<T> item, Predicate<T> predicate)
        {
            return item.RemoveAllUntil(i => predicate(i) == false, false);
        }
        static public int RemoveAllWhile<T>(this ICollection<T> item, T to_remove)
        {
            return item.RemoveAllWhile(i => i.EqualsEX(to_remove));
        }

        static public int RemoveAllSince<T>(this ICollection<T> item, Predicate<T> predicate, bool should_remove_first)
        {
            bool has_reached = false;

            return item.RemoveAll(delegate(T sub_item) {
                if (has_reached)
                    return true;

                if (predicate.DoesDescribe(sub_item))
                {
                    has_reached = true;
                    if (should_remove_first)
                        return true;
                }

                return false;
            });
        }
        static public int RemoveAllSince<T>(this ICollection<T> item, T to_remove, bool should_remove_first)
        {
            return item.RemoveAllSince(i => i.EqualsEX(to_remove), should_remove_first);
        }
    }
}