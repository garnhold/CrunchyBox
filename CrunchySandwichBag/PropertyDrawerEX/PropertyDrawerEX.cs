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
        private Dictionary<SerializedProperty, EditorGUIElement> elements;

        private const int MAXIMUM_NUMBER_INSTANCES = 64;

        public abstract EditorGUIElement CreateEditorGUIElement(SerializedProperty property);

        public PropertyDrawerEX()
        {
            elements = new Dictionary<SerializedProperty, EditorGUIElement>();
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
                GetEditorGUIElement(property).LabelWithGUIContent(label).LayoutDrawAndUnwind(
                    position, 
                    new EditorGUILayoutState(EditorGUIUtility.labelWidth)
                );
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return GetEditorGUIElement(property).LabelWithGUIContent(label).GetHeight();
        }

        public EditorGUIElement GetEditorGUIElement(SerializedProperty serialized_property)
        {
            if (elements.Count >= MAXIMUM_NUMBER_INSTANCES)
                elements.Clear();

            return elements.GetOrCreateValue(serialized_property, p => CreateEditorGUIElement(p).InitilizeAndGet());
        }
    }
}