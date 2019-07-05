using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceComponentStickExtensions_Angle
    {
        static public float GetAngleInDegrees(this InputDeviceComponent_Stick item)
        {
            return item.GetValue().GetAngleInDegrees();
        }

        static public float GetAngleInRadians(this InputDeviceComponent_Stick item)
        {
            return item.GetValue().GetAngleInRadians();
        }

        static public float GetAngleInPercent(this InputDeviceComponent_Stick item)
        {
            return item.GetValue().GetAngleInPercent();
        }
    }
}