using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class Wave
    {
        static public float Sine(float x)
        {
            return TrigPercent.Sin(x);
        }

        static public float Cosine(float x)
        {
            return TrigPercent.Cos(x);
        }

        static public float Ramp(float x)
        {
            return x - Mathq.Floor(x);
        }

        static public float Saw(float x)
        {
            return Ramp(x).InterpolateWith(-1.0f, 1.0f);
        }

        static public float ReverseSaw(float x)
        {
            return Ramp(x).InterpolateWith(1.0f, -1.0f);
        }

        static public float Pulse(float x, float duty)
        {
            if (Ramp(x) < duty)
                return 1.0f;

            return -1.0f;
        }
        static public float Square(float x)
        {
            return Pulse(x, 0.5f);
        }

        static public float SkewTriangle(float x, float peak)
        {
            x = Ramp(x);

            if (x < peak)
                return (x / peak).InterpolateWith(-1.0f, 1.0f);

            return ((x - peak) / (1.0f - peak)).InterpolateWith(1.0f, -1.0f);
        }
        static public float Triangle(float x)
        {
            return SkewTriangle(x, 0.5f);
        }
    }
}