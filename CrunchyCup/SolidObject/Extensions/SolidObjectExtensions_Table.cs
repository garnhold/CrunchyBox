using System;
using System.Collections;
using System.Collections.Generic;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectExtensions_Table
    {
        static private readonly Cache<Type, SolidObjectTable> SOLID_OBJECT_TABLE = new Cache<Type, SolidObjectTable>(delegate(Type type) {
            return type.GetCustomAttributeOfType<SolidObjectTableAttribute>(true).IfNotNull(a => a.CreateTable(type));
        });
        static public SolidObjectTable GetSolidObjectTable(this SolidObject item)
        {
            return SOLID_OBJECT_TABLE.Fetch(item.GetType());
        }
    }
}