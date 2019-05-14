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
    public class EditorGUIElement_Graph : EditorGUIElement
    {
        private float height;

        private Rect element_rect;

        private List<EditorGUIElement_GraphNode> nodes;

        protected override void InitilizeInternal()
        {
            nodes.Process(n => n.Initilize());
        }

        protected override Rect LayoutElementInternal(Rect rect, float label_width)
        {
            element_rect = rect;

            return rect;
        }

        protected override void LayoutContentsInternal(Rect rect, float label_width)
        {
            nodes.Process(n => n.Layout(rect, label_width));
        }

        protected override void DrawElementInternal(Rect view)
        {
            EditorGUIExtensions.DrawOutlinedRect(element_rect, Color.gray);
        }

        protected override void DrawContentsInternal(Rect view)
        {
            nodes.Process(n => n.Draw(view));
        }

        protected override void UnwindInternal()
        {
            nodes.Process(n => n.Unwind());
        }

        protected override float CalculateElementHeightInternal()
        {
            return height;
        }

        public EditorGUIElement_Graph(float h)
        {
            height = h;
            nodes = new List<EditorGUIElement_GraphNode>();
        }

        public void ClearNodes()
        {
            nodes.Clear();
        }

        public void AddNode(EditorGUIElement_GraphNode node)
        {
            if (node != null)
            {
                nodes.Add(node);
                node.SetGraph(this);
            }
        }

        public bool RemoveNode(EditorGUIElement_GraphNode node)
        {
            return nodes.Remove(node);
        }

        public IEnumerable<EditorGUIElement_GraphNode> GetNodes()
        {
            return nodes;
        }

        public Rect GetDesiredRect()
        {
            return nodes.Convert(n => n.GetDesiredRect()).GetEncompassing()
                .GetEnlarged(50.0f);
        }
    }
}