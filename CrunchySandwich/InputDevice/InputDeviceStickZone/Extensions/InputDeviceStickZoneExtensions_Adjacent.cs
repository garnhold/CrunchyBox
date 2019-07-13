using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class InputDeviceStickZoneExtensions_Adjacent
    {
        static public InputDeviceStickZone GetCounterClockwiseNext(this InputDeviceStickZone item)
        {
            switch (item)
            {
                case InputDeviceStickZone.Center: return InputDeviceStickZone.Right;

                case InputDeviceStickZone.Right: return InputDeviceStickZone.RightUp;
                case InputDeviceStickZone.RightUp: return InputDeviceStickZone.Up;
                case InputDeviceStickZone.Up: return InputDeviceStickZone.LeftUp;
                case InputDeviceStickZone.LeftUp: return InputDeviceStickZone.Left;
                case InputDeviceStickZone.Left: return InputDeviceStickZone.LeftDown;
                case InputDeviceStickZone.LeftDown: return InputDeviceStickZone.Down;
                case InputDeviceStickZone.Down: return InputDeviceStickZone.RightDown;
                case InputDeviceStickZone.RightDown: return InputDeviceStickZone.Right;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public InputDeviceStickZone GetClockwisePrevious(this InputDeviceStickZone item)
        {
            return item.GetCounterClockwiseNext();
        }

        static public InputDeviceStickZone GetClockwiseNext(this InputDeviceStickZone item)
        {
            switch (item)
            {
                case InputDeviceStickZone.Center: return InputDeviceStickZone.Right;

                case InputDeviceStickZone.Right: return InputDeviceStickZone.RightDown;
                case InputDeviceStickZone.RightDown: return InputDeviceStickZone.Down;
                case InputDeviceStickZone.Down: return InputDeviceStickZone.LeftDown;
                case InputDeviceStickZone.LeftDown: return InputDeviceStickZone.Left;
                case InputDeviceStickZone.Left: return InputDeviceStickZone.LeftUp;
                case InputDeviceStickZone.LeftUp: return InputDeviceStickZone.Up;
                case InputDeviceStickZone.Up: return InputDeviceStickZone.RightUp;
                case InputDeviceStickZone.RightUp: return InputDeviceStickZone.Right;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public InputDeviceStickZone GetCounterClockwisePrevious(this InputDeviceStickZone item)
        {
            return item.GetClockwiseNext();
        }
    }
}