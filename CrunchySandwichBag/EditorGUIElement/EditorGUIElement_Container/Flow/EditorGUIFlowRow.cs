using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    public class EditorGUIFlowRow : IEnumerable<EditorGUIFlowElement>
    {
        private float height;
        private List<EditorGUIFlowElement> elements;

        public EditorGUIFlowRow()
        {
            elements = new List<EditorGUIFlowElement>();
        }

        public EditorGUIFlowRow(IEnumerable<EditorGUIFlowElement> e)
        {
            elements = e.ToList();
        }

        public float Plan(float width, EditorGUILayoutState state)
        {
            float total_weight = elements.Convert(e => e.GetDimension().GetWeight()).Sum();
            float total_minimum = elements.Convert(e => e.GetDimension().GetMinimum()).Sum();

            height = elements.Convert(e => e.Plan(width, total_weight, total_minimum, state)).Max();
            return height;
        }

        public void Layout(Vector2 position)
        {
            foreach (EditorGUIFlowElement element in elements)
            {
                element.Layout(position);
                position.x += element.GetFootprintWidth();
            }
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
            return height;
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