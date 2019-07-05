using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [AddComponentMenu("Motion/MotionNode_Time")]
    public class MotionNode_Time : MotionNode
    {
        [SerializeField]private float time_offset;

        public override float GetMotionValue()
        {
            return Time.time + time_offset;
        }
    }
}