using System;
using System.Reflection;

using System.Data.SQLite;

namespace Crunchy.Cup
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public class SolidObjectPropertyAttributeExtensions_Create
    {
        static public SolidObjectProperty CreateProperty(this SolidObjectPropertyAttribute item, FieldInfo field)
        {
            return new SolidObjectProperty(field.Name, field);
        }
    }
}