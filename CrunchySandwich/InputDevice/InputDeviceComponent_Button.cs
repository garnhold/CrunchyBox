using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Button : InputDeviceComponent
    {
        private string internal_axis_name;

        public InputDeviceComponent_Button(string a)
        {
            internal_axis_name = a;
        }

        public bool IsButtonDown()
        {
            if (Input.GetButton(internal_axis_name))
                return true;

            return false;
        }

        public bool IsButtonPressed()
        {
            if (Input.GetButtonDown(internal_axis_name))
                return true;

            return false;
        }

        public bool IsButtonReleased()
        {
            if (Input.GetButtonUp(internal_axis_name))
                return true;

            return false;
        }
    }
}