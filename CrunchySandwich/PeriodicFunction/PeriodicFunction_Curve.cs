using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Curve : PeriodicFunction
    {
        [SerializeField]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetLoopedValue(input);
        }
    }
}