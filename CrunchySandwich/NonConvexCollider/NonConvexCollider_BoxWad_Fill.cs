using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Physics/NonConvexCollider_BoxWad_Fill")]
    public class NonConvexCollider_BoxWad_Fill : NonConvexCollider_BoxWad
    {
        [SerializeField]private float size;

        protected override void GenerateBoxWadInternal()
        {
            Bounds bounds = GetMeshCollider().bounds;

            for (float y = bounds.min.y; y < bounds.max.y; y += size)
            {
                for (float x = bounds.min.x; x < bounds.max.x; x += size)
                {
                    for (float z = bounds.min.z; z < bounds.max.z; z += size)
                    {
                        Bounds b = BoundsExtensions.CreateMinMaxBounds(
                            new Vector3(x, y, z),
                            new Vector3(x + size, y + size, z + size)
                        );

                        if (PhysicsExtensions.OverlapBox(b).Has(GetMeshCollider()))
                            AddWadBox(b);
                    }
                }
            }
        }
    }
}