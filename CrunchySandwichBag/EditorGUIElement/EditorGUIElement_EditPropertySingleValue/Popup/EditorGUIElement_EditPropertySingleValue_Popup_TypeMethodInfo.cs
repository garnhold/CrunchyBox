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
    public class EditorGUIElement_EditPropertySingleValue_Popup_TypeMethodInfo : EditorGUIElement_EditPropertySingleValue_Popup<MethodInfo>
    {
        private EditProperty_Single_Value type_property;

        private List<Filterer<MethodInfo>> filters;

        public EditorGUIElement_EditPropertySingleValue_Popup_TypeMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value t, IEnumerable<Filterer<MethodInfo>> f) : base(p)
        {
            type_property = t;

            filters = f.ToList();
        }

        public EditorGUIElement_EditPropertySingleValue_Popup_TypeMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value t, params Filterer<MethodInfo>[] f) : this(p, t, (IEnumerable<Filterer<MethodInfo>>)f) { }

        public override IEnumerable<MethodInfo> GetOptions()
        {
            Type type;

            if (type_property.TryGetContentValues(out type))
                return type.IfNotNull(t => t.GetFilteredMethods(filters).Convert<MethodInfoEX, MethodInfo>());

            return Empty.IEnumerable<MethodInfo>();
        }
    }
}