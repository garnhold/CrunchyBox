using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    using Sandwich;

    [EditorGUIElementForType(typeof(SceneEX), true)]
    public class EditorGUIElement_Composite_EditPropertySingleValue_SceneEX : EditorGUIElement_Composite_EditPropertySingleValue
    {
        protected override EditorGUIElement CreateElement()
        {
            return new EditorGUIElement_Composite_EditPropertySingleValue_UnityObject(
                GetProperty().GetContents().ForcePropertyValue("scene_asset"),
                typeof(SceneAsset)
            );
        }

        public EditorGUIElement_Composite_EditPropertySingleValue_SceneEX(EditProperty_Single_Value p) : base(p) { }
    }
}