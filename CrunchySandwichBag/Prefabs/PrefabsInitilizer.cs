using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

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
    [InitializeOnLoad]
    static public class PrefabsInitializer
    {
        [CodeGenerator]
        static private void GeneratePrefabs()
        {
            CodeGenerator.GenerateCode("Prefabs", delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();

                writer.Write("public class Prefabs : Subsystem<Prefabs>", delegate() {
                    AssetDatabaseExtensions.GetPrefabs()
                        .ConvertComponent<DeployablePrefab>()
                        .Process(p => p.GeneratePrefabsMembers(builder));
                });
            }, false);
        }

        static private void Initilize()
        {
            SubsystemExtensions_Asset.GetSubsystemAsset("Prefabs")
                .IfNotNull(s => s.ModifyAsset(obj =>
                    AssetDatabaseExtensions.GetPrefabs()
                        .ConvertComponent<DeployablePrefab>()
                        .Process(p => p.PushPrefabToPrefabs(obj))
                ));
        }

        static PrefabsInitializer()
        {
            Initilize();
        }
    }
}