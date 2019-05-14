using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_MethodInfo_Instance
    {
        static public IEnumerable<MethodInfoEX> GetAllInstanceMethods(this Object item)
        {
            return item.GetType().GetAllInstanceMethods();
        }

        static public IEnumerable<MethodInfoEX> GetFilteredInstanceMethods(this Object item, IEnumerable<Filterer<MethodInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceMethods(filters);
        }
        static public IEnumerable<MethodInfoEX> GetFilteredInstanceMethods(this Object item, params Filterer<MethodInfo>[] filters)
        {
            return item.GetFilteredInstanceMethods((IEnumerable<Filterer<MethodInfo>>)filters);
        }
    }
}