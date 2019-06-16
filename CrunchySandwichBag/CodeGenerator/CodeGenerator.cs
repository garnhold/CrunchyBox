using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class CodeGenerator
    {
        [MenuItem("Edit/Force Code Generation")]
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateCode()
        {
            MarkedMethods<CodeGeneratorAttribute>
                .GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.HasNoEffectiveParameters()
                ).Process(m => m.Invoke(null, Empty.Array<object>()));
        }

        static public void GenerateCode(string base_filename, Process<CSTextDocumentBuilder> process, bool is_editor)
        {
            CSTextDocument document = new CSTextDocument(new CSHeader_SimpleDated("MMMM dd, yyyy"));
            string directory = is_editor.ConvertBool(Project.GetEditorGeneratedDirectory(), Project.GetGeneratedDirectory());

            CSTextDocumentBuilder builder = document.CreateCSTextBuilder();
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();
            
            writer.Write("using System;");

            writer.Write("using UnityEngine;");

            writer.Write("#if UNITY_EDITOR");
            writer.Write("using UnityEditor;");
            writer.Write("using CrunchySandwichBag;");
            writer.Write("#endif");

            writer.Write("using CrunchyDough;");
            writer.Write("using CrunchySalt;");
            writer.Write("using CrunchyNoodle;");
            writer.Write("using CrunchyBun;");
            writer.Write("using CrunchySandwich;");

            process(builder);

            if (document.RenderDocument().SaveChanges(directory, base_filename + ".cs", true))
                AssetDatabase.Refresh();
        }

        static public void GenerateStaticClass(string class_name, Process<CSTextDocumentBuilder> process, bool is_editor)
        {
            GenerateCode(class_name, delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "CLASS", class_name.StyleAsClassName()
                );

                writer.Write("static public class ?CLASS", delegate() {
                    process(builder);
                });
            }, is_editor);
        }
    }
}