﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Spacar_Bounds
    {
        static public Bounds GetSpacarRendererBounds(this Transform item)
        {
            return item.GetComponent<Renderer>().bounds;
        }
    }
}