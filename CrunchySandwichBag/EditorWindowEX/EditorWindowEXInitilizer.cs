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
    static public class EditorWindowEXInitilizer
    {
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateEditorWindowEXMenuItems()
        {
            CodeGenerator.GenerateEditorClassFromTypes<EditorWindowEX>("EditorWindowEXMenuItems", delegate(Type type, CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "PATH", ("Window/" + type.Name).StyleAsLiteralString(),
                    "FUNCTION", ("Open" + type.Name).StyleAsFunctionName(),
                    "TYPE", type.Namespace.AppendToVisible(".") + type.Name
                );

                writer.Write("[MenuItem(?PATH)]");
                writer.Write("static public void ?FUNCTION()", delegate() {
                    writer.Write("EditorWindow.GetWindow(typeof(?TYPE)).Show();");
                });
            });
        }
    }
}