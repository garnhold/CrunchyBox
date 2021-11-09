using System;

using OpenTK.Input;

using Crunchy.Dough;
using Crunchy.Salt;

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
            JoystickCapabilities capabilities = JoystickExtensions.GetCapabilities(device_index);

            return "Buttons: {0}, Axises: {1}, Hats: {2}".Inject(
                capabilities.ButtonCount,
                capabilities.AxisCount,
                capabilities.HatCount
            );
        }
    }
}