using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Axis_Basic : InputDeviceComponent_Axis
    {
        private string internal_axis_name;

        protected override float GetValueInternal()
        {
 	        return Input.GetAxis(internal_axis_name);
        }

        public InputDeviceComponent_Axis_Basic(string a)
        {
            internal_axis_name = a;
        }
    }
}