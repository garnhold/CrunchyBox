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
    [EditorInitializer]
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

                writer.Write("static public class PrefabsExtensions", delegate() {
                    CrunchyNoodle.Types.GetFilteredTypes(
                        Filterer_Type.CanBeTreatedAs<DeployablePrefab>(),
                        Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
                    )
                    .Process(t => DeployablePrefabExtensions_Prefabs.GeneratePrefabsExtensionsMembers(t, builder));
                });
            }, false);
        }

        [EditorInitializer]
        static private void Initilize()
        {
            SubsystemExtensions_Asset.GetSubsystemAsset("Prefabs")
                .IfNotNull(s => s.ModifyAsset(obj =>
                    AssetDatabaseExtensions.GetPrefabs()
                        .ConvertComponent<DeployablePrefab>()
                        .Process(p => p.PushPrefabToPrefabs(obj))
                ));
        }
    }
}