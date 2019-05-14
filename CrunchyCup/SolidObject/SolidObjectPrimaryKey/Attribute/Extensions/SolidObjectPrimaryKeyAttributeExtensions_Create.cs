using System;
using System.Reflection;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectPrimaryKeyAttributeExtensions_Create
    {
        static public SolidObjectPrimaryKey CreatePrimaryKey(this SolidObjectPrimaryKeyAttribute item, FieldInfo field)
        {
            return new SolidObjectPrimaryKey(field.Name, field);
        }
    }
}