using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public class EditorGUIElement_EditPropertySingleValue_Popup_TypeSubType : EditorGUIElement_EditPropertySingleValue_Popup<Type>
    {
        private EditProperty_Single_Value type_property;

        public EditorGUIElement_EditPropertySingleValue_Popup_TypeSubType(EditProperty_Single_Value p, EditProperty_Single_Value t) : base(p)
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