using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public bool DropZone<T>(Rect rect, Predicate<T> predicate, out IList<T> dragging)
        {
            GUIControlHandle handle = GUIExtensions.GetControlHandle(FocusType.Passive);

            if (rect.Contains(handle.GetEvent().mousePosition))
            {
                dragging = DragAndDrop.objectReferences
                    .Convert<UnityEngine.Object, T>()
                    .Narrow(predicate)
                    .ToList();

                if (dragging.IsNotEmpty())
                {
                    switch (handle.GetEventType())
                    {
                        case EventType.DragUpdated:
                            DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                            break;

                        case EventType.DragPerform:
                            DragAndDrop.AcceptDrag();
                            handle.UseEvent();
                            return true;
                    }
                }
            }

            dragging = Empty.IList<T>();
            return false;
        }
        
        static public T DropZone<T>(Rect rect, T value, Predicate<T> predicate)
        {
            IList<T> dragging;

            if (DropZone(rect, predicate, out dragging))
                return dragging.GetFirst();

            return value;
        }

        static public T DropZone<T>(Rect rect, T value)
        {
            return DropZone<T>(rect, value, v => true);
        }

        static public Sprite SpriteDropZone(Rect rect, Sprite value)
        {
            GUIExtensions.DrawSprite(rect, value);

            return DropZone<Sprite>(rect, value);
        }
    }
}