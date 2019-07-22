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
    [EditorGUIElementForType(typeof(TargetComponent), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_TargetComponent : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
            EditTarget target = GetProperty().GetContents();
            EditorGUIElement_Container_HorizontalStrip container = new EditorGUIElement_Container_HorizontalStrip();

            container.AddChild(0.3f, target.ForcePropertyValue("game_object").CreateEditorGUIElement());
            container.AddChild(
                0.7f,
                new EditorGUIElement_EditPropertySingleValuePopup_GameObjectComponentType(
                    target.ForcePropertyValue("component_type"),
                    target.ForcePropertyValue("game_object")
                )
            );

            return container;
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_TargetComponent(EditProperty_Single_Value p) : base(p) { }
    }
}