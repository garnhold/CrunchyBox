using System;
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
    public class PrefabsSettings : Subsystem<PrefabsSettings>
    {
        public void GeneratePrefabs()
        {
            CodeGenerator.GenerateCode("Prefabs", delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();

                writer.Write("public class Prefabs : Subsystem<Prefabs>", delegate() {
                    GetAllDeployablePrefabs().Process(p => p.GeneratePrefabsMembers(builder));
                    GetAllEphemeralPrefabs().Process(p => p.GeneratePrefabsMembers(builder));
                });

                writer.Write("static public class PrefabsExtensions", delegate() {
                    GetAllDeployablePrefabTypes().Process(t =>
                        DeployablePrefabExtensions_Prefabs.GeneratePrefabsExtensionsMembers(t, builder)
                    );

                    GetAllEphemeralPrefabTypes().Process(t => 
                        EphemeralPrefabExtensions_Prefabs.GeneratePrefabsExtensionsMembers(t, builder)
                    );
                });
            }, GeneratedCodeType.RuntimeDefinition);
        }

        public void PopulatePrefabs()
        {
            SubsystemExtensions_Asset.GetSubsystemAsset("Prefabs")
                .IfNotNull(s => s.ModifyAsset(delegate(SerializedObject obj) {
                    GetAllDeployablePrefabs().Process(p => p.PushPrefabToPrefabs(obj));
                    GetAllEphemeralPrefabs().Process(p => p.PushPrefabToPrefabs(obj));
                }));
        }

        public IEnumerable<Type> GetAllDeployablePrefabTypes()
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<DeployablePrefab>(),
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
            );
        }

        public IEnumerable<Type> GetAllEphemeralPrefabTypes()
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<EphemeralPrefab>(),
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
            );
        }

        public IEnumerable<DeployablePrefab> GetAllDeployablePrefabs()
        {
            return Project.GetAllPrefabs<DeployablePrefab>();
        }

        public IEnumerable<EphemeralPrefab> GetAllEphemeralPrefabs()
        {
            return Project.GetAllPrefabs<EphemeralPrefab>();
        }
    }
}