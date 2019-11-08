﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionManualNode_Ease : MotionManualNode
    {
        [SerializeField]private float speed = 3.5f;
        [SerializeField]private TimeType time_type;

        protected override float UpdateMotionValue(float current, float target)
        {
            return current.GetInterpolate(target, speed * time_type.GetDelta());
        }
    }
}