using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectExtensions_Propertys
    {
        static private readonly Cache<Type, Dictionary<string, SolidObjectProperty>> SOLID_OBJECT_PROPERTYS = new Cache<Type, Dictionary<string, SolidObjectProperty>>(delegate(Type type) {
            return type.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<SolidObjectPropertyAttribute>()
            )
            .Convert(f => f.GetCustomAttributeOfType<SolidObjectPropertyAttribute>(true).CreateProperty(f))
            .ToDictionaryValues(p => p.GetName());
        });
        static public IEnumerable<SolidObjectProperty> GetSolidObjectPropertys(this SolidObject item)
        {
            return SOLID_OBJECT_PROPERTYS.Fetch(item.GetType()).Values;
        }
    }
}