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

        private Dictionary<Key, InputAtom_Button> buttons;

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

            buttons = typeof(Key).GetEnumValues<Key>()
                .Convert(v => new KeyValuePair<Key, InputAtom_Button>(v, new InputAtom_Button_Native_Keyboard(di, v)))
                .ToDictionary();
        }

        public InputAtom_Button GetButton(Key key)
        {
            return buttons.GetValue(key);
        }

        public IEnumerable<InputAtom_Button> GetButtons()
        {
            return buttons.Values;
        }
    }
}