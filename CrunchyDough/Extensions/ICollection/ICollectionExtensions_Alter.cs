using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class ICollectionExtensions_Alter
    {
        static public void Alter<T>(this ICollection<T> item, Predicate<T> predicate, Process<T> process)
        {
            item.Narrow(predicate).Process(process);
        }

        static public void Alter<T>(this ICollection<T> item, Predicate<T> predicate, Operation<T> operation)
        {
            item.Set(item.Exchange(predicate, operation).ToList());
        }
        static public void Alter<T>(this ICollection<T> item, Predicate<T> predicate, Operation<T, T> operation)
        {
            item.Set(item.Exchange(predicate, operation).ToList());
        }

        static public void Alter<T>(this ICollection<T> item, Predicate<T> predicate, Operation<IEnumerable<T>> operation)
        {
            item.Set(item.Exchange(predicate, operation).ToList());
        }
        static public void Alter<T>(this ICollection<T> item, Predicate<T> predicate, Operation<IEnumerable<T>, T> operation)
        {
            item.Set(item.Exchange(predicate, operation).ToList());
        }
    }
}