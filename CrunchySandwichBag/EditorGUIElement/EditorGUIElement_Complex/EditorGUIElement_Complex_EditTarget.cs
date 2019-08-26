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
    public class EditorGUIElement_Complex_EditTarget : EditorGUIElement_Complex<Tuple<bool, bool, Type>>
    {
        private EditTarget target;

        protected override Tuple<bool, bool, Type> PullState()
        {
            return Tuple.New(
                target.IsSerializationCorrupt(),
                GetLayoutState().ShouldAlwaysShowRecoveryFields(),
                target.GetTargetType()
            );
        }

        protected override EditorGUIElement PushState()
        {
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (target.IsSerializationNotCorrupt())
            {
                container.AddChildren(
                    target.GetPropertys()
                        .Convert(p => p.CreateLabeledEditorGUIElement())
                );

                container.AddChildren(
                    target.GetActions()
                        .Convert(a => a.CreateEditorGUIElement())
                );
            }
            
            if(target.IsSerializationCorrupt() || GetLayoutState().ShouldAlwaysShowRecoveryFields())
            {
                EditorGUIElement_Container_Auto recovery_container = container.AddChild(new EditorGUIElement_Container_Auto_Simple_VerticalStrip());

                if (target.IsSerializationCorrupt())
                {
                    recovery_container.AddChild(new EditorGUIElement_Text("!Corruption Detected!"));
                    recovery_container.AddAttachment(new EditorGUIElementAttachment_Box(Color.red));
                }
                else
                {
                    recovery_container.AddAttachment(new EditorGUIElementAttachment_Box(Color.blue));
                }

                recovery_container.AddChildren(
                    target.GetRecoveryPropertys()
                        .Convert(p => p.CreateLabeledEditorGUIElement())
                );

                recovery_container.AddChildren(
                    target.GetRecoveryActions()
                        .Convert(a => a.CreateEditorGUIElement())
                );
            }

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