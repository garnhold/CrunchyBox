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
    public abstract class EditorSceneElement
    {
        private List<EditorSceneElementAttachment> attachments;
        private List<EditorSceneElementAttachment> surpressed_attachments;

        private EditorSceneElement parent;

        protected virtual void InitilizeInternal() { }
        protected virtual bool HandleAttachment(ref EditorSceneElementAttachment attachment) { return true; }

        protected virtual void DrawInternal() { }

        protected virtual void UnwindInternal() { }

        public EditorSceneElement()
        {
            attachments = new List<EditorSceneElementAttachment>();
            surpressed_attachments = new List<EditorSceneElementAttachment>();
        }

        public void Initilize()
        {
            InitilizeInternal();
        }

        public void Draw()
        {
            attachments.Process(a => a.PreDrawInternal());
                DrawInternal();
                attachments.Process(a => a.DrawInternal());
            attachments.Process(a => a.PostDrawInternal());
        }

        public void Unwind()
        {
            UnwindInternal();
            attachments.Process(a => a.UnwindInternal());
        }

        public void ClearAttachments()
        {
            attachments.Clear();
            surpressed_attachments.Clear();
        }

        public void AddAttachment(EditorSceneElementAttachment to_add)
        {
            if (to_add != null)
            {
                if (to_add.PrepareElementForAttachment(this))
                {
                    if (HandleAttachment(ref to_add))
                        attachments.Add(to_add);
                    else
                        surpressed_attachments.Add(to_add);
                }
            }
        }

        public void AddAttachments(IEnumerable<EditorSceneElementAttachment> to_add)
        {
            to_add.Process(i => AddAttachment(i));
        }
        public void AddAttachments(params EditorSceneElementAttachment[] to_add)
        {
            AddAttachments((IEnumerable<EditorSceneElementAttachment>)to_add);
        }

        public bool RemoveAttachment(EditorSceneElementAttachment to_remove)
        {
            if (attachments.Remove(to_remove) | surpressed_attachments.Remove(to_remove))
                return true;

            return false;
        }

        public void RemoveAttachments(Predicate<EditorSceneElementAttachment> predicate)
        {
            attachments.RemoveAll(predicate);
            surpressed_attachments.RemoveAll(predicate);
        }

        public IEnumerable<EditorSceneElementAttachment> GetAttachments()
        {
            return attachments.Append(surpressed_attachments);
        }

        public void SetParent(EditorSceneElement p)
        {
            parent = p;
        }

        public EditorSceneElement GetParent()
        {
            return parent;
        }
    }
}