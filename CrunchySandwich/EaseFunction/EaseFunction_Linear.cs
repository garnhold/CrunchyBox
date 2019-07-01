using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class EaseFunction_Linear : EaseFunction
    {
        protected override float ExecuteInternal(float input)
        {
            return EaseOperations.Linear(input);
        }
    }
}