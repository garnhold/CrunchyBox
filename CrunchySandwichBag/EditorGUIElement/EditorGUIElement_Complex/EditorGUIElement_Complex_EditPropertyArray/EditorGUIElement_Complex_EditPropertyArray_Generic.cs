using System;
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
    
    public class EditorGUIElement_Complex_EditPropertyArray_Generic : EditorGUIElement_Complex_EditPropertyArray<Tuple<bool, int>>
    {
        protected override bool HandleAttachment(ref EditorGUIElementAttachment attachment)
        {
            EditorGUIElementAttachment_Singular_Label_GUIContent_Inline label;

            if (attachment.Convert<EditorGUIElementAttachment_Singular_Label_GUIContent_Inline>(out label))
                attachment = new EditorGUIElementAttachment_Singular_Label_GUIContent_Block(label.GetLabel());

            return base.HandleAttachment(ref attachment);
        }

        protected override Tuple<bool, int> PullState()
        {
            int number_elements;
            bool result = GetEditPropertyArray().TryGetNumberElements(out number_elements);

            return Tuple.New(result, number_elements);
        }

        protected override EditorGUIElement PushState()
        {
            int number_elements;
            EditProperty_Array property = GetEditPropertyArray();
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            Type array_type = property.GetPropertyType().GetIEnumerableType();

            if (property.TryGetNumberElements(out number_elements))
            {
                EditorGUIElement_Container_Flow_Line length_strip = container.AddChild(new EditorGUIElement_Container_Flow_Line())
                    .LabelWithGUIContent("Length");

                length_strip.AddWeightedChild(0.6f, new EditorGUIElement_EditPropertyArray_ArraySize(property));

                if (number_elements <= 0)
                {
                    length_strip.AddWeightedChild(0.4f, new EditorGUIElement_Button("+", delegate() {
                        property.InsertElement(0);
                    }));

                    if (array_type.CanBeTreatedAs<UnityEngine.Object>())
                    {
                        length_strip.AddWeightedChild(0.6f, new EditorGUIElement_DropZone("Drag + Drop",
                            o => o.CanObjectBeTreatedAs(array_type),
                            l => property.ForceContentValues(l)
                        ));
                    }
                }
                else
                {
                    for (int i = 0; i < number_elements; i++)
                    {
                        EditProperty sub_property = property.GetElement(i);

                        EditorGUIElement control = sub_property.CreateEditorGUIElement();
                        EditorGUIElement_Container_Auto_Simple_HorizontalStrip buttons = new EditorGUIElement_Container_Auto_Simple_HorizontalStrip();

                        buttons.AddChild(new EditorGUIElement_Button("+v", delegate() {
                            property.InsertElementAfter(sub_property);
                        }));
                        buttons.AddChild(new EditorGUIElement_Button("+^", delegate() {
                            property.InsertElementBefore(sub_property);
                        }));
                        buttons.AddChild(new EditorGUIElement_Button("-", delegate() {
                            property.RemoveElement(sub_property);
                        }));

                        container.AddChild(new EditorGUIElement_Sideboard(
                            new EditorGUIFlowElement(control, EditorGUIElementDimension.Weighted(1.0f)),
                            new EditorGUIFlowElement(buttons, EditorGUIElementDimension.Fixed(100.0f))
                        )).LabelWithIndex(property, i, () => ForceRecreation());
                    }
                }
            }
            else
            {
                container.AddChild(new EditorGUIElement_Text("--Disabled(Array lengths are not unified)--"));
            }

            return container;
        }

        public EditorGUIElement_Complex_EditPropertyArray_Generic(EditProperty_Array p) : base(p)
        {
        }
    }
}