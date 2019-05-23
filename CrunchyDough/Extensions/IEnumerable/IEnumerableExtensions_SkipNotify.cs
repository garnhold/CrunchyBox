using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_SkipNotify
    {
        static public IEnumerable<T> SkipNotify<T>(this IEnumerable<T> item, Predicate<T> predicate, Process process)
        {
            bool has_notified = false;

            return item.Skip<T>(delegate(T sub_item) {
                if (predicate.DoesDescribe(sub_item))
                {
                    if (has_notified == false)
                    {
                        process();
                        has_notified = true;
                    }

                    return true;
                }

                return false;
            });
        }

        static public IEnumerable<T> SkipNotify<T>(this IEnumerable<T> item, T value, Process process)
        {
            return item.SkipNotify<T>(i => i.EqualsEX(value), process);
        }

        static public IEnumerable<T> SkipNotifyNull<T>(this IEnumerable<T> item, Process process)
        {
            return item.SkipNotify<T>(i => i.IsNull(), process);
        }
    }
}