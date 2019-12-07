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
    
    public class EditorGUIElementAttachment_Singular_Label_Index : EditorGUIElementAttachment_Singular_Label
    {
        private EditorGUIElementPlan index_plan;
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

        public override EditorGUIElementPlan PlanContentsInternal(EditorGUIElementPlan plan, EditorGUILayoutState state)
        {
            plan.SplitAtLeftOffset(state.GetCurrentLabelWidth(), out index_plan, out plan);

            return plan;
        }

        public override void LayoutInternal(Vector2 position, float footprint_height)
        {
            index_rect = index_plan.Layout(position, EditorGUIElement.LINE_HEIGHT);
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