using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using OpenTK.Input;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_Filtered_OpenTK : InputDeviceRawAxis_Filtered
    {
        private int device_index;
        private int axis_index;

        protected override float GetRawValue()
        {
            return Joystick.GetState(device_index).GetAxis(axis_index);
        }

        public InputDeviceRawAxis_Filtered_OpenTK(int di, int ai, AxisFilter f) : base(f)
        {
            device_index = di - 1;
            axis_index = ai;
        }
    }
}