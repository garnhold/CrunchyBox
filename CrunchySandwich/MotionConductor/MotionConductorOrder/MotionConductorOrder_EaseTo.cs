using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class MotionConductorOrder_EaseTo : MotionConductorOrder
    {
        private float start;
        private float target;

        private GameTimer timer;
        private EaseOperation operation;

        public MotionConductorOrder_EaseTo(float t, GameTimer gt, EaseOperation o, MotionConductor c) : base(c)
        {
            start = GetMotionValue();
            target = t;

            timer = gt.StartAndGet();
            operation = o;
        }

        public MotionConductorOrder_EaseTo(float t, float d, TimeType tt, EaseOperation o, MotionConductor c) : this(t, new GameTimer(d, tt), o, c) { }
        public MotionConductorOrder_EaseTo(float t, float d, TimeType tt, MotionConductor c) : this(t, d, tt, EaseOperations.Linear, c) { }

        public override bool Fulfill()
        {
            SetMotionValue(
                operation(timer.GetTimeElapsedInPercent())
                    .BindPercent()
                    .ConvertFromPercentToRange(start, target)
            );

            if (timer.IsTimeOver())
                return true;

            return false;
        }
    }
}