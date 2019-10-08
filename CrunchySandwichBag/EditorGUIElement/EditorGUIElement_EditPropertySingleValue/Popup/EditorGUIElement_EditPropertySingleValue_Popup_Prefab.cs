using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditPropertySingleValue_Popup_Prefab : EditorGUIElement_EditPropertySingleValue_Popup<UnityEngine.Object>
    {
        private bool should_force_non_null;

        public EditorGUIElement_EditPropertySingleValue_Popup_Prefab(EditProperty_Single_Value p, bool non_null) : base(p)
        {
            should_force_non_null = non_null;
        }

        public override IEnumerable<UnityEngine.Object> GetOptions()
        {
            return Project.GetAllPrefabs(GetProperty().GetPropertyType())
                .Convert<Component, UnityEngine.Object>()
                .PrependIfNot(should_force_non_null, (UnityEngine.Object)null);
        }
    }
}