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
    static public class SubsystemInitilizer
    {
        [MenuItem("Edit/Force Subsystem Generation")]
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateSubsystems()
        {
            CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<Subsystem>(),
                Filterer_Type.IsConcreteClass()
            ).Process(t => SubsystemExtensions_Asset.CreateSubsystemAssetIfMissing(t));

            CodeGenerator.GenerateEditorClassFromTypes<Subsystem>("SubsystemMenuItems", delegate(Type type, CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                    "PATH", ("Edit/Project Settings/" + type.Name).StyleAsLiteralString(),
                    "FUNCTION", ("Focus" + type.Name).StyleAsFunctionName(),
                    "TYPE", type.Namespace.AppendToVisible(".") + type.Name
                );

                writer.Write("[MenuItem(?PATH)]");
                writer.Write("static public void ?FUNCTION()", delegate() {
                    writer.Write("Subsystem.GetInstance<?TYPE>().FocusAsset();");
                });
            });
        }
    }
}