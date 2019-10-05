using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class FiltererExtensions_IEnumerable
    {
        static public IEnumerable<T> FilterBy<T, J>(this IEnumerable<J> item, IEnumerable<Filterer<T>> filters) where J : T
        {
            foreach (T sub_item in item)
            {
                T adjusted;

                if (filters.Filter(sub_item, out adjusted))
                    yield return adjusted;
            }
        }
        static public IEnumerable<T> FilterBy<T, J>(this IEnumerable<J> item, params Filterer<T>[] filters) where J : T
        {
            return item.FilterBy((IEnumerable<Filterer<T>>)filters);
        }

        static public IEnumerable<Filterer<Assembly>> GetAssemblyFilters<T>(this IEnumerable<Filterer<T>> filters)
        {
            return filters.Convert(f => f.GetAssemblyFilters());
        }
    }
}