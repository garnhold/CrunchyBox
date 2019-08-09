using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIFlowRow : IEnumerable<EditorGUIFlowElement>
    {
        private List<EditorGUIFlowElement> elements;

        public EditorGUIFlowRow()
        {
            elements = new List<EditorGUIFlowElement>();
        }

        public EditorGUIFlowRow(IEnumerable<EditorGUIFlowElement> e)
        {
            elements = e.ToList();
        }

        public Rect Layout(Rect rect, EditorGUILayoutState state, float width)
        {
            Rect row_rect;

            float total_weight = elements.Convert(e => e.GetDimension().GetWeight()).Sum();
            float total_minimum = elements.Convert(e => e.GetDimension().GetMinimum()).Sum();

            rect.SplitByYBottomOffset(
                GetHeight(),
                out row_rect,
                out rect
            );

            elements.Apply(row_rect, (r, e) => e.Layout(r, state, width, total_weight, total_minimum));
            return rect;
        }

        public void Clear()
        {
            elements.Clear();
        }

        public void Add(EditorGUIFlowElement element)
        {
            elements.Add(element);
        }

        public bool Remove(EditorGUIFlowElement element)
        {
            return elements.Remove(element);
        }
        public bool Remove(EditorGUIElement element)
        {
            return elements.RemoveFirst(e => e.GetElement() == element);
        }

        public float GetHeight()
        {
            return elements.Convert(e => e.GetElement().GetHeight()).Max();
        }

        public IEnumerator<EditorGUIFlowElement> GetEnumerator()
        {
            return elements.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}