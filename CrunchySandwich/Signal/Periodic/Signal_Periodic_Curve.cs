using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Periodic_Curve : Signal_Periodic_Typical
    {
        [SerializeFieldEX]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetLoopedValue(input);
        }
    }
}