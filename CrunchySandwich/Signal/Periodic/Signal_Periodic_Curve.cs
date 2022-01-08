using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Periodic_Curve : Signal_Periodic
    {
        [SerializeFieldEX]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetLoopedValue(input);
        }
    }
}