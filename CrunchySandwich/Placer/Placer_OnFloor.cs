using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class Placer_OnFloor : Placer
    {
        [SerializeField]private LayerMask layer_mask;

        protected virtual void ForcePlaceGameObjectOnFloor(GameObject game_object, RaycastHit hit)
        {
            game_object.transform.SetSpacarPosition(hit.point);
        }

        public override void ForcePlaceGameObjectAt(GameObject game_object, Vector3 position)
        {
            Placement.PlaceOnFloor(delegate(RaycastHit hit) {
                ForcePlaceGameObjectOnFloor(game_object, hit);
            }, position, layer_mask);
        }
    }
}