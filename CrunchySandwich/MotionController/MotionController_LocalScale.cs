using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_LocalScale")]
    public class MotionController_LocalScale : MotionController
    {
        [SerializeField]private Vector3 center;
        [SerializeField]private Vector3 radius;

        protected override void UpdateInternal(float value)
        {
            GetTarget().SetLocalSpacarScale(center + radius * value);
        }
    }
}