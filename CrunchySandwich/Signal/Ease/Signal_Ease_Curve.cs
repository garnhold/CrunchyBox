using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    public class Signal_Ease_Curve : Signal_Ease_Typical
    {
        [SerializeFieldEX]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetValue(input);
        }
    }
}