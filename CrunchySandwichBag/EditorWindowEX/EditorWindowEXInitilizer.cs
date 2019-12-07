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
    
    [CodeGenerator]
    static public class EditorWindowEXInitilizer
    {
        [CodeGenerator]
        static private void GenerateEditorWindowEXMenuItems()
        {
            CodeGenerator.GenerateStaticClass("EditorWindowEXMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in Types.GetFilteredTypes(
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
            }, GeneratedCodeType.EditorOnlyLeaf);
        }
    }
}