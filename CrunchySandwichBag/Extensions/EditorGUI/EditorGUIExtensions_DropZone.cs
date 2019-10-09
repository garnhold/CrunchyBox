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
            new GUIControl_DropCapture(DragAndDropVisualMode.Copy).UpdateSingle(
                rect,
                o => o.CanObjectBeTreatedAs(type),
                o => value = o
            );

            new GUIControl_MouseCapture().UpdateClick(
                rect,
                () => Selection.activeObject = value as UnityEngine.Object
            );

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