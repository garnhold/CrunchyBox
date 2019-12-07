using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class PredicateExtensions_Combine
    {
        static public Predicate<T> And<T>(this Predicate<T> item, params Predicate<T>[] predicates)
        {
            return delegate(T to_check) {
                return item.DoesDescribe(to_check) && predicates.DoAllDescribe(to_check);
            };
        }

        static public Predicate<T> AndIs<T, J>(this Predicate<T> item, Predicate<J> predicate)
        {
            return item.And(Predicates<T>.AndIs(predicate));
        }

        static public Predicate<T> Or<T>(this Predicate<T> item, params Predicate<T>[] predicates)
        {
            return delegate(T to_check) {
                return item.DoesDescribe(to_check) || predicates.DoAnyDescribe(to_check);
            };
        }

        static public Predicate<T> OrIs<T, J>(this Predicate<T> item, Predicate<J> predicate)
        {
            return item.Or(Predicates<T>.AndIs(predicate));
        }
    }
}