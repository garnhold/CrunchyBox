using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class LandRegionPrefabPopulater
    {
        [SerializeField]private float prefabs_per_area;
        [SerializeField]private PrefabSpawner prefab_spawner;

        public void Populate(GameObject parent, Bounds bounds, float strength)
        {
            int count = (prefabs_per_area * strength).ConvertFromDensityToCount(bounds.GetFootprintArea());

            for (int i = 0; i < count; i++)
                parent.AddChild(prefab_spawner.SpawnPrefabAt(RandVector3.GetWithinBounds(bounds)));
        }
    }
}