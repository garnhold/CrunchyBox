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

        protected override bool InitializeFulfill()
        {
            start = GetMotionValue();
            return true;
        }

        protected override void StartFulfill()
        {
            easer.Start();
        }

        protected override void PauseFulfill()
        {
            easer.Pause();
        }

        protected override bool UpdateFulfill()
        {
            ForceMotionValue(
                start.GetInterpolate(end, easer.GetCurrentValue())
            );

            return easer.IsTimeOver();
        }

        public ConductorOrder_MotionManualNode_EaseTo(MotionManualNode n, float e, EaseOperation o, float d, TimeType tt) : base(n)
        {
            end = e;
            easer = new GameEaser(o, d, tt);
        }
    }
}