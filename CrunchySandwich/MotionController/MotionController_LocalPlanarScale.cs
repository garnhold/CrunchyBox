using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_LocalPlanarScale")]
    public class MotionController_LocalPlanarScale : MotionController
    {
        [SerializeField]private Vector2 center;
        [SerializeField]private Vector2 radius;

        protected override void UpdateInternal(float value)
        {
            this.SetLocalPlanarScale(center + radius * value);
        }
    }
}