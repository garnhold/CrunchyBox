using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void AutoLabel(Rect rect, GUIContent content, out Rect actual_rect)
        {
            actual_rect = rect.GetWidthedAnchorLeft(content.GetLabelLayoutWidth());

            GUI.Label(actual_rect, content);
        }
    }
}