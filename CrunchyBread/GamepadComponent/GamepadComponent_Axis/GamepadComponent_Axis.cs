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

        protected override InputAtom GetAtom()
        {
            return axis;
        }

        public GamepadComponent_Axis(GamepadAxisId i, InputAtomLockType l = InputAtomLockType.Zeroed) : base(i, l)
        {
            value = 0.0f;
            frozen_value = 0.0f;
        }

        public void Initialize(InputAtom_Axis a)
        {
            axis = a;
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}