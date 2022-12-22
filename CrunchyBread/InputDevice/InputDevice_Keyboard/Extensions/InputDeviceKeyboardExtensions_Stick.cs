using System;
using System.Collections;
using System.Collections.Generic;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;

    static public class InputDeviceKeyboardExtensions_Stick
    {
        static public InputAtom_Stick GetButtonPairAxisStick(this InputDevice_Keyboard item, Key horizontal_negative_key, Key horizontal_positive_key, Key vertical_negative_key, Key vertical_positive_key)
        {
            return new InputAtom_Stick_AxisPair(
                item.GetButtonPairAxis(horizontal_negative_key, horizontal_positive_key),
                item.GetButtonPairAxis(vertical_negative_key, vertical_positive_key)
            );
        }

        static public InputAtom_Stick GetArrowsStick(this InputDevice_Keyboard item)
        {
            return item.GetButtonPairAxisStick(
                Key.Left, Key.Right,
                Key.Down, Key.Up
            );
        }
        static public InputAtom_Stick GetWASDStick(this InputDevice_Keyboard item)
        {
            return item.GetButtonPairAxisStick(
                Key.A, Key.D,
                Key.S, Key.W
            );
        }
    }
}