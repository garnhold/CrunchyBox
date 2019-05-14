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
    public abstract class EditorGUIElement_GraphNode : EditorGUIElement
    {
        private float bar_size;

        private Rect box_rect;
        private Rect drag_rect;
        private Rect resize_rect;

        private EditorGUIFragment_MouseCapture_Drag drag_drag;
        private EditorGUIFragment_MouseCapture_Drag resize_drag;

        private EditorGUIElement element;

        private EditorGUIElement_Graph graph;

        static public readonly float DEFAULT_BAR_SIZE = 16.0f;

        protected abstract void SetWidthInternal(float width);
        protected abstract void SetPositionInternal(Vector2 position);

        protected abstract float GetWidthInternal();
        protected abstract Vector2 GetPositionInternal();

        protected override void InitilizeInternal()
        {
            element.Initilize();
        }

        protected override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            rect = GetDesiredRect().GetConstrainedByOrShrunk(rect);

            rect.SplitByYBottomOffset(bar_size, out drag_rect, out rect);
            rect.SplitByXRightOffset(bar_size, out box_rect, out resize_rect);

            drag_drag.Layout(drag_rect);
            resize_drag.Layout(resize_rect);

            return box_rect;
        }

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            element.Layout(rect, label_width);
        }

        protected override void DrawElementInternal(Rect view)
        {
            EditorGUIExtensions.DrawOutlinedRect(drag_rect, Color.grey.GetBrightened(1.1f));
            EditorGUIExtensions.DrawOutlinedRect(resize_rect, Color.grey.GetBrightened(1.1f));

            EditorGUIExtensions.DrawOutlinedRect(box_rect, Color.grey.GetBrightened(1.2f));
        }

        protected override void DrawContentsInternal(Rect view)
        {
            element.Draw(view);

            drag_drag.Draw();
            resize_drag.Draw();
        }

        protected override void UnwindInternal()
        {
            element.Unwind();
        }

        protected override float CalculateElementHeightInternal()
        {
            return element.GetHeight() + bar_size;
        }

        protected void DirtyGraphLayout()
        {
            InvalidateLayout();
            graph.InvalidateLayout();
        }

        public EditorGUIElement_GraphNode(EditorGUIElement e, float h)
        {
            bar_size = h;

            element = e;
            element.SetParent(this);

            drag_drag = new EditorGUIFragment_MouseCapture_Drag(delegate(int button, Vector2 position) {
                SetPosition(position);
                DirtyGraphLayout();
            });

            resize_drag = new EditorGUIFragment_MouseCapture_Drag(delegate(int button, Vector2 position) {
                SetWidth(position.x - GetPositionInternal().x);
                DirtyGraphLayout();
            });
        }

        public EditorGUIElement_GraphNode(EditorGUIElement e) : this(e, DEFAULT_BAR_SIZE) { }

        public void SetGraph(EditorGUIElement_Graph g)
        {
            graph = g;

            SetParent(graph);
        }

        public void SetWidth(float width)
        {
            SetWidthInternal(width);
        }

        public void SetPosition(Vector2 position)
        {
            SetPositionInternal(position);
        }

        public float GetWidth()
        {
            return GetWidthInternal().Max(bar_size * 4.0f);
        }

        public Vector2 GetPosition()
        {
            return GetPositionInternal();
        }

        public EditorGUIElement GetElement()
        {
            return element;
        }

        public Vector2 GetSize()
        {
            return new Vector2(GetWidth(), GetHeight());
        }

        public Rect GetDesiredRect()
        {
            return new Rect(GetPosition(), GetSize());
        }
    }
}