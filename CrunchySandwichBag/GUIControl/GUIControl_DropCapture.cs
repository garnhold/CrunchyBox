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
    public class GUIControl_DropCapture : GUIControl
    {
        private DragAndDropVisualMode visual_mode;

        public GUIControl_DropCapture(DragAndDropVisualMode v) : base(FocusType.Passive)
        {
            visual_mode = v;
        }

        public void UpdateMultiple(Rect rect, Predicate<UnityEngine.Object[]> predicate, Process<UnityEngine.Object[]> process)
        {
            base.Update(delegate(EventType type, Event evt) {
                if (rect.Contains(evt.mousePosition) && predicate(DragAndDrop.objectReferences))
                {
                    switch (type)
                    {
                        case EventType.DragUpdated:
                            DragAndDrop.visualMode = visual_mode;
                            break;

                        case EventType.DragPerform:
                            process(DragAndDrop.objectReferences);

                            DragAndDrop.AcceptDrag();
                            return true;
                    }
                }

                return false;
            });
        }

        public void UpdateSingle(Rect rect, Predicate<UnityEngine.Object> predicate, Process<UnityEngine.Object> process)
        {
            UpdateMultiple(rect, os => predicate(os.GetFirst()), os => process(os.GetFirst()));
        }
    }
}