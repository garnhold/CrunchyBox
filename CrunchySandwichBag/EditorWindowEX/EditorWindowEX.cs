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
        private EditorGUIView view;

        protected abstract EditorGUIElement CreateRootEditorGUIElement();

        private void OnGUI()
        {
            GetEditorGUIView().LayoutDrawUnwind();
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
    }
}