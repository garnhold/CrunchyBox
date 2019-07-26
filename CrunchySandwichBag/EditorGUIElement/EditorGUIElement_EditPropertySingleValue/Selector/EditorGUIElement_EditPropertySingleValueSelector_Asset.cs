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
    public class EditorGUIElement_EditPropertySingleValueSelector_Asset : EditorGUIElement_EditPropertySingleValueSelector<UnityEngine.Object>
    {
        private bool should_force_non_null;

        public EditorGUIElement_EditPropertySingleValueSelector_Asset(EditProperty_Single_Value p, bool non_null) : base(p)
        {
            should_force_non_null = non_null;
        }

        public override IEnumerable<AssetInfo> GetAssetInfos()
        {
            return Project.GetAllAssetInfos(GetProperty().GetPropertyType())
                .PrependIfNot(should_force_non_null, (AssetInfo)null);
        }
    }
}