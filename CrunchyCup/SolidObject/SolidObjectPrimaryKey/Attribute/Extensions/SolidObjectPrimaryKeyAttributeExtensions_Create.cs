using System;
using System.Reflection;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class SolidObjectPrimaryKeyAttributeExtensions_Create
    {
        static public SolidObjectPrimaryKey CreatePrimaryKey(this SolidObjectPrimaryKeyAttribute item, FieldInfo field)
        {
            return new SolidObjectPrimaryKey(field.Name, field);
        }
    }
}