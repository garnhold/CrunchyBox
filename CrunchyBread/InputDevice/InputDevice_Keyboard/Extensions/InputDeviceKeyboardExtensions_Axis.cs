using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputDeviceKeyboardExtensions_Axis
    {
        static public InputAtom_Axis GetButtonPairAxis(this InputDevice_Keyboard item, Key negative_key, Key positive_key)
        {
            return new InputAtom_Axis_ButtonPair(
                item.GetButton(negative_key),
                item.GetButton(positive_key)
            );
        }
    }
}