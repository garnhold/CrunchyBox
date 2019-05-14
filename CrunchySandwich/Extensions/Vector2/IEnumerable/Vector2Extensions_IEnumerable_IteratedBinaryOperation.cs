using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_IteratedBinaryOperation
    {
        static public Vector2 Sum(this IEnumerable<Vector2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2);
        }

        static public Vector2 Average(this IEnumerable<Vector2> item)
        {
            int count;

            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2, out count) / count;
        }

        static public Vector2 Min(this IEnumerable<Vector2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMin(v2));
        }

        static public Vector2 Max(this IEnumerable<Vector2> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMax(v2));
        }

        static public Vector2 DiminishingAverage(this IEnumerable<Vector2> item, float ratio)
        {
            float current_weight = 1.0f;

            float total_weight = 0.0f;
            Vector2 total = Vector2.zero;

            foreach (Vector2 sub_item in item)
            {
                total += sub_item * current_weight;
                total_weight += current_weight;

                current_weight *= ratio;
            }

            return total / total_weight;
        }
    }
}