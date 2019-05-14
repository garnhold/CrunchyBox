using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorSceneElement_Complex_EditTarget : EditorSceneElement_Complex<Type>
    {
        private EditTarget target;

        protected override Type PullState()
        {
            return target.GetTargetType();
        }

        protected override EditorSceneElement PushState()
        {
            EditorSceneElement_Container_Auto_Simple_Normal container = new EditorSceneElement_Container_Auto_Simple_Normal();

            container.AddChildren(
                target.GetGadgets()
                    .Convert(g => g.CreateEditorSceneElement())
            );

            return container;
        }

        public EditorSceneElement_Complex_EditTarget(EditTarget t)
        {
            target = t;
        }

        public EditorSceneElement_Complex_EditTarget(SerializedObject o) : this(new EditTarget_Serialized_Object(o))
        {
            AddAttachment(new EditorSceneElementAttachment_SerializedObjectSection(o));
        }

        public EditorSceneElement_Complex_EditTarget(SerializedProperty p) : this(new EditTarget_Serialized_Property(p)) { }
        public EditorSceneElement_Complex_EditTarget(ReflectedObject o) : this(new EditTarget_Reflected(o)) { }
    }
}