using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class DeployablePrefabManager : Subsystem
    {
        [SerializeField]private DeployablePrefab[] prefabs;

        public void Initialize(IEnumerable<DeployablePrefab> p)
        {
            prefabs = p.ToArray();
        }
        public void Initialize(params DeployablePrefab[] p)
        {
            Initialize((IEnumerable<DeployablePrefab>)p);
        }

        public IEnumerable<DeployablePrefab> GetPrefabs()
        {
            return prefabs;
        }
    }
}