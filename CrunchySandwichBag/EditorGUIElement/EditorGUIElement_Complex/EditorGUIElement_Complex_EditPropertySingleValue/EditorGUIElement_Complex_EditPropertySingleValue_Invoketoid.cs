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
    [EditorGUIElementForType(typeof(Invoketoid), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_Invoketoid : EditorGUIElement_Complex_EditPropertySingleValue<MethodInfo>
    {
        protected override MethodInfo PullState()
        {
            MethodInfo value;

            GetProperty()
                .GetContents()
                .ForcePropertyValue("target_method")
                .TryGetContentValues<MethodInfo>(out value);

            return value;
        }

        protected override EditorGUIElement PushState()
        {
            MethodInfo method;
            EditTarget target = GetProperty().GetContents();

            EditorGUIElement_Container_Auto_Simple_VerticalStrip container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            EditorGUIElement_Container_Flow_Line line = container.AddChild(new EditorGUIElement_Container_Flow_Line());

            line.AddWeightedChild(0.3f,
                new EditorGUIElement_EditPropertySingleValue_Type(target.ForcePropertyValue("target_type"))
            );

            line.AddWeightedChild(0.7f,
                new EditorGUIElement_EditPropertySingleValue_TypeMethodInfo(
                    target.ForcePropertyValue("target_method"),
                    target.ForcePropertyValue("target_type")
                )
            );

            if (target.ForcePropertyValue("target_method").TryGetContentValues<MethodInfo>(out method))
            {
                if (method != null)
                {
                    EditTarget invoker_contents;
                    EditProperty_Single invoker_property = target.ForcePropertySingle("invoker");

                    Type invoker_type = CrunchyNoodle.Types.GetFilteredTypes(
                        Filterer_Type.CanBeTreatedAs<InvoketoidInvokerBase>(),
                        Filterer_Type.IsConcreteClass(),
                        Filterer_Type.CanGenericParametersHold(method.GetEffectiveParameterTypes())
                    )
                    .GetFirst();

                    if (invoker_type != null)
                    {
                        if (invoker_type.IsGenericClass())
                            invoker_type = invoker_type.MakeGenericType(method.GetEffectiveParameterTypes().ToArray());

                        invoker_property.EnsureContents(invoker_type);
                        if (invoker_property.TryGetContents(out invoker_contents))
                        {
                            container.AddChildWithAttachments(
                                new EditorGUIElement_Complex_EditTarget(invoker_contents),
                                new EditorGUIElementAttachment_Indent()
                            );
                        }
                    }
                    else
                    {
                        container.AddChild(new EditorGUIElement_Text("Unable to find a InvoketoidInvoker type that matches the method signature."));
                    }
                }
            }
            
            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_Invoketoid(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}