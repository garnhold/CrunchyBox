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
    }
}