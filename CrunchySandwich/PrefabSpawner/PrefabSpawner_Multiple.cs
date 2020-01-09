using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class PrefabSpawner_Multiple : PrefabSpawner
    {
        [SerializeField]private List<GameObject> prefabs;

        public override GameObject SpawnPrefab()
        {
            return prefabs.GetRandom().SpawnInstance();
        }
    }
}