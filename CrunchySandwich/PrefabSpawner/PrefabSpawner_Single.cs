using System;

using UnityEngine;

namespace CrunchySandwich
{
    public class PrefabSpawner_Single : PrefabSpawner
    {
        [SerializeField]private GameObject prefab;

        public override GameObject SpawnPrefab()
        {
            return prefab.SpawnInstance();
        }
    }
}