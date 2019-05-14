﻿using System;
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
    static public class SortingLayerInitilizer
    {
        [MenuItem("Edit/Force SortingLayers Class Regeneration")]
        [UnityEditor.Callbacks.DidReloadScripts]
        static private void GenerateSortingLayersClass()
        {
            CodeGenerator.GenerateStandardClass("SortingLayers", delegate(CSTextDocumentBuilder builder) {
                SortingLayerEX.GetAllSortingLayers().Process(delegate(SortingLayerEX layer) {
                    CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                        "NAME", layer.GetName().StyleAsConstantName(),
                        "VALUE", layer.GetName().StyleAsLiteralString()
                    );

                    writer.Write("static public readonly SortingLayerEX ?NAME = new SortingLayerEX(?VALUE);");
                });
            });
        }
    }
}