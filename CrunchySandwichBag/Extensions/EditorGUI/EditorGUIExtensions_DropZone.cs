using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class EditorGUIExtensions
    {
        static public object DropZone(Rect rect, object value, Type type)
        {
            UnityEngine.Object dragging = DragAndDrop.objectReferences.GetFirst();
            GUIControlHandle handle = GUIExtensions.GetControlHandle(FocusType.Passive);

            if (rect.Contains(handle.GetEvent().mousePosition) && dragging.CanObjectBeTreatedAs(type))
            {
                switch (handle.GetEventType())
                {
                    case EventType.DragUpdated:
                        DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                        break;

                    case EventType.DragPerform:
                        DragAndDrop.AcceptDrag();
                        handle.UseEvent();
                        return dragging;
                }
            }

            return value;
        }
        static public T DropZone<T>(Rect rect, T value)
        {
            return DropZone(rect, value, typeof(T)).Convert<T>();
        }

        static public Sprite SpriteDropZone(Rect rect, Sprite value)
        {
            GUIExtensions.DrawSprite(rect, value);

            return DropZone<Sprite>(rect, value);
        }
    }
}