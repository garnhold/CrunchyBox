using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class SignalPeriodicTransform
    {
        [SerializeFieldEX]private float amplitude = 1.0f;
        [SerializeFieldEX]private float frequency = 1.0f;
        [SerializeFieldEX]private float phase = 0.0f;
        [SerializeFieldEX]private float offset = 0.0f;

        public float Apply(float input, Operation<float, float> operation)
        {
            return amplitude * operation(input * frequency + phase) + offset;
        }
    }
}