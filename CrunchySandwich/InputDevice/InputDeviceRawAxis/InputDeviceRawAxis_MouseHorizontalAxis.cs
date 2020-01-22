using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using OpenTK.Input;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    public class InputDeviceRawAxis_MouseHorizontalAxis : InputDeviceRawAxis
    {
        private int device_index;

        private IntDelta delta;

        public InputDeviceRawAxis_MouseHorizontalAxis(int di)
        {
            device_index = di;

            delta = new IntDelta();
        }

        public InputDeviceRawAxis_MouseHorizontalAxis() : this(-1) { }

        public override float UpdateValue()
        {
            return delta.UpdateDelta(MouseExtensions.GetState(device_index).X);
        }
    }
}