using System;

using CrunchyDough;

namespace CrunchyBun
{
    public delegate float EaseOperation(float x);

    static public class EaseOperations
    {
        static public float Instant(float x)
        {
            return 1.0f;
        }

        static public float Linear(float x)
        {
            return x.BindBetween(0.0f, 1.0f);
        }

        static public float QuadIn(float x)
        {
            return Mathq.IntPow(x.BindBetween(0.0f, 1.0f), 2);
        }
        static public float QuadOut(float x)
        {
            return Inverse(x, QuadIn);
        }
        static public float QuadInOut(float x)
        {
            return InOut(x, QuadIn, QuadOut);
        }

        static public float CubicIn(float x)
        {
            return Mathq.IntPow(x.BindBetween(0.0f, 1.0f), 3);
        }
        static public float CubicOut(float x)
        {
            return Inverse(x, CubicIn);
        }
        static public float CubicInOut(float x)
        {
            return InOut(x, CubicIn, CubicOut);
        }

        static public float QuintIn(float x)
        {
            return Mathq.IntPow(x.BindBetween(0.0f, 1.0f), 4);
        }
        static public float QuintOut(float x)
        {
            return Inverse(x, QuintIn);
        }
        static public float QuintInOut(float x)
        {
            return InOut(x, QuintIn, QuintOut);
        }

        static public float SineIn(float x)
        {
            return Wave.Sine(x.BindBetween(0.0f, 1.0f) / 4.0f);
        }
        static public float SineOut(float x)
        {
            return Inverse(x, SineIn);
        }
        static public float SineInOut(float x)
        {
            return InOut(x, SineIn, SineOut);
        }

        static public float Inverse(float x, EaseOperation operation)
        {
            return 1.0f - operation(1.0f - x);
        }
        static public EaseOperation Inverse(EaseOperation operation)
        {
            return delegate(float x) {
                return Inverse(x, operation);
            };
        }

        static public float Delay(float x, float start, EaseOperation operation)
        {
            if (x <= start)
                return 0.0f;

            return operation((x - start) / (1.0f - start));
        }
        static public EaseOperation Delay(float start, EaseOperation operation)
        {
            return delegate(float x) {
                return Delay(x, start, operation);
            };
        }

        static public float InOut(float x, EaseOperation in_operation, EaseOperation out_operation)
        {
            if (x < 0.5f)
                return in_operation(x * 2.0f) * 0.5f;

            return out_operation((x - 0.5f) * 2.0f) * 0.5f + 0.5f;
        }
        static public EaseOperation InOut(EaseOperation in_operation, EaseOperation out_operation)
        {
            return delegate(float x) {
                return InOut(x, in_operation, out_operation);
            };
        }
    }
}