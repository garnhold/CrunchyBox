using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PrefabRegion_Bounds : PrefabRegion
    {
        protected abstract float GetRegionSize();
        protected abstract Bounds GetRegionBounds();

        protected override void PopulateRegionInternal(float density)
        {
            Bounds bounds = GetRegionBounds();

            density.ProcessDensity(GetRegionSize(), () => SpawnPrefab(RandVector3.GetWithinBounds(bounds)));
        }
    }
}