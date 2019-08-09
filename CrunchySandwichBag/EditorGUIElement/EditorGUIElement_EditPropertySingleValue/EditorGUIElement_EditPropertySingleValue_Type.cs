using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditPropertySingleValue_Type: EditorGUIElement_EditPropertySingleValue<Type>
    {
        protected override Type DrawValueInternal(Rect rect, Type value)
        {
            string name = value.IfNotNull(m => m.Name);
            string new_name = EditorGUI.DelayedTextField(rect, name);

            if (new_name != name)
            {
                value = CrunchyNoodle.Types.GetFilteredTypes(
                    Filterer_Type.IsNamed(new_name)
                ).GetFirst();
            }

            return value;
        }

        public EditorGUIElement_EditPropertySingleValue_Type(EditProperty_Single_Value p) : base(p)
        {
        }
    }
}