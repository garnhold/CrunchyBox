﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Plane2Extensions_Flip
    {
        static public Plane2 GetFlipped(this Plane2 item)
        {
            return Plane2Extensions.CreateNormalAndPoint(-item.normal, item.GetOrigin());
        }
    }
}