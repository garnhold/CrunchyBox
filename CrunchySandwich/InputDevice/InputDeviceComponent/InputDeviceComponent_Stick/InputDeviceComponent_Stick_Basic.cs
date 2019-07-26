using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Stick_Basic : InputDeviceComponent_Stick
    {
        private string horizontal_internal_axis_name;
        private string vertical_internal_axis_name;

        protected override Vector2 GetValueInternal()
        {
 	        return new Vector2(Input.GetAxis(horizontal_internal_axis_name), Input.GetAxis(vertical_internal_axis_name));
        }

        public InputDeviceComponent_Stick_Basic(string ha, string va)
        {
            horizontal_internal_axis_name = ha;
            vertical_internal_axis_name = va;
        }
    }
}