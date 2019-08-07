using System;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIFlowElement
    {
        private EditorGUIElement element;
        private EditorGUIElementDimension dimension;

        public EditorGUIFlowElement(EditorGUIElement e, EditorGUIElementDimension d)
        {
            element = e;
            dimension = d;
        }

        public Rect Layout(Rect rect, EditorGUILayoutState state, float width, float total_weight, float total_minimum)
        {
            Rect element_rect;

            rect.SplitByXLeftOffset(
                dimension.Calculate(width, total_weight, total_minimum),
                out element_rect,
                out rect
            );

            element.Layout(element_rect, state);
            return rect;
        }

        public EditorGUIElement GetElement()
        {
            return element;
        }

        public EditorGUIElementDimension GetDimension()
        {
            return dimension;
        }
    }
}