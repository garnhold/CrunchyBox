using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class PeriodicFunctionTransform
    {
        [SerializeField]private float amplitude = 1.0f;
        [SerializeField]private float frequency = 1.0f;
        [SerializeField]private float phase = 0.0f;
        [SerializeField]private float offset = 0.0f;

        public float Apply(float input, Operation<float, float> operation)
        {
            return amplitude * operation(input * frequency + phase) + offset;
        }
    }
}