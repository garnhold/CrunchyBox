using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Saw : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Saw(input);
        }
    }
}