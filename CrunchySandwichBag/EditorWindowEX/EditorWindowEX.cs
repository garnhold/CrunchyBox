using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    public abstract class EditorWindowEX : EditorWindow
    {
        private EditorGUIView view;
        private EditorSceneElement scene_element;

        protected virtual EditorGUIElement CreateRootEditorGUIElement() { return null; }
        protected virtual EditorSceneElement CreateRootEditorSceneElement() { return null; }

        private void OnGUI()
        {
            GetEditorGUIView().LayoutDrawUnwind();
        }

        private void OnSceneGUI(SceneView sceneView)
        {
            GetEditorSceneElement().Draw();
        }

        public EditorWindowEX()
        {
            titleContent = new GUIContent(GetType().Name);
        }

        public EditorGUIView GetEditorGUIView()
        {
            if (view == null)
                view = new EditorGUIView(CreateRootEditorGUIElement().InitilizeAndGet());

            return view;
        }

        public EditorSceneElement GetEditorSceneElement()
        {
            if (scene_element == null)
                scene_element = CreateRootEditorSceneElement().InitilizeAndGet();

            return scene_element;
        }
    }
}