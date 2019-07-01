using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction_Identity : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return input;
        }
    }
}