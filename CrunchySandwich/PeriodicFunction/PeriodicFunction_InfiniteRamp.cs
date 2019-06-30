using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction_InfiniteRamp : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return input;
        }
    }
}