using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Ease_Curve : Signal_Ease_Typical
    {
        [SerializeFieldEX]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetValue(input);
        }
    }
}