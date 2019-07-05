using System;

using CrunchyDough;

namespace CrunchyBun
{
    public abstract class RandFloatSource
    {
        public abstract float Get();

        public float GetMagnitude(float m)
        {
            return Get() * m;
        }

        public float GetSign()
        {
            if (Get() < 0.5f)
                return -1.0f;

            return 1.0f;
        }

        public float GetOffset(float radius)
        {
            return GetMagnitude(radius * 2.0f) - radius;
        }

        public float GetVariance(float center, float radius)
        {
            return center + GetOffset(radius);
        }

        public float GetBetween(float a, float b)
        {
            float low;
            float high;

            a.Order(b, out low, out high);
            return low + Get() * (high - low);
        }
        public float GetBetween(FloatRange range)
        {
            return GetBetween(range.x1, range.x2);
        }
    }
}