using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class InputDeviceStickZoneExtensions_Angle
    {
        static public float GetAngleInDegrees(this InputDeviceStickZone item)
        {
            switch (item)
            {
                case InputDeviceStickZone.Center: return 0.0f;

                case InputDeviceStickZone.Right: return 0.0f;
                case InputDeviceStickZone.RightUp: return 45.0f;
                case InputDeviceStickZone.Up: return 45.0f * 2;
                case InputDeviceStickZone.LeftUp: return 45.0f * 3;
                case InputDeviceStickZone.Left: return 45.0f * 4;
                case InputDeviceStickZone.LeftDown: return 45.0f * 5;
                case InputDeviceStickZone.Down: return 45.0f * 6;
                case InputDeviceStickZone.RightDown: return 45.0f * 7;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}