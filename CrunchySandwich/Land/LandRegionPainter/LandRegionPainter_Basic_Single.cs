using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class LandRegionPainter_Basic_Single : LandRegionPainter_Basic
    {
        [SerializeField]private LandRegionSplat land_region_splat;

        public override IEnumerable<LandRegionSplat> GetLandRegionSplats()
        {
            return land_region_splat.WrapAsEnumerable();
        }
    }
}