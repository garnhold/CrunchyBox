using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceRawAxis_Native : InputDeviceRawAxis
    {
        private string internal_axis_name;

        public InputDeviceRawAxis_Native(string a)
        {
            internal_axis_name = a;
        }

        public override float GetValue()
        {
            return Input.GetAxis(internal_axis_name);
        }
    }
}