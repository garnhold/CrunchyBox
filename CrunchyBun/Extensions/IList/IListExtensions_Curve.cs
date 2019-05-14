﻿using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBun
{
    static public class IListExtensions_Curve
    {
        static public IEnumerable<VectorF2> InferCurveByWidth(this IList<float> item, float x, float width)
        {
            return item.InferCurveByInterval(x, width / item.Count);
        }
    }
}