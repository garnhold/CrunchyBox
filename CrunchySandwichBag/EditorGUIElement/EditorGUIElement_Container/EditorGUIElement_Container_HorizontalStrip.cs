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
        private List<Tuple<EditorGUIElementLength, EditorGUIElement>> strip_elements;

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            float total_weight = strip_elements.Convert(t => t.item1.GetWeight()).Sum();
            float total_fixed_width = strip_elements.Convert(t => t.item1.GetFixedLength()).Sum();
            float total_weighted_width = rect.width - total_fixed_width;

            foreach (Tuple<EditorGUIElementLength, EditorGUIElement> element in strip_elements)
            {
                Rect current_rect;
                float width = element.item1.GetLength(total_weighted_width, total_weight);

                rect.SplitByXLeftOffset(width, out current_rect, out rect);
                element.item2.Layout(current_rect, state);
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return strip_elements.Convert(e => e.item2.GetHeight()).Max();
        }

        public EditorGUIElement_Container_HorizontalStrip()
        {
            strip_elements = new List<Tuple<EditorGUIElementLength, EditorGUIElement>>();
        }

        public T AddChild<T>(EditorGUIElementLength l, T child) where T : EditorGUIElement
        {
            if (child != null)
            {
                strip_elements.Add(Tuple.New<EditorGUIElementLength, EditorGUIElement>(l, child));

                Invalidate();
                child.SetParent(this);
            }

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
            strip_elements.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            if (strip_elements.RemoveFirst(e => e.item2 == child))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return strip_elements.Convert(e => e.item2);
        }
    }
}