using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class MotionManualNode_Instant : MotionManualNode
    {
        protected override float UpdateMotionValue(float current, float target)
        {
            return target;
        }
    }
}