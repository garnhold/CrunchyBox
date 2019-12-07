using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Crunchy.Salt
{
    using Dough;
    
    static public partial class AssemblyCreator
    {
        static public AssemblyBuilder CreateAssemblyBuilder(string assembly_name, AssemblyBuilderAccess assembly_builder_access)
        {
            return AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(assembly_name), assembly_builder_access);
        }
    }
}