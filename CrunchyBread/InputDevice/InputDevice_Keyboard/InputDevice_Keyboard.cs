using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    public class InputDevice_Keyboard : InputDevice
    {
        private int device_index;

        private OperationCache<InputAtom_Button, Key> buttons;

        static private Dictionary<int, InputDevice_Keyboard> KEYBOARDS = new Dictionary<int, InputDevice_Keyboard>();
        static public InputDevice_Keyboard GetKeyboard(int device_index)
        {
            return KEYBOARDS.GetOrCreateValue(device_index, i => new InputDevice_Keyboard(i));
        }
        static public InputDevice_Keyboard GetKeyboard()
        {
            return GetKeyboard(-1);
        }

        private InputDevice_Keyboard(int di)
        {
            device_index = di;

            buttons = new OperationCache<InputAtom_Button, Key>("buttons", k => new InputAtom_Button_Native_Keyboard(device_index, k));
        }

        public InputAtom_Button GetButton(Key key)
        {
            return buttons.Fetch(key);
        }
    }
}