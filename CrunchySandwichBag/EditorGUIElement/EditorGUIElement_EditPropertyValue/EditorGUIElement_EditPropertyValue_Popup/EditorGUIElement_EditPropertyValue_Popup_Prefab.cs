﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditorGUIElement_EditPropertyValue_Popup_Prefab : EditorGUIElement_EditPropertyValue_Popup<UnityEngine.Object>
    {
        private bool should_force_non_null;

        public EditorGUIElement_EditPropertyValue_Popup_Prefab(EditProperty_Value p, bool non_null) : base(p)
        {
            should_force_non_null = non_null;
        }

        public override IEnumerable<UnityEngine.Object> GetOptions()
        {
            return AssetDatabaseExtensions.GetPrefabs()
                .Convert(g => g.GetComponent(GetProperty().GetPropertyType()))
                .Convert<Component, UnityEngine.Object>()
                .PrependIfNot(should_force_non_null, (UnityEngine.Object)null);
        }
    }
}