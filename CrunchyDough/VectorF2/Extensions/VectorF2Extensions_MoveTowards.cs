using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_MoveTowards
    {
        static public bool GetMoveTowards(this VectorF2 item, VectorF2 target, VectorF2 amount, out VectorF2 output)
        {
            float x_output;
            float y_output;

            bool x_result = item.x.GetMoveTowards(target.x, amount.x, out x_output);
            bool y_result = item.y.GetMoveTowards(target.y, amount.y, out y_output);

            output = new VectorF2(x_output, y_output);
            return x_result && y_result;
        }
        static public bool GetMoveTowards(this VectorF2 item, VectorF2 target, float amount, out VectorF2 output)
        {
            return item.GetMoveTowards(
                target,
                item.GetDirection(target) * amount,
                out output
            );
        }
    }
}