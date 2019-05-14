using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class TypeBuilderExtensions_Field
    {
        static public FieldInfo CreateField(this TypeBuilder item, Type type, string name, FieldAttributes attributes)
        {
            return item.DefineField(name, type, attributes);
        }

        static public FieldInfo CreateField<T>(this TypeBuilder item, string name, FieldAttributes attributes)
        {
            return item.CreateField(typeof(T), name, attributes);
        }
    }
}