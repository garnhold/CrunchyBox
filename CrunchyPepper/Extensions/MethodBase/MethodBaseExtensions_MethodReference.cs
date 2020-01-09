using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Crunchy.Pepper
{
    using Dough;
    
    static public class MethodBaseExtensions_MethodReference
    {
        static public MethodReference GetMethodReference(this MethodBase item, AssemblyDefinition assembly)
        {
            return assembly.MainModule.Import(item);
        }
    }
}