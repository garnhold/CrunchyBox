using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class JoystickExtensions
    {
        static public JoystickState GetState(int device_index)
        {
            return Joystick.GetState(device_index);
        }

        static public JoystickCapabilities GetCapabilities(int device_index)
        {
            return Joystick.GetCapabilities(device_index);
        }

        static public string GetName(int device_index)
        {
            return JoystickExtensions.GetCapabilities(device_index).ToStringEX();
        }
    }
}