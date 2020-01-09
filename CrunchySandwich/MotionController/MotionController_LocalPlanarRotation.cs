using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    [AddComponentMenu("Motion/MotionController_LocalPlanarRotation")]
    public class MotionController_LocalPlanarRotation : MotionController
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarRotation(center + radius * value);
        }
    }
}