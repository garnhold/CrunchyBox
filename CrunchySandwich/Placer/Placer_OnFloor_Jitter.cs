using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class Placer_OnFloor_Jitter : Placer_OnFloor
    {
        [SerializeField]private Bounds translation_jitter;
        [SerializeField]private Bounds rotation_jitter;
        [SerializeField]private Bounds scaling_jitter;

        protected override void ForcePlaceGameObjectOnFloor(GameObject game_object, RaycastHit hit)
        {
            game_object.SetSpacarPosition(hit.point + RandVector3.GetWithinBounds(translation_jitter));
            game_object.SetSpacarRotation(RandVector3.GetWithinBounds(rotation_jitter));
            game_object.SetSpacarScale(RandVector3.GetWithinBounds(scaling_jitter));
        }
    }
}