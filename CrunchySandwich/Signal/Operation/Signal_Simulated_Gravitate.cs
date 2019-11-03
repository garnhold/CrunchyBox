using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Simulated_Gravitate : Signal_Simulated
    {
        [SerializeFieldEX]private float gravity = 0.1f;

        protected override float CalculateAcceleration(float position, float velocity, float target)
        {
            if (target < position)
                return -gravity;

            return gravity;
        }
    }
}