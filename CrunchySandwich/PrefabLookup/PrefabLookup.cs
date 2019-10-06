using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class PrefabLookup : Subsystem<PrefabLookup>
    {
        [SerializeFieldEX][HideInInspector]private Dictionary<string, UnityEngine.Object> prefabs;
        [SerializeFieldEX]
        private List<KeyValuePair<string, UnityEngine.Object>> prefabsd;

        private void Validate()
        {
            if (prefabs == null)
                prefabs = new Dictionary<string, UnityEngine.Object>();
        }

        [InspectorDisplay]
        private string GetInfo()
        {
            Validate();
            return prefabs.Convert(p => p.Key + " -> " + p.Value).Join("\n");
        }

        public void RegisterPrefab(string id, UnityEngine.Object prefab)
        {
            Validate();
            prefabs[id] = prefab;
        }

        public UnityEngine.Object LookupPrefab(string id)
        {
            Validate();
            return prefabs.GetValue(id);
        }
    }
}