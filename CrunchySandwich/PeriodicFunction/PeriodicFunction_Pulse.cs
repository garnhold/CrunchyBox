using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Pulse : PeriodicFunction_Typical
    {
        [SerializeField]private float duty;

        protected override float ExecuteInternal(float input)
        {
            return Wave.Pulse(input, duty);
        }
    }
}