using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("CrunchySandwich/Prefab/PrefabRegion/PrefabRegion_Bounds/PrefabRegion_Bounds_Volume")]
    public class PrefabRegion_Bounds_Volume : PrefabRegion_Bounds
    {
        protected override float GetRegionSize()
        {
            return GetBounds().GetVolume();
        }

        protected override Bounds GetRegionBounds()
        {
            return GetBounds();
        }
    }
}