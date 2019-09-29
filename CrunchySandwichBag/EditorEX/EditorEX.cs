using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorEX<T> : Editor where T : UnityEngine.Object
    {
        private Dictionary<SerializedObject, EditorGUIElement> gui_elements;
        private Dictionary<SerializedObject, EditorSceneElement> scene_elements;

        private const int MAXIMUM_NUMBER_INSTANCES = 8;

        protected virtual EditorGUIElement CreateRootEditorGUIElement(T item, SerializedObject serialized_object) { return null; }
        protected virtual EditorSceneElement CreateRootEditorSceneElement(T item, SerializedObject serialized_object) { return null; }

        public EditorEX()
        {
            gui_elements = new Dictionary<SerializedObject, EditorGUIElement>();
            scene_elements = new Dictionary<SerializedObject, EditorSceneElement>();
        }

        public override void OnInspectorGUI()
        {
            T item;

            if (target.Convert<T>(out item))
            {
                EditorGUIElement root = GetEditorGUIElement(item, serializedObject);

                root.LayoutDrawAndUnwind(
                    EditorGUILayout.GetControlRect(true, root.GetFootprintHeight()),
                    EditorGUISettings.GetInstance().GetInitialLayoutState()
                );
            }
        }

        public virtual void OnSceneGUI()
        {
            T item;

            if (target.Convert<T>(out item))
            {
                EditorSceneElement root = GetEditorSceneElement(item, serializedObject);

                root.Draw();
            }
        }

        public EditorGUIElement GetEditorGUIElement(T item, SerializedObject serialized_object)
        {
            if (gui_elements.Count >= MAXIMUM_NUMBER_INSTANCES)
                gui_elements.Clear();

            return gui_elements.GetOrCreateValue(serialized_object, o => CreateRootEditorGUIElement(item, o).InitilizeAndGet());
        }

        public EditorSceneElement GetEditorSceneElement(T item, SerializedObject serialized_object)
        {
            if (scene_elements.Count >= MAXIMUM_NUMBER_INSTANCES)
                scene_elements.Clear();

            return scene_elements.GetOrCreateValue(serialized_object, o => CreateRootEditorSceneElement(item, o).InitilizeAndGet());
        }
    }
}