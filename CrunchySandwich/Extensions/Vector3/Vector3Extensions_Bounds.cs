using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_Bounds
    {
        static public Bounds GetBounds(this Vector3 item)
        {
            return new Bounds(item, Vector3.zero);
        }
    }
}