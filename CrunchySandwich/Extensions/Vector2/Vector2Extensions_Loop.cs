using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_Loop
    {
        static public IEnumerable<Vector2> CollapseLoopPoints(this IEnumerable<Vector2> item, float minimum_distance)
        {
            return item.SweepApproximateLoop(2, minimum_distance, delegate(List<Vector2> points) {
                return points[0].GetDistanceTo(points[1]);
            }, delegate(List<Vector2> points) {
                return ((points[0] + points[1]) * 0.5f).WrapAsEnumerable();
            });
        }

        static public IEnumerable<Vector2> CollapseLoopTriangles(this IEnumerable<Vector2> item, float minimum_area)
        {
            return item.SweepApproximateLoop(3, minimum_area, delegate(List<Vector2> points) {
                return points[0].CalculateTriangleArea(points[1], points[2]);
            }, delegate(List<Vector2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<Vector2> CollapseLoopStellations(this IEnumerable<Vector2> item, float minimum_shortest_to_longest_ratio)
        {
            return item.SweepApproximateLoop(3, minimum_shortest_to_longest_ratio, delegate(List<Vector2> points) {
                return points[0].CalculateTriangleShortestToLongestSideRatio(points[1], points[2]);
            }, delegate(List<Vector2> points) {
                return points[0].WrapAsEnumerable().Append(points[2]);
            });
        }

        static public IEnumerable<Vector2> BisectApproximateLoop(this IEnumerable<Vector2> item, float maximum_normal_deviance)
        {
            return item.BisectApproximateLoop(maximum_normal_deviance, delegate(Vector2 start, Vector2 end, Vector2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }

        static public IEnumerable<Vector2> VariableSweepApproximateLoop(this IEnumerable<Vector2> item, int maximum_length, float maximum_normal_deviance)
        {
            return item.VariableSweepApproximateLoop(maximum_length, maximum_normal_deviance, delegate(Vector2 start, Vector2 end, Vector2 point) {
                return point.GetDistanceToLine(start, end);
            });
        }
    }
}