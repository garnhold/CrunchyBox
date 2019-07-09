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
    public class EditorGUIElement_SerializedProperty_FloatSequence : EditorGUIElement_SerializedProperty
    {
        private float min_value;
        private float max_value;

        private float height;

        private Rect border_rect;
        private Rect background_rect;
        private GUIControl_MouseCapture percent_area;

        protected override Rect LayoutElementInternal(Rect rect, EditorGUILayoutState state)
        {
            border_rect = rect;
            background_rect = border_rect.GetShrunk(1.0f);

            return background_rect;
        }

        protected override void DrawElementInternal(Rect view)
        {
            EditorGUI.DrawRect(border_rect, Color.black);
            EditorGUI.DrawRect(background_rect, Color.gray);

            float x = background_rect.xMin;
            float y = background_rect.yMax;

            float element_width = background_rect.width / GetSerializedProperty().arraySize;
            float element_max_height = background_rect.height;

            foreach (Tuple<float, float> heights in GetSerializedProperty().GetArrayElements()
                .Convert(p => element_max_height * p.floatValue.ConvertFromRangeToPercent(min_value, max_value))
                .ConvertConnections())
            {
                Vector2 p1 = new Vector2(x, y);
                Vector2 p2 = new Vector2(x, y - heights.item1);

                x += element_width;

                Vector2 p3 = new Vector2(x, y - heights.item2);
                Vector2 p4 = new Vector2(x, y);

                EditorGUIExtensions.DrawQuad(p1, p2, p3, p4, Color.cyan);
            }

            percent_area.UpdatePercentPoint(background_rect, delegate(int button, Vector2 position) {
                int index = (int)(GetSerializedProperty().arraySize * position.x);
                float magnitude = 1.0f - position.y;

                if (GetSerializedProperty().IsArrayIndexValid(index))
                    GetSerializedProperty().GetArrayElementAtIndex(index).floatValue = magnitude.ConvertFromPercentToRange(min_value, max_value);
            });
        }

        protected override float CalculateElementHeightInternal()
        {
            return height;
        }

        public EditorGUIElement_SerializedProperty_FloatSequence(SerializedProperty s, float min, float max, float h) : base(s)
        {
            min_value = min;
            max_value = max;

            height = h;

            percent_area = new GUIControl_MouseCapture();
        }

        public EditorGUIElement_SerializedProperty_FloatSequence(SerializedProperty s, float min, float max) : this(s, min, max, EditorGUIElement_Single.DEFAULT_HEIGHT * 3.0f) { }
        public EditorGUIElement_SerializedProperty_FloatSequence(SerializedProperty s, float max) : this(s, 0.0f, max) { }
        public EditorGUIElement_SerializedProperty_FloatSequence(SerializedProperty s) : this(s, 1.0f) { }
    }
}