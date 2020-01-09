using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ModuleBuilderExtensions_Type
    {
        static public Type CreateType(this ModuleBuilder item, string name, TypeAttributes type_attributes, Process<TypeBuilder> process)
        {
            TypeBuilder type_builder = item.CreateTypeBuilder(name, type_attributes);

            process(type_builder);
            return type_builder.CreateType();
        }
    }
}