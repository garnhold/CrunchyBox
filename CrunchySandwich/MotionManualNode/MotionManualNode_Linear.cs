using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionManualNode_Linear : MotionManualNode
    {
        [SerializeField]private float speed = 3.5f;
        [SerializeField]private TimeType time_type;

        protected override float UpdateMotionValue(float current, float target)
        {
            return current.GetTowards(target, speed * time_type.GetDelta());
        }
    }
}