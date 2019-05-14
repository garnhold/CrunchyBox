using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class LandRegionPopulater_Basic_Single : LandRegionPopulater_Basic
    {
        [SerializeField]private LandRegionPrefabPopulater land_region_prefab_populater;

        public override IEnumerable<LandRegionPrefabPopulater> GetLandRegionPrefabPopulaters()
        {
            return land_region_prefab_populater.WrapAsEnumerable();
        }
    }
}