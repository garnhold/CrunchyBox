﻿using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Periodic_Multiple_Average : Signal_Periodic_Multiple
    {
        protected override float ExecuteInternal(float input)
        {
            return GetFunctions().Convert(f => f.Execute(input)).Average();
        }
    }
}