using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Ramp : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Ramp(input);
        }
    }
}