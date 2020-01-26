using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [AddComponentMenu("Motion/MotionController_LocalRotation")]
    public class MotionController_LocalRotation : MotionController
    {
        [SerializeField]private Vector3 center;
        [SerializeField]private Vector3 radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalSpacarRotation(center + radius * value);
        }
    }
}