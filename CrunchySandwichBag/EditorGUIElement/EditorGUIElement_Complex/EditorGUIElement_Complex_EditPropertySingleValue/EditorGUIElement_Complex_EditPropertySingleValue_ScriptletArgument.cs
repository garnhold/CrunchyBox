using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;
    
    [EditorGUIElementForType(typeof(ScriptletArgument), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_ScriptletArgument : EditorGUIElement_Complex_EditPropertySingleValue<Type>
    {
        protected override Type PullState()
        {
            Type type;
            EditTarget target = GetProperty().GetContents();

            if (target.IsValid())
            {
                target.ForcePropertyValue("type")
                    .TryGetContentValues<Type>(out type);

                return type;
            }

            return null;
        }

        protected override EditorGUIElement PushState()
        {
            EditTarget target = GetProperty().GetContents();
            EditorGUIElement_Container_Flow_Multiline container = new EditorGUIElement_Container_Flow_Multiline();

            if (target.IsValid())
            {
                container.AddWeightedChild(0.3f, target.ForceProperty("type").CreateEditorGUIElement());
                container.AddWeightedChild(0.2f, target.ForceProperty("name").CreateEditorGUIElement());
                container.AddWeightedChild(0.4f,
                    new EditorGUIElement_Complex_EditPropertySingleValue_TypedObject(
                        target.ForcePropertyValue("value"),
                        target.ForcePropertyValue("type")
                    )
                );
            }
            
            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_ScriptletArgument(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}