
using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class KeyboardExtensions
    {
        static public KeyboardState GetState(int device_index)
        {
            if (device_index == -1)
                return Keyboard.GetState();

            return Keyboard.GetState(device_index);
        }
    }
}