using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Periodic_RampEase : Signal_Periodic
    {
        [SerializeFieldEX]private SignalPeriodicTransform transform;
        [SerializeFieldEX][PolymorphicField]private Signal_Ease ease;

        public override float Execute(float input)
        {
            return ease.Execute(transform.Apply(input, Wave.Ramp));
        }
    }
}