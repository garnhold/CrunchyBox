
using Crunchy.Dough;
using UnityEditor;
using UnityEngine;

namespace Crunchy.SandwichBag
{
    public class ModalEditorWindow : EditorWindow
    {
        private EditorGUIView view;
        private EditorGUIElement_ScrollBox_VerticalStrip element;

        static public ModalEditorWindow GetInstance()
        {
            return EditorWindow.GetWindow<ModalEditorWindow>();
        }

        private void OnGUI()
        {
            if (element != null)
            {
                element.SetHeight(this.GetHeight());
                view.LayoutDrawUnwind();
            }
        }

        public ModalEditorWindow()
        {
            titleContent = new GUIContent("");
        }

        public void Open(string title, Process<EditorGUIElement_Container_Auto> process)
        {
            element = new EditorGUIElement_ScrollBox_VerticalStrip(this.GetHeight());

            process(element.GetElement());
            element.Initialize();

            view = new EditorGUIView(element);

            titleContent = new GUIContent(title);
            ShowUtility();
        }
    }
}