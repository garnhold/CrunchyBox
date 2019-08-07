using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElementAttachment_Singular_Label_Index : EditorGUIElementAttachment_Singular_Label
    {
        private Rect index_rect;

        private EditProperty_Array property;
        private int index;

        private Process process;

        public EditorGUIElementAttachment_Singular_Label_Index(EditProperty_Array a, int i, Process p)
        {
            property = a;
            index = i;

            process = p;
        }

        public override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            Rect discard;

            rect.SplitByXLeftOffset(state.GetCurrentLabelWidth(), out index_rect, out rect);

            index_rect.SplitByXLeftOffset(GetLabelWidth(), out index_rect, out discard);
            index_rect.SplitByYBottomOffset(EditorGUIElement.LINE_HEIGHT, out index_rect, out discard);

            return rect;
        }

        public override void DrawInternal(Rect view)
        {
            int new_index = EditorGUI.DelayedIntField(index_rect, index);

            if (new_index != index)
            {
                property.MoveElement(index, new_index);
                index = new_index;

                process.IfNotNull(p => p());
            }
        }

        public override float GetLabelWidth()
        {
            return 32.0f;
        }
    }
}