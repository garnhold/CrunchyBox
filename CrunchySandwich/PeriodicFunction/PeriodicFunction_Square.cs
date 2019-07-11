using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Square : PeriodicFunction_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Square(input);
        }
    }
}