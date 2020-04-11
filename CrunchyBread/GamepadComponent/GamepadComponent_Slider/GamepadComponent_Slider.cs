using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_Slider : GamepadComponent, InputAtom_Slider
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
            value = slider.GetRawValue();
        }

        protected override InputAtom GetAtom()
        {
            return slider;
        }

        public GamepadComponent_Slider(GamepadSliderId i, InputAtomLockType l = InputAtomLockType.Zeroed) : base(i, l)
        {
            value = 0.0f;
            frozen_value = 0.0f;
        }

        public void Initialize(InputAtom_Slider s)
        {
            slider = s;
        }

        public float GetRawValue()
        {
            return slider.GetRawValue();
        }

        public float GetValue()
        {
            return SwitchSharedFrozen(value, frozen_value);
        }
    }
}