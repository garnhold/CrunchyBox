using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Multiple_Composite : PeriodicFunction_Multiple
    {
        protected override float ExecuteInternal(float input)
        {
            return GetFunctions().Apply(input, (i, f) => f.Execute(i));
        }
    }
}