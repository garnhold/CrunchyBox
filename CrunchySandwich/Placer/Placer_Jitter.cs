using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    public class Placer_Jitter : Placer
    {
        [SerializeField]private Bounds translation_jitter;
        [SerializeField]private Bounds rotation_jitter;
        [SerializeField]private Bounds scaling_jitter;

        public override void ForcePlaceGameObjectAt(GameObject game_object, Vector3 position)
        {
            game_object.SetSpacarPosition(position + RandVector3.GetWithinBounds(translation_jitter));
            game_object.SetSpacarRotation(RandVector3.GetWithinBounds(rotation_jitter));
            game_object.SetSpacarScale(RandVector3.GetWithinBounds(scaling_jitter));
        }
    }
}