using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Stick : InputDeviceComponent
    {
        private string horizontal_internal_axis_name;
        private string vertical_internal_axis_name;

        public InputDeviceComponent_Stick(string ha, string va)
        {
            horizontal_internal_axis_name = ha;
            vertical_internal_axis_name = va;
        }

        public override void Update()
        {
        }

        public Vector2 GetValue()
        {
            return new Vector2(Input.GetAxis(horizontal_internal_axis_name), Input.GetAxis(vertical_internal_axis_name));
        }
    }
}