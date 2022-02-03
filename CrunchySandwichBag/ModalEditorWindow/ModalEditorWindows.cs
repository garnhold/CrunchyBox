
using Crunchy.Dough;
using UnityEditor;
using UnityEngine;

namespace Crunchy.SandwichBag
{
    static public class ModalEditorWindows
    {
        static public void General(string title, Process<EditorGUIElement_Container_Auto> process)
        {
            ModalEditorWindow.GetInstance().Open(title, process);
        }

        static public void Alert(string title, string message)
        {
            General(title, container => {
                container.AddChild(new EditorGUIElement_Text(message));
            });
        }

        static public void Prompt<T>(string title, string message, Process<T> process, string button_label="Ok") where T : new()
        {
            T value = new T();
            EditTarget target = new EditTarget(value);

            General(title, container => {
                container.AddChild(new EditorGUIElement_Text(message));
                container.AddChild(new EditorGUIElement_Complex_EditTarget(target));
                container.AddChild(new EditorGUIElement_Button(button_label, () => process(value)));
            });
        }

        private class PromptStringValue
        {
            public string value;
        }
        static public void PromptString(string title, string message, Process<string> process, string button_label="Ok")
        {
            Prompt<PromptStringValue>(title, message, v => process(v.value), button_label);
        }
    }
}