using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_IEnumerable_LoopReduction_General
    {
        static public IEnumerable<Vector2> ApproximateLoop(this IEnumerable<Vector2> item, int quality, float maximum_normal_deviance, float minimum_inter_length, float minimum_area)
        {
            if (quality > 0)
            {
                return item.BisectApproximateLoop(maximum_normal_deviance / 4.0f)
                    .VariableSweepApproximateLoop(quality, maximum_normal_deviance)
                    .CollapseLoopPoints(minimum_inter_length)
                    .CollapseLoopTriangles(minimum_area);
            }

            return item.BisectApproximateLoop(maximum_normal_deviance)
                .CollapseLoopPoints(minimum_inter_length)
                .CollapseLoopTriangles(minimum_area);
        }
    }
}