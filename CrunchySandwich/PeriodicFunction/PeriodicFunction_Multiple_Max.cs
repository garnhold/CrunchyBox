using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class PeriodicFunction_Multiple_Max : PeriodicFunction_Multiple
    {
        protected override float ExecuteInternal(float input)
        {
            return GetFunctions().Convert(f => f.Execute(input)).Max();
        }
    }
}