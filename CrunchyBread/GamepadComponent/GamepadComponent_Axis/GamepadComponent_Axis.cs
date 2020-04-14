using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_Axis : GamepadComponent, InputAtom_Axis
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
            value = axis.GetRawValue();
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

        public float GetRawValue()
        {
            return axis.GetRawValue();
        }

        public float GetValue()
        {
            return CalculateEffectiveValueFrozen(value, frozen_value);
        }
    }
}