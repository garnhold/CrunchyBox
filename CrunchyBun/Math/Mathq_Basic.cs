using System;

using CrunchyDough;

namespace CrunchyBun
{
    static public partial class Mathq
    {
        static public float Sqrt(float x)
        {
            return (float)Math.Sqrt(x);
        }

        static public float Pow(float x, float y)
        {
            return (float)Math.Pow(x, y);
        }

        static public float Exp(float b, float x)
        {
            return Pow(b, x);
        }
        static public float Exp10(float x)
        {
            return Exp(10.0f, x);
        }
        static public float ExpE(float x)
        {
            return Exp(E, x);
        }

        static public float Log(float b, float x)
        {
            return (float)Math.Log(x, b);
        }
        static public float Log10(float x)
        {
            return Log(10.0f, x);
        }
        static public float LogE(float x)
        {
            return Log(E, x);
        }

        static public float Floor(float x)
        {
            return (float)Math.Floor(x);
        }

        static public float Ceil(float x)
        {
            return (float)Math.Ceiling(x);
        }

        static public float Abs(float x)
        {
            return (float)Math.Abs(x);
        }
    }
}