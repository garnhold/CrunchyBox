using System;

using UnityEngine;

namespace CrunchySandwich
{
    public abstract class PeriodicFunction : CustomAsset
    {
        [SerializeField]private float amplitude = 1.0f;
        [SerializeField]private float frequency = 1.0f;
        [SerializeField]private float phase = 0.0f;
        [SerializeField]private float offset = 0.0f;

        protected abstract float ExecuteInternal(float input);

        public float Execute(float input)
        {
            return ExecuteInternal(input * frequency + phase) * amplitude + offset;
        }
    }
}