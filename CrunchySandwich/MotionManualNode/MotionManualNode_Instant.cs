using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionManualNode_Instant : MotionManualNode
    {
        protected override float UpdateMotionValue(float current, float target)
        {
            return target;
        }
    }
}