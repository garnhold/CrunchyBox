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
    static public class SortingLayerInitilizer
    {
        [CodeGenerator]
        static private void GenerateSortingLayersClass()
        {
            CodeGenerator.GenerateStaticClass("SortingLayers", delegate(CSTextDocumentBuilder builder) {
                SortingLayerEXExtensions.GetAllSortingLayers().Process(delegate(SortingLayerEX layer) {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "NAME", layer.GetName().StyleAsConstantName(),
                        "VALUE", layer.GetName().StyleAsLiteralString()
                    );

                    writer.Write("static public readonly SortingLayerEX ?NAME = new SortingLayerEX(?VALUE);");
                });
            }, GeneratedCodeType.RuntimeDefinition);
        }
    }
}