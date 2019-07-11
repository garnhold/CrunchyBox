using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_CubicIn : EaseFunction_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.CubicIn(input);
        }
    }
}