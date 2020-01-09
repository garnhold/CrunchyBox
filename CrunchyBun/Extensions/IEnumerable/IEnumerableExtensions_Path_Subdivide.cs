using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class IEnumerableExtensions_Path_Subdivide
    {
        static public IEnumerable<T> SubdividePathToLength<T>(this IEnumerable<T> item, float maximum_inter_length, Operation<float, T, T> distance_operation, Operation<T, T, T, float> interpolate_operation)
        {
            return item.ConvertConnections(delegate(T sub_item1, T sub_item2) {
                float length = distance_operation(sub_item1, sub_item2);

                if (length > maximum_inter_length)
                {
                    int number_divisions = Mathq.CeilToInt(length / maximum_inter_length);

                    return Floats.Line(0.0f, 1.0f, number_divisions, false)
                        .Convert(f => interpolate_operation(sub_item1, sub_item2, f));
                }

                return sub_item1.WrapAsEnumerable();
            });
        }

        static public IEnumerable<T> SubdividePathByDivisions<T>(this IEnumerable<T> item, int divisions, Operation<T, T, T, float> interpolate_operation)
        {
            return item.ConvertConnections(delegate(T sub_item1, T sub_item2) {
                return Floats.Line(0.0f, 1.0f, divisions, false)
                    .Convert(f => interpolate_operation(sub_item1, sub_item2, f));
            });
        }
    }
}