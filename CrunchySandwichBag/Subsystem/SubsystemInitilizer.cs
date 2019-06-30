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
    static public class SubsystemInitilizer
    {
        [CodeGenerator]
        static private void GenerateSubsystems()
        {
            CodeGenerator.GenerateStaticClass("SubsystemMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.CanBeTreatedAs<Subsystem>(),
                    Filterer_Type.IsConcreteClass()
                ))
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Edit/Project Settings/" + type.Name).StyleAsLiteralString(),
                        "FUNCTION", ("Focus" + type.Name).StyleAsFunctionName(),
                        "TYPE", type.Namespace.AppendToVisible(".") + type.Name
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION()", delegate() {
                        writer.Write("?TYPE.GetInstance().FocusAsset();");
                    });

                    SubsystemExtensions_Asset.CreateSubsystemAssetIfMissing(type);
                }
            }, true);
        }
    }
}