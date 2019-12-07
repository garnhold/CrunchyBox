using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class RelatableExtensions_Parent
    {
        static public object GetImmediateParent(this Relatable item)
        {
            return RelatableExtensions_Parent_Internal.GetImmediateParent(item);
        }

        static public IEnumerable<object> GetParents(this Relatable item)
        {
            return RelatableExtensions_Parent_Internal.GetParents(item);
        }
        static public IEnumerable<T> GetParents<T>(this Relatable item)
        {
            return item.GetParents().Convert<object, T>();
        }

        static public IEnumerable<object> GetSelfAndParents(this Relatable item)
        {
            return item.GetParents().Prepend(item);
        }
        static public IEnumerable<T> GetSelfAndParents<T>(this Relatable item)
        {
            return item.GetSelfAndParents().Convert<object, T>();
        }

        static public T GetParent<T>(this Relatable item)
        {
            return item.GetParents<T>().GetFirst();
        }

        static public T GetParent<T>(this Relatable item, Predicate<T> predicate)
        {
            return item.GetParents<T>().FindFirst(predicate);
        }

        static public T GetSelfOrParent<T>(this Relatable item)
        {
            return item.GetSelfAndParents<T>().GetFirst();
        }

        static public T GetSelfOrParent<T>(this Relatable item, Predicate<T> predicate)
        {
            return item.GetSelfAndParents<T>().FindFirst(predicate);
        }
    }
}