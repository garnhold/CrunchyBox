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

        private Dictionary<int, InputAtom_Axis> axises;
        private Dictionary<int, InputAtom_Button> buttons;

        static private Dictionary<int, InputDevice_Joystick> JOYSTICKS = new Dictionary<int, InputDevice_Joystick>();
        static public InputDevice_Joystick GetJoystick(int device_index)
        {
            return JOYSTICKS.GetOrCreateValue(device_index, i => new InputDevice_Joystick(i));
        }

        private InputDevice_Joystick(int di)
        {
            device_index = di;

            JoystickCapabilities capabilities = Joystick.GetCapabilities(device_index);

            axises = Ints.Indexs(capabilities.AxisCount)
                .ConvertToKeyOfPair(i => (InputAtom_Axis)new InputAtom_Axis_Native_Joystick(device_index, i))
                .ToDictionary();

            buttons = Ints.Indexs(capabilities.ButtonCount)
                .ConvertToKeyOfPair(i => (InputAtom_Button)new InputAtom_Button_Native_Joystick(device_index, i))
                .ToDictionary();
        }

        public InputAtom_Axis GetAxis(int axis_index)
        {
            return axises.GetValue(axis_index);
        }

        public InputAtom_Button GetButton(int button_index)
        {
            return buttons.GetValue(button_index);
        }

        public IEnumerable<InputAtom_Axis> GetAxises()
        {
            return axises.Values;
        }

        public IEnumerable<InputAtom_Button> GetButtons()
        {
            return buttons.Values;
        }
    }
}