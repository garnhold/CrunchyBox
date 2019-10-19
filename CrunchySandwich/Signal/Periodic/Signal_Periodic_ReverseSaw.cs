﻿using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Periodic_ReverseSaw : Signal_Periodic_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.ReverseSaw(input);
        }
    }
}