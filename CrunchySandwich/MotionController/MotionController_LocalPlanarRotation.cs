using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_LocalPlanarRotation")]
    public class MotionController_LocalPlanarRotation : MotionController
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            GetTarget().SetLocalPlanarRotation(center + radius * value);
        }
    }
}