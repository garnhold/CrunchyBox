using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class LandRegionPainter_Basic_Multi : LandRegionPainter_Basic
    {
        [SerializeField]private List<LandRegionSplat> land_region_splats;

        public override IEnumerable<LandRegionSplat> GetLandRegionSplats()
        {
            return land_region_splats;
        }
    }
}