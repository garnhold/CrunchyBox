using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class AssemblyDefinitionExtensions_Types
    {
        static public IEnumerable<TypeDefinition> GetTypes(this AssemblyDefinition item)
        {
            return item.MainModule.GetTypes();
        }

        static public TypeDefinition GetTypeByName(this AssemblyDefinition item, string name)
        {
            return item.GetTypes().FindFirst(t => t.Name == name);
        }
    }
}