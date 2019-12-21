using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using OpenTK.Input;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_OpenTKJoystickAxis : InputDeviceRawAxis
    {
        private int device_index;
        private int axis_index;

        public InputDeviceRawAxis_OpenTKJoystickAxis(int di, int ai)
        {
            device_index = di;
            axis_index = ai;
        }

        public override float GetValue()
        {
            return Joystick.GetState(device_index).GetAxis(axis_index);
        }
    }
}