using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;

    static public class GamepadComponentTypeExtensions_SystemType
    {
        static public Type GetSystemType(this GamepadComponentType item)
        {
            switch (item)
            {
                case GamepadComponentType.Axis: return typeof(GamepadComponent_Axis);
                case GamepadComponentType.Button: return typeof(GamepadComponent_Button);
                case GamepadComponentType.Slider: return typeof(GamepadComponent_Slider);
                case GamepadComponentType.Stick: return typeof(GamepadComponent_Stick);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}