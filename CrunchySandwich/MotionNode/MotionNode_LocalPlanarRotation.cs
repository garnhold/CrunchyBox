using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionNode_LocalPlanarRotation")]
    public class MotionNode_LocalPlanarRotation : MotionNode
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarRotation(center + radius * value);
        }
    }
}