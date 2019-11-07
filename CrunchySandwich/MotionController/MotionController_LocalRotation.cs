using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_LocalRotation")]
    public class MotionController_LocalRotation : MotionController
    {
        [SerializeField]private Vector3 center;
        [SerializeField]private Vector3 radius;

        protected override void UpdateInternal(float value)
        {
            GetTarget().SetLocalSpacarRotation(center + radius * value);
        }
    }
}