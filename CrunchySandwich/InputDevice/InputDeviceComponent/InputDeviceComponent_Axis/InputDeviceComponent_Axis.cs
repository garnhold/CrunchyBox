using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Axis : InputDeviceComponent
    {
        private string internal_axis_name;

        private float value;

        private float frozen_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = Input.GetAxis(internal_axis_name);
        }

        public InputDeviceComponent_Axis(string a)
        {
            internal_axis_name = a;

            value = 0.0f;

            frozen_value = 0.0f;
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}