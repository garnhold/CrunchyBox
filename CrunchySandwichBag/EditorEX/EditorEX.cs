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
        private Dictionary<SerializedObject, EditorGUIView> gui_views;
        private Dictionary<SerializedObject, EditorSceneElement> scene_elements;

        private const int MAXIMUM_NUMBER_INSTANCES = 8;

        protected virtual EditorGUIElement CreateRootEditorGUIElement(T item, SerializedObject serialized_object) { return null; }
        protected virtual EditorSceneElement CreateRootEditorSceneElement(T item, SerializedObject serialized_object) { return null; }

        public EditorEX()
        {
            gui_views = new Dictionary<SerializedObject, EditorGUIView>();
            scene_elements = new Dictionary<SerializedObject, EditorSceneElement>();
        }

        public override void OnInspectorGUI()
        {
            T item;

            if (target.Convert<T>(out item))
                GetEditorGUIView(item, serializedObject).LayoutDrawUnwind();
        }

        public virtual void OnSceneGUI()
        {
            T item;

            if (target.Convert<T>(out item))
                GetEditorSceneElement(item, serializedObject).Draw();
        }

        public EditorGUIView GetEditorGUIView(T item, SerializedObject serialized_object)
        {
            if (gui_views.Count >= MAXIMUM_NUMBER_INSTANCES)
                gui_views.Clear();

            return gui_views.GetOrCreateValue(
                serialized_object, 
                o => new EditorGUIView(CreateRootEditorGUIElement(item, o).InitilizeAndGet())
            );
        }

        public EditorSceneElement GetEditorSceneElement(T item, SerializedObject serialized_object)
        {
            if (scene_elements.Count >= MAXIMUM_NUMBER_INSTANCES)
                scene_elements.Clear();

            return scene_elements.GetOrCreateValue(
                serialized_object,
                o => CreateRootEditorSceneElement(item, o).InitilizeAndGet()
            );
        }
    }
}