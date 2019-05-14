using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class Placer_OnFloor_Jitter : Placer_OnFloor
    {
        [SerializeField]private Bounds translation_jitter;
        [SerializeField]private Bounds rotation_jitter;
        [SerializeField]private Bounds scaling_jitter;

        protected override void ForcePlaceGameObjectOnFloor(GameObject game_object, RaycastHit hit)
        {
            game_object.transform.SetSpacarPosition(hit.point + RandVector3.GetWithinBounds(translation_jitter));
            game_object.transform.SetSpacarRotation(RandVector3.GetWithinBounds(rotation_jitter));
            game_object.transform.SetSpacarScale(RandVector3.GetWithinBounds(scaling_jitter));
        }
    }
}