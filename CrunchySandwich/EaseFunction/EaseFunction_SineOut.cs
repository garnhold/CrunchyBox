using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_SineOut : EaseFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.SineOut(input);
        }
    }
}