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
    public class EditorGUIElement_Complex_EditPropertySingleValue_TypedObject : EditorGUIElement_Complex_EditPropertySingleValue<Type>
    {
        private EditProperty_Single_Value type_property;

        protected override Type PullState()
        {
            Type type;

            type_property.TryGetContentValues<Type>(out type);
            return type;
        }

        protected override EditorGUIElement PushState()
        {
            Type type;
            EditorGUIElement_Container_Auto_Simple_VerticalStrip container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (type_property.TryGetContentValues<Type>(out type))
            {
                GetProperty().EnsureContents(type);

                container.AddChild(type.CreateEditorGUIElement(GetProperty()));
            }

            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_TypedObject(EditProperty_Single_Value p, EditProperty_Single_Value t) : base(p)
        {
            type_property = t;
        }
    }
}