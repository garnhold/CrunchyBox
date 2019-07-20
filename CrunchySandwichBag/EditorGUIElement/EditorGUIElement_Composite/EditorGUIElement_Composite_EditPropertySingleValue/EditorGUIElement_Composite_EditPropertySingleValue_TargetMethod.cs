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
    [EditorGUIElementForType(typeof(TargetMethod), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_TargetMethod : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
            EditTarget target = GetProperty().GetContents();
            EditorGUIElement_Container_Auto_Simple_VerticalStrip container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();
            
            container.AddChild(target.ForceProperty("target_component").CreateEditorGUIElement());
            container.AddChild(
                new EditorGUIElement_EditPropertySingleValue_Popup_TypeMethodInfo(
                    target.ForcePropertyValue("method"),
                    target.ForcePropertyValue("target_component.component_type")
                )
            );
            return container;
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_TargetMethod(EditProperty_Single_Value p) : base(p) { }
    }
}