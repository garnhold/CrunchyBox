using System;

namespace Crunchy.Bun
{
    using Dough;
    
    public class SmoothedFloat
    {
        private float smoothing_ratio;

        private float current_value;

        private float conglomerate_value;
        private float conglomerate_divisor;
        private float conglomerate_smoothing_ratio;

        public SmoothedFloat(float v, float r)
        {
            smoothing_ratio = r;

            ResetValue(v);
        }

        public SmoothedFloat(float r) : this(0.0f, r) { }

        public void ResetValue(float value)
        {
            conglomerate_value = 0.0f;
            conglomerate_divisor = 0.0f;
            conglomerate_smoothing_ratio = smoothing_ratio;

            current_value = value;
        }

        public void SetValue(float value)
        {
            conglomerate_value = (current_value + conglomerate_value) * smoothing_ratio;
            conglomerate_divisor += conglomerate_smoothing_ratio;
            conglomerate_smoothing_ratio *= smoothing_ratio;

            current_value = value;
        }

        public float GetValue()
        {
            return (current_value + conglomerate_value) / (1.0f + conglomerate_divisor);
        }

        public float GetRawValue()
        {
            return current_value;
        }
    }
}