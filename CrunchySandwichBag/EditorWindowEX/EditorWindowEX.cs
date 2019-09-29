using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditorWindowEX : EditorWindow
    {
        private EditorGUIElement element;

        protected abstract EditorGUIElement CreateRootEditorGUIElement();

        private void OnGUI()
        {
            EditorGUIElement root = GetGUIElement();

            root.LayoutDrawAndUnwind(
                EditorGUILayout.GetControlRect(true, root.GetFootprintHeight()),
                EditorGUISettings.GetInstance().GetInitialLayoutState()
            );
        }

        public EditorWindowEX()
        {
            titleContent = new GUIContent(GetType().Name);
        }

        public EditorGUIElement GetGUIElement()
        {
            if (element == null)
                element = CreateRootEditorGUIElement().InitilizeAndGet();

            return element;
        }
    }
}