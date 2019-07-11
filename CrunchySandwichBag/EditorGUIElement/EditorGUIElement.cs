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
    public abstract class EditorGUIElement
    {
        private float height;

        private Rect element_rect;
        private Rect contents_rect;

        private Rect layout_rect;
        private EditorGUILayoutState layout_state;

        private bool is_height_dirty;
        private bool is_layout_dirty;

        private List<EditorGUIElementAttachment> attachments;
        private List<EditorGUIElementAttachment> surpressed_attachments;

        private EditorGUIElement parent;

        protected virtual void InitilizeInternal() { }

        protected virtual bool HandleAttachment(ref EditorGUIElementAttachment attachment) { return true; }

        protected virtual Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state) { return rect; }
        protected virtual void LayoutContentsInternal(Rect rect, EditorGUILayoutState state) { }

        protected virtual void DrawElementInternal(Rect view) { }
        protected virtual void DrawContentsInternal(Rect view) { }

        protected virtual void UnwindInternal() { }

        protected virtual float CalculateElementHeightInternal() { return LINE_HEIGHT; }

        public const float LINE_HEIGHT = 16.0f;

        private void Validate()
        {
            ValidateHeight();
            ValidateLayout();
        }

        private void ValidateHeight()
        {
            if (is_height_dirty)
                DoHeight();
        }

        private void ValidateLayout()
        {
            if (is_layout_dirty)
                DoLayout();
        }

        private void DoHeight()
        {
            float old_requested_height = height;

            height = attachments.Apply(CalculateElementHeightInternal(), (h, a) => a.ModifyElementHeight(h));
            is_height_dirty = false;

            if (height != old_requested_height)
            {
                is_layout_dirty = true;

                if (parent != null)
                    parent.DoHeight();
            }
        }

        private void DoLayout()
        {
            attachments.Process(a => a.PreLayoutInternal(layout_rect, layout_state));
                element_rect = attachments.Apply(layout_rect, (r, a) => a.LayoutElementInternal(r, layout_state));
                contents_rect = LayoutElementInternal(element_rect, layout_state);

                contents_rect = attachments.Apply(contents_rect, (r, a) => a.LayoutContentsInternal(r, layout_state));
                LayoutContentsInternal(contents_rect, layout_state);
            attachments.Process(a => a.PostLayoutInternal(layout_rect, layout_state));

            is_layout_dirty = false;
        }

        public EditorGUIElement()
        {
            height = -1.0f;
            
            element_rect = new Rect();
            contents_rect = new Rect();

            layout_rect = new Rect();
            layout_state = new EditorGUILayoutState();

            is_height_dirty = true;
            is_layout_dirty = true;

            attachments = new List<EditorGUIElementAttachment>();
            surpressed_attachments = new List<EditorGUIElementAttachment>();

            AddAttachment(new EditorGUIElementAttachment_Singular_Margin(1.0f));
        }

        public void Initilize()
        {
            InitilizeInternal();
            Invalidate();
        }
        
        public void InvalidateHeight()
        {
            is_height_dirty = true;
        }

        public void InvalidateLayout()
        {
            is_layout_dirty = true;
        }

        public void Invalidate()
        {
            InvalidateHeight();
            InvalidateLayout();
        }

        public void Layout(Rect rect, EditorGUILayoutState state)
        {
            if (EventExtensions.IsLayoutNullRect(rect) == false)
            {
                if (rect != layout_rect || state != layout_state)
                {
                    layout_rect = rect;
                    layout_state = state;

                    DoLayout();
                }
            }
        }

        public void Draw(Rect view)
        {
            Validate();

            EditorGUIUtilityExtensions.UseLabelWidth(layout_state.GetCurrentLabelWidth(), delegate() {
                attachments.Process(a => a.PreDrawInternal());
                    if (view.Overlaps(layout_rect))
                    {
                        DrawElementInternal(view);
                        DrawContentsInternal(view);

                        attachments.Process(a => a.DrawInternal(view));
                    }
                attachments.Process(a => a.PostDrawInternal());
            });
        }

        public void Draw()
        {
            Draw(layout_rect);
        }

        public void Unwind()
        {
            UnwindInternal();
            attachments.Process(a => a.UnwindInternal());
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
            attachments.RemoveAll(predicate);
            surpressed_attachments.RemoveAll(predicate);

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

        public float GetHeight()
        {
            ValidateHeight();

            return height;
        }

        public Rect GetElementRect()
        {
            return element_rect;
        }

        public Rect GetContentsRect()
        {
            return contents_rect;
        }

        public Rect GetLayoutRect()
        {
            return layout_rect;
        }

        public EditorGUILayoutState GetLayoutState()
        {
            return layout_state;
        }
    }
}