using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class LandRegionPopulater_Basic_Multi : LandRegionPopulater_Basic
    {
        [SerializeField]private List<LandRegionPrefabPopulater> land_region_prefab_populaters;

        public override IEnumerable<LandRegionPrefabPopulater> GetLandRegionPrefabPopulaters()
        {
            return land_region_prefab_populaters;
        }
    }
}