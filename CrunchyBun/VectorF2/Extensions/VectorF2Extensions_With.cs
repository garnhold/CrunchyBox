﻿using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyBun;

namespace CrunchyBun
{
    static public class VectorF2Extensions_With
    {
        static public VectorF2 GetWithX(this VectorF2 item, float x)
        {
            return new VectorF2(x, item.y);
        }

        static public VectorF2 GetWithY(this VectorF2 item, float y)
        {
            return new VectorF2(item.x, y);
        }
    }
}