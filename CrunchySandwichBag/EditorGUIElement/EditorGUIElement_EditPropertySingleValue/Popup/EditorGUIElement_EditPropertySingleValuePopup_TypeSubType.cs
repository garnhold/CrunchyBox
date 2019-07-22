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
    public class EditorGUIElement_EditPropertySingleValuePopup_TypeSubType : EditorGUIElement_EditPropertySingleValuePopup<Type>
    {
        private EditProperty_Single_Value type_property;

        public EditorGUIElement_EditPropertySingleValuePopup_TypeSubType(EditProperty_Single_Value p, EditProperty_Single_Value t) : base(p)
        {
            type_property = t;
        }

        public override IEnumerable<Type> GetOptions()
        {
            Type type;

            if (type_property.TryGetContentValues(out type))
                return type.GetTypeAndAllBaseTypes();

            return Empty.IEnumerable<Type>();
        }
    }
}