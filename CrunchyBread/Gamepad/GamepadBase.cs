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

        protected GamepadComponent_Axis RegisterAxis(GamepadComponent_Axis axis)
        {
            components.Add(axis.GetId(), axis);
            axises.Add((GamepadAxisId)axis.GetId(), axis);

            return axis;
        }

        protected GamepadComponent_Button RegisterButton(GamepadComponent_Button button)
        {
            components.Add(button.GetId(), button);
            buttons.Add((GamepadButtonId)button.GetId(), button);

            return button;
        }

        protected GamepadComponent_Slider RegisterSlider(GamepadComponent_Slider slider)
        {
            components.Add(slider.GetId(), slider);
            sliders.Add((GamepadSliderId)slider.GetId(), slider);

            return slider;
        }

        protected GamepadComponent_Stick RegisterStick(GamepadComponent_Stick stick)
        {
            components.Add(stick.GetId(), stick);
            sticks.Add((GamepadStickId)stick.GetId(), stick);

            return stick;
        }

        public GamepadBase()
        {
            components = new Dictionary<GamepadComponentId, GamepadComponent>();

            axises = new Dictionary<GamepadAxisId, GamepadComponent_Axis>();
            buttons = new Dictionary<GamepadButtonId, GamepadComponent_Button>();
            sliders = new Dictionary<GamepadSliderId, GamepadComponent_Slider>();
            sticks = new Dictionary<GamepadStickId, GamepadComponent_Stick>();
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
    }
}