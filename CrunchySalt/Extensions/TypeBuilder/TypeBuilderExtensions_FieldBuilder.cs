using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class TypeBuilderExtensions_FieldBuilder
    {
        static public FieldBuilder CreateFieldBuilder(this TypeBuilder item, Type type, string name, FieldAttributes attributes)
        {
            return item.DefineField(name, type, attributes);
        }

        static public FieldBuilder CreateFieldBuilder<T>(this TypeBuilder item, string name, FieldAttributes attributes)
        {
            return item.CreateFieldBuilder(typeof(T), name, attributes);
        }
    }
}