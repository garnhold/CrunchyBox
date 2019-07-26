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
    [Serializable]
    public class DeployablePrefabGroup
    {
        [SerializeField]private string group_name;
        [SerializeField]private string deployable_prefab_type_name;
        [SerializeField]private bool should_include_child_types;

        public void GeneratePrefabsMembers(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "FUNCTION", ("Get_" + group_name).StyleAsFunctionName(),
                "TYPE", deployable_prefab_type_name
            );

            writer.Write("static public IEnumerable<?TYPE> ?FUNCTION()", delegate() {
                GetDeployablePrefabs().Process(p => p.GeneratePrefabsYieldReturn(builder));
                writer.Write("yield break;");
            });
        }

        public bool DoesBelongTo(Type to_check)
        {
            if (to_check.IsNamed(deployable_prefab_type_name))
                return true;

            if (should_include_child_types)
            {
                if (to_check.GetAllBaseTypesAndInterfaces().Has(t => t.IsNamed(deployable_prefab_type_name)))
                    return true;
            }

            return false;
        }
        public bool DoesBelongTo(DeployablePrefab to_check)
        {
            return DoesBelongTo(to_check.GetType());
        }

        public IEnumerable<DeployablePrefab> GetDeployablePrefabs()
        {
            return Project.GetAllPrefabs<DeployablePrefab>()
                .Narrow(p => DoesBelongTo(p));
        }
    }
}