﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class RectI2Extensions_Rect
    {
        static public Rect GetRect(this RectI2 item)
        {
            return new Rect(
                item.GetLowerLeftPoint().GetVector2(), 
                item.GetSize().GetVector2()
            );
        }
    }
}