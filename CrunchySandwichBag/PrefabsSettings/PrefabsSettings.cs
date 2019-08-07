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
        [SerializeField]private List<DeployablePrefabGroup> deployable_prefab_groups;

        public void GeneratePrefabs()
        {
            CodeGenerator.GenerateCode("Prefabs", delegate(CSTextDocumentBuilder builder) {
                CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs();

                writer.Write("public class Prefabs : Subsystem<Prefabs>", delegate() {
                    GetAllDeployablePrefabs().Process(p => p.GeneratePrefabsMembers(builder));

                    deployable_prefab_groups.Process(g => g.GeneratePrefabsMembers(builder));
                });

                writer.Write("static public class PrefabsExtensions", delegate() {
                    GetAllDeployablePrefabTypes().Process(t => 
                        DeployablePrefabExtensions_Prefabs.GeneratePrefabsExtensionsMembers(t, builder)
                    );
                });
            }, GeneratedCodeType.RuntimeDefinition);
        }

        public void PopulatePrefabs()
        {
            SubsystemExtensions_Asset.GetSubsystemAsset("Prefabs")
                .IfNotNull(s => s.ModifyAsset(obj =>
                    GetAllDeployablePrefabs().Process(p => p.PushPrefabToPrefabs(obj))
                ));
        }

        public IEnumerable<Type> GetAllDeployablePrefabTypes()
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<DeployablePrefab>(),
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
            );
        }

        public IEnumerable<DeployablePrefab> GetAllDeployablePrefabs()
        {
            return Project.GetAllPrefabs<DeployablePrefab>();
        }
    }
}