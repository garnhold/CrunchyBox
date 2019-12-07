using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_EditFunction_Button : EditorGUIElement_EditFunction
    {
        private bool is_pressed;

        protected override void DrawElementInternal(Rect view)
        {
            is_pressed = GUI.Button(GetElementRect(), "Open " + GetEditFunction().GetName().StyleEntityForDisplay());
        }

        protected override void UnwindInternal()
        {
            if (is_pressed)
            {
                ModalEditorWindow.OpenWindow(GetEditFunction().GetName().StyleEntityForDisplay(), delegate(EditorGUIElement_Container_Auto container) {
                    container.AddChildren(
                        GetEditFunction().GetParameters().Convert(p => p.CreateLabeledEditorGUIElement())
                    );

                    container.AddChild(new EditorGUIElement_Button("Execute", delegate() {
                        GetEditFunction().Execute();
                    }));
                });
            }
        }

        public EditorGUIElement_EditFunction_Button(EditFunction f) : base(f) { }
    }
}