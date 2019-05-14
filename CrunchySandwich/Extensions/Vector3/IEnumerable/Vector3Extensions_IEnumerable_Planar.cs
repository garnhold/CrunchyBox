﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector3Extensions_IEnumerable_Planar
    {
        static public IEnumerable<Vector2> GetPlanar(this IEnumerable<Vector3> item)
        {
            return item.Convert(v => v.GetPlanar());
        }
    }
}