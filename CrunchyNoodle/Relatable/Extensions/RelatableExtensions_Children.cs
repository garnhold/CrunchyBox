using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class RelatableExtensions_Children
    {
        static public IEnumerable<object> GetImmediateChildren(this Relatable item)
        {
            return RelatableExtensions_Children_Internal.GetImmediateChildren(item);
        }
        static public IEnumerable<T> GetImmediateChildren<T>(this Relatable item)
        {
            return item.GetImmediateChildren().Convert<object, T>();
        }

        static public IEnumerable<object> GetChildren(this Relatable item, Predicate<object> predicate)
        {
            return RelatableExtensions_Children_Internal.GetChildren(item, predicate);
        }
        static public IEnumerable<T> GetChildren<T>(this Relatable item, Predicate<object> predicate)
        {
            return item.GetChildren(predicate).Convert<object, T>();
        }

        static public IEnumerable<T> GetTopicalChildren<T>(this Relatable item)
        {
            return item.GetChildren<T>(o => o.IsNot<T>());
        }
        static public IEnumerable<T> GetDeepChildren<T>(this Relatable item)
        {
            return item.GetChildren<T>(Predicates<object>.EVERYTHING);
        }

        static public IEnumerable<object> GetSelfAndChildren(this Relatable item, Predicate<object> predicate)
        {
            return RelatableExtensions_Children_Internal.GetSelfAndChildren(item, predicate);
        }
        static public IEnumerable<T> GetSelfAndChildren<T>(this Relatable item, Predicate<object> predicate)
        {
            return item.GetSelfAndChildren(predicate).Convert<object, T>();
        }

        static public IEnumerable<T> GetSelfAndTopicalChildren<T>(this Relatable item)
        {
            return item.GetSelfAndChildren<T>(o => o.IsNot<T>());
        }
        static public IEnumerable<T> GetSelfAndDeepChildren<T>(this Relatable item)
        {
            return item.GetSelfAndChildren<T>(Predicates<object>.EVERYTHING);
        }
    }
}