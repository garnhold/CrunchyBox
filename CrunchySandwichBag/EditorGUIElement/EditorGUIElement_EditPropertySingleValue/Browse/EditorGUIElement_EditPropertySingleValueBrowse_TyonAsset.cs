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
    
    [EditorGUIElementForType(typeof(TyonAsset), true)]
    public class EditorGUIElement_EditPropertySingleValue_Browse_TyonDefinition : EditorGUIElement_EditPropertySingleValue_Browse<TyonAsset>
    {
        protected override TyonAsset DrawValueInternal(Rect rect, TyonAsset value)
        {
            Rect play_rect;

            rect.SplitByXRightOffset(45.0f, out rect, out play_rect);

            if (GUI.Button(play_rect, "New"))
            {
                return Assets.CreateNewTextFile<TyonAsset>(
                    ("New_" + GetProperty().GetName()).StyleAsClassName(), 
                    "tyon"
                );
            }

            return base.DrawValueInternal(rect, value);
        }

        protected override EditorGUIElement CreateAssetInfoElement(AssetInfo info)
        {
            EditorGUIElement_Container_Flow_Line container = new EditorGUIElement_Container_Flow_Line();

            container.AddWeightedChild(1.0f, new EditorGUIElement_Button(info.GetName(), delegate() {
                GetProperty().SetContentValues(info.Resolve<TyonAsset>());
            }));

            return container;
        }

        public EditorGUIElement_EditPropertySingleValue_Browse_TyonDefinition(EditProperty_Single_Value p) : base(p) { }
    }
}