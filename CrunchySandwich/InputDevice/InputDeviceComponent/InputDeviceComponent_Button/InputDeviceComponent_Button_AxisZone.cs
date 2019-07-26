using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceComponent_Button_AxisZone : InputDeviceComponent_Button
    {
        private string internal_axis_name;

        private float zone;
        private float tolerance;

        protected override bool IsButtonDownInternal()
        {
            if (Input.GetAxis(internal_axis_name).IsApproximatelyEqualTo(zone, tolerance))
                return true;

            return false;
        }

        public InputDeviceComponent_Button_AxisZone(string a, float z, float t)
        {
            internal_axis_name = a;

            zone = z;
            tolerance = t;
        }
    }
}