using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_Curve : EaseFunction_Typical
    {
        [SerializeField]private Curve curve;

        protected override float ExecuteInternal(float input)
        {
            return curve.GetValue(input);
        }
    }
}