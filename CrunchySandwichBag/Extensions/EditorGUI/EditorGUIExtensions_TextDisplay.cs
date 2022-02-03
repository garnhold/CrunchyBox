using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public void TextDisplay(Rect rect, string value)
        {
            string layout_value = GUI.skin.LayoutDefaultText(value, rect.width);

            if (layout_value.GetNumberLines() > 1)
            {
                Rect button_rect;

                rect.SplitByXRightOffset(32.0f, out rect, out button_rect);

                if (GUI.Button(button_rect, ". . ."))
                    ModalEditorWindows.Alert("Text", value);
            }

            GUI.Box(rect, layout_value);
        }
    }
}