﻿using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Periodic_Square : Signal_Periodic_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Square(input);
        }
    }
}