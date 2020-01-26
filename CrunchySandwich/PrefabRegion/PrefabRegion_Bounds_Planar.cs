using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [AddComponentMenu("CrunchySandwich/Prefab/PrefabRegion/PrefabRegion_Bounds/PrefabRegion_Bounds_Planar")]
    public class PrefabRegion_Bounds_Planar : PrefabRegion_Bounds
    {
        protected override float GetRegionSize()
        {
            return GetBounds().GetPlanarArea();
        }

        protected override Bounds GetRegionBounds()
        {
            return GetBounds().GetPlanar().GetSpacar();
        }
    }
}