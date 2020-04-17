using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_MenuAxis : GamepadComponent, InputAtom_IntAxis
    {
        private InputAtom_IntAxis axis;

        private int value;
        private int frozen_value;
        private MenuRepeater<int> menu_value;

        protected override void FreezeInternal()
        {
            frozen_value = value;
        }

        protected override void UpdateInternal()
        {
            value = axis.GetRawValue();
            menu_value.UpdateValue(value);
        }

        protected override InputAtom GetAtom()
        {
            return axis;
        }

        public GamepadComponent_MenuAxis(GamepadMenuAxisId i, InputAtomLockType l = InputAtomLockType.Zeroed) : base(i, l)
        {
            menu_value = new MenuRepeater<int>();
        }

        public void Initialize(InputAtom_IntAxis a)
        {
            axis = a;
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

        public int GetRawValue()
        {
            return axis.GetRawValue();
        }

        public int GetValue()
        {
            return CalculateEffectiveValueFrozen(value, frozen_value);
        }

        public int GetMenuValue()
        {
            return CalculateEffectiveValueExclusive(menu_value.GetMenuValue());
        }
    }
}