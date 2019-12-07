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
    
    public class EditorGUIElement_Container_Flow_Line : EditorGUIElement_Container_Flow
    {
        private EditorGUIFlowRow row;

        protected override float DoPlanInternal()
        {
            return row.Plan(GetContentsWidth(), GetLayoutState());
        }

        protected override void LayoutContentsInternal(Vector2 position)
        {
            row.Layout(position);
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

                child.SetParent(this);
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