using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Button_Basic : InputDeviceComponent_Button
    {
        private string internal_axis_name;

        protected override bool IsButtonDownInternal()
        {
            if (Input.GetButton(internal_axis_name))
                return true;

            return false;
        }

        public InputDeviceComponent_Button_Basic(string a)
        {
            internal_axis_name = a;
        }
    }
}