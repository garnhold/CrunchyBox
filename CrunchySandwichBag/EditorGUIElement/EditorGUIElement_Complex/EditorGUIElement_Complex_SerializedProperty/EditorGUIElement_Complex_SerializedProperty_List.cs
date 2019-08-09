using System;
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
    public class EditorGUIElement_Complex_SerializedProperty_List : EditorGUIElement_Complex_SerializedProperty<int>
    {
        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_Label_GUIContent_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_Label_GUIContent_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_Label_GUIContent_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

        protected override int PullState()
        {
            return GetSerializedProperty().GetArraySize();
        }

        protected override EditorGUIElement PushState()
        {
            SerializedProperty serialized_property = GetSerializedProperty();
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChild(new EditorGUIElement_Single_SerializedProperty_ArraySize(serialized_property).LabelWithGUIContent("# Elements"));

            for (int i = 0; i < serialized_property.arraySize; i++)
            {
                SerializedProperty sub_property = serialized_property.GetArrayElementAtIndex(i);
                EditorGUIElement_Container_Flow_Line line_container = container.AddChild(new EditorGUIElement_Container_Flow_Line())
                    .LabelWithGUIContent("[" + i + "]");

                line_container.AddWeightedChild(1.0f, new EditorGUIElement_Complex_SerializedProperty_FieldEX(sub_property));
                line_container.AddFixedChild(35.0f, new EditorGUIElement_Button("+v", delegate() {
                    serialized_property.InsertArrayElementAbove(sub_property);
                }));
                line_container.AddFixedChild(35.0f, new EditorGUIElement_Button("+^", delegate() {
                    serialized_property.InsertArrayElementBelow(sub_property);
                }));
                line_container.AddFixedChild(20.0f, new EditorGUIElement_Button("-", delegate() {
                    serialized_property.DeleteSerializedPropertyElement(sub_property);
                }));
            }

            return container;
        }

        public EditorGUIElement_Complex_SerializedProperty_List(SerializedProperty s) : base(s)
        {
        }
    }
}