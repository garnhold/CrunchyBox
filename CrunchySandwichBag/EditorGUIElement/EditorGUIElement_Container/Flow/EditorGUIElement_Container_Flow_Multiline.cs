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
    public class EditorGUIElement_Container_Flow_Multiline : EditorGUIElement_Container_Flow
    {
        private float width;
        private List<EditorGUIFlowRow> flow_rows;

        private List<EditorGUIFlowElement> flow_elements;

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            if (rect.width != width)
            {
                width = rect.width;
                flow_rows.Set(
                    flow_elements
                        .GetCostGroups(width, p => p.GetDimension().GetMinimum())
                        .Convert(e => new EditorGUIFlowRow(e))
                );

                InvalidateHeight();
            }

            flow_rows.Apply(rect, (r, e) => e.Layout(r, state, width));
        }

        protected override float CalculateElementHeightInternal()
        {
            return flow_rows.Convert(r => r.GetHeight()).Sum();
        }

        public EditorGUIElement_Container_Flow_Multiline()
        {
            width = -1.0f;
            flow_rows = new List<EditorGUIFlowRow>();

            flow_elements = new List<EditorGUIFlowElement>();
        }

        public override void AddChild(EditorGUIFlowElement child)
        {
            if (child != null)
            {
                flow_elements.Add(child);

                child.GetElement().SetParent(this);
                Invalidate();
            }
        }

        public override void ClearChildren()
        {
            flow_elements.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            if (flow_elements.RemoveFirst(e => e.GetElement() == child))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return flow_elements.Convert(e => e.GetElement());
        }
    }
}