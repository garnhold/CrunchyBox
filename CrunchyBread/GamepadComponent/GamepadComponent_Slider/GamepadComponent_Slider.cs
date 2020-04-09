using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_Slider : GamepadComponent
    {
        private InputAtom_Slider slider;

        private float value;
        private float frozen_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = slider.GetValue();
        }

        public GamepadComponent_Slider(string i, InputAtom_Slider a, InputAtomLockType l) : base(i, a, l)
        {
            slider = a;

            value = 0.0f;
            frozen_value = 0.0f;
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}