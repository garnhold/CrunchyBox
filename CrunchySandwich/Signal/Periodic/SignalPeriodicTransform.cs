using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [Serializable]
    public class SignalPeriodicTransform
    {
        [SerializeFieldEX]private float amplitude = 1.0f;
        [SerializeFieldEX]private float frequency = 1.0f;
        [SerializeFieldEX]private float phase = 0.0f;
        [SerializeFieldEX]private float offset = 0.0f;

        public SignalPeriodicTransform(float a, float f, float p, float o)
        {
            amplitude = a;
            frequency = f;
            phase = p;
            offset = o;
        }
        public SignalPeriodicTransform() : this(1.0f, 1.0f, 0.0f, 0.0f) { }

        public float Apply(float input, Operation<float, float> operation)
        {
            return amplitude * operation(input * frequency + phase) + offset;
        }

        public float GetAmplitude()
        {
            return amplitude;
        }

        public float GetFrequency()
        {
            return frequency;
        }

        public float GetPhase()
        {
            return phase;
        }

        public float GetOffset()
        {
            return offset;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + amplitude.GetHashCode();
                hash = hash * 23 + frequency.GetHashCode();
                hash = hash * 23 + phase.GetHashCode();
                hash = hash * 23 + offset.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            SignalPeriodicTransform cast;

            if (obj.Convert<SignalPeriodicTransform>(out cast))
            {
                if (cast.amplitude == amplitude)
                {
                    if (cast.frequency == frequency)
                    {
                        if (cast.phase == phase)
                        {
                            if (cast.offset == offset)
                                return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}