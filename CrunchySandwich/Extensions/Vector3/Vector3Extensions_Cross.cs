﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_Cross
    {
        static public Vector3 GetCross(this Vector3 item, Vector3 other)
        {
            return Vector3.Cross(item, other);
        }
    }
}