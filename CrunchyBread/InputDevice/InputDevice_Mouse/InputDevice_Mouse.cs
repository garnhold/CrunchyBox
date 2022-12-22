using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputDevice_Mouse : InputDevice
    {
        private int device_index;

        private OperationCache<InputAtom_Position> horizontal_position;
        private OperationCache<InputAtom_Position> vertical_position;
        private OperationCache<InputAtom_Position> wheel_position;

        private OperationCache<InputAtom_Button, MouseButton> buttons;

        static private Dictionary<int, InputDevice_Mouse> MOUSES = new Dictionary<int, InputDevice_Mouse>();
        static public InputDevice_Mouse GetMouse(int device_index)
        {
            return MOUSES.GetOrCreateValue(device_index, i => new InputDevice_Mouse(i));
        }
        static public InputDevice_Mouse GetMouse()
        {
            return GetMouse(-1);
        }

        private InputDevice_Mouse(int di)
        {
            device_index = di;

            horizontal_position = new OperationCache<InputAtom_Position>("horizontal_position", () => new InputAtom_Position_Native_MouseHorizontal(device_index));
            vertical_position = new OperationCache<InputAtom_Position>("vertical_position", () => new InputAtom_Position_Native_MouseVertical(device_index));
            wheel_position = new OperationCache<InputAtom_Position>("wheel_position", () => new InputAtom_Position_Native_MouseWheel(device_index));

            buttons = new OperationCache<InputAtom_Button, MouseButton>("buttons", k => new InputAtom_Button_Native_Mouse(device_index, k));
        }

        public InputAtom_Position GetHorizontalPosition()
        {
            return horizontal_position.Fetch();
        }

        public InputAtom_Position GetVerticalPosition()
        {
            return vertical_position.Fetch();
        }

        public InputAtom_Position GetWheelPosition()
        {
            return wheel_position.Fetch();
        }

        public InputAtom_Button GetButton(MouseButton button)
        {
            return buttons.Fetch(button);
        }
    }
}