using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Periodic_SkewTriangle : Signal_Periodic_Typical
    {
        [SerializeFieldEX]private float peak;

        protected override float ExecuteInternal(float input)
        {
            return Wave.SkewTriangle(input, peak);
        }
    }
}