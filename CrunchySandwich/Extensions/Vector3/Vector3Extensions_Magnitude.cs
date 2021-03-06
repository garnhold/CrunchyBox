﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Magnitude
    {
        static public float GetMagnitude(this Vector3 item)
        {
            return item.magnitude;
        }

        static public float GetSquaredMagnitude(this Vector3 item)
        {
            return item.sqrMagnitude;
        }
    }
}