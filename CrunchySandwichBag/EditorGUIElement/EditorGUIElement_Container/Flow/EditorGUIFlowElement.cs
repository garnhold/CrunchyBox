using System;
using System.Collections;
using System.Collections.Generic;

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

        public float Plan(float width, EditorGUILayoutState state)
        {
            return element.Plan(width, state);
        }
        public float Plan(float total_width, float total_weight, float total_minimum, EditorGUILayoutState state)
        {
            return Plan(dimension.Calculate(total_width, total_weight, total_minimum), state);
        }

        public void Initialize() { element.Initialize(); }
        public void Layout(Vector2 position) { element.Layout(position); }
        public void Draw(Rect view) { element.Draw(view); }
        public void Unwind() { element.Unwind(); }

        public void Invalidate() { element.Invalidate(); }
        public void InvalidatePlan() { element.InvalidatePlan(); }
        public void InvalidateLayout() { element.InvalidateLayout(); }

        public void SetParent(EditorGUIElement p) { element.SetParent(p); }

        public void ClearAttachments() { element.ClearAttachments(); }
        public void AddAttachment(EditorGUIElementAttachment to_add) { element.AddAttachment(to_add); }
        public void AddAttachments(IEnumerable<EditorGUIElementAttachment> to_add) { element.AddAttachments(to_add); }
        public void AddAttachments(params EditorGUIElementAttachment[] to_add) { element.AddAttachments(to_add); }
        public bool RemoveAttachment(EditorGUIElementAttachment to_remove) { return element.RemoveAttachment(to_remove); }
        public void RemoveAttachments(Predicate<EditorGUIElementAttachment> predicate) { element.RemoveAttachments(predicate); }
        public IEnumerable<EditorGUIElementAttachment> GetAttachments() { return element.GetAttachments(); }

        public EditorGUIElement GetParent() { return element.GetParent(); }

        public float GetFootprintWidth() { return element.GetFootprintWidth(); }
        public float GetElementWidth() { return element.GetElementWidth(); }
        public float GetContentsWidth() { return element.GetContentsWidth(); }
        public float GetFootprintHeight() { return element.GetFootprintHeight(); }
        public Rect GetElementRect() { return element.GetElementRect(); }
        public Rect GetContentsRect() { return element.GetContentsRect(); }
        public EditorGUILayoutState GetLayoutState() { return element.GetLayoutState(); }

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