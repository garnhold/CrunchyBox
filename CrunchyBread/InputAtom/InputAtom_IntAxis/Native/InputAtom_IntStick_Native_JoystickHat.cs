using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class InputAtom_IntStick_Native_JoystickHat : InputAtom_IntStick_Native
    {
        private int device_index;
        private int hat_index;

        public InputAtom_IntStick_Native_JoystickHat(int di, int hi)
        {
            device_index = di;
            hat_index = hi;
        }

        public override VectorI2 GetRawValue()
        {
            return JoystickExtensions.GetState(device_index).GetHat(hat_index).GetVectorI2();
        }
    }
}