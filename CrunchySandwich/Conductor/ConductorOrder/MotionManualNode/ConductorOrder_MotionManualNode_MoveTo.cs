using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class ConductorOrder_MotionManualNode_MoveTo : ConductorOrder_MotionManualNode
    {
        private float target;

        private float speed;
        private TimeType time_type;

        public ConductorOrder_MotionManualNode_MoveTo(MotionManualNode n, float t, float s, TimeType tt) : base(n)
        {
            target = t;

            speed = s;
            time_type = tt;
        }

        public override bool UpdateFulfill()
        {
            float value;
            bool result = GetMotionValue().GetMoveTowards(target, speed * time_type.GetDelta(), out value);

            ForceMotionValue(value);
            return result;
        }
    }
}