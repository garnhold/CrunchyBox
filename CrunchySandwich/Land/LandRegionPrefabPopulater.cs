using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    [Serializable]
    public class LandRegionPrefabPopulater
    {
        [SerializeField]private float prefabs_per_area;
        [SerializeField]private PrefabSpawner prefab_spawner;

        public void Populate(GameObject parent, Bounds bounds, float strength)
        {
            parent.AddChildren(
                (prefabs_per_area * strength).ConvertDensity(
                    bounds.GetFootprintArea(),
                    () => prefab_spawner.SpawnPrefabAt(RandVector3.GetWithinBounds(bounds))
                )
            );
        }
    }
}