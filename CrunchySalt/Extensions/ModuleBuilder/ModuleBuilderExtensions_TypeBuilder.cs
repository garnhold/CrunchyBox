using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class ModuleBuilderExtensions_TypeBuilder
    {
        static public TypeBuilder CreateTypeBuilder(this ModuleBuilder item, string name, TypeAttributes type_attributes)
        {
            return item.DefineType(name, type_attributes);
        }
    }
}