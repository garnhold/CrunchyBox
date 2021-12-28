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
    
    static public class CodeGenerator
    {
        static private int REGENERATION_COUNT;

        [MenuItem("Edit/Force Code Generation")]
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateCode()
        {
            REGENERATION_COUNT = 0;

            MarkedMethods<CodeGeneratorAttribute>
                .GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.HasNoEffectiveParameters()
                ).ProcessSandboxed(
                    m => m.Invoke(null, Empty.Array<object>()),
                    e => Debug.LogException(e)
                );

            if(REGENERATION_COUNT >= 1)
                AssetDatabase.Refresh();
        }

        static public void GenerateCode(string base_filename, Process<CSTextDocumentBuilder> process, GeneratedCodeType type)
        {
            CSTextDocument document = new CSTextDocument(new CSHeader_SimpleStatement());

            CSTextDocumentBuilder builder = document.CreateCSTextBuilder();
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();
            
            writer.Write("using System;");
            writer.Write("using System.Collections;");
            writer.Write("using System.Collections.Generic;");

            writer.Write("using UnityEngine;");

            writer.Write("#if UNITY_EDITOR");
            writer.Write("using UnityEditor;");
            writer.Write("using Crunchy.SandwichBag;");
            writer.Write("#endif");

            writer.Write("using Crunchy.Dough;");
            writer.Write("using Crunchy.Salt;");
            writer.Write("using Crunchy.Noodle;");
            writer.Write("using Crunchy.Bread;");
            writer.Write("using Crunchy.Sandwich;");

            process(builder);

            if (document.RenderDocument().SaveChanges(type.GetDirectory(), base_filename + ".cs", true))
                REGENERATION_COUNT++;
        }

        static public void GenerateStaticClass(string class_name, Process<CSTextDocumentBuilder> process, GeneratedCodeType type)
        {
            GenerateCode(class_name, delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "CLASS", class_name.StyleAsClassName()
                );

                writer.Write("static public class ?CLASS", delegate() {
                    process(builder);
                });
            }, type);
        }
    }
}