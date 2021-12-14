using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public bool DropZoneUnityObjects(Rect rect, out IList<UnityEngine.Object> dragging)
        {
            GUIControlHandle handle = GUIExtensions.GetControlHandle(FocusType.Passive);

            if (rect.Contains(handle.GetEvent().mousePosition))
            {
                dragging = DragAndDrop
                    .objectReferences
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

            dragging = Empty.IList<UnityEngine.Object>();
            return false;
        }

        static public bool DropZone(Rect rect, Type type, out Array dragging)
        {
            IList<UnityEngine.Object> temp;

            if (DropZoneUnityObjects(rect, out temp))
            {
                dragging = temp
                    .Narrow(i => i.CanObjectBeTreatedAs(type))
                    .ToArrayOfType(type);

                return true;
            }

            dragging = Empty.Array<UnityEngine.Object>();
            return false;
        }

        static public T DropZoneSingle<T>(Rect rect, T value)
        {
            IList<UnityEngine.Object> dragging;

            if (DropZoneUnityObjects(rect, out dragging))
                return dragging.FindFirstOfType<UnityEngine.Object, T>();

            return value;
        }

        static public Sprite SpriteDropZone(Rect rect, Sprite value)
        {
            GUIExtensions.DrawSprite(rect, value);

            return DropZoneSingle(rect, value);
        }
    }
}