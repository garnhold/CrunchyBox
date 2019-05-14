using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectExtensions_PrimaryKey
    {
        static private readonly Cache<Type, SolidObjectPrimaryKey> SOLID_OBJECT_PRIMARY_KEY = new Cache<Type, SolidObjectPrimaryKey>(delegate(Type type) {
            return type.GetFilteredInstanceFields(
                Filterer_FieldInfo.HasCustomAttributeOfType<SolidObjectPrimaryKeyAttribute>()
            )
            .GetFirst()
            .IfNotNull(f => f.GetCustomAttributeOfType<SolidObjectPrimaryKeyAttribute>(true).CreatePrimaryKey(f));
        });
        static public SolidObjectPrimaryKey GetSolidObjectPrimaryKey(this SolidObject item)
        {
            return SOLID_OBJECT_PRIMARY_KEY.Fetch(item.GetType());
        }

        static public bool IsSolidObjectNew(this SolidObject item)
        {
            item.GetSolidObjectPrimaryKey()
        }
    }
}