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
    public class EditorGUIElement_Container_Flow_Line : EditorGUIElement_Container_Flow
    {
        private EditorGUIFlowRow row;

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            row.Layout(rect, state, rect.width);
        }

        protected override float CalculateElementHeightInternal()
        {
            return row.GetHeight();
        }

        public EditorGUIElement_Container_Flow_Line()
        {
            row = new EditorGUIFlowRow();
        }

        public override void AddChild(EditorGUIFlowElement child)
        {
            if (child != null)
            {
                row.Add(child);

                child.GetElement().SetParent(this);
                Invalidate();
            }
        }

        public override void ClearChildren()
        {
            row.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            return row.Remove(child);
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return row.Convert(e => e.GetElement());
        }
    }
}