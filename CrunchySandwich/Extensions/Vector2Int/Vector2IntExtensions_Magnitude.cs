﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2IntExtensions_Magnitude
    {
        static public float GetMagnitude(this Vector2Int item)
        {
            return item.magnitude;
        }

        static public int GetSquaredMagnitude(this Vector2Int item)
        {
            return item.sqrMagnitude;
        }
    }
}