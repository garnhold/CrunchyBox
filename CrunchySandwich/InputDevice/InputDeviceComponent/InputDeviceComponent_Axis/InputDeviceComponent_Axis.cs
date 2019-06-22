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

        public InputDeviceComponent_Axis(string a)
        {
            internal_axis_name = a;
        }

        public override void Update()
        {
        }

        public float GetValue()
        {
            return Input.GetAxis(internal_axis_name);
        }
    }
}