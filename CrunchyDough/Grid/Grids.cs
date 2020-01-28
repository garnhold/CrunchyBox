using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Grids
    {
        static public IGrid<T> Operation<T>(int width, int height, Operation<T, int, int> get_operation, Process<int, int, T> set_process)
        {
            return new IGridTransform<T>(width, height, get_operation, set_process);
        }
        static public IGrid<T> Operation<T>(int width, int height, Operation<T, int, int> get_operation)
        {
            return Operation<T>(width, height, get_operation, null);
        }
        static public IGrid<T> Operation<T>(int width, int height, Process<int, int, T> set_process)
        {
            return Operation<T>(width, height, null, set_process);
        }

        static public IGrid<T> Circle<T>(int radius, Operation<T, float> operation)
        {
            int diameter = radius * 2;
            VectorF2 center = new VectorF2(radius, radius);

            return Operation<T>(diameter, diameter, 
                (x, y) => operation(center.GetDistanceTo(new VectorF2(x, y)) / radius)
            );
        }

        static public IGrid<T> Circle<T>(int radius, T inside, T outside = default(T))
        {
            return Circle<T>(radius, d => (d <= 1.0f).ConvertBool(inside, outside));
        }

        static public IGrid<T> SoftCircle<T>(int radius, float hardness, float power, Operation<T, float> operation)
        {
            float transition_interval = 1.0f - hardness;

            return Circle<T>(radius, delegate (float distance) {
                float weight = 0.0f;

                if (distance <= 1.0f)
                {
                    weight = 1.0f;

                    if (distance > hardness)
                    {
                        float transition_distance = distance - hardness;
                        float transition_percent = transition_distance / transition_interval;

                        weight = Mathq.Pow(transition_percent, power).InterpolateWith(1.0f, 0.0f);
                    }
                }

                return operation(weight);
            });
        }
    }
}