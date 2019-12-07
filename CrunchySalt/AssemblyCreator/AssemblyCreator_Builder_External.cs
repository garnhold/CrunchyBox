using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public partial class AssemblyCreator
    {
        static public AssemblyBuilder CreateExternalAssemblyBuilder(string assembly_name)
        {
            return CreateAssemblyBuilder(assembly_name, AssemblyBuilderAccess.RunAndSave);
        }

        static public ModuleBuilder CreateExternalSingleModuleAssemblyBuilder(string assembly_name)
        {
            return CreateExternalAssemblyBuilder(assembly_name).CreateExternalModuleBuilder();
        }

        static public TypeBuilder CreateExternalSingleTypeAssemblyBuilder(string assembly_name, TypeAttributes attributes)
        {
            return CreateExternalSingleModuleAssemblyBuilder(assembly_name).CreateTypeBuilder(assembly_name, attributes);
        }
    }
}