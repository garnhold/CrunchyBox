using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    static public class CompileMenu
    {
        [MenuItem("Edit/Provoke Recompile")]
        static private void ProvokeRecompile()
        {
            CodeGenerator.GenerateCode("CompileControl", delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "DATE", DateTime.UtcNow.ToString(),
                    "JUNK", Strings.PseudoRandom(32)
                );

                writer.Write("//?DATE");
                writer.Write("//?JUNK");
            }, GeneratedCodeType.RuntimeDefinition);
        }
    }
}