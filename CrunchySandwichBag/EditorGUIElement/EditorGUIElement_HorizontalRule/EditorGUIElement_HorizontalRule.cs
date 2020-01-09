using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_HorizontalRule : EditorGUIElement
    {
        protected override void DrawElementInternal(int draw_id, Rect view)
        {
            Rect rect = GetElementRect();

            GUIExtensions.DrawRect(
                rect.GetHeightedAnchorCenter(1.0f).GetShrunk(rect.width * 0.125f, 0.0f),
                Color.gray
            );
        }
    }
}