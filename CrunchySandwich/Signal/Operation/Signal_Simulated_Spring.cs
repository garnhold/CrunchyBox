using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class Signal_Simulated_Spring : Signal_Simulated
    {
        [SerializeFieldEX]private float stiffness = 1.3f;

        private float velocity;

        protected override float CalculateAcceleration(float position, float velocity, float target)
        {
            return stiffness * (target - position);
        }
    }
}