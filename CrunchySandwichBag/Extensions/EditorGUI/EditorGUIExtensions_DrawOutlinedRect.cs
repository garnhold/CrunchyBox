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
        static public void DrawOutlinedRect(Rect rect, Color primary, float weight, Color outline)
        {
            EditorGUI.DrawRect(rect, outline);
            EditorGUI.DrawRect(rect.GetShrunk(weight), primary);
        }
        static public void DrawOutlinedRect(Rect rect, Color primary, float weight)
        {
            DrawOutlinedRect(rect, primary, weight, Color.black);
        }
        static public void DrawOutlinedRect(Rect rect, Color primary)
        {
            DrawOutlinedRect(rect, primary, 1.0f);
        }
    }
}