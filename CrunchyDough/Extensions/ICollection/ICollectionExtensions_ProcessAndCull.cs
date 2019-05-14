using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_ProcessAndCull
    {
        static public void ProcessAndCull<T>(this ICollection<T> item, Predicate<T> predicate, Process<T> process)
        {
            item.RemoveAll(delegate(T sub_item) {
                process(sub_item);

                if (predicate.DoesDescribe(sub_item))
                    return true;

                return false;
            });
        }

        static public void CullAndProcess<T>(this ICollection<T> item, Predicate<T> predicate, Process<T> process)
        {
            item.RemoveAll(delegate(T sub_item) {
                if (predicate.DoesDescribe(sub_item))
                    return true;

                process(sub_item);

                return false;
            });
        }

        static public void CullValueAndProcess<T>(this ICollection<T> item, T value, Process<T> process)
        {
            item.CullAndProcess(i => i.EqualsEX(value), process);
        }

        static public void CullNullAndProcess<T>(this ICollection<T> item, Process<T> process) where T : class
        {
            item.CullValueAndProcess(null, process);
        }
    }
}