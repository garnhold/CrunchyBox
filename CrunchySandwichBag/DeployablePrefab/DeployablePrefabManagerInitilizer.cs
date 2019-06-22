using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [InitializeOnLoad]
    static public class DeployablePrefabManagerInitializer
    {
        static private void Initilize()
        {
            Subsystem.GetInstance<DeployablePrefabManager>().Initialize(
                Resources.LoadAll("", typeof(DeployablePrefab))
                    .Convert(o => o as DeployablePrefab)
            );
        }

        static DeployablePrefabManagerInitializer()
        {
            Initilize();
        }
    }
}