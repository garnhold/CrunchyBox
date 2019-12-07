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
    static public class LayerInitilizer
    {
        [CodeGenerator]
        static private void GenerateLayersClass()
        {
            CodeGenerator.GenerateStaticClass("Layers", delegate(CSTextDocumentBuilder builder) {
                LayerEXExtensions.GetAllLayers().Process(delegate(LayerEX layer) {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "NAME", layer.GetName().StyleAsConstantName(),
                        "VALUE", layer.GetName().StyleAsLiteralString()
                    );

                    writer.Write("static public readonly LayerEX ?NAME = new LayerEX(?VALUE);");
                });
            }, GeneratedCodeType.RuntimeDefinition);
        }
    }
}