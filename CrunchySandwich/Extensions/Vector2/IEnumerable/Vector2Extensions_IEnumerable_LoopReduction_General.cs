using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_LoopReduction_General
    {
        static public IEnumerable<Vector2> ApproximateLoop(this IEnumerable<Vector2> item, float maximum_sweep_normal_deviance, int inspect_length, float maximum_inspect_normal_deviance, float minimum_inter_length, float minimum_shortest_to_longest_ratio)
        {
            return item.BisectApproximateLoop(maximum_sweep_normal_deviance)
                .VariableSweepApproximateLoop(inspect_length, maximum_inspect_normal_deviance)
                .CollapseLoopPoints(minimum_inter_length)
                .CollapseLoopStellations(minimum_shortest_to_longest_ratio);
        }
    }
}