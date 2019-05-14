using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_FieldInfo_Instance
    {
        static public IEnumerable<FieldInfoEX> GetAllInstanceFields(this Object item)
        {
            return item.GetType().GetAllInstanceFields();
        }

        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFields(this Object item, IEnumerable<Filterer<FieldInfo>> filters)
        {
            return item.GetType().GetFilteredInstanceFields(filters);
        }
        static public IEnumerable<FieldInfoEX> GetFilteredInstanceFields(this Object item, params Filterer<FieldInfo>[] filters)
        {
            return item.GetFilteredInstanceFields((IEnumerable<Filterer<FieldInfo>>)filters);
        }
    }
}