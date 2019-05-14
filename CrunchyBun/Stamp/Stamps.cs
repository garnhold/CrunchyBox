using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class Stamps
    {
        static public Stamp<T> Circle<T>(float radius, Operation<T, float> operation)
        {
            VectorF2 center = new VectorF2(radius, radius);

            return new Stamp<T>(radius, delegate(int x, int y, out T output) {
                float distance = center.GetDistanceTo(new VectorF2(x, y));

                if (distance <= radius)
                {
                    output = operation(distance / radius);
                    return true;
                }

                output = default(T);
                return false;
            });
        }
        static public Stamp<T> Circle<T>(float radius, T inside)
        {
            return Circle<T>(radius, delegate(float distance) {
                return inside;
            });
        }

        static public Stamp<T> SoftCircle<T>(float radius, float hardness, float power, Operation<T, float> operation)
        {
            return Circle<T>(radius, delegate(float distance) {
                float weight = 1.0f;

                if (distance > hardness)
                {
                    float transition_interval = 1.0f - hardness;
                    float transition_distance = distance - hardness;
                    float transition_percent = transition_distance / transition_interval;

                    weight = Mathq.Pow(transition_percent, power).InterpolateWith(1.0f, 0.0f);
                }

                return operation(weight);
            });
        }
    }
}