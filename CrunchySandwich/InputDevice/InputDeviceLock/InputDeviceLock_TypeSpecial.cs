using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class InputDeviceLock_TypeSpecial : InputDeviceLock
    {
        private Type special_type;
        private InputDeviceLockState special_state;

        private InputDeviceLockState default_state;

        public InputDeviceLock_TypeSpecial(Type st, InputDeviceLockState s, InputDeviceLockState d)
        {
            special_type = st;
            special_state = s;

            default_state = d;
        }

        public override InputDeviceLockState GetLockState(InputDeviceComponent component)
        {
            if (component.CanObjectBeTreatedAs(special_type))
                return special_state;

            return default_state;
        }
    }
}