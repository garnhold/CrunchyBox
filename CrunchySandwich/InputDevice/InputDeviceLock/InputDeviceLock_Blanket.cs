using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class InputDeviceLock_Blanket : InputDeviceLock
    {
        private InputDeviceLockState state;

        public InputDeviceLock_Blanket(InputDeviceLockState s)
        {
            state = s;
        }

        public override InputDeviceLockState GetLockState(InputDeviceComponent component)
        {
            return state;
        }
    }
}