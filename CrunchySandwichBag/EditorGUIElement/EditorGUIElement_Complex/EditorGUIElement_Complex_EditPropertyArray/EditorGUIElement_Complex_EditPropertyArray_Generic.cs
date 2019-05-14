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
    public class EditorGUIElement_Complex_EditPropertyArray_Generic : EditorGUIElement_Complex_EditPropertyArray<int>
    {
        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_GUIContentLabel_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_GUIContentLabel_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_GUIContentLabel_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

        protected override int PullState()
        {
            int number_elements;

            GetEditPropertyArray().TryGetNumberElements(out number_elements);
            return number_elements;
        }

        protected override EditorGUIElement PushState()
        {
            int number_elements;
            EditProperty_Array property = GetEditPropertyArray();
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (property.TryGetNumberElements(out number_elements))
            {
                container.AddChild(new EditorGUIElement_Single_EditPropertyArray_ArraySize(property).LabelWithGUIContent("# Elements"));

                for (int i = 0; i < number_elements; i++)
                {
                    int i_latched = i;
                    EditProperty sub_property = property.GetElement(i);

                    EditorGUIElement_Container_HorizontalStrip strip = container.AddChild(new EditorGUIElement_Container_HorizontalStrip())
                        .LabelWithGUIContent("[" + i + "]");

                    strip.AddChild(1.0f, sub_property.CreateEditorGUIElement());
                    strip.AddChild(new EditorGUIElementLength_Fixed(35.0f), new EditorGUIElement_Single_Button("+v", delegate() {
                        property.InsertElement(i_latched + 1);
                    }));
                    strip.AddChild(new EditorGUIElementLength_Fixed(35.0f), new EditorGUIElement_Single_Button("+^", delegate() {
                        property.InsertElement(i_latched);
                    }));
                    strip.AddChild(new EditorGUIElementLength_Fixed(20.0f), new EditorGUIElement_Single_Button("-", delegate() {
                        property.RemoveElement(i_latched);
                    }));
                }
            }

            return container;
        }

        public EditorGUIElement_Complex_EditPropertyArray_Generic(EditProperty_Array p) : base(p)
        {
        }
    }
}