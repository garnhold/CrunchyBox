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
    public class EditorGUIElement_Container_HorizontalStrip : EditorGUIElement_Container
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

        public EditorGUIElement_Container_HorizontalStrip()
        {
            row = new EditorGUIFlowRow();
        }

        public void AddChild(EditorGUIFlowElement child)
        {
            if (child != null)
            {
                row.Add(child);

                Invalidate();
                child.GetElement().SetParent(this);
            }
        }

        public T AddChild<T>(EditorGUIElementDimension d, T child) where T : EditorGUIElement
        {
            AddChild(new EditorGUIFlowElement(child, d));
            return child;
        }

        public void AddChildren(IEnumerable<Tuple<EditorGUIElementLength, EditorGUIElement>> children)
        {
            children.Process(p => AddChild(p.item1, p.item2));
        }
        public void AddChildren(params Tuple<EditorGUIElementLength, EditorGUIElement>[] children)
        {
            AddChildren((IEnumerable<Tuple<EditorGUIElementLength, EditorGUIElement>>)children);
        }

        public void AddChildren(EditorGUIElementLength l, IEnumerable<EditorGUIElement> children)
        {
            children.Process(c => AddChild(l, c));
        }
        public void AddChildren(EditorGUIElementLength l, params EditorGUIElement[] children)
        {
            AddChildren((IEnumerable<EditorGUIElement>)children);
        }

        public T AddChild<T>(float w, T child) where T : EditorGUIElement
        {
            return AddChild<T>(new EditorGUIElementLength_Weighted(w), child);
        }

        public void AddChildren(IEnumerable<Tuple<float, EditorGUIElement>> children)
        {
            children.Process(p => AddChild(p.item1, p.item2));
        }
        public void AddChildren(params Tuple<float, EditorGUIElement>[] children)
        {
            AddChildren((IEnumerable<Tuple<float, EditorGUIElement>>)children);
        }

        public void AddChildren(float w, IEnumerable<EditorGUIElement> children)
        {
            children.Process(c => AddChild(w, c));
        }
        public void AddChildren(float w, params EditorGUIElement[] children)
        {
            AddChildren(w, (IEnumerable<EditorGUIElement>)children);
        }

        public void AddChildren(IEnumerable<EditorGUIElement> children)
        {
            AddChildren(1.0f, children);
        }
        public void AddChildren(params EditorGUIElement[] children)
        {
            AddChildren((IEnumerable<EditorGUIElement>)children);
        }

        public override void ClearChildren()
        {
            row.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            if (row.Remove(child))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return row.Convert(e => e.GetElement());
        }
    }
}