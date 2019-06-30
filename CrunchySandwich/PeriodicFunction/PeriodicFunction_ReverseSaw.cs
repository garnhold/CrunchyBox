using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_ReverseSaw : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.ReverseSaw(input);
        }
    }
}