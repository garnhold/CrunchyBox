using System;
using System.Reflection;

using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyCup
{
    static public class SolidObjectPropertyAttributeExtensions_Create
    {
        static public SolidObjectProperty CreateProperty(this SolidObjectPropertyAttribute item, FieldInfo field)
        {
            return new SolidObjectProperty(field.Name, field);
        }
    }
}