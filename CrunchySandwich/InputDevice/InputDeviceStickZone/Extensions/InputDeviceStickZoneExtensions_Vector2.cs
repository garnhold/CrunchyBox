using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class InputDeviceStickZoneExtensions_Vector2
    {
        static public Vector2 GetVector2(this InputDeviceStickZone item)
        {
            switch (item)
            {
                case InputDeviceStickZone.Center: return new Vector2(0.0f, 0.0f);

                case InputDeviceStickZone.Right: return new Vector2(1.0f, 0.0f);
                case InputDeviceStickZone.RightUp: return new Vector2(Mathq.DIAGONAL, Mathq.DIAGONAL);
                case InputDeviceStickZone.Up: return new Vector2(0.0f, 1.0f);
                case InputDeviceStickZone.LeftUp: return new Vector2(-Mathq.DIAGONAL, Mathq.DIAGONAL);
                case InputDeviceStickZone.Left: return new Vector2(-1.0f, 0.0f);
                case InputDeviceStickZone.LeftDown: return new Vector2(-Mathq.DIAGONAL, -Mathq.DIAGONAL);
                case InputDeviceStickZone.Down: return new Vector2(0.0f, -1.0f);
                case InputDeviceStickZone.RightDown: return new Vector2(Mathq.DIAGONAL, -Mathq.DIAGONAL);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}