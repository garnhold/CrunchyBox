using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public abstract class ConductorOrder_MotionManualNode_EaseTo : ConductorOrder_MotionManualNode
    {
        private float start;
        private float end;

        private GameEaser easer;

        public ConductorOrder_MotionManualNode_EaseTo(MotionManualNode n, float e, EaseOperation o, float d, TimeType tt) : base(n)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }

        public override void Start()
        {
            start = GetMotionValue();
            easer.Start();
        }

        public override bool Fulfill()
        {
            ForceMotionValue(
                start.GetInterpolate(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }
    }
}