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
    
    public abstract class EditorGUIElement
    {
        private bool is_plan_invalid;
        private bool is_layout_invalid;

        private float footprint_width;

        private EditorGUIElementPlan element_plan;
        private EditorGUIElementPlan contents_plan;

        private float footprint_height;

        private Vector2 layout_position;
        private EditorGUILayoutState layout_state;

        private Rect element_rect;
        private Rect contents_rect;

        private List<EditorGUIElementAttachment> attachments;
        private List<EditorGUIElementAttachment> surpressed_attachments;

        private EditorGUIElement parent;

        protected virtual void InitializeInternal() { }

        protected virtual bool HandleAttachment(ref EditorGUIElementAttachment attachment) { return true; }

        protected virtual float DoPlanInternal() { return LINE_HEIGHT; }
        protected virtual Rect LayoutElementInternal(Rect rect) { return rect; }
        protected virtual void LayoutContentsInternal(Vector2 position) { }

        protected virtual void DrawElementInternal(Rect view) { }
        protected virtual void DrawContentsInternal(Rect view) { }

        protected virtual void UnwindInternal() { }

        public const float LINE_HEIGHT = 16.0f;

        private bool DoPlan()
        {
            float old_footprint_height = footprint_height;

            is_plan_invalid = false;
            is_layout_invalid = true;

            element_plan = attachments.Apply(
                new EditorGUIElementPlan(footprint_width),
                (p, a) => a.PlanElementInternal(p, layout_state)
            );

            contents_plan = attachments.Apply(
                element_plan,
                (p, a) => a.PlanContentsInternal(p, layout_state)
            );

            footprint_height = attachments.Apply(
                DoPlanInternal(),
                (h, a) => a.ModifyFootprintHeight(h, layout_state)
            );

            if (footprint_height != old_footprint_height)
                return true;

            return false;
        }

        private void DoLayout()
        {
            is_layout_invalid = false;

            element_rect = element_plan.Layout(layout_position, footprint_height);
            contents_rect = contents_plan.Layout(layout_position, footprint_height);

            attachments.Process(a => a.LayoutInternal(layout_position, footprint_height));

            LayoutElementInternal(element_rect);
            LayoutContentsInternal(contents_rect.min);
        }

        public EditorGUIElement()
        {
            is_plan_invalid = true;
            is_layout_invalid = true;

            layout_state = new EditorGUILayoutState();

            attachments = new List<EditorGUIElementAttachment>();
            surpressed_attachments = new List<EditorGUIElementAttachment>();

            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(1.0f));
        }

        public void Initialize()
        {
            InitializeInternal();
            Invalidate();
        }

        public float Plan(float width, EditorGUILayoutState state)
        {
            if (width != footprint_width || state != layout_state || is_plan_invalid)
            {
                footprint_width = width;
                layout_state = state;

                DoPlan();
            }

            return footprint_height;
        }

        public void Layout(Vector2 position)
        {
            if (position != layout_position || is_layout_invalid)
            {
                layout_position = position;

                DoLayout();
            }
        }

        public void Draw(Rect view)
        {
            EditorGUIUtilityExtensions.UseLabelWidth(layout_state.GetCurrentLabelWidth(), delegate() {
                attachments.Process(a => a.PreDrawInternal());
                    if (view.Overlaps(element_rect))
                    {
                        DrawElementInternal(view);
                        DrawContentsInternal(view);

                        attachments.Process(a => a.DrawInternal(view));
                    }
                attachments.Process(a => a.PostDrawInternal());
            });
        }

        public void Unwind()
        {
            UnwindInternal();
            attachments.Process(a => a.UnwindInternal());

            if (is_plan_invalid)
            {
                if (DoPlan())
                    parent.IfNotNull(p => p.Invalidate());
            }

            if (is_layout_invalid)
                DoLayout();
        }

        public void Invalidate()
        {
            InvalidatePlan();
            InvalidateLayout();
        }
        public void InvalidatePlan()
        {
            is_plan_invalid = true;
        }
        public void InvalidateLayout()
        {
            is_layout_invalid = true;
        }

        public void SetParent(EditorGUIElement p)
        {
            parent = p;
        }

        public void ClearAttachments()
        {
            attachments.Clear();
            surpressed_attachments.Clear();

            Invalidate();
        }

        public void AddAttachment(EditorGUIElementAttachment to_add)
        {
            if (to_add != null)
            {
                if (to_add.PrepareElementForAttachment(this))
                {
                    if (HandleAttachment(ref to_add))
                        attachments.Add(to_add);
                    else
                        surpressed_attachments.Add(to_add);

                    Invalidate();
                }
            }
        }

        public void AddAttachments(IEnumerable<EditorGUIElementAttachment> to_add)
        {
            to_add.Process(i => AddAttachment(i));
        }
        public void AddAttachments(params EditorGUIElementAttachment[] to_add)
        {
            AddAttachments((IEnumerable<EditorGUIElementAttachment>)to_add);
        }

        public bool RemoveAttachment(EditorGUIElementAttachment to_remove)
        {
            if (attachments.Remove(to_remove) | surpressed_attachments.Remove(to_remove))
            {
                Invalidate();

                return true;
            }

            return false;
        }

        public void RemoveAttachments(Predicate<EditorGUIElementAttachment> predicate)
        {
            if (attachments.RemoveAll(predicate) > 0 | surpressed_attachments.RemoveAll(predicate) > 0)
                Invalidate();
        }

        public IEnumerable<EditorGUIElementAttachment> GetAttachments()
        {
            return attachments.Append(surpressed_attachments);
        }

        public EditorGUIElement GetParent()
        {
            return parent;
        }

        public float GetFootprintWidth()
        {
            return footprint_width;
        }

        public float GetElementWidth()
        {
            return element_plan.GetWidth();
        }

        public float GetContentsWidth()
        {
            return contents_plan.GetWidth();
        }

        public float GetFootprintHeight()
        {
            return footprint_height;
        }

        public Rect GetElementRect()
        {
            return element_rect;
        }

        public Rect GetContentsRect()
        {
            return contents_rect;
        }

        public EditorGUILayoutState GetLayoutState()
        {
            return layout_state;
        }
    }
}