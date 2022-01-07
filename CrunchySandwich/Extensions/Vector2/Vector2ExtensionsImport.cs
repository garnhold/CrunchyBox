using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Crunchy.Dough;

    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable
    {
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_Area
    {
        static public float GetLoopShoelaceArea(this IEnumerable<Vector2> item)
        {
            return item.CloseLoop().ConvertConnections((v0, v1) => v0.x*v1.y - v1.x*v0.y).Sum() * 0.5f;
        }

        static public float GetLoopArea(this IEnumerable<Vector2> item)
        {
            return item.GetLoopShoelaceArea().GetAbs();
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_Connect
    {
        static public IEnumerable<LineSegment2> Connect(this IEnumerable<Vector2> item)
        {
            return item.ConvertConnections((v0, v1) => new LineSegment2(v0, v1));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_Convert
    {
        static public IEnumerable<J> ConvertLoop<J>(this IEnumerable<Vector2> item, Operation<J, Vector2, Vector2> operation)
        {
            return item.WindClockwise().OpenLoop().ConvertLoopedNeighbors((v1, v2, v3) => operation(v2, v2.GetNormalizedNormal(v1, v3)));
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_IEnumerable_Floats
    {
        static public IEnumerable<float> ConvertToFloats(this IEnumerable<Vector2> item)
        {
            foreach (Vector2 vector in item)
            {
                yield return vector.x;
                yield return vector.y;
            }
        }

        static public IEnumerable<Vector2> ConvertToVector2s(this IEnumerable<float> item, IEnumerable<float> other)
        {
            return item.PairStrict(other, (x, y) => new Vector2(x, y));
        }
    }
}
    namespace Crunchy.Sandwich
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
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_Loop
    {
        static public IEnumerable<Vector2> CloseClockwiseLoop(this IEnumerable<Vector2> item)
        {
            return item.WindClockwise().CloseLoop();
        }
        static public IEnumerable<Vector2> CloseCounterClockwiseLoop(this IEnumerable<Vector2> item)
        {
            return item.WindCounterClockwise().CloseLoop();
        }

        static public bool IsLoopClockwise(this IEnumerable<Vector2> item)
        {
            if (item.GetLoopShoelaceArea() < 0.0f)
                return true;

            return false;
        }
        static public bool IsLoopCounterClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopClockwise() == false)
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_LoopInflate
    {
        static public IEnumerable<Vector2> InflateLoop(this IEnumerable<Vector2> item, float amount)
        {
            return item.ConvertLoop((p, n) => p + n * amount);
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_IEnumerable_LoopReduction
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
    namespace Crunchy.Sandwich
{    
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
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_PathPromotion
    {
        static public IEnumerable<Vector2> SubdividePathToLength(this IEnumerable<Vector2> item, float maximum_inter_length)
        {
            return item.SubdividePathToLength<Vector2>(maximum_inter_length, delegate(Vector2 v1, Vector2 v2) {
                return v1.GetDistanceTo(v2);
            }, delegate(Vector2 v1, Vector2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }

        static public IEnumerable<Vector2> SubdividePathByDivisions(this IEnumerable<Vector2> item, int divisions)
        {
            return item.SubdividePathByDivisions<Vector2>(divisions, delegate(Vector2 v1, Vector2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_PathReduction
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
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IEnumerable_Winding
    {
        static public IEnumerable<Vector2> WindClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopClockwise())
                return item;

            return item.Reverse();
        }
        static public IEnumerable<Vector2> WindCounterClockwise(this IEnumerable<Vector2> item)
        {
            if (item.IsLoopCounterClockwise())
                return item;

            return item.Reverse();
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions
    {
        static public Vector2 CreateDirectionFromRadians(float radians)
        {
            return Vector2Extensions_Angle_Radians.CreateDirection(radians);
        }

        static public Vector2 CreateDirectionFromDegrees(float degrees)
        {
            return Vector2Extensions_Angle_Degrees.CreateDirection(degrees);
        }

        static public Vector2 CreateDirectionFromPercent(float percent)
        {
            return Vector2Extensions_Angle_Percent.CreateDirection(percent);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Abs
    {
        static public Vector2 GetAbs(this Vector2 item)
        {
            return new Vector2(item.x.GetAbs(), item.y.GetAbs());
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_Angle
    {
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Angle_Custom
    {
        static public Vector2 CreateDirection(float x, float period)
        {
            return new Vector2(TrigCustom.Cos(x, period), TrigCustom.Sin(x, period));
        }

        static public float GetAngleInCustom(this Vector2 item, float period)
        {
            return TrigCustom.Atan2(item.y, item.x, period);
        }

        static public float GetAngleInCustomDifference(this Vector2 item, Vector2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDifference(other.GetAngleInCustom(period), period);
        }

        static public float GetAngleInCustomDistance(this Vector2 item, Vector2 other, float period)
        {
            return item.GetAngleInCustom(period).GetAngleDistance(other.GetAngleInCustom(period), period);
        }

        static public Vector2 GetAdjustDirectionAngleInCustom(this Vector2 item, float adjustment, float period)
        {
            return CreateDirection(item.GetAngleInCustom(period) + adjustment, period);
        }

        static public Vector2 GetJitteredDirectionAngleInCustom(this Vector2 item, float magnitude, float period)
        {
            return item.GetAdjustDirectionAngleInCustom(RandFloat.GetMagnitude(magnitude), period);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Angle_Degrees
    {
        static public Vector2 CreateDirection(float degrees)
        {
            return new Vector2(TrigDegree.Cos(degrees), TrigDegree.Sin(degrees));
        }

        static public float GetAngleInDegrees(this Vector2 item)
        {
            return TrigDegree.Atan2(item.y, item.x);
        }

        static public float GetAngleInDegreesDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDifference(other.GetAngleInDegrees());
        }

        static public float GetAngleInDegreesDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInDegrees().GetDegreeAngleDistance(other.GetAngleInDegrees());
        }

        static public Vector2 GetAdjustDirectionAngleInDegrees(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInDegrees() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInDegrees(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInDegrees(RandFloat.GetMagnitude(magnitude));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Angle_Percent
    {
        static public Vector2 CreateDirection(float percent)
        {
            return new Vector2(TrigPercent.Cos(percent), TrigPercent.Sin(percent));
        }

        static public float GetAngleInPercent(this Vector2 item)
        {
            return TrigPercent.Atan2(item.y, item.x);
        }

        static public float GetAngleInPercentDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDifference(other.GetAngleInPercent());
        }

        static public float GetAngleInPercentDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInPercent().GetPercentAngleDistance(other.GetAngleInPercent());
        }

        static public Vector2 GetAdjustDirectionAngleInPercent(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInPercent() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInPercent(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInPercent(RandFloat.GetMagnitude(magnitude));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Angle_Radians
    {
        static public Vector2 CreateDirection(float radians)
        {
            return new Vector2(TrigRadian.Cos(radians), TrigRadian.Sin(radians));
        }

        static public float GetAngleInRadians(this Vector2 item)
        {
            return TrigRadian.Atan2(item.y, item.x);
        }

        static public float GetAngleInRadiansDifference(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDifference(other.GetAngleInRadians());
        }

        static public float GetAngleInRadiansDistance(this Vector2 item, Vector2 other)
        {
            return item.GetAngleInRadians().GetRadianAngleDistance(other.GetAngleInRadians());
        }

        static public Vector2 GetAdjustDirectionAngleInRadians(this Vector2 item, float adjustment)
        {
            return CreateDirection(item.GetAngleInRadians() + adjustment);
        }

        static public Vector2 GetJitteredDirectionAngleInRadians(this Vector2 item, float magnitude)
        {
            return item.GetAdjustDirectionAngleInRadians(RandFloat.GetMagnitude(magnitude));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Aspect
    {
        static public float GetFactorToFillDimension(this Vector2 item, Vector2 bounds)
        {
            return (bounds.x / item.x).Min(bounds.y / item.y);
        }

        static public Vector2 GetFilledDimension(this Vector2 item, Vector2 bounds)
        {
            return item.GetFactorToFillDimension(bounds) * item;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_Binding
    {
        static public Vector2 BindAbove(this Vector2 item, Vector2 lower)
        {
            return new Vector2(item.x.BindAbove(lower.x), item.y.BindAbove(lower.y));
        }

        static public Vector2 BindBelow(this Vector2 item, Vector2 upper)
        {
            return new Vector2(item.x.BindBelow(upper.x), item.y.BindBelow(upper.y));
        }

        static public Vector2 BindBetween(this Vector2 item, Vector2 value1, Vector2 value2)
        {
            return new Vector2(item.x.BindBetween(value1.x, value2.x), item.y.BindBetween(value1.y, value2.y));
        }
        static public Vector2 BindBetween(this Vector2 item, FloatRange x_range, FloatRange y_range)
        {
            return item.BindBetween(new Vector2(x_range.x1, y_range.x1), new Vector2(x_range.x2, y_range.x2));
        }
        static public Vector2 BindBetween(this Vector2 item, FloatRange range)
        {
            return item.BindBetween(range, range);
        }

        static public Vector2 BindWithin(this Vector2 item, Rect rect)
        {
            return item.BindBetween(rect.min, rect.max);
        }

        static public Vector2 BindAround(this Vector2 item, float radius)
        {
            float distance;
            Vector2 direction = item.GetNormalized(out distance);

            if (distance > radius)
                return direction * radius;

            return item;
        }
        static public Vector2 BindAround(this Vector2 item, Vector2 center, float radius)
        {
            return center + (item - center).BindAround(radius);
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_BindMagnitude
    {
        static public Vector2 BindMagnitudeAbove(this Vector2 item, float lower)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindAbove(lower);
        }

        static public Vector2 BindMagnitudeBelow(this Vector2 item, float upper)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBelow(upper);
        }

        static public Vector2 BindMagnitudeBetween(this Vector2 item, float value1, float value2)
        {
            float magnitude;

            return item.GetNormalized(out magnitude) * magnitude.BindBetween(value1, value2);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_CardinalDirection
    {
        static public CardinalDirection GetClosestCardinalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalDirection();
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_CardinalOrdinalDirection
    {
        static public CardinalOrdinalDirection GetClosestCardinalOrdinalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestCardinalOrdinalDirection();
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2Extensions_Compare
    {
        static public bool IsZero(this Vector2 item)
        {
            if (item.x == 0.0f && item.y == 0.0f)
                return true;

            return false;
        }

        static public bool IsNonZero(this Vector2 item)
        {
            if (item.IsZero() == false)
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Component
    {
        static public Vector2 GetComponentMultiply(this Vector2 item, float x, float y)
        {
            return new Vector2(item.x * x, item.y * y);
        }
        static public Vector2 GetComponentMultiply(this Vector2 item, Vector2 other)
        {
            return item.GetComponentMultiply(other.x, other.y);
        }

        static public Vector2 GetComponentDivide(this Vector2 item, float x, float y)
        {
            return new Vector2(item.x / x, item.y / y);
        }
        static public Vector2 GetComponentDivide(this Vector2 item, Vector2 other)
        {
            return item.GetComponentDivide(other.x, other.y);
        }

        static public float GetMaxComponent(this Vector2 item)
        {
            return item.x.Max(item.y);
        }
        static public float GetMinComponent(this Vector2 item)
        {
            return item.x.Min(item.y);
        }

        static public float GetMagnitudeMaxComponent(this Vector2 item)
        {
            if (item.x.GetAbs() > item.y.GetAbs())
                return item.x;

            return item.y;
        }
        static public float GetMagnitudeMinComponent(this Vector2 item)
        {
            if (item.x.GetAbs() < item.y.GetAbs())
                return item.x;

            return item.y;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_Convert
    {
        static public Vector2 ConvertFromPercentToRange(this Vector2 item, FloatRange x_range, FloatRange y_range)
        {
            return new Vector2(
                item.x.ConvertFromPercentToRange(x_range),
                item.y.ConvertFromPercentToRange(y_range)
            );
        }
        static public Vector2 ConvertFromPercentToRange(this Vector2 item, FloatRange range)
        {
            return item.ConvertFromPercentToRange(range, range);
        }

        static public Vector2 ConvertFromRangeToPercent(this Vector2 item, FloatRange x_range, FloatRange y_range)
        {
            return new Vector2(
                item.x.ConvertFromRangeToPercent(x_range),
                item.y.ConvertFromRangeToPercent(y_range)
            );
        }
        static public Vector2 ConvertFromRangeToPercent(this Vector2 item, FloatRange range)
        {
            return item.ConvertFromRangeToPercent(range, range);
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2Extensions_Direction
    {
        static public Vector2 GetDirection(this Vector2 item, Vector2 target)
        {
            return (target - item).GetNormalized();
        }

        static public Vector2 GetDirection(this Vector2 item, Vector2 target, out float distance)
        {
            return (target - item).GetNormalized(out distance);
        }

        static public bool IsComplyingDirection(this Vector2 item, Vector2 direction)
        {
            if (item.GetDot(direction) > 0.0f)
                return true;

            return false;
        }

        static public bool IsOpposingDirection(this Vector2 item, Vector2 direction)
        {
            if (item.GetDot(direction) < 0.0f)
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2Extensions_Distance
    {
        static public float GetDistanceTo(this Vector2 item, Vector2 point)
        {
            return (point - item).GetMagnitude();
        }

        static public float GetSquaredDistanceTo(this Vector2 item, Vector2 point)
        {
            return (point - item).GetSquaredMagnitude();
        }

        static public bool IsWithinSquaredDistance(this Vector2 item, Vector2 point, float squared_distance)
        {
            if (item.GetSquaredDistanceTo(point) <= squared_distance)
                return true;

            return false;
        }

        static public bool IsWithinDistance(this Vector2 item, Vector2 point, float distance)
        {
            distance = distance.BindAbove(0.0f);

            return item.IsWithinSquaredDistance(point, distance * distance);
        }

        static public bool IsOutsideSquaredDistance(this Vector2 item, Vector2 point, float squared_distance)
        {
            if (item.IsWithinSquaredDistance(point, squared_distance) == false)
                return true;

            return false;
        }

        static public bool IsOutsideDistance(this Vector2 item, Vector2 point, float distance)
        {
            if (item.IsWithinDistance(point, distance) == false)
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Dot
    {
        static public float GetDot(this Vector2 item, Vector2 other)
        {
            return item.x * other.x + item.y * other.y;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Fill
    {
        static public int GetPowerFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            int x_power = item.x.GetPowerFillByMultiplier(target.x, multiplier);
            int y_power = item.y.GetPowerFillByMultiplier(target.y, multiplier);

            return x_power.Min(y_power);
        }

        static public float GetMultiplierFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            float x_multiplier = item.x.GetMultiplierFillByMultiplier(target.x, multiplier);
            float y_multiplier = item.y.GetMultiplierFillByMultiplier(target.y, multiplier);

            return x_multiplier.Min(y_multiplier);
        }

        static public Vector2 GetFillByMultiplier(this Vector2 item, Vector2 target, float multiplier)
        {
            return item.GetMultiplierFillByMultiplier(target, multiplier) * item;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_HorizontalDirection
    {
        static public HorizontalDirection GetClosestHorizontalDirection(this Vector2 item)
        {
            return item.GetAngleInRadians().GetRadianAngleClosestHorizontalDirection();
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Interpolate
    {
        static public Vector2 GetInterpolate(this Vector2 item, Vector2 target, float amount)
        {
            amount = amount.BindPercent();

            return item * (1.0f - amount) + target * amount;
        }

        static public Vector2 GetMidpoint(this Vector2 item, Vector2 target)
        {
            return (item + target) * 0.5f;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_IsBound
    {
        static public bool IsBoundAbove(this Vector2 item, Vector2 value)
        {
            if (item.x >= value.x && item.y >= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this Vector2 item, Vector2 value)
        {
            if (item.x <= value.x && item.y <= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this Vector2 item, Vector2 value1, Vector2 value2)
        {
            Vector2 lower;
            Vector2 upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Line
    {
        static public float GetDistanceToLine(this Vector2 item, Vector2 point1, Vector2 point2)
        {
            return point1.GetNormalizedNormal(point2).GetDot(item - point1).GetAbs();
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Line_Point
    {
        static public Vector2 GetPointOnLineByPercent(this Vector2 item, Vector2 target, float percent)
        {
            return item * (1.0f - percent) + target * percent;
        }
        static public Vector2 GetPointOnLine(this Vector2 item, Vector2 target, float distance)
        {
            return item.GetPointOnLineByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public Vector2 GetPointOnLineSegmentByPercent(this Vector2 item, Vector2 target, float percent)
        {
            return item.GetInterpolate(target, percent);
        }
        static public Vector2 GetPointOnLineSegment(this Vector2 item, Vector2 target, float distance)
        {
            return item.GetPointOnLineSegmentByPercent(target, distance / item.GetDistanceTo(target));
        }

        static public Vector2 GetPointNearLineByPercent(this Vector2 item, Vector2 target, float percent, float offset)
        {
            return item.GetPointOnLineByPercent(target, percent) + item.GetNormalizedNormal(target) * offset;
        }
        static public Vector2 GetPointNearLine(this Vector2 item, Vector2 target, float distance, float offset)
        {
            return item.GetPointNearLineByPercent(target, distance / item.GetDistanceTo(target), offset);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Line_ProjectedPoint
    {
        static public Vector2 GetProjectedPointOntoLine(this Vector2 item, Vector2 target, Vector2 point)
        {
            Vector2 direction = item.GetDirection(target);

            return direction * direction.GetDot(point - item) + item;
        }

        static public Vector2 GetProjectedPointOntoLineSegment(this Vector2 item, Vector2 target, Vector2 point)
        {
            Vector2 direction = item.GetDirection(target);

            float point_projection = direction.GetDot(point - item);

            float item_projection = 0.0f;
            float target_projection = direction.GetDot(target - item);

            return direction * point_projection.BindBetween(item_projection, target_projection) + item;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Looped
    {
        static public Vector2 GetLooped(this Vector2 item, float length)
        {
            return new Vector2(item.x.GetLooped(length), item.y.GetLooped(length));
        }

        static public Vector2 GetLooped(this Vector2 item, Vector2 length)
        {
            return new Vector2(item.x.GetLooped(length.x), item.y.GetLooped(length.y));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Magnitude
    {
        static public float GetMagnitude(this Vector2 item)
        {
            return Mathq.Sqrt(item.GetSquaredMagnitude());
        }

        static public float GetSquaredMagnitude(this Vector2 item)
        {
            return item.x.GetSquared() + item.y.GetSquared();
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_MinMax
    {
        static public Vector2 GetMin(this Vector2 item, Vector2 input)
        {
            return new Vector2(item.x.Min(input.x), item.y.Min(input.y));
        }

        static public Vector2 GetMax(this Vector2 item, Vector2 input)
        {
            return new Vector2(item.x.Max(input.x), item.y.Max(input.y));
        }

        static public void Order(this Vector2 item, Vector2 input, out Vector2 lower, out Vector2 upper)
        {
            float x_min;
            float x_max;
            item.x.Order(input.x, out x_min, out x_max);

            float y_min;
            float y_max;
            item.y.Order(input.y, out y_min, out y_max);

            lower = new Vector2(x_min, y_min);
            upper = new Vector2(x_max, y_max);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_MoveTowards
    {
        static public bool GetMoveTowards(this Vector2 item, Vector2 target, Vector2 amount, out Vector2 output)
        {
            float x_output;
            float y_output;

            bool x_result = item.x.GetMoveTowards(target.x, amount.x, out x_output);
            bool y_result = item.y.GetMoveTowards(target.y, amount.y, out y_output);

            output = new Vector2(x_output, y_output);
            return x_result && y_result;
        }
        static public bool GetMoveTowards(this Vector2 item, Vector2 target, float amount, out Vector2 output)
        {
            return item.GetMoveTowards(
                target,
                item.GetDirection(target) * amount,
                out output
            );
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Normal
    {
        static public Vector2 GetNormal(this Vector2 item)
        {
            return new Vector2(-item.y, item.x);
        }
        static public Vector2 GetNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormal();
        }

        static public Vector2 GetNormalizedNormal(this Vector2 item)
        {
            return item.GetNormal().GetNormalized();
        }
        static public Vector2 GetNormalizedNormal(this Vector2 item, Vector2 point)
        {
            return (point - item).GetNormalizedNormal();
        }

        static public Vector2 GetNormalizedNormal(this Vector2 item, Vector2 before, Vector2 after)
        {
            return (before.GetNormalizedNormal(item) + item.GetNormalizedNormal(after)) * 0.5f;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Normalize
    {
        static public Vector2 GetNormalized(this Vector2 item)
        {
            return item / item.GetMagnitude();
        }

        static public Vector2 GetNormalized(this Vector2 item, out float magnitude)
        {
            magnitude = item.GetMagnitude();

            if(magnitude != 0.0f)
                return item / magnitude;

            return Vector2.zero;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2Extensions_Precision
    {
        static public Vector2 GetAtPrecision(this Vector2 item, int exponent)
        {
            return new Vector2(
                item.x.GetAtPrecision(exponent),
                item.y.GetAtPrecision(exponent)
            );
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Rect
    {
        static public Rect GetRect(this Vector2 item)
        {
            return RectExtensions.CreateCenterRect(item, Vector2.zero);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_Towards
    {
        static public Vector2 GetTowards(this Vector2 item, Vector2 target, Vector2 amount)
        {
            return new Vector2(
                item.x.GetTowards(target.x, amount.x),
                item.y.GetTowards(target.y, amount.y)
            );
        }
        static public Vector2 GetTowards(this Vector2 item, Vector2 target, float amount)
        {
            return item.GetTowards(
                target,
                item.GetDirection(target) * amount
            );
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2Extensions_Triangle
    {
        static public float CalculateTriangleArea(this Vector2 point1, Vector2 point2, Vector2 point3)
        {
            float a;
            float b;
            float c;

            point1.GetDistanceTo(point2).Order(
                point2.GetDistanceTo(point3),
                point3.GetDistanceTo(point1),
                out c, out b, out a
            );

            float ab = a - b;

            float t1 = a + (b + c);
            float t2 = c - ab;
            float t3 = c + ab;
            float t4 = a + (b - c);

            return 0.25f * Mathq.Sqrt(t1 * t2 * t3 * t4);
        }

        static public float CalculateTriangleShortestToLongestSideRatio(this Vector2 point1, Vector2 point2, Vector2 point3)
        {
            float a;
            float b;
            float c;

            point1.GetDistanceTo(point2).Order(
                point2.GetDistanceTo(point3),
                point3.GetDistanceTo(point1),
                out c, out b, out a
            );

            return c / a;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2Extensions_VectorI2
    {
        static public VectorI2 GetVectorI2(this Vector2 item)
        {
            return new VectorI2(item.x, item.y);
        }

        static public VectorI2 GetDeflated(this Vector2 item, Vector2 unit)
        {
            return item.GetComponentDivide(unit).GetVectorI2();
        }
        static public VectorI2 GetDeflated(this Vector2 item, float unit)
        {
            return item.GetDeflated(new Vector2(unit, unit));
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2Extensions_With
    {
        static public Vector2 GetWithX(this Vector2 item, float x)
        {
            return new Vector2(x, item.y);
        }

        static public Vector2 GetWithFlippedX(this Vector2 item)
        {
            return item.GetWithX(-item.x);
        }

        static public Vector2 GetWithAdjustedX(this Vector2 item, float amount)
        {
            return item.GetWithX(item.x + amount);
        }

        static public Vector2 GetWithScaledX(this Vector2 item, float scale)
        {
            return item.GetWithX(item.x * scale);
        }

        static public Vector2 GetWithY(this Vector2 item, float y)
        {
            return new Vector2(item.x, y);
        }

        static public Vector2 GetWithFlippedY(this Vector2 item)
        {
            return item.GetWithY(-item.y);
        }

        static public Vector2 GetWithAdjustedY(this Vector2 item, float amount)
        {
            return item.GetWithY(item.y + amount);
        }

        static public Vector2 GetWithScaledY(this Vector2 item, float scale)
        {
            return item.GetWithY(item.y * scale);
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public partial class Vector2s
    {
        static public IEnumerable<Vector2> Ray(Vector2 start, Vector2 step, int divisions)
        {
            for (int i = 0; i < divisions; i++)
                yield return start + i * step;
        }

        static public IEnumerable<Vector2> Line(Vector2 start, Vector2 end, int divisions, bool include_end)
        {
            Vector2 step;

            if (include_end)
                step = (end - start) / (divisions - 1);
            else
                step = (end - start) / divisions;

            return Ray(start, step, divisions);
        }

        static public IEnumerable<Vector2> Range(Vector2 start, Vector2 end, float step, bool include_end)
        {
            float distance;
            Vector2 direction = start.GetDirection(end, out distance);

            int divisions = (int)(distance / step).GetAbs();

            if (include_end)
                divisions++;

            return Ray(start, direction * (distance / divisions), divisions);
        }
        static public IEnumerable<Vector2> Range(Vector2 start, Vector2 end, bool include_end)
        {
            return Range(start, end, 1.0f, include_end);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public partial class Vector2s
	{
	
		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromRadians(a));
        }

		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromRadians(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromRadians(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromRadians(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromRadians(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromRadians(a, magnitudes)).Flatten();
        }
	
		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromDegrees(a));
        }

		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromDegrees(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromDegrees(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromDegrees(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromDegrees(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromDegrees(a, magnitudes)).Flatten();
        }
	
		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles)
        {
            return angles.Convert(a => Vector2Extensions.CreateDirectionFromPercent(a));
        }

		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles, float magnitude)
        {
			return RadialFromPercent(angles).Convert(v => v * magnitude);
        }

		static public IEnumerable<Vector2> RadialFromPercent(float angle, IEnumerable<float> magnitudes)
		{
			Vector2 direction = Vector2Extensions.CreateDirectionFromPercent(angle);

			return magnitudes.Convert(m => direction * m);
		}

		static public IEnumerable<Vector2> RadialFromPercent(IEnumerable<float> angles, IEnumerable<float> magnitudes)
        {
			return angles.Convert(a => RadialFromPercent(a, magnitudes)).Flatten();
        }
	
	}
}
