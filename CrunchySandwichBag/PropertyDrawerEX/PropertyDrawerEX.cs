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
    public abstract class PropertyDrawerEX : PropertyDrawer
    {
        private Dictionary<SerializedProperty, EditorGUIView> views;

        private const int MAXIMUM_NUMBER_INSTANCES = 64;

        public abstract EditorGUIElement CreateEditorGUIElement(SerializedProperty property);

        public PropertyDrawerEX()
        {
            views = new Dictionary<SerializedProperty, EditorGUIView>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
                EditorGUIView view = GetEditorGUIView(property);

                view.GetElement().LabelWithGUIContent(label);
                view.LayoutDrawUnwind(
                    position,
                    EditorGUISettings.GetInstance().GetInitialLayoutState()
                            .GetWithCurrentLabelWidth(EditorGUIUtility.labelWidth)
                );
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return GetEditorGUIView(property).GetElement().LabelWithGUIContent(label).GetFootprintHeight();
        }

        public EditorGUIView GetEditorGUIView(SerializedProperty serialized_property)
        {
            if (views.Count >= MAXIMUM_NUMBER_INSTANCES)
                views.Clear();

            return views.GetOrCreateValue(
                serialized_property,
                p => new EditorGUIView(CreateEditorGUIElement(p).InitilizeAndGet())
            );
        }
    }
}