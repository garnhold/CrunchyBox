using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class PrefabLookupSystem : Subsystem<PrefabLookupSystem>
    {
        [SerializeFieldEX][HideInInspector]private Dictionary<string, UnityObjectEX> prefabs;

        [InspectorDisplay]
        private string GetInfo()
        {
            return prefabs.Convert(p => p.Key + " -> " + p.Value).Join("\n");
        }

        public void RegisterPrefab(string id, UnityObjectEX prefab)
        {
            prefabs[id] = prefab;
        }

        public UnityObjectEX LookupPrefab(string id)
        {
            return prefabs.GetValue(id);
        }
    }
}