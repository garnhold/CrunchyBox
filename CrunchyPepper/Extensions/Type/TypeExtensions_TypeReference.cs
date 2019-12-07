using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class TypeExtensions_TypeReference
    {
        static public TypeReference GetTypeReference(this Type item, AssemblyDefinition assembly)
        {
            return assembly.MainModule.Import(item);
        }
    }
}