using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions_Label
    {
        static public void AutoLabel(Rect rect, GUIContent content, out Rect actual_rect)
        {
            actual_rect = rect.GetWidthedAnchorLeft(content.GetLabelLayoutWidth());

            GUI.Label(actual_rect, content);
        }
    }
}