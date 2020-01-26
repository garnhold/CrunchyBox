using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
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