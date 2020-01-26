using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class RectExtensions_Points
    {
        static public IEnumerable<Vector2> GetPoints(this Rect item)
        {
            yield return item.GetLowerLeftPoint();
            yield return item.GetLowerRightPoint();

            yield return item.GetUpperRightPoint();
            yield return item.GetUpperLeftPoint();
        }

        static public Vector2 GetCenterPoint(this Rect item)
        {
            return item.center;
        }

        static public Vector2 GetLowerLeftPoint(this Rect item)
        {
            return new Vector2(item.xMin, item.yMin);
        }

        static public Vector2 GetLowerRightPoint(this Rect item)
        {
            return new Vector2(item.xMax, item.yMin);
        }

        static public Vector2 GetUpperLeftPoint(this Rect item)
        {
            return new Vector2(item.xMin, item.yMax);
        }

        static public Vector2 GetUpperRightPoint(this Rect item)
        {
            return new Vector2(item.xMax, item.yMax);
        }
    }
}