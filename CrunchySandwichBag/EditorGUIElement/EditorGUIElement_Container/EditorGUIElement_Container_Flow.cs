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
    public class EditorGUIElement_Container_Flow : EditorGUIElement_Container
    {
        private float width;
        private List<Tuple<float, EditorGUIElement>> flow_elements;

        private IEnumerable<Tuple<float, IEnumerable<Tuple<float, EditorGUIElement>>>> GetRows(float width)
        {
            return flow_elements.GetCostGroups(width, p => p.item1)
                .Convert(e => Tuple.New(e.Convert(z => z.item2.GetHeight()).Max(), e));
        }

        protected override void LayoutContentsInternal(Rect rect, EditorGUILayoutState state)
        {
            if (rect.width != width)
            {
                InvalidateHeight();
                width = rect.width;
            }

            foreach (Tuple<float, IEnumerable<Tuple<float, EditorGUIElement>>> row in GetRows(rect.width))
            {
                Rect row_rect;

                rect.SplitByYBottomOffset(row.item1, out row_rect, out rect);

                foreach (Tuple<float, EditorGUIElement> element in row.item2)
                {
                    Rect element_rect;

                    row_rect.SplitByXLeftOffset(element.item1, out element_rect, out row_rect);

                    element.item2.Layout(element_rect, state);
                }
            }
        }

        protected override float CalculateElementHeightInternal()
        {
            return GetRows(width).Convert(r => r.item1).Sum();
        }

        public EditorGUIElement_Container_Flow()
        {
            flow_elements = new List<Tuple<float, EditorGUIElement>>();
        }

        public T AddChild<T>(float l, T child) where T : EditorGUIElement
        {
            if (child != null)
            {
                flow_elements.Add(Tuple.New<float, EditorGUIElement>(l, child));

                Invalidate();
                child.SetParent(this);
            }

            return child;
        }

        public void AddChildren(IEnumerable<Tuple<float, EditorGUIElement>> children)
        {
            children.Process(p => AddChild(p.item1, p.item2));
        }
        public void AddChildren(params Tuple<float, EditorGUIElement>[] children)
        {
            AddChildren((IEnumerable<Tuple<float, EditorGUIElement>>)children);
        }

        public void AddChildren(float l, IEnumerable<EditorGUIElement> children)
        {
            children.Process(c => AddChild(l, c));
        }
        public void AddChildren(float l, params EditorGUIElement[] children)
        {
            AddChildren(l, (IEnumerable<EditorGUIElement>)children);
        }

        public override void ClearChildren()
        {
            flow_elements.Clear();

            Invalidate();
        }

        public override bool RemoveChild(EditorGUIElement child)
        {
            if (flow_elements.RemoveFirst(e => e.item2 == child))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public override IEnumerable<EditorGUIElement> GetChildren()
        {
            return flow_elements.Convert(e => e.item2);
        }
    }
}