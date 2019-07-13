﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Aspect
    {
        static public float GetFactorToFillDimension(this Vector2 item, Vector2 bounds)
        {
            return (bounds.x / item.x).Min(bounds.y / item.y);
        }

        static public Vector2 GetFilledDimension(this Vector2 item, Vector2 bounds)
        {
            return item.GetFactorToFillDimension(bounds) * item;
        }
    }
}