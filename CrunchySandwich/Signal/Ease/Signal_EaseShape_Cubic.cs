﻿using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_EaseShape_Cubic : Signal_EaseShape
    {
        public override float Execute(float input)
        {
            return EaseOperations.CubicIn(input);
        }
    }
}