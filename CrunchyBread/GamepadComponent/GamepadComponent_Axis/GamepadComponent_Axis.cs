using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_Axis : GamepadComponent
    {
        private InputAtom_Axis axis;

        private float value;
        private float frozen_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = axis.GetValue();
        }

        public GamepadComponent_Axis(string i, InputAtom_Axis a, InputAtomLockType l) : base(i, a, l)
        {
            axis = a;

            value = 0.0f;
            frozen_value = 0.0f;
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}