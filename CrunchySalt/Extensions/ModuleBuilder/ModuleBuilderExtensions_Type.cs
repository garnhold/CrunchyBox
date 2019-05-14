using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
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