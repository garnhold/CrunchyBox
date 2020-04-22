using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector3Extensions_MoveTowards
    {
        static public bool GetMoveTowards(this Vector3 item, Vector3 target, Vector3 amount, out Vector3 output)
        {
            float x_output;
            float y_output;
            float z_output;

            bool x_result = item.x.GetMoveTowards(target.x, amount.x, out x_output);
            bool y_result = item.y.GetMoveTowards(target.y, amount.y, out y_output);
            bool z_result = item.z.GetMoveTowards(target.z, amount.z, out z_output);

            output = new Vector3(x_output, y_output, z_output);
            return x_result && y_result && z_result;
        }
        static public bool GetMoveTowards(this Vector3 item, Vector3 target, float amount, out Vector3 output)
        {
            return item.GetMoveTowards(
                target,
                item.GetDirection(target) * amount,
                out output
            );
        }
    }
}