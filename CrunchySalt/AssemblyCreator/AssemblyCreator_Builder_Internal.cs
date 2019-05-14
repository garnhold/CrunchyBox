using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public partial class AssemblyCreator
    {
        static public AssemblyBuilder CreateInternalAssemblyBuilder(string assembly_name)
        {
            return CreateAssemblyBuilder(assembly_name, AssemblyBuilderAccess.Run);
        }

        static public ModuleBuilder CreateInternalSingleModuleAssemblyBuilder(string assembly_name)
        {
            return CreateInternalAssemblyBuilder(assembly_name).CreateInternalModuleBuilder();
        }

        static public TypeBuilder CreateInternalSingleTypeAssemblyBuilder(string assembly_name, TypeAttributes attributes)
        {
            return CreateInternalSingleModuleAssemblyBuilder(assembly_name).CreateTypeBuilder(assembly_name, attributes);
        }
    }
}