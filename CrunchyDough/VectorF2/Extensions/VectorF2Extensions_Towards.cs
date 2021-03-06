﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_Towards
    {
        static public VectorF2 GetTowards(this VectorF2 item, VectorF2 target, VectorF2 amount)
        {
            return new VectorF2(
                item.x.GetTowards(target.x, amount.x),
                item.y.GetTowards(target.y, amount.y)
            );
        }
        static public VectorF2 GetTowards(this VectorF2 item, VectorF2 target, float amount)
        {
            return item.GetTowards(
                target,
                item.GetDirection(target) * amount
            );
        }
    }
}