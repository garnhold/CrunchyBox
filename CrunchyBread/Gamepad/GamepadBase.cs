using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public abstract class GamepadBase
    {
        private Dictionary<GamepadComponentId, GamepadComponent> components;

        private Dictionary<GamepadAxisId, GamepadComponent_Axis> axises;
        private Dictionary<GamepadButtonId, GamepadComponent_Button> buttons;
        private Dictionary<GamepadSliderId, GamepadComponent_Slider> sliders;
        private Dictionary<GamepadStickId, GamepadComponent_Stick> sticks;

        private Dictionary<GamepadMenuAxisId, GamepadComponent_MenuAxis> menu_axises;
        private Dictionary<GamepadMenuStickId, GamepadComponent_MenuStick> menu_sticks;

        protected GamepadComponent_Axis RegisterAxis(GamepadComponent_Axis axis)
        {
            components.Add(axis.GetId(), axis);
            axises.Add((GamepadAxisId)axis.GetId(), axis);

            return axis;
        }
        protected GamepadComponent_Axis CreateAxis(GamepadAxisId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterAxis(new GamepadComponent_Axis(id, lock_type));
        }

        protected GamepadComponent_Button RegisterButton(GamepadComponent_Button button)
        {
            components.Add(button.GetId(), button);
            buttons.Add((GamepadButtonId)button.GetId(), button);

            return button;
        }
        protected GamepadComponent_Button CreateButton(GamepadButtonId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterButton(new GamepadComponent_Button(id, lock_type));
        }

        protected GamepadComponent_Slider RegisterSlider(GamepadComponent_Slider slider)
        {
            components.Add(slider.GetId(), slider);
            sliders.Add((GamepadSliderId)slider.GetId(), slider);

            return slider;
        }
        protected GamepadComponent_Slider CreateSlider(GamepadSliderId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterSlider(new GamepadComponent_Slider(id, lock_type));
        }

        protected GamepadComponent_Stick RegisterStick(GamepadComponent_Stick stick)
        {
            components.Add(stick.GetId(), stick);
            sticks.Add((GamepadStickId)stick.GetId(), stick);

            return stick;
        }
        protected GamepadComponent_Stick CreateStick(GamepadStickId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterStick(new GamepadComponent_Stick(id, lock_type));
        }

        protected GamepadComponent_MenuAxis RegisterMenuAxis(GamepadComponent_MenuAxis axis)
        {
            components.Add(axis.GetId(), axis);
            menu_axises.Add((GamepadMenuAxisId)axis.GetId(), axis);

            return axis;
        }
        protected GamepadComponent_MenuAxis CreateMenuAxis(GamepadMenuAxisId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterMenuAxis(new GamepadComponent_MenuAxis(id, lock_type));
        }

        protected GamepadComponent_MenuStick RegisterMenuStick(GamepadComponent_MenuStick stick)
        {
            components.Add(stick.GetId(), stick);
            menu_sticks.Add((GamepadMenuStickId)stick.GetId(), stick);

            return stick;
        }
        protected GamepadComponent_MenuStick CreateMenuStick(GamepadMenuStickId id, InputAtomLockType lock_type = InputAtomLockType.Zeroed)
        {
            return RegisterMenuStick(new GamepadComponent_MenuStick(id, lock_type));
        }

        public GamepadBase()
        {
            components = new Dictionary<GamepadComponentId, GamepadComponent>();

            axises = new Dictionary<GamepadAxisId, GamepadComponent_Axis>();
            buttons = new Dictionary<GamepadButtonId, GamepadComponent_Button>();
            sliders = new Dictionary<GamepadSliderId, GamepadComponent_Slider>();
            sticks = new Dictionary<GamepadStickId, GamepadComponent_Stick>();

            menu_axises = new Dictionary<GamepadMenuAxisId, GamepadComponent_MenuAxis>();
            menu_sticks = new Dictionary<GamepadMenuStickId, GamepadComponent_MenuStick>();
        }

        public void Update()
        {
            components.Values.Process(c => c.Update());
        }

        public GamepadComponent GetComponent(GamepadComponentId id)
        {
            return components.GetValue(id);
        }

        public GamepadComponent_Axis GetAxis(GamepadAxisId id)
        {
            return axises.GetValue(id);
        }

        public GamepadComponent_Button GetButton(GamepadButtonId id)
        {
            return buttons.GetValue(id);
        }

        public GamepadComponent_Slider GetSlider(GamepadSliderId id)
        {
            return sliders.GetValue(id);
        }

        public GamepadComponent_Stick GetStick(GamepadStickId id)
        {
            return sticks.GetValue(id);
        }

        public GamepadComponent_MenuAxis GetMenuAxis(GamepadMenuAxisId id)
        {
            return menu_axises.GetValue(id);
        }

        public GamepadComponent_MenuStick GetMenuStick(GamepadMenuStickId id)
        {
            return menu_sticks.GetValue(id);
        }

        public IEnumerable<GamepadComponent> GetComponents()
        {
            return components.Values;
        }

        public IEnumerable<GamepadComponent_Axis> GetAxises()
        {
            return axises.Values;
        }

        public IEnumerable<GamepadComponent_Button> GetButtons()
        {
            return buttons.Values;
        }

        public IEnumerable<GamepadComponent_Slider> GetSliders()
        {
            return sliders.Values;
        }

        public IEnumerable<GamepadComponent_Stick> GetSticks()
        {
            return sticks.Values;
        }

        public IEnumerable<GamepadComponent_MenuAxis> GetMenuAxises()
        {
            return menu_axises.Values;
        }

        public IEnumerable<GamepadComponent_MenuStick> GetMenuSticks()
        {
            return menu_sticks.Values;
        }
    }
}