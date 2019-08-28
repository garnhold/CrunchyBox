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
    public class EditorGUIElement_EditPropertySingleValueCombo_TypeMethodInfo : EditorGUIElement_EditPropertySingleValueCombo<MethodInfo>
    {
        private EditProperty_Single_Value type_property;

        public EditorGUIElement_EditPropertySingleValueCombo_TypeMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value t) : base(p)
        {
            type_property = t;
        }

        public override IEnumerable<MethodInfo> GetOptions(string text)
        {
            Type type;

            if(type_property.TryGetContentValues<Type>(out type))
            {
                return type.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.DoesNameContain(text)
                ).Convert<MethodInfoEX, MethodInfo>();
            }

            return Empty.IEnumerable<MethodInfo>();
        }
    }
}