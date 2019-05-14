﻿using System;
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
    public class EditorGUIElement_Complex_EditPropertyObject_Generic : EditorGUIElement_Complex_EditPropertyObject<Type>
    {
        protected override Type PullState()
        {
            Type type;

            GetEditPropertyObject().TryGetContentsType(out type);
            return type;
        }

        protected override EditorGUIElement PushState()
        {
            EditTarget value;
            EditProperty_Object property = GetEditPropertyObject();
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (property.HasCustomAttributeOfType<PolymorphicField>(true))
            {
                EditorGUIElement_Container_HorizontalStrip strip = container.AddChild(new EditorGUIElement_Container_HorizontalStrip());

                strip.AddChild(
                    new EditorGUIElementLength_Weighted(1.0f),
                    new EditorGUIElement_Popup_ProcessOperation<Type>(
                        CrunchyNoodle.Types.GetFilteredTypes(
                            Filterer_Type.CanBeTreatedAs(property.GetPropertyType()),
                            Filterer_Type.IsConcreteClass()
                        ),
                        t => property.CreateContents(t),
                        (out Type t) => property.TryGetContentsType(out t)
                    )
                );

                strip.AddChild(
                    new EditorGUIElementLength_Fixed(90.0f),
                    new EditorGUIElement_Single_Button("Delete", delegate() {
                        property.ClearContents();
                    })
                );
            }
            else
            {
                property.EnsureContents(property.GetPropertyType());
            }

            if (property.TryGetContents(out value))
                container.AddChild(new EditorGUIElement_Complex_EditTarget(value));

            return container;
        }

        public EditorGUIElement_Complex_EditPropertyObject_Generic(EditProperty_Object p) : base(p)
        {
        }
    }
}