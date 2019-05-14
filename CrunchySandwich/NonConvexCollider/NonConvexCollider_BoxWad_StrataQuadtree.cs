using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AddComponentMenu("Physics/NonConvexCollider_BoxWad_StrataQuadtree")]
    public class NonConvexCollider_BoxWad_StrataQuadtree : NonConvexCollider_BoxWad
    {
        [SerializeField]private int strata_divisions;
        [SerializeField]private int depth;

        private NonConvexColliderFillResponse Fill(Bounds bounds, int depth)
        {
            int new_depth = depth - 1;

            Bounds b1, b2, b3, b4;
            bool f1, f2, f3, f4;

            if(CheckBox(bounds))
            {
                if (new_depth <= 0)
                    return NonConvexColliderFillResponse.RequestFill;

                bounds.SplitIntoAreaQuarters(out b1, out b2, out b3, out b4);

                f1 = Fill(b1, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f2 = Fill(b2, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f3 = Fill(b3, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f4 = Fill(b4, new_depth) == NonConvexColliderFillResponse.RequestFill;

                if (f1 && f2 && f3 && f4)
                    return NonConvexColliderFillResponse.RequestFill;

                if (f1) AddWadBox(b1);
                if (f2) AddWadBox(b2);
                if (f3) AddWadBox(b3);
                if (f4) AddWadBox(b4);

                return NonConvexColliderFillResponse.Filled;
            }

            return NonConvexColliderFillResponse.Empty;
        }

        protected override void GenerateBoxWadInternal()
        {
            Bounds bounds = GetMeshCollider().bounds;
            float strata_height = bounds.size.y / strata_divisions;

            for (float y = bounds.min.y; y < bounds.max.y; y += strata_height)
            {                
                Bounds strata = BoundsExtensions.CreateMinMaxBounds(
                    bounds.min.GetWithY(y),
                    bounds.max.GetWithY(y + strata_height)
                );

                if (Fill(strata, depth) == NonConvexColliderFillResponse.RequestFill)
                    AddWadBox(strata);
            }
        }
    }
}