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
    public class EditorGUIElement_EditPropertySingleValue_Popup_ObjectMethodInfo : EditorGUIElement_EditPropertySingleValue_Popup<MethodInfo>
    {
        private EditProperty_Single_Value object_property;

        private List<Filterer<MethodInfo>> filters;

        public EditorGUIElement_EditPropertySingleValue_Popup_ObjectMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value o, IEnumerable<Filterer<MethodInfo>> f) : base(p)
        {
            object_property = o;

            filters = f.ToList();
        }

        public EditorGUIElement_EditPropertySingleValue_Popup_ObjectMethodInfo(EditProperty_Single_Value p, EditProperty_Single_Value o, params Filterer<MethodInfo>[] f) : this(p, o, (IEnumerable<Filterer<MethodInfo>>)f) { }

        public override IEnumerable<MethodInfo> GetOptions()
        {
            object obj;

            if (object_property.TryGetContentValues(out obj))
                return obj.IfNotNull(o => o.GetFilteredInstanceMethods(filters).Convert<MethodInfoEX, MethodInfo>());

            return Empty.IEnumerable<MethodInfo>();
        }
    }
}