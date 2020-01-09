using System;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public class PlacementEvaluator_NonColliding : PlacementEvaluator
    {
        [SerializeField]private Vector3 bounds_scale;
        [SerializeField]private LayerMask layer_mask;

        public override bool IsGameObjectPlacementValid(GameObject game_object)
        {
            Bounds bounds = game_object.GetSpacarMeshBounds().GetScaled(bounds_scale);

            if (PhysicsExtensions.OverlapBox(bounds, layer_mask).Has(c => c.gameObject != game_object))
                return false;

            return true;
        }
    }
}