﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_LoopInflate
    {
        static public IEnumerable<Vector2> InflateLoop(this IEnumerable<Vector2> item, float amount)
        {
            return item.ConvertLoop((p, n) => p + n * amount);
        }
    }
}