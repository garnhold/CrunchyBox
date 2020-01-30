using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using Crunchy.Dough;

    namespace Crunchy.Sandwich
{    
    static public class Vector2IntExtensions_Abs
    {
        static public Vector2Int GetAbs(this Vector2Int item)
        {
            return new Vector2Int(item.x.GetAbs(), item.y.GetAbs());
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_Binding
    {
        static public Vector2Int BindAbove(this Vector2Int item, Vector2Int lower)
        {
            return new Vector2Int(item.x.BindAbove(lower.x), item.y.BindAbove(lower.y));
        }

        static public Vector2Int BindBelow(this Vector2Int item, Vector2Int upper)
        {
            return new Vector2Int(item.x.BindBelow(upper.x), item.y.BindBelow(upper.y));
        }

        static public Vector2Int BindBetween(this Vector2Int item, Vector2Int value1, Vector2Int value2)
        {
            return new Vector2Int(item.x.BindBetween(value1.x, value2.x), item.y.BindBetween(value1.y, value2.y));
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2IntExtensions_Component
    {
        static public Vector2Int GetComponentMultiply(this Vector2Int item, int x, int y)
        {
            return new Vector2Int(item.x * x, item.y * y);
        }
        static public Vector2Int GetComponentMultiply(this Vector2Int item, Vector2Int other)
        {
            return item.GetComponentMultiply(other.x, other.y);
        }

        static public Vector2Int GetComponentDivide(this Vector2Int item, int x, int y)
        {
            return new Vector2Int(item.x / x, item.y / y);
        }
        static public Vector2Int GetComponentDivide(this Vector2Int item, Vector2Int other)
        {
            return item.GetComponentDivide(other.x, other.y);
        }

        static public int GetMaxComponent(this Vector2Int item)
        {
            return item.x.Max(item.y);
        }

        static public int GetMinComponent(this Vector2Int item)
        {
            return item.x.Min(item.y);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2IntExtensions_Looped
    {
        static public Vector2Int GetLooped(this Vector2Int item, int length)
        {
            return new Vector2Int(item.x.GetLooped(length), item.y.GetLooped(length));
        }

        static public Vector2Int GetLooped(this Vector2Int item, Vector2Int length)
        {
            return new Vector2Int(item.x.GetLooped(length.x), item.y.GetLooped(length.y));
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_Magnitude
    {
        static public float GetMagnitude(this Vector2Int item)
        {
            return Mathq.Sqrt(item.GetSquaredMagnitude());
        }

        static public int GetSquaredMagnitude(this Vector2Int item)
        {
            return item.x.GetSquared() + item.y.GetSquared();
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_MinMax
    {
        static public Vector2Int GetMin(this Vector2Int item, Vector2Int input)
        {
            return new Vector2Int(item.x.Min(input.x), item.y.Max(input.y));
        }

        static public Vector2Int GetMax(this Vector2Int item, Vector2Int input)
        {
            return new Vector2Int(item.x.Max(input.x), item.y.Max(input.y));
        }

        static public void Order(this Vector2Int item, Vector2Int input, out Vector2Int lower, out Vector2Int upper)
        {
            int x_min;
            int x_max;
            item.x.Order(input.x, out x_min, out x_max);

            int y_min;
            int y_max;
            item.y.Order(input.y, out y_min, out y_max);

            lower = new Vector2Int(x_min, y_min);
            upper = new Vector2Int(x_max, y_max);
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2IntExtensions_Neighbors
    {
        static public IEnumerable<Vector2Int> GetCardinalNeighbors(this Vector2Int item)
        {
            yield return new Vector2Int(item.x, item.y - 1);
            yield return new Vector2Int(item.x - 1, item.y);
            yield return new Vector2Int(item.x + 1, item.y);
            yield return new Vector2Int(item.x, item.y + 1);
        }

        static public IEnumerable<Vector2Int> GetOrdinalNeighbors(this Vector2Int item)
        {
            yield return new Vector2Int(item.x - 1, item.y - 1);
            yield return new Vector2Int(item.x + 1, item.y - 1);
            yield return new Vector2Int(item.x - 1, item.y + 1);
            yield return new Vector2Int(item.x + 1, item.y + 1);
        }

        static public IEnumerable<Vector2Int> GetCardinalThenOrdinalNeighbors(this Vector2Int item)
        {
            return item.GetCardinalNeighbors().Append(item.GetOrdinalNeighbors());
        }
        static public IEnumerable<Vector2Int> GetNeighbors(this Vector2Int item)
        {
            return item.GetCardinalThenOrdinalNeighbors();
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_Adjacent
    {
        static public bool IsCardinallyAdjacent(this Vector2Int item, Vector2Int other)
        {
            if (item.x == other.x)
            {
                if (item.y == other.y - 1)
                    return true;

                if (item.y == other.y + 1)
                    return true;
            }

            if (item.y == other.y)
            {
                if (item.x == other.x - 1)
                    return true;

                if (item.x == other.x + 1)
                    return true;
            }

            return false;
        }

        static public bool IsOrdinallyAdjacent(this Vector2Int item, Vector2Int other)
        {
            if (item.x == other.x - 1 || item.x == other.x + 1)
            {
                if (item.y == other.y - 1)
                    return true;

                if (item.y == other.y + 1)
                    return true;
            }

            return false;
        }

        static public bool IsCardinallyOrOrdinallyAdjacent(this Vector2Int item, Vector2Int other)
        {
            if (item.IsCardinallyAdjacent(other) || item.IsOrdinallyAdjacent(other))
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{    
    static public class Vector2IntExtensions_IsBound
    {
        static public bool IsBoundAbove(this Vector2Int item, Vector2Int value)
        {
            if (item.x >= value.x && item.y >= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBelow(this Vector2Int item, Vector2Int value)
        {
            if (item.x <= value.x && item.y <= value.y)
                return true;

            return false;
        }

        static public bool IsBoundBetween(this Vector2Int item, Vector2Int value1, Vector2Int value2)
        {
            Vector2Int lower;
            Vector2Int upper;

            value1.Order(value2, out lower, out upper);

            if (item.IsBoundAbove(lower) && item.IsBoundBelow(upper))
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_With
    {
        static public Vector2Int GetWithX(this Vector2Int item, int x)
        {
            return new Vector2Int(x, item.y);
        }

        static public Vector2Int GetWithFlippedX(this Vector2Int item)
        {
            return item.GetWithX(-item.x);
        }

        static public Vector2Int GetWithAdjustedX(this Vector2Int item, int amount)
        {
            return item.GetWithX(item.x + amount);
        }

        static public Vector2Int GetWithY(this Vector2Int item, int y)
        {
            return new Vector2Int(item.x, y);
        }

        static public Vector2Int GetWithFlippedY(this Vector2Int item)
        {
            return item.GetWithY(-item.y);
        }

        static public Vector2Int GetWithAdjustedY(this Vector2Int item, int amount)
        {
            return item.GetWithY(item.y + amount);
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_Vector2
    {
        static public Vector2 GetVector2(this Vector2Int item)
        {
            return new Vector2(item.x, item.y);
        }

        static public Vector2 GetCenterVector2(this Vector2Int item)
        {
            return new Vector2(item.x + 0.5f, item.y + 0.5f);
        }

        static public Vector2 GetInflated(this Vector2Int item, Vector2 unit)
        {
            return item.GetVector2().GetComponentMultiply(unit);
        }

        static public Vector2 GetCenterInflated(this Vector2Int item, Vector2 unit)
        {
            return item.GetCenterVector2().GetComponentMultiply(unit);
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_ICollection_Rectangle
    {
        static public void AddRectangle(this ICollection<Vector2Int> item, Vector2Int point1, Vector2Int point2)
        {
            Vector2Int lower;
            Vector2Int upper;

            point1.Order(point2, out lower, out upper);

            for (int x = lower.x; x <= upper.x; x++)
            {
                for (int y = lower.y; y <= upper.y; y++)
                    item.Add(new Vector2Int(x, y));
            }
        }
    }
}
    namespace Crunchy.Sandwich
{
    static public class Vector2IntExtensions_IEnumerable_CardinallyAdjacent
    {
        static public IEnumerable<Vector2Int> GetCardinallyAdjacent(this IEnumerable<Vector2Int> item, Vector2Int point)
        {
            return item.Narrow(i => i.IsCardinallyAdjacent(point));
        }
        static public bool IsCardinallyAdjacent(this IEnumerable<Vector2Int> item, Vector2Int point)
        {
            if (item.GetCardinallyAdjacent(point).IsNotEmpty())
                return true;

            return false;
        }

        static public IEnumerable<Vector2Int> GetCardinallyAdjacentToAny(this IEnumerable<Vector2Int> item, IEnumerable<Vector2Int> points)
        {
            return item.Narrow(i => points.IsCardinallyAdjacent(i));
        }
        static public bool IsCardinallyAdjacentToAny(this IEnumerable<Vector2Int> item, IEnumerable<Vector2Int> points)
        {
            if (item.GetCardinallyAdjacentToAny(points).IsNotEmpty())
                return true;

            return false;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2IntExtensions_IEnumerable_IteratedBinaryOperation
    {
        static public Vector2Int Sum(this IEnumerable<Vector2Int> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2);
        }

        static public Vector2 Average(this IEnumerable<Vector2Int> item)
        {
            int count;

            return item.PerformIteratedBinaryOperation((v1, v2) => v1 + v2, out count).GetVector2() / count;
        }

        static public Vector2Int Min(this IEnumerable<Vector2Int> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMin(v2));
        }

        static public Vector2Int Max(this IEnumerable<Vector2Int> item)
        {
            return item.PerformIteratedBinaryOperation((v1, v2) => v1.GetMax(v2));
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2IntExtensions_HashSet_CardinallyContinous
    {
        static private HashSet<Vector2Int> GetCardinallyContinousAreaAtInternal(HashSet<Vector2Int> item, Vector2Int point, HashSet<Vector2Int> area)
        {
            if (item.Has(point))
            {
                if (area.Add(point))
                {
                    GetCardinallyContinousAreaAtInternal(item, point + Vector2Int.left, area);
                    GetCardinallyContinousAreaAtInternal(item, point + Vector2Int.right, area);
                    GetCardinallyContinousAreaAtInternal(item, point + Vector2Int.down, area);
                    GetCardinallyContinousAreaAtInternal(item, point + Vector2Int.up, area);
                }
            }

            return area;
        }
        static public HashSet<Vector2Int> GetCardinallyContinousAreaAt(this HashSet<Vector2Int> item, Vector2Int point)
        {
            return GetCardinallyContinousAreaAtInternal(item, point, new HashSet<Vector2Int>());
        }

        static public IEnumerable<HashSet<Vector2Int>> GetCardinallyContinousAreas(this HashSet<Vector2Int> item)
        {
            HashSet<Vector2Int> copy = item.ToHashSet();
            List<HashSet<Vector2Int>> areas = new List<HashSet<Vector2Int>>();

            while(copy.IsNotEmpty())
            {
                Vector2Int point = copy.GetFirst();
                HashSet<Vector2Int> area = copy.GetCardinallyContinousAreaAt(point);

                areas.Add(area);
                copy.ExceptWith(area);
            }

            return areas;
        }
    }
}
    namespace Crunchy.Sandwich
{   
    static public class Vector2IntExtensions_HashSet
    {
    }
}
