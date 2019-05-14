using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class BoundsExtensions_Center
    {
        static public Bounds GetWithCenter(this Bounds item, Vector3 center)
        {
            return new Bounds(center, item.size);
        }
    }
}