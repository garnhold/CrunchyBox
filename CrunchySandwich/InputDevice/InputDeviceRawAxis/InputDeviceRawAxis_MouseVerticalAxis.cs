using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using OpenTK.Input;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_MouseVerticalAxis : InputDeviceRawAxis
    {
        private int device_index;

        private IntDelta delta;

        public InputDeviceRawAxis_MouseVerticalAxis(int di)
        {
            device_index = di;

            delta = new IntDelta();

            CursorLooper.Enable();
        }

        public InputDeviceRawAxis_MouseVerticalAxis() : this(-1) { }

        public override float UpdateValue()
        {
            return delta.UpdateDelta(MouseExtensions.GetState(device_index).Y);
        }
    }
}