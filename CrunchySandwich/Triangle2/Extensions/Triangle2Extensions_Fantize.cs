using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Fantize
    {
        static public IEnumerable<Triangle2> Fantize(this Triangle2 item, Vector2 point)
        {
            yield return new Triangle2(item.v0, item.v1, point);
            yield return new Triangle2(item.v1, item.v2, point);
            yield return new Triangle2(item.v2, item.v0, point);
        }

        static public IEnumerable<Triangle2> FantizeAtCenter(this Triangle2 item)
        {
            return item.Fantize(item.GetCenter());
        }

        static public IEnumerable<Triangle2> RecursiveFantizeAtCenterByArea(this Triangle2 item, float min_area, int max_recursions)
        {
            if (item.GetArea() > min_area && max_recursions >= 1)
            {
                return item.FantizeAtCenter()
                    .Convert(t => t.RecursiveFantizeAtCenterByArea(min_area, max_recursions - 1))
                    .Flatten();
            }

            return item.WrapAsEnumerable();
        }
    }
}