using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawHorizontalRule(Rect rect, float line_thickness = 2.0f)
        {
            DrawRect(rect.GetHeightedAnchorCenter(line_thickness));
        }
    }
}