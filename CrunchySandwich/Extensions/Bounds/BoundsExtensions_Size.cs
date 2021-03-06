﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class BoundsExtensions_Size
    {
        static public Bounds GetWithSize(this Bounds item, Vector3 size)
        {
            return new Bounds(item.center, size);
        }

        static public Bounds GetWithSize(this Bounds item, float size)
        {
            return item.GetWithSize(new Vector3(size, size, size));
        }
    }
}