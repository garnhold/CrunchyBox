using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Path
    {
        static public IEnumerable<Vector2> CollapsePathPoints(this IEnumerable<Vector2> item, float minimum_distance)
        {
            return item.SweepApproximatePath(2, minimum_distance, delegate(List<Vector2> points) {
                return points[0].GetDistanceTo(points[1]);
            }, delegate(List<Vector2> points) {
                return ((points[0] + points[1]) * 0.5f).WrapAsEnumerable();
            });
        }

        static public IEnumerable<Vector2> CollapsePathTriangles(this IEnumerable<Vector2> item, float minimum_area)
        {
            return item.SweepApproximatePath(3, minimum_area, delegate(List<Vector2> points) {
                return points[0].CalculateTriangleArea(points[1], points[2]);
            }, delegate(List<Vector2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<Vector2> CollapsePathStellations(this IEnumerable<Vector2> item, float minimum_shortest_to_longest_ratio)
        {
            return item.SweepApproximatePath(3, minimum_shortest_to_longest_ratio, delegate(List<Vector2> points) {
                return points[0].CalculateTriangleShortestToLongestSideRatio(points[1], points[2]);
            }, delegate(List<Vector2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<Vector2> BisectApproximatePath(this IEnumerable<Vector2> item, float maximum_normal_deviance)
        {
            return item.BisectApproximatePath(maximum_normal_deviance, delegate(Vector2 start, Vector2 end, Vector2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }

        static public IEnumerable<Vector2> VariableSweepApproximatePath(this IEnumerable<Vector2> item, int maximum_length, float maximum_normal_deviance)
        {
            return item.VariableSweepApproximatePath(maximum_length, maximum_normal_deviance, delegate(Vector2 start, Vector2 end, Vector2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }
    }
}