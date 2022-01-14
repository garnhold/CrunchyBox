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
    using Sandwich;
    
    [EditorGUIElementForType(typeof(Curve), true)]
    public class EditorGUIElement_Complex_EditPropertySingleValue_Curve : EditorGUIElement_Complex_EditPropertySingleValue<int>
    {
        protected override int PullState()
        {
            return 1;
        }

        protected override EditorGUIElement PushState()
        {
            EditTarget target = GetProperty().GetContents();
            EditorGUIElement_Container_Flow_Multiline container = new EditorGUIElement_Container_Flow_Multiline();

            if (target.IsValid())
            {
                EditProperty_Array property = target.ForcePropertyArray("percents");

                container.AddFixedChild(32.0f, new EditorGUIElement_EditPropertyArray_ArraySize(property));
                container.AddWeightedChild(1.0f, new EditorGUIElement_EditPropertyArray_FloatSequence(property));
            }
            
            return container;
        }

        public EditorGUIElement_Complex_EditPropertySingleValue_Curve(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}