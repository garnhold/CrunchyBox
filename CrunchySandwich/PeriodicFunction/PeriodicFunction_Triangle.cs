using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction_Triangle : PeriodicFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Triangle(input);
        }
    }
}