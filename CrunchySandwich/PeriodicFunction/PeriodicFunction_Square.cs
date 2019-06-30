using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Square : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Square(input);
        }
    }
}