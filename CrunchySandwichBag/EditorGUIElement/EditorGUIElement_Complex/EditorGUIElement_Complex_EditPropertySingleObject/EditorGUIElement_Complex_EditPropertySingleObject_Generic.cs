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
                EditorGUIElement_Container_Flow_Line strip = container.AddChild(new EditorGUIElement_Container_Flow_Line());

                strip.AddWeightedChild(1.0f,
                    new EditorGUIElement_Popup_ProcessOperation<Type>(
                        Types.GetFilteredTypes(
                            Filterer_Type.CanBeTreatedAs(property.GetPropertyType()),
                            Filterer_Type.IsConcreteClass()
                        ),
                        t => property.CreateContents(t),
                        (out Type t) => property.TryGetContentsType(out t)
                    )
                );

                strip.AddFixedChild(20.0f,
                    new EditorGUIElement_Button("X", delegate () {
                        property.ClearContents();
                    })
                );
            }
            else if (property.HasCustomAttributeOfType<MonomorphicFieldAttribute>(true))
            {
                property.EnsureContents(
                    property.GetCustomAttributeOfType<MonomorphicFieldAttribute>(true)
                        .GetTargetType()
                );
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