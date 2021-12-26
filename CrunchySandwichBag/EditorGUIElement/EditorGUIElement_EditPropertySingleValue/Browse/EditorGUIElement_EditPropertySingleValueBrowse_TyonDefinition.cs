using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Sandwich;
    
    [EditorGUIElementForType(typeof(TyonDefinition), true)]
    public class EditorGUIElement_EditPropertySingleValue_Browse_TyonDefinition : EditorGUIElement_EditPropertySingleValue_Browse<TextAsset>
    {
        protected override TextAsset DrawValueInternal(Rect rect, TextAsset value)
        {
            Rect play_rect;

            rect.SplitByXRightOffset(45.0f, out rect, out play_rect);

            if (GUI.Button(play_rect, "New"))
            {
                return TextAssets.CreateTextAsset(
                    ("New" + GetProperty().GetName()).StyleAsClassName(), 
                    "tyon"
                );
            }

            return base.DrawValueInternal(rect, value);
        }

        protected override EditorGUIElement CreateAssetInfoElement(AssetInfo info)
        {
            EditorGUIElement_Container_Flow_Line container = new EditorGUIElement_Container_Flow_Line();

            container.AddWeightedChild(1.0f, new EditorGUIElement_Button(info.GetName(), delegate() {
                GetProperty().SetContentValues(info.Resolve<TextAsset>());
            }));

            return container;
        }

        public EditorGUIElement_EditPropertySingleValue_Browse_TyonDefinition(EditProperty_Single_Value p)
            : base(p, a => a.GetExtension() == "tyon") { }
    }
}