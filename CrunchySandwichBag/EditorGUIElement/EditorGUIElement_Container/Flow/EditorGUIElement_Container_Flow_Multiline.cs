using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    public class EditorGUIElement_Container_Flow_Multiline : EditorGUIElement_Container_Flow
    {
        private List<EditorGUIFlowRow> flow_rows;

        private List<EditorGUIFlowElement> flow_elements;

        protected override float DoPlanInternal()
        {
            flow_rows.Set(
                flow_elements
                    .GetCostGroups(GetContentsWidth(), BoundType.Below, p => p.GetDimension().GetMinimum())
                    .Convert(e => new EditorGUIFlowRow(e))
            );

            return flow_rows.Convert(r => r.Plan(GetContentsWidth(), GetLayoutState())).Sum();
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            foreach (EditorGUIFlowRow row in flow_rows)
            {
                row.Layout(position);
                position.y += row.GetHeight();
            }
        }

        public EditorGUIElement_Container_Flow_Multiline()
        {
            flow_rows = new List<EditorGUIFlowRow>();

            flow_elements = new List<EditorGUIFlowElement>();
        }

        public override void AddChild(EditorGUIFlowElement child)
        {
            if (child != null)
            {
                flow_elements.Add(child);

                child.SetParent(this);
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