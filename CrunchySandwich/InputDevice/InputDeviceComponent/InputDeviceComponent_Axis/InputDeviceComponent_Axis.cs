using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceComponent_Axis : InputDeviceComponent
    {
        private InputDeviceRawAxis axis;

        private float value;
        private float frozen_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = axis.UpdateValue();
        }

        public InputDeviceComponent_Axis()
        {
            value = 0.0f;

            frozen_value = 0.0f;
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}