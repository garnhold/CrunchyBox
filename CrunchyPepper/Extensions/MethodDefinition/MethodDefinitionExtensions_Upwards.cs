using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class MethodDefinitionExtensions_Upwards
    {
        static public TypeDefinition GetTypeDefinition(this MethodDefinition item)
        {
            return item.DeclaringType;
        }

        static public ModuleDefinition GetModuleDefinition(this MethodDefinition item)
        {
            return item.Module;
        }

        static public TypeSystem GetTypeSystem(this MethodDefinition item)
        {
            return item.GetModuleDefinition().TypeSystem;
        }

        static public AssemblyDefinition GetAssemblyDefinition(this MethodDefinition item)
        {
            return item.GetModuleDefinition().Assembly;
        }
    }
}