using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class Vector2Extensions_GUI
    {
        static private readonly float GUI_OFFSET = 38.0f;

        static public Vector2 ConvertFromGUIToScreen(this Vector2 item)
        {
            return new Vector2(item.x, Screen.height - (item.y + GUI_OFFSET));
        }

        static public Vector2 ConvertFromScreenToGUI(this Vector2 item)
        {
            return new Vector2(item.x, Screen.height - (item.y + GUI_OFFSET));
        }
    }
}