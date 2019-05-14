using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class TypeExtensions_TypeReference
    {
        static public TypeReference GetTypeReference(this Type item, AssemblyDefinition assembly)
        {
            return assembly.MainModule.Import(item);
        }
    }
}