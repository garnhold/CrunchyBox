using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Skip
    {
        static public IEnumerable<T> Skip<T>(this IEnumerable<T> item, Predicate<T> predicate)
        {
            return item.Narrow(i => predicate.DoesntDescribe(i));
        }

        static public IEnumerable<T> Skip<T>(this IEnumerable<T> item, T value)
        {
            return item.Skip(i => i.EqualsEX(value));
        }

        static public IEnumerable<T> Skip<T>(this IEnumerable<T> item, IEnumerable<T> values)
        {
            return item.Skip(i => values.Has(i));
        }

        static public IEnumerable<T> SkipNull<T>(this IEnumerable<T> item)
        {
            return item.Skip(i => i.IsNull());
        }
    }
}