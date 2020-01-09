using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_Complex_EditTarget : EditorGUIElement_Complex<Tuple<bool, bool, Type>>
    {
        private EditTarget target;

        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_Label_GUIContent_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_Label_GUIContent_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_Label_GUIContent_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

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
                    target.GetDisplays()
                        .Convert(d => d.CreateLabeledEditorGUIElement())
                );

                container.AddChildren(
                    target.GetFunctions()
                        .Convert(f => f.CreateEditorGUIElement())
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
    }
}