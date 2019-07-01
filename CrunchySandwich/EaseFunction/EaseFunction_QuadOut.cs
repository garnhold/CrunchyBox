﻿using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_QuadOut : EaseFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.QuadOut(input);
        }
    }
}