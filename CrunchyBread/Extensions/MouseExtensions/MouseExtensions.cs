using System;

using OpenTK.Input;

namespace Crunchy.Bread
{
    using Dough;
    
    static public class MouseExtensions
    {
        static public MouseState GetState(int device_index)
        {
            if (device_index == -1)
                return Mouse.GetState();

            return Mouse.GetState(device_index);
        }
    }
}