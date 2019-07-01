using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionNode_LocalRotation")]
    public class MotionNode_LocalRotation : MotionNode
    {
        [SerializeField]private Vector3 center;
        [SerializeField]private Vector3 radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalSpacarRotation(center + radius * value);
        }
    }
}