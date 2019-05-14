using System;
using System.Reflection;
using System.Reflection.Emit;

using CrunchyDough;

namespace CrunchySalt
{
    static public class AssemblyBuilderExtensions_Module
    {
        static public ModuleBuilder CreateInternalModuleBuilder(this AssemblyBuilder item)
        {
            return item.DefineDynamicModule("Main");
        }

        static public ModuleBuilder CreateExternalModuleBuilder(this AssemblyBuilder item)
        {
            return item.DefineDynamicModule("Main", item.GetDefaultFilename());
        }
    }
}