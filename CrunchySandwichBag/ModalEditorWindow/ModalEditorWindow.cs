using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class ModalEditorWindow : EditorWindow
    {
        private EditorGUIElement_ScrollBox_VerticalStrip element;

        static public ModalEditorWindow GetInstance()
        {
            return EditorWindow.GetWindow<ModalEditorWindow>();
        }

        static public void OpenWindow(string title, Process<EditorGUIElement_Container_Auto> process)
        {
            GetInstance().Open(title, process);
        }

        private void OnGUI()
        {
            if (element != null)
            {
                element.LayoutDrawAndUnwind(
                    EditorGUILayout.GetControlRect(true, this.GetHeight()),
                    EditorGUISettings.GetInstance().GetInitialLayoutState()
                );
            }
        }

        public ModalEditorWindow()
        {
            titleContent = new GUIContent("");
        }

        public void Open(string title, Process<EditorGUIElement_Container_Auto> process)
        {
            element = new EditorGUIElement_ScrollBox_VerticalStrip();

            process(element.GetElement());
            element.Initialize();

            titleContent = new GUIContent(title);
            ShowPopup();
        }
    }
}