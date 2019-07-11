﻿using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_SkewTriangle : PeriodicFunction_Typical
    {
        [SerializeField]private float peak;

        protected override float ExecuteInternal(float input)
        {
            return Wave.SkewTriangle(input, peak);
        }
    }
}