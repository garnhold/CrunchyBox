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
    static public class SubsystemInitilizer
    {
        [CodeGenerator]
        static private void GenerateSubsystems()
        {
            CodeGenerator.GenerateStaticClass("SubsystemMenuItems", delegate(CSTextDocumentBuilder builder) {
                foreach (Type type in Types.GetFilteredTypes(
                    Filterer_Type.CanBeTreatedAs<Subsystem>(),
                    Filterer_Type.IsConcreteClass()
                ))
                {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "PATH", ("Edit/Project Settings/" + type.Name).StyleAsDoubleQuoteLiteral(),
                        "FUNCTION", ("Focus" + type.Name).StyleAsFunctionName(),
                        "TYPE", type.Namespace.AppendToVisible(".") + type.Name
                    );

                    writer.Write("[MenuItem(?PATH)]");
                    writer.Write("static public void ?FUNCTION()", delegate() {
                        writer.Write("?TYPE.GetInstance().FocusAsset();");
                    });

                    SubsystemExtensions_Asset.CreateSubsystemAssetIfMissing(type);
                }
            }, GeneratedCodeType.EditorOnlyLeaf);
        }
    }
}