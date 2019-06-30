﻿using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Sine : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Sine(input);
        }
    }
}