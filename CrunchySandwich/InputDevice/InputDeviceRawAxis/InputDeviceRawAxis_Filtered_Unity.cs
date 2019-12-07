using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBread;

namespace CrunchySandwich
{
    public class InputDeviceRawAxis_Filtered_Unity : InputDeviceRawAxis_Filtered
    {
        private string internal_axis_name;

        protected override float GetRawValue()
        {
            return Input.GetAxisRaw(internal_axis_name);
        }

        public InputDeviceRawAxis_Filtered_Unity(string a, AxisFilter f) : base(f)
        {
            internal_axis_name = a;
        }

        public InputDeviceRawAxis_Filtered_Unity(string a) : this(a, new AxisFilter_AdaptiveLimit()) { }
    }
}