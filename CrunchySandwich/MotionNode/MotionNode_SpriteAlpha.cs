using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionNode_SpriteAlpha")]
    public class MotionNode_SpriteAlpha : MotionNode
    {
        [SerializeField]private float center;
        [SerializeField]private float radius;

        protected override void UpdateInternal(float value)
        {
            this.GetComponent<SpriteRenderer>().SetAlpha(center + radius * value);
        }
    }
}