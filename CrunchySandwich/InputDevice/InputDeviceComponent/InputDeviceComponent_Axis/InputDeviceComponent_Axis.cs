using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class InputDeviceComponent_Axis : InputDeviceComponent
    {
        private float value;

        private float frozen_value;

        protected abstract float GetValueInternal();

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = GetValueInternal();
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