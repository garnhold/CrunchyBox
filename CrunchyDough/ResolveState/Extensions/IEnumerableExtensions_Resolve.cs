using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Resolve
    {
        static public ResolveState TryResolve<T>(this IEnumerable<T> item, out T resolved)
        {
            if (item != null)
            {
                using (IEnumerator<T> iter = item.GetEnumerator())
                {
                    if (iter.MoveNext())
                    {
                        resolved = iter.Current;

                        if (iter.MoveNext())
                            return ResolveState.UnableToResolve_NotUnique;

                        return ResolveState.Resolved;
                    }
                }
            }

            resolved = default(T);
            return ResolveState.UnableToResolve_NotFound;
        }

        static public ResolveState TryResolve<T>(this IEnumerable<IEnumerable<T>> item, out T resolved)
        {
            foreach (IEnumerable<T> layer in item)
            {
                ResolveState state = layer.TryResolve<T>(out resolved);

                if (state != ResolveState.UnableToResolve_NotFound)
                    return state;
            }

            resolved = default(T);
            return ResolveState.UnableToResolve_NotFound;
        }

        static public ResolveState TryResolve<T>(this IEnumerable<IEnumerable<T>> item, Predicate<T> predicate, out T resolved)
        {
            return item.InnerNarrow(predicate).TryResolve<T>(out resolved);
        }
    }
}