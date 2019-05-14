﻿using System;

using UnityEngine;

namespace CrunchySandwich
{
    [CustomAssetCategory("Utility")]
    public abstract class PrefabSpawner : CustomAsset
    {
        [SerializeField]private Placer placer;

        public abstract GameObject SpawnPrefab();

        public virtual GameObject SpawnPrefabAt(Vector3 position)
        {
            GameObject instance = SpawnPrefab();

            placer.PlaceGameObjectAt(instance, position, true);
            return instance;
        }
    }
}