using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public abstract class MotionManualNode : MonoBehaviourEX, MotionValueProvider
    {
        private float motion_value;
        private float target_motion_value;

        protected abstract float UpdateMotionValue(float current, float target);

        private void Update()
        {
            motion_value = UpdateMotionValue(motion_value, target_motion_value);
        }

        public void SetMotionValue(float value)
        {
            target_motion_value = value;
        }
        public void ForceMotionValue(float value)
        {
            SetMotionValue(value);
            ForceMotionValue();
        }

        public void ForceMotionValue()
        {
            motion_value = target_motion_value;
        }

        public float GetMotionValue()
        {
            return motion_value;
        }
    }
}