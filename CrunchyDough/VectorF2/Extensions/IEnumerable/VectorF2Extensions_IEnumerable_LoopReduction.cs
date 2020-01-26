using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_LoopReduction
    {
        static public IEnumerable<VectorF2> CollapseLoopPoints(this IEnumerable<VectorF2> item, float minimum_distance)
        {
            return item.SweepApproximateLoop(2, minimum_distance, delegate(List<VectorF2> points) {
                return points[0].GetDistanceTo(points[1]);
            }, delegate(List<VectorF2> points) {
                return ((points[0] + points[1]) * 0.5f).WrapAsEnumerable();
            });
        }

        static public IEnumerable<VectorF2> CollapseLoopTriangles(this IEnumerable<VectorF2> item, float minimum_area)
        {
            return item.SweepApproximateLoop(3, minimum_area, delegate(List<VectorF2> points) {
                return points[0].CalculateTriangleArea(points[1], points[2]);
            }, delegate(List<VectorF2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<VectorF2> CollapseLoopStellations(this IEnumerable<VectorF2> item, float minimum_shortest_to_longest_ratio)
        {
            return item.SweepApproximateLoop(3, minimum_shortest_to_longest_ratio, delegate(List<VectorF2> points) {
                return points[0].CalculateTriangleShortestToLongestSideRatio(points[1], points[2]);
            }, delegate(List<VectorF2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<VectorF2> BisectApproximateLoop(this IEnumerable<VectorF2> item, float maximum_normal_deviance)
        {
            return item.BisectApproximateLoop(maximum_normal_deviance, delegate(VectorF2 start, VectorF2 end, VectorF2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }

        static public IEnumerable<VectorF2> VariableSweepApproximateLoop(this IEnumerable<VectorF2> item, int maximum_length, float maximum_normal_deviance)
        {
            return item.VariableSweepApproximateLoop(maximum_length, maximum_normal_deviance, delegate(VectorF2 start, VectorF2 end, VectorF2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }
    }
}