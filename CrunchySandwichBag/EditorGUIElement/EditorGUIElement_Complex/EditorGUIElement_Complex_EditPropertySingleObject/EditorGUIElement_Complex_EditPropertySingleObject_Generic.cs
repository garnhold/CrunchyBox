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
    public class EditorGUIElement_Complex_EditPropertySingleObject_Generic : EditorGUIElement_Complex_EditPropertySingleObject<Type>
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
            EditProperty_Single_Object property = GetEditPropertyObject();
            EditorGUIElement_Container_Auto container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            if (property.HasCustomAttributeOfType<PolymorphicFieldAttribute>(true))
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
                    new EditorGUIElementLength_Fixed(20.0f),
                    new EditorGUIElement_Button("X", delegate() {
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

        public EditorGUIElement_Complex_EditPropertySingleObject_Generic(EditProperty_Single_Object p) : base(p)
        {
        }
    }
}