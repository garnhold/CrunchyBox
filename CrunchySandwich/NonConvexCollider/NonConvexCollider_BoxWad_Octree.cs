using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Physics/NonConvexCollider_BoxWad_Octree")]
    public class NonConvexCollider_BoxWad_Octree : NonConvexCollider_BoxWad
    {
        [SerializeField]private int depth;

        private NonConvexColliderFillResponse Fill(Bounds bounds, int depth)
        {
            int new_depth = depth - 1;
            Bounds b1, b2, b3, b4, b5, b6, b7, b8;
            bool f1, f2, f3, f4, f5, f6, f7, f8;

            if (CheckBox(bounds))
            {
                if (new_depth <= 0)
                    return NonConvexColliderFillResponse.RequestFill;

                bounds.SplitIntoSpaceEighths(out b1, out b2, out b3, out b4, out b5, out b6, out b7, out b8);

                f1 = Fill(b1, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f2 = Fill(b2, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f3 = Fill(b3, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f4 = Fill(b4, new_depth) == NonConvexColliderFillResponse.RequestFill;

                f5 = Fill(b5, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f6 = Fill(b6, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f7 = Fill(b7, new_depth) == NonConvexColliderFillResponse.RequestFill;
                f8 = Fill(b8, new_depth) == NonConvexColliderFillResponse.RequestFill;

                if (f1 && f2 && f3 && f4 && f5 && f6 && f7 && f8)
                    return NonConvexColliderFillResponse.RequestFill;

                if (f1) AddWadBox(b1);
                if (f2) AddWadBox(b2);
                if (f3) AddWadBox(b3);
                if (f4) AddWadBox(b4);

                if (f5) AddWadBox(b5);
                if (f6) AddWadBox(b6);
                if (f7) AddWadBox(b7);
                if (f8) AddWadBox(b8);

                return NonConvexColliderFillResponse.Filled;
            }

            return NonConvexColliderFillResponse.Empty;
        }

        protected override void GenerateBoxWadInternal()
        {
            Bounds bounds = GetMeshCollider().bounds;

            if (Fill(bounds, depth) == NonConvexColliderFillResponse.RequestFill)
                AddWadBox(bounds);
        }
    }
}