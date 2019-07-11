using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_CubicOut : EaseFunction_Typical
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.CubicOut(input);
        }
    }
}