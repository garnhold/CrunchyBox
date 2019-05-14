using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwich
{
    static public partial class EventExtensions
    {
        static private readonly Rect LAYOUT_RECT = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        static public bool IsLayoutNullRect(Rect to_check)
        {
            if (Event.current.type == EventType.Layout && to_check == LAYOUT_RECT)
                return true;

            return false;
        }
    }
}