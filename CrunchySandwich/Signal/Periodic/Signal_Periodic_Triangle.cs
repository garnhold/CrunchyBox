using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public abstract class Signal_Periodic_Triangle : Signal_Periodic_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return Wave.Triangle(input);
        }
    }
}