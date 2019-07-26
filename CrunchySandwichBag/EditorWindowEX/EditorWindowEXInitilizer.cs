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
    [CodeGenerator]
    static public class EditorWindowEXInitilizer
    {
        [CodeGenerator]
        static private void GenerateEditorWindowEXMenuItems()
        {
            CodeGenerator.GenerateStaticClass("EditorWindowEXMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.CanBeTreatedAs<EditorWindowEX>(),
                    Filterer_Type.IsConcreteClass()
                ))
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Window/" + type.Name).StyleAsLiteralString(),
                        "FUNCTION", ("Open" + type.Name).StyleAsFunctionName(),
                        "TYPE", type.Namespace.AppendToVisible(".") + type.Name
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION()", delegate() {
                        writer.Write("EditorWindow.GetWindow<?TYPE>().Show();");
                    });
                }
            }, true);
        }
    }
}