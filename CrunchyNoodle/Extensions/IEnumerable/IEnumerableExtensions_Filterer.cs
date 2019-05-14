using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class IEnumerableExtensions_Filterer
    {
        static public IEnumerable<T> FilterBy<T, J>(this IEnumerable<T> item, IEnumerable<Filterer<J>> filters) where T : J
        {
            return item.Narrow(i => filters.Filter(i));
        }
        static public IEnumerable<T> FilterBy<T, J>(this IEnumerable<T> item, params Filterer<J>[] filters) where T : J
        {
            return item.FilterBy((IEnumerable<Filterer<J>>)filters);
        }

        static public IEnumerable<Filterer<Assembly>> GetAssemblyFilters<T>(this IEnumerable<Filterer<T>> filters)
        {
            return filters.Convert(f => f.GetAssemblyFilters());
        }
    }
}