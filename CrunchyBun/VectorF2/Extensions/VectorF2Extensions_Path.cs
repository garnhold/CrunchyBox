using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyBun
{
    static public class VectorF2Extensions_Path
    {
        static public IEnumerable<VectorF2> CollapsePathPoints(this IEnumerable<VectorF2> item, float minimum_distance)
        {
            return item.SweepApproximatePath(2, minimum_distance, delegate(List<VectorF2> points) {
                return points[0].GetDistanceTo(points[1]);
            }, delegate(List<VectorF2> points) {
                return ((points[0] + points[1]) * 0.5f).WrapAsEnumerable();
            });
        }

        static public IEnumerable<VectorF2> CollapsePathTriangles(this IEnumerable<VectorF2> item, float minimum_area)
        {
            return item.SweepApproximatePath(3, minimum_area, delegate(List<VectorF2> points) {
                return points[0].CalculateTriangleArea(points[1], points[2]);
            }, delegate(List<VectorF2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<VectorF2> CollapsePathStellations(this IEnumerable<VectorF2> item, float minimum_shortest_to_longest_ratio)
        {
            return item.SweepApproximatePath(3, minimum_shortest_to_longest_ratio, delegate(List<VectorF2> points) {
                return points[0].CalculateTriangleShortestToLongestSideRatio(points[1], points[2]);
            }, delegate(List<VectorF2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<VectorF2> BisectApproximatePath(this IEnumerable<VectorF2> item, float maximum_normal_deviance)
        {
            return item.BisectApproximatePath(maximum_normal_deviance, delegate(VectorF2 start, VectorF2 end, VectorF2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }

        static public IEnumerable<VectorF2> VariableSweepApproximatePath(this IEnumerable<VectorF2> item, int maximum_length, float maximum_normal_deviance)
        {
            return item.VariableSweepApproximatePath(maximum_length, maximum_normal_deviance, delegate(VectorF2 start, VectorF2 end, VectorF2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }
    }
}