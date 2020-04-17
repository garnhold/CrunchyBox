using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    public class GamepadComponent_MenuStick : GamepadComponent, InputAtom_IntStick
    {
        private InputAtom_IntStick stick;

        private VectorI2 value;
        private VectorI2 frozen_value;
        private MenuRepeater<VectorI2> menu_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = stick.GetRawValue();
            menu_value.UpdateValue(value);
        }

        protected override InputAtom GetAtom()
        {
            return stick;
        }

        public GamepadComponent_MenuStick(GamepadMenuStickId i, InputAtomLockType l = InputAtomLockType.Zeroed) : base(i, l)
        {
            menu_value = new MenuRepeater<VectorI2>();
        }

        public void Initialize(InputAtom_IntStick s)
        {
            stick = s;
        }

        public void SetDurations(Duration delay, Duration repeat)
        {
            menu_value.SetDurations(delay, repeat);
        }
        public void SetDelayDuration(Duration duration)
        {
            menu_value.SetDelayDuration(duration);
        }
        public void SetRepeatDuration(Duration duration)
        {
            menu_value.SetRepeatDuration(duration);
        }

        public VectorI2 GetRawValue()
        {
            return stick.GetRawValue();
        }

        public VectorI2 GetValue()
        {
            return CalculateEffectiveValueFrozen(value, frozen_value);
        }

        public VectorI2 GetMenuValue()
        {
            return CalculateEffectiveValueExclusive(menu_value.GetMenuValue());
        }
    }
}