using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using OpenTK.Input;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_MouseWheelAxis : InputDeviceRawAxis
    {
        private int device_index;

        public InputDeviceRawAxis_MouseWheelAxis(int di)
        {
            device_index = di;
        }

        public InputDeviceRawAxis_MouseWheelAxis() : this(-1) { }

        public override float GetValue()
        {
            return MouseExtensions.GetState(device_index).WheelPrecise;
        }
    }
}