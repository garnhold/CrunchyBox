using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class MotionConductorOrder : ConductorOrder
    {
        private MotionConductor conductor;

        protected void SetMotionValue(float value)
        {
            conductor.SetMotionValue(value);
        }

        protected float GetMotionValue()
        {
            return conductor.GetMotionValue();
        }

        public MotionConductorOrder(MotionConductor c)
        {
            conductor = c;
        }
    }
}