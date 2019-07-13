﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class InputDeviceComponentStickExtensions_Direction
    {
        static public HorizontalDirection GetClosestHorizontalDirection(this InputDeviceComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestHorizontalDirection();
        }

        static public CardinalDirection GetClosestCardinalDirection(this InputDeviceComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestCardinalDirection();
        }

        static public CardinalOrdinalDirection GetClosestCardinalOrdinalDirection(this InputDeviceComponent_Stick item)
        {
            return item.GetAngleInDegrees().GetDegreeAngleClosestCardinalOrdinalDirection();
        }
    }
}