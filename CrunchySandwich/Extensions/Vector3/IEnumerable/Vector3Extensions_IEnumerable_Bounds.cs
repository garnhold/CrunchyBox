﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector3Extensions_IEnumerable_Bounds
    {
        static public Bounds GetEncompassing(this IEnumerable<Vector3> item)
        {
            Bounds bounds = new Bounds();

            item.Process(p => bounds = new Bounds(p, Vector3.zero), p => bounds.Encapsulate(p));
            return bounds;
        }
    }
}