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
    static public partial class CodeGenerator
    {
        static private void GenerateCode(string directory, string filename, Process<CSTextDocumentBuilder> process)
        {
            CSTextDocument document = new CSTextDocument(new CSHeader_SimpleDated("MMMM dd, yyyy"));

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

            if (document.RenderDocument().SaveChanges(directory, filename, true))
                AssetDatabase.Refresh();
        }

        static private void GenerateClass(string directory, string class_name, Process<CSTextDocumentBuilder> process)
        {
            GenerateCode(directory, class_name + ".cs", delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "CLASSNAME", class_name
                );

                writer.Write("static public class ?CLASSNAME", delegate() {
                    process(builder);
                });
            });
        }

        static private void GenerateCodeFromTypes(string directory, string class_base_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateCode(directory, class_base_name + ".cs", delegate(CSTextDocumentBuilder builder) {
                CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.IsConcreteClass(),
                    Filterer_Type.CanBeTreatedAs(type)
                ).Process(t => process(t, builder));
            });
        }

        static private void GenerateClassFromTypes(string directory, string class_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateClass(directory, class_name, delegate(CSTextDocumentBuilder builder) {
                CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.IsConcreteClass(),
                    Filterer_Type.CanBeTreatedAs(type)
                )
                .Process(t => process(t, builder));
            });
        }
    }
}