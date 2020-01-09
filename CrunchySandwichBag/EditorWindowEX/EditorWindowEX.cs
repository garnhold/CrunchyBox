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