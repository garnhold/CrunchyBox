using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class PainterWindow : EditorWindowEX_Simple
    {
        protected override void InitilizeRootEditorGUIElement(EditorGUIElement_Container_Auto root)
        {
            Painter painter = Painter.GetInstance();
            SerializedObject serialized_object = new SerializedObject(painter);

            root.AddChild(new EditorGUIElement_Complex_SerializedObject(serialized_object));
            root.AddAttachment(new EditorGUIElementAttachment_SerializedObjectSection(serialized_object));
            root.AddAttachment(new EditorGUIElementAttachment_ChangeListener(delegate() {
                painter.DirtyUtensil();
            }));

            root.AddChild(new EditorGUIElement_Single_Button("Swap Colors", delegate() {
                painter.SwapColors();
            }));
        }
    }
}