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
    [EditorGUIElementForType(typeof(Preditoid), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_Preditoid : EditorGUIElement_Complex_EditPropertySingleValue<MethodInfo>
    {
        protected override MethodInfo PullState()
        {
            MethodInfo value;

            GetProperty()
                .GetContents()
                .ForcePropertyValue("invoketoid.target_method")
                .TryGetContentValues<MethodInfo>(out value);

            return value;
        }

        protected override EditorGUIElement PushState()
        {
            MethodInfo method;
            EditTarget target = GetProperty().GetContents();

            EditorGUIElement_Container_Auto_Simple_VerticalStrip container = new EditorGUIElement_Container_Auto_Simple_VerticalStrip();

            container.AddChild(target.ForceProperty("invoketoid").CreateEditorGUIElement());
            
            if (target.ForcePropertyValue("invoketoid.target_method").TryGetContentValues<MethodInfo>(out method))
            {
                if (method.HasReturn())
                {
                    EditTarget comparer_contents;
                    EditProperty_Single comparer_property = target.ForcePropertySingle("comparer");

                    Type comparer_type = typeof(PreditoidComparer<>).MakeGenericType(method.GetReturnType());

                    comparer_property.EnsureContents(comparer_type);
                    if (comparer_property.TryGetContents(out comparer_contents))
                    {
                        EditorGUIElement_Container_Flow_Line line = container.AddChild(new EditorGUIElement_Container_Flow_Line());

                        line.AddFixedChild(100.0f, comparer_contents.ForceProperty("relation").CreateEditorGUIElement());
                        line.AddWeightedChild(1.0f, comparer_contents.ForceProperty("value").CreateEditorGUIElement());
                    }
                }
                else
                {
                    container.AddChild(new EditorGUIElement_Text("Selected method has no return value."));
                }
            }
            
            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_Preditoid(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}