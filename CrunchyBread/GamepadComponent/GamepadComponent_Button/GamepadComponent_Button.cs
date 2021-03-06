using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class GamepadComponent_Button : GamepadComponent, InputAtom_Button
    {
        private InputAtom_Button button;

        private bool is_down;
        private bool is_pressed;
        private bool is_released;

        private bool frozen_is_down;

        private GamepadEventLog<bool> presses;

        protected override void FreezeInternal()
        {
            frozen_is_down = is_down;
        }

        protected override void UpdateInternal()
        {
            is_down = button.GetRawValue();

            is_pressed = false;
            is_released = false;

            if (is_down)
            {
                if (presses.LogValue(true))
                    is_pressed = true;
            }
            else
            {
                if (presses.LogValue(false))
                    is_released = true;
            }
        }

        protected override InputAtom GetAtom()
        {
            return button;
        }

        public GamepadComponent_Button(GamepadButtonId i, InputAtomLockType l = InputAtomLockType.Zeroed) : base(i, l)
        {
            is_down = false;
            is_pressed = false;
            is_released = false;

            frozen_is_down = false;

            presses = new GamepadEventLog<bool>(32);
        }

        public void Initialize(InputAtom_Button b)
        {
            button = b;
        }

        public bool GetRawValue()
        {
            return button.GetRawValue();
        }

        public bool IsButtonDown()
        {
            return CalculateEffectiveValueFrozen(is_down, frozen_is_down);
        }

        public bool IsButtonPressed()
        {
            return CalculateEffectiveValueExclusive(is_pressed);
        }

        public bool IsButtonReleased()
        {
            return CalculateEffectiveValueExclusive(is_released);
        }

        public GamepadEventHistory<bool> GetHistory()
        {
            return CalculateEffectiveValueExclusive<GamepadEventHistory<bool>>(
                presses,
                GamepadEventEmptyHistory<bool>.INSTANCE
            );
        }
    }
}