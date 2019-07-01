using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_QuadInOut : EaseFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.QuadInOut(input);
        }
    }
}