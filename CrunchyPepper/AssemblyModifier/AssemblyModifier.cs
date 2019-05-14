using System;
using System.Collections;
using System.Collections.Generic;

using Mono.Cecil;

using CrunchyDough;

namespace CrunchyPepper
{
    static public class AssemblyModifier
    {
        static public void Modify(string filename, Process<AssemblyDefinition> process)
        {
            AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(filename);

            process(assembly);
            assembly.Write(filename);
        }
    }
}