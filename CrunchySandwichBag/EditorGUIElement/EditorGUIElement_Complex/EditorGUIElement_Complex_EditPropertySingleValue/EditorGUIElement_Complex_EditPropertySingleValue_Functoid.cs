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
    [EditorGUIElementForType(typeof(Functoid), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_Functoid : EditorGUIElement_Complex_EditPropertySingleValue<MethodInfo>
    {
        protected override MethodInfo PullState()
        {
            MethodInfo value;

            GetProperty()
                .GetContents()
                .ForcePropertyValue("target_method.method")
                .TryGetContentValues<MethodInfo>(out value);

            return value;
        }

        protected override EditorGUIElement PushState()
        {
            MethodInfo method;
            EditTarget target = GetProperty().GetContents();

            EditorGUIElement_Container_Auto_Simple_VerticalStrip container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChild(target.ForceProperty("target_method").CreateEditorGUIElement());
            
            if (target.ForcePropertyValue("target_method.method").TryGetContentValues<MethodInfo>(out method))
            {
                if (method != null)
                {
                    EditTarget invoker_contents;
                    EditProperty_Single invoker_property = target.ForcePropertySingle("invoker");

                    Type invoker_type = CrunchyNoodle.Types.GetFilteredTypes(
                        Filterer_Type.CanBeTreatedAs<FunctoidInvokerBase>(),
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
                            container.AddChild(new EditorGUIElement_Complex_EditTarget(invoker_contents));
                    }
                    else
                    {
                        container.AddChild(new EditorGUIElement_Text("Unable to find a FunctoidInvoker type that matches the method signature."));
                    }
                }
            }
            
            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_Functoid(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}