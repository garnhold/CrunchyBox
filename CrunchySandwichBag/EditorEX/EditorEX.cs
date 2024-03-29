using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public abstract class EditorEX<T> : Editor where T : UnityEngine.Object
    {
        private Dictionary<SerializedObject, EditorGUIView> gui_views;
        private Dictionary<SerializedObject, EditorSceneElement> scene_elements;

        private const int MAXIMUM_NUMBER_INSTANCES = 128;

        protected virtual EditorGUIElement CreateRootEditorGUIElement(EditTarget target) { return null; }
        protected virtual EditorSceneElement CreateRootEditorSceneElement(EditTarget target) { return null; }

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
                o => new EditorGUIView(CreateRootEditorGUIElement(new EditTarget(o)).InitilizeAndGet())
            );
        }

        public EditorSceneElement GetEditorSceneElement(T item, SerializedObject serialized_object)
        {
            if (scene_elements.Count >= MAXIMUM_NUMBER_INSTANCES)
                scene_elements.Clear();

            return scene_elements.GetOrCreateValue(
                serialized_object,
                o => CreateRootEditorSceneElement(new EditTarget(o)).InitilizeAndGet()
            );
        }
    }
}