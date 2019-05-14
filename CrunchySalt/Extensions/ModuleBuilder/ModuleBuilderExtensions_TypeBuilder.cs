using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class ModuleBuilderExtensions_TypeBuilder
    {
        static public TypeBuilder CreateTypeBuilder(this ModuleBuilder item, string name, TypeAttributes type_attributes)
        {
            return item.DefineType(name, type_attributes);
        }
    }
}