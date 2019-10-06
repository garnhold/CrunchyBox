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
        [SerializeFieldEX]private Dictionary<string, UnityEngine.Object> prefabs;

        public void RegisterPrefab(string id, UnityEngine.Object prefab)
        {
            prefabs[id] = prefab;
        }

        public UnityEngine.Object LookupPrefab(string id)
        {
            return prefabs.GetValue(id);
        }
    }
}