using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_Complex_EditTarget : EditorGUIElement_Complex<Type>
    {
        private EditTarget target;

        protected override Type PullState()
        {
            return target.GetTargetType();
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChildren(
                target.GetPropertys()
                    .Convert(p => p.CreateEditorGUIElement().LabelWithGUIContent(p.GetGUIContentLabel()))
            );

            container.AddChildren(
                target.GetActions()
                    .Convert(a => a.CreateEditorGUIElement())
            );

            return container;
        }

        public EditorGUIElement_Complex_EditTarget(EditTarget t)
        {
            target = t;
        }

        public EditorGUIElement_Complex_EditTarget(SerializedObject o) : this(new EditTarget_Serialized_Object(o))
        {
            AddAttachment(new EditorGUIElementAttachment_SerializedObjectSection(o));
        }

        public EditorGUIElement_Complex_EditTarget(SerializedProperty p) : this(new EditTarget_Serialized_Property(p)) { }
        public EditorGUIElement_Complex_EditTarget(ReflectedObject o) : this(new EditTarget_Reflected(o)) { }
    }
}