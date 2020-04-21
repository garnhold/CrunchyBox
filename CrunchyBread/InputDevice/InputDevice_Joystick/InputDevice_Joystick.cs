using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputDevice_Joystick : InputDevice
    {
        private int device_index;

        private OperationCache<InputAtom_Axis, int> axises;
        private OperationCache<InputAtom_Button, int> buttons;
        private OperationCache<InputAtom_IntStick, int> int_sticks;

        static private Dictionary<int, InputDevice_Joystick> JOYSTICKS = new Dictionary<int, InputDevice_Joystick>();
        static public InputDevice_Joystick GetJoystick(int device_index)
        {
            return JOYSTICKS.GetOrCreateValue(device_index, i => new InputDevice_Joystick(i));
        }

        private InputDevice_Joystick(int di)
        {
            device_index = di;

            axises = new OperationCache<InputAtom_Axis, int>("axises", i => new InputAtom_Axis_Native_Joystick(device_index, i));
            buttons = new OperationCache<InputAtom_Button, int>("buttons", i => new InputAtom_Button_Native_Joystick(device_index, i));
            int_sticks = new OperationCache<InputAtom_IntStick, int>("int_sticks", i => new InputAtom_IntStick_Native_JoystickHat(device_index, i));
        }

        public InputAtom_Axis GetAxis(int axis_index)
        {
            return axises.Fetch(axis_index);
        }

        public InputAtom_Button GetButton(int button_index)
        {
            return buttons.Fetch(button_index);
        }

        public InputAtom_IntStick GetIntStick(int int_stick_index)
        {
            return int_sticks.Fetch(int_stick_index);
        }
    }
}