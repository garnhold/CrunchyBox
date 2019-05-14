using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class AssemblyDefinitionExtensions_Initilizer
    {
        static public MethodDefinition GetInitilizer(this AssemblyDefinition item)
        {
            return item.GetTypes()
                .FindFirst(t => t.Name == "<Module>")
                .GetStaticConstructor();
        }
    }
}