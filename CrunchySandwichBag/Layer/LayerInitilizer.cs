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
    static public class LayerInitilizer
    {
        [CodeGenerator]
        static private void GenerateLayersClass()
        {
            CodeGenerator.GenerateStaticClass("Layers", delegate(CSTextDocumentBuilder builder) {
                LayerEX.GetAllLayers().Process(delegate(LayerEX layer) {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "NAME", layer.GetName().StyleAsConstantName(),
                        "VALUE", layer.GetName().StyleAsLiteralString()
                    );

                    writer.Write("static public readonly LayerEX ?NAME = new LayerEX(?VALUE);");
                });
            }, false);
        }
    }
}