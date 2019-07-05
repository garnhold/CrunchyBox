using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionController_SpriteAlpha")]
    public class MotionController_SpriteAlpha : MotionController
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            this.GetComponent<SpriteRenderer>().SetAlpha(center + radius * value);
        }
    }
}