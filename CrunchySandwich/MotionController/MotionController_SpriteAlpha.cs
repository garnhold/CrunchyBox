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
        [SerializeFieldEX][Range(0.0f, 1.0f)]private FloatRange range;

        protected override void UpdateInternal(float value)
        {
            this.GetComponent<SpriteRenderer>().SetAlpha(value.ConvertFromOffsetToRange(range));
        }
    }
}