using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeDefinitionExtensions_Upwards
    {
        static public ModuleDefinition GetModuleDefinition(this TypeDefinition item)
        {
            return item.Module;
        }

        static public TypeSystem GetTypeSystem(this TypeDefinition item)
        {
            return item.GetModuleDefinition().TypeSystem;
        }

        static public AssemblyDefinition GetAssemblyDefinition(this TypeDefinition item)
        {
            return item.GetModuleDefinition().Assembly;
        }
    }
}